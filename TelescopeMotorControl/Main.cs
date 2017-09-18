using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TelescopeMotorControl.Commands;
using TelescopeMotorControl.ControlHelpers;
using TelescopeMotorControl.Helpers;
using TelescopeMotorControl.Senders;

namespace TelescopeMotorControl
{
    public partial class Main : Form
    {
        private readonly IBindingList _commandTypes = ComboBoxItemList.Create(
            ComboBoxItem.Create("home", "Home"),
            ComboBoxItem.Create("goto", "Goto Location")
        );

        private readonly ILogger _rtbLogger;
        private readonly TextBoxParser _textBoxParser;
        private readonly ICheckSummer _checkSummer;
        private readonly ISender _sender;

        public Main()
        {
            InitializeComponent();
            InitialiseCommandTypes();
            SetupTextBoxValidationClearDown(tlpGoto.Controls, Color.White, Color.Black);
            SetupTextBoxValidationClearDown(tlpHome.Controls, Color.White, Color.Black);

            _rtbLogger = new RichTextBoxLogger(rtbLog);
            _textBoxParser = new TextBoxParser();
            _checkSummer = new ModCheckSummer();
            _sender = new MultiSender(new List<ISender>
            {
                new TestSender(_rtbLogger)
            });

            btnSend.Click += (s, e) => SendButtonClicked();
        }

        private void SetupTextBoxValidationClearDown(Control.ControlCollection controls, Color resetBackColor, Color resetForeColor)
        {
            foreach (var textBox in controls.OfType<TextBox>())
                textBox.TextChanged += (s, e) =>
                {
                    textBox.BackColor = resetBackColor;
                    textBox.ForeColor = resetForeColor;
                };
        }

        private void SendButtonClicked()
        {
            var selectedCommand = cboCommandType.SelectedItem as ComboBoxItem;
            if (selectedCommand != null)
                switch (selectedCommand.Value)
                {
                    case "home":
                        SendHomeCommand();
                        break;
                    case "goto":
                        SendGotoCommand();
                        break;
                }
        }

        private ushort MotorSpeedParser(string text)
        {
            var value = ushort.Parse(text);
            if (value > 5000)
                throw new ArgumentOutOfRangeException();
            return value;
        }

        private float BearingParser(string text)
        {
            var value = float.Parse(text);
            if (value < 0 || value >= 360)
                throw new ArgumentOutOfRangeException();
            return value;
        }

        private ushort AccelerationParser(string text)
        {
            var value = ushort.Parse(text);
            if (value <= 71 || value >= 100)
                throw new ArgumentOutOfRangeException();
            return value;
        }

        private ushort DecelerationParser(string text)
        {
            var value = ushort.Parse(text);
            if (value <= 71 || value >= 100)
                throw new ArgumentOutOfRangeException();
            return value;
        }

        private void SendGotoCommand()
        {
            var validationFailure = false;
            void FailureHandler(Exception ex)
            {
                validationFailure = true;
            }

            var command = new GotoCommand(_checkSummer, _sender)
            {
                AziB = _textBoxParser.Parse(txtGotoAziB, BearingParser, FailureHandler),
                AltB = _textBoxParser.Parse(txtGotoAltB, BearingParser, FailureHandler),
                AziS = _textBoxParser.Parse(txtGotoAziS, MotorSpeedParser, FailureHandler),
                AltS = _textBoxParser.Parse(txtGotoAltS, MotorSpeedParser, FailureHandler),
                AziA = _textBoxParser.Parse(txtGotoAziA, AccelerationParser, FailureHandler),
                AltA = _textBoxParser.Parse(txtGotoAltA, AccelerationParser, FailureHandler),
                AziD = _textBoxParser.Parse(txtGotoAziD, DecelerationParser, FailureHandler),
                AltD = _textBoxParser.Parse(txtGotoAltD, DecelerationParser, FailureHandler)
            };

            if (!validationFailure)
                SendCommand(command);
        }

        private void SendHomeCommand()
        {
            var validationFailure = false;
            void FailureHandler(Exception ex)
            {
                validationFailure = true;
            }

            var command = new HomeCommand(_checkSummer, _sender)
            {
                AziB = _textBoxParser.Parse(txtHomeAziB, BearingParser, FailureHandler),
                AltB = _textBoxParser.Parse(txtHomeAltB, BearingParser, FailureHandler)
            };

            if (!validationFailure)
                SendCommand(command);
        }

        private void SendCommand(Command command)
        {
            try
            {
                command.Send();
            }
            catch (Exception e)
            {
                _rtbLogger.Error(nameof(SendCommand), e);
            }
        }

        private void InitialiseCommandTypes()
        {
            cboCommandType.Items.Clear();
            cboCommandType.DataSource = _commandTypes;
            cboCommandType.ValueMember = ComboBoxItemList.ValueMember;
            cboCommandType.DisplayMember = ComboBoxItemList.DisplayMember;
            cboCommandType.SelectedItem = _commandTypes[0];
            cboCommandType.SelectedIndexChanged += (s, e) => CommandTypeChanged();

            tlpHome.Visible = false;
            tlpGoto.Visible = false;
            pnlActiveCommand.Controls.Add(tlpHome);
            pnlActiveCommand.Controls.Add(tlpGoto);

            CommandTypeChanged();
        }

        private void CommandTypeChanged()
        {
            var selectedCommand = cboCommandType.SelectedItem as ComboBoxItem;
            if (selectedCommand != null)
            {
                for (var i = 0; i < pnlActiveCommand.Controls.Count; i++)
                    pnlActiveCommand.Controls[i].Visible = false;

                switch (selectedCommand.Value)
                {
                    case "home":
                        InitialiseHomeCommand();
                        break;
                    case "goto":
                        InitialiseGotoCommand();
                        break;
                }
            }
        }

        private void InitialiseGotoCommand()
        {
            tlpGoto.Dock = DockStyle.Fill;
            tlpGoto.Visible = true;
        }

        private void InitialiseHomeCommand()
        {
            tlpHome.Dock = DockStyle.Fill;
            tlpHome.Visible = true;
        }
    }
}