namespace TelescopeMotorControl
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCommandType = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.txtHomeAziB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHomeAltB = new System.Windows.Forms.TextBox();
            this.tlpHome = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGoto = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGotoAziB = new System.Windows.Forms.TextBox();
            this.txtGotoAltB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGotoAziS = new System.Windows.Forms.TextBox();
            this.txtGotoAltS = new System.Windows.Forms.TextBox();
            this.txtGotoAziA = new System.Windows.Forms.TextBox();
            this.txtGotoAltA = new System.Windows.Forms.TextBox();
            this.txtGotoAziD = new System.Windows.Forms.TextBox();
            this.txtGotoAltD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlActiveCommand = new System.Windows.Forms.Panel();
            this.tlpHome.SuspendLayout();
            this.tlpGoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCommandType
            // 
            this.cboCommandType.FormattingEnabled = true;
            this.cboCommandType.Location = new System.Drawing.Point(14, 16);
            this.cboCommandType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCommandType.Name = "cboCommandType";
            this.cboCommandType.Size = new System.Drawing.Size(234, 25);
            this.cboCommandType.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(255, 16);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 27);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.Location = new System.Drawing.Point(394, 12);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(364, 340);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            // 
            // txtHomeAziB
            // 
            this.txtHomeAziB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHomeAziB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeAziB.Location = new System.Drawing.Point(68, 4);
            this.txtHomeAziB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomeAziB.Name = "txtHomeAziB";
            this.txtHomeAziB.Size = new System.Drawing.Size(88, 29);
            this.txtHomeAziB.TabIndex = 4;
            this.txtHomeAziB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "AziB";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "AltB";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHomeAltB
            // 
            this.txtHomeAltB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHomeAltB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeAltB.Location = new System.Drawing.Point(68, 41);
            this.txtHomeAltB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomeAltB.Name = "txtHomeAltB";
            this.txtHomeAltB.Size = new System.Drawing.Size(88, 29);
            this.txtHomeAltB.TabIndex = 6;
            this.txtHomeAltB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpHome
            // 
            this.tlpHome.ColumnCount = 2;
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpHome.Controls.Add(this.label2, 0, 1);
            this.tlpHome.Controls.Add(this.txtHomeAziB, 1, 0);
            this.tlpHome.Controls.Add(this.txtHomeAltB, 1, 1);
            this.tlpHome.Controls.Add(this.label1, 0, 0);
            this.tlpHome.Location = new System.Drawing.Point(404, 31);
            this.tlpHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpHome.Name = "tlpHome";
            this.tlpHome.RowCount = 3;
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHome.Size = new System.Drawing.Size(225, 87);
            this.tlpHome.TabIndex = 4;
            // 
            // tlpGoto
            // 
            this.tlpGoto.ColumnCount = 4;
            this.tlpGoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpGoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpGoto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGoto.Controls.Add(this.label3, 0, 1);
            this.tlpGoto.Controls.Add(this.txtGotoAziB, 1, 0);
            this.tlpGoto.Controls.Add(this.txtGotoAltB, 1, 1);
            this.tlpGoto.Controls.Add(this.label4, 0, 0);
            this.tlpGoto.Controls.Add(this.label5, 0, 2);
            this.tlpGoto.Controls.Add(this.txtGotoAziS, 1, 2);
            this.tlpGoto.Controls.Add(this.txtGotoAltS, 1, 3);
            this.tlpGoto.Controls.Add(this.label6, 0, 3);
            this.tlpGoto.Controls.Add(this.label7, 2, 0);
            this.tlpGoto.Controls.Add(this.label8, 2, 1);
            this.tlpGoto.Controls.Add(this.label9, 2, 2);
            this.tlpGoto.Controls.Add(this.label10, 2, 3);
            this.tlpGoto.Controls.Add(this.txtGotoAziA, 3, 0);
            this.tlpGoto.Controls.Add(this.txtGotoAltA, 3, 1);
            this.tlpGoto.Controls.Add(this.txtGotoAziD, 3, 2);
            this.tlpGoto.Controls.Add(this.txtGotoAltD, 3, 3);
            this.tlpGoto.Location = new System.Drawing.Point(404, 168);
            this.tlpGoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpGoto.Name = "tlpGoto";
            this.tlpGoto.RowCount = 5;
            this.tlpGoto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGoto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGoto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGoto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGoto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGoto.Size = new System.Drawing.Size(305, 148);
            this.tlpGoto.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "AltB";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGotoAziB
            // 
            this.txtGotoAziB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAziB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAziB.Location = new System.Drawing.Point(68, 4);
            this.txtGotoAziB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAziB.Name = "txtGotoAziB";
            this.txtGotoAziB.Size = new System.Drawing.Size(88, 29);
            this.txtGotoAziB.TabIndex = 4;
            this.txtGotoAziB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGotoAltB
            // 
            this.txtGotoAltB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAltB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAltB.Location = new System.Drawing.Point(68, 41);
            this.txtGotoAltB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAltB.Name = "txtGotoAltB";
            this.txtGotoAltB.Size = new System.Drawing.Size(88, 29);
            this.txtGotoAltB.TabIndex = 6;
            this.txtGotoAltB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "AziB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "AziS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGotoAziS
            // 
            this.txtGotoAziS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAziS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAziS.Location = new System.Drawing.Point(68, 78);
            this.txtGotoAziS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAziS.Name = "txtGotoAziS";
            this.txtGotoAziS.Size = new System.Drawing.Size(69, 29);
            this.txtGotoAziS.TabIndex = 8;
            this.txtGotoAziS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGotoAltS
            // 
            this.txtGotoAltS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAltS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAltS.Location = new System.Drawing.Point(68, 115);
            this.txtGotoAltS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAltS.Name = "txtGotoAltS";
            this.txtGotoAltS.Size = new System.Drawing.Size(69, 29);
            this.txtGotoAltS.TabIndex = 10;
            this.txtGotoAltS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGotoAziA
            // 
            this.txtGotoAziA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAziA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAziA.Location = new System.Drawing.Point(227, 4);
            this.txtGotoAziA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAziA.Name = "txtGotoAziA";
            this.txtGotoAziA.Size = new System.Drawing.Size(69, 29);
            this.txtGotoAziA.TabIndex = 11;
            this.txtGotoAziA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGotoAltA
            // 
            this.txtGotoAltA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAltA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAltA.Location = new System.Drawing.Point(227, 41);
            this.txtGotoAltA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAltA.Name = "txtGotoAltA";
            this.txtGotoAltA.Size = new System.Drawing.Size(69, 29);
            this.txtGotoAltA.TabIndex = 12;
            this.txtGotoAltA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGotoAziD
            // 
            this.txtGotoAziD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAziD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAziD.Location = new System.Drawing.Point(227, 78);
            this.txtGotoAziD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAziD.Name = "txtGotoAziD";
            this.txtGotoAziD.Size = new System.Drawing.Size(69, 29);
            this.txtGotoAziD.TabIndex = 13;
            this.txtGotoAziD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGotoAltD
            // 
            this.txtGotoAltD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGotoAltD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGotoAltD.Location = new System.Drawing.Point(227, 115);
            this.txtGotoAltD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGotoAltD.Name = "txtGotoAltD";
            this.txtGotoAltD.Size = new System.Drawing.Size(69, 29);
            this.txtGotoAltD.TabIndex = 14;
            this.txtGotoAltD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "AltS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "AziA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "AltA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "AziD";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "AltD";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlActiveCommand
            // 
            this.pnlActiveCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlActiveCommand.Location = new System.Drawing.Point(12, 50);
            this.pnlActiveCommand.Name = "pnlActiveCommand";
            this.pnlActiveCommand.Size = new System.Drawing.Size(376, 302);
            this.pnlActiveCommand.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 359);
            this.Controls.Add(this.pnlActiveCommand);
            this.Controls.Add(this.tlpGoto);
            this.Controls.Add(this.tlpHome);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cboCommandType);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Form1";
            this.tlpHome.ResumeLayout(false);
            this.tlpHome.PerformLayout();
            this.tlpGoto.ResumeLayout(false);
            this.tlpGoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCommandType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.TextBox txtHomeAziB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHomeAltB;
        private System.Windows.Forms.TableLayoutPanel tlpHome;
        private System.Windows.Forms.TableLayoutPanel tlpGoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGotoAziB;
        private System.Windows.Forms.TextBox txtGotoAltB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlActiveCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGotoAziS;
        private System.Windows.Forms.TextBox txtGotoAltS;
        private System.Windows.Forms.TextBox txtGotoAziA;
        private System.Windows.Forms.TextBox txtGotoAltA;
        private System.Windows.Forms.TextBox txtGotoAziD;
        private System.Windows.Forms.TextBox txtGotoAltD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

