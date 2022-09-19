namespace UX_Design
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.lblLoanTerm = new System.Windows.Forms.Label();
			this.lblInterestRate = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.lblLoamAmt = new System.Windows.Forms.Label();
			this.btnCompute = new System.Windows.Forms.Button();
			this.lblMP = new System.Windows.Forms.Label();
			this.lblDisplayMP = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(326, 347);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "compute";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Location = new System.Drawing.Point(54, 25);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(116, 15);
			this.lblWelcome.TabIndex = 2;
			this.lblWelcome.Text = "Welcome, Username";
			// 
			// lblLoanTerm
			// 
			this.lblLoanTerm.AutoSize = true;
			this.lblLoanTerm.Location = new System.Drawing.Point(61, 298);
			this.lblLoanTerm.Name = "lblLoanTerm";
			this.lblLoanTerm.Size = new System.Drawing.Size(62, 15);
			this.lblLoanTerm.TabIndex = 4;
			this.lblLoanTerm.Text = "Loan Term";
			// 
			// lblInterestRate
			// 
			this.lblInterestRate.AutoSize = true;
			this.lblInterestRate.Location = new System.Drawing.Point(61, 362);
			this.lblInterestRate.Name = "lblInterestRate";
			this.lblInterestRate.Size = new System.Drawing.Size(72, 15);
			this.lblInterestRate.TabIndex = 5;
			this.lblInterestRate.Text = "Interest Rate";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(147, 234);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(226, 23);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(147, 295);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(226, 23);
			this.textBox2.TabIndex = 7;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(147, 359);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(226, 23);
			this.textBox3.TabIndex = 8;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// lblLoamAmt
			// 
			this.lblLoamAmt.AutoSize = true;
			this.lblLoamAmt.Location = new System.Drawing.Point(61, 237);
			this.lblLoamAmt.Name = "lblLoamAmt";
			this.lblLoamAmt.Size = new System.Drawing.Size(80, 15);
			this.lblLoamAmt.TabIndex = 9;
			this.lblLoamAmt.Text = "Loan Amount";
			// 
			// btnCompute
			// 
			this.btnCompute.Location = new System.Drawing.Point(213, 426);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(75, 23);
			this.btnCompute.TabIndex = 10;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
			// 
			// lblMP
			// 
			this.lblMP.AutoSize = true;
			this.lblMP.Location = new System.Drawing.Point(200, 109);
			this.lblMP.Name = "lblMP";
			this.lblMP.Size = new System.Drawing.Size(110, 15);
			this.lblMP.TabIndex = 11;
			this.lblMP.Text = "Monthly Payments:";
			// 
			// lblDisplayMP
			// 
			this.lblDisplayMP.AutoSize = true;
			this.lblDisplayMP.Location = new System.Drawing.Point(235, 155);
			this.lblDisplayMP.Name = "lblDisplayMP";
			this.lblDisplayMP.Size = new System.Drawing.Size(13, 15);
			this.lblDisplayMP.TabIndex = 12;
			this.lblDisplayMP.Text = "$";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(503, 530);
			this.Controls.Add(this.lblDisplayMP);
			this.Controls.Add(this.lblMP);
			this.Controls.Add(this.btnCompute);
			this.Controls.Add(this.lblLoamAmt);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblInterestRate);
			this.Controls.Add(this.lblLoanTerm);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private Label lblWelcome;
		private Label lblLoanTerm;
		private Label lblInterestRate;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Label lblLoamAmt;
		private Button btnCompute;
		private Label lblMP;
		private Label lblDisplayMP;
	}
}