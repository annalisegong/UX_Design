namespace UX_Design
{
	partial class CalcForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDisplayMP = new System.Windows.Forms.TextBox();
            this.lblMP = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblLoamAmt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(47, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(330, 37);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "COMPUTE MONTHLY PAYMENTS";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 72);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 206);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblLoanTerm);
            this.panel3.Controls.Add(this.lblInterestRate);
            this.panel3.Controls.Add(this.lblLoamAmt);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(30, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 206);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter amounts below:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDisplayMP
            // 
            this.txtDisplayMP.BackColor = System.Drawing.Color.White;
            this.txtDisplayMP.Location = new System.Drawing.Point(42, 38);
            this.txtDisplayMP.Name = "txtDisplayMP";
            this.txtDisplayMP.Size = new System.Drawing.Size(143, 23);
            this.txtDisplayMP.TabIndex = 24;
            // 
            // lblMP
            // 
            this.lblMP.AutoSize = true;
            this.lblMP.BackColor = System.Drawing.Color.Transparent;
            this.lblMP.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMP.Location = new System.Drawing.Point(42, 6);
            this.lblMP.Name = "lblMP";
            this.lblMP.Size = new System.Drawing.Size(143, 29);
            this.lblMP.TabIndex = 23;
            this.lblMP.Text = "Monthly Payments";
            this.lblMP.Click += new System.EventHandler(this.lblMP_Click);
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.BackColor = System.Drawing.Color.Transparent;
            this.lblLoanTerm.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoanTerm.Location = new System.Drawing.Point(32, 104);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(87, 29);
            this.lblLoanTerm.TabIndex = 16;
            this.lblLoanTerm.Text = "Loan Term";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompute.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompute.Location = new System.Drawing.Point(170, 424);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(89, 34);
            this.btnCompute.TabIndex = 22;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click_1);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.BackColor = System.Drawing.Color.Transparent;
            this.lblInterestRate.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInterestRate.Location = new System.Drawing.Point(32, 153);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(100, 29);
            this.lblInterestRate.TabIndex = 17;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // lblLoamAmt
            // 
            this.lblLoamAmt.AutoSize = true;
            this.lblLoamAmt.BackColor = System.Drawing.Color.Transparent;
            this.lblLoamAmt.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoamAmt.Location = new System.Drawing.Point(32, 53);
            this.lblLoamAmt.Name = "lblLoamAmt";
            this.lblLoamAmt.Size = new System.Drawing.Size(107, 29);
            this.lblLoamAmt.TabIndex = 21;
            this.lblLoamAmt.Text = "Loan Amount";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(149, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(149, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 23);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(149, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 23);
            this.textBox2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtDisplayMP);
            this.panel4.Controls.Add(this.lblMP);
            this.panel4.Location = new System.Drawing.Point(108, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 73);
            this.panel4.TabIndex = 25;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(425, 530);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.panel1);
            this.Name = "CalcForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private Label lblWelcome;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox txtDisplayMP;
        private Label lblMP;
        private Label lblLoanTerm;
        private Button btnCompute;
        private Label lblInterestRate;
        private Label lblLoamAmt;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel4;
    }
}