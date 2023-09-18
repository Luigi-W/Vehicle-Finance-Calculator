namespace Vehicle_Finance_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontlyPayment = new System.Windows.Forms.TextBox();
            this.txtBalloonPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAffordibility = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCTA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Payment:";
            // 
            // txtMontlyPayment
            // 
            this.txtMontlyPayment.Location = new System.Drawing.Point(179, 41);
            this.txtMontlyPayment.Name = "txtMontlyPayment";
            this.txtMontlyPayment.Size = new System.Drawing.Size(188, 22);
            this.txtMontlyPayment.TabIndex = 1;
            this.txtMontlyPayment.TextChanged += new System.EventHandler(this.txtMontlyPayment_TextChanged);
            // 
            // txtBalloonPayment
            // 
            this.txtBalloonPayment.Location = new System.Drawing.Point(179, 79);
            this.txtBalloonPayment.Name = "txtBalloonPayment";
            this.txtBalloonPayment.Size = new System.Drawing.Size(188, 22);
            this.txtBalloonPayment.TabIndex = 3;
            this.txtBalloonPayment.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balloon Payment:";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(179, 119);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(188, 22);
            this.txtDeposit.TabIndex = 5;
            this.txtDeposit.TextChanged += new System.EventHandler(this.txtDeposit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deposit:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(179, 158);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(188, 22);
            this.txtTradeInValue.TabIndex = 7;
            this.txtTradeInValue.TextChanged += new System.EventHandler(this.txtTradeInValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trade In Value:";
            // 
            // lblAffordibility
            // 
            this.lblAffordibility.AutoSize = true;
            this.lblAffordibility.Location = new System.Drawing.Point(279, 43);
            this.lblAffordibility.Name = "lblAffordibility";
            this.lblAffordibility.Size = new System.Drawing.Size(51, 16);
            this.lblAffordibility.TabIndex = 8;
            this.lblAffordibility.Text = "Answer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maximum Value of Vehicle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount on Loan Agreement:";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(279, 81);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(51, 16);
            this.lblLoanAmount.TabIndex = 10;
            this.lblLoanAmount.Text = "Answer";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(154)))), ((int)(((byte)(44)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblLoanAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAffordibility);
            this.groupBox1.Location = new System.Drawing.Point(-13, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 137);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnCTA
            // 
            this.btnCTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(174)))), ((int)(((byte)(171)))));
            this.btnCTA.Location = new System.Drawing.Point(101, 393);
            this.btnCTA.Name = "btnCTA";
            this.btnCTA.Size = new System.Drawing.Size(230, 50);
            this.btnCTA.TabIndex = 13;
            this.btnCTA.Text = "Apply Now !";
            this.btnCTA.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.btnCTA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBalloonPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontlyPayment);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vehicle Finance Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontlyPayment;
        private System.Windows.Forms.TextBox txtBalloonPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAffordibility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCTA;
    }
}

