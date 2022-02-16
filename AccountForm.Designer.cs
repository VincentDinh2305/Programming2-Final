namespace AccountsApp
{
    partial class AccountForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.interestRate = new System.Windows.Forms.TextBox();
            this.dailyWithdrawalLimit = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.visa = new System.Windows.Forms.RadioButton();
            this.cusChecking = new System.Windows.Forms.RadioButton();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            //
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.interestRate);
            this.groupBox1.Controls.Add(this.dailyWithdrawalLimit);
            this.groupBox1.Controls.Add(this.balance);
            this.groupBox1.Controls.Add(this.clientName);
            this.groupBox1.Controls.Add(this.accountNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            //
            this.interestRate.Location = new System.Drawing.Point(156, 227);
            this.interestRate.Name = "TbInterestRate";
            this.interestRate.Size = new System.Drawing.Size(118, 20);
            this.interestRate.TabIndex = 10;
            //
            this.dailyWithdrawalLimit.Location = new System.Drawing.Point(156, 179);
            this.dailyWithdrawalLimit.Name = "TbDailyWithdrawalLimit";
            this.dailyWithdrawalLimit.Size = new System.Drawing.Size(118, 20);
            this.dailyWithdrawalLimit.TabIndex = 9;
            //
            this.balance.Location = new System.Drawing.Point(156, 131);
            this.balance.Name = "TbBalance";
            this.balance.Size = new System.Drawing.Size(118, 20);
            this.balance.TabIndex = 8;
            //
            this.clientName.Location = new System.Drawing.Point(156, 85);
            this.clientName.Name = "TbClientName";
            this.clientName.Size = new System.Drawing.Size(240, 20);
            this.clientName.TabIndex = 7;
            //
            this.accountNumber.Location = new System.Drawing.Point(156, 40);
            this.accountNumber.Name = "TbAccountNumber";
            this.accountNumber.Size = new System.Drawing.Size(118, 20);
            this.accountNumber.TabIndex = 6;
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Daily Withdrawal Limit :";
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interest Rate :";
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance :";
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Name :";
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number :";
            //
            this.groupBox2.Controls.Add(this.visa);
            this.groupBox2.Controls.Add(this.cusChecking);
            this.groupBox2.Location = new System.Drawing.Point(414, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type Of Account";
            //
            this.visa.AutoSize = true;
            this.visa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visa.Location = new System.Drawing.Point(18, 55);
            this.visa.Name = "RbVisa";
            this.visa.Size = new System.Drawing.Size(48, 19);
            this.visa.TabIndex = 1;
            this.visa.Text = "Visa";
            this.visa.UseVisualStyleBackColor = true;
            //
            this.cusChecking.AutoSize = true;
            this.cusChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusChecking.Location = new System.Drawing.Point(18, 24);
            this.cusChecking.Name = "RbChecking";
            this.cusChecking.Size = new System.Drawing.Size(76, 19);
            this.cusChecking.TabIndex = 0;
            this.cusChecking.Text = "Checking";
            this.cusChecking.UseVisualStyleBackColor = true;
            this.cusChecking.CheckedChanged += new System.EventHandler(this.CheckingChange);
            //
            this.BtnCreateAccount.Location = new System.Drawing.Point(439, 311);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(138, 40);
            this.BtnCreateAccount.TabIndex = 1;
            this.BtnCreateAccount.Text = "Create Account";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCrtAccOnClick);
            //
            this.BtnSearch.Location = new System.Drawing.Point(289, 39);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearchOnClick);
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 361);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        //
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox interestRate;
        private System.Windows.Forms.TextBox dailyWithdrawalLimit;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton visa;
        private System.Windows.Forms.RadioButton cusChecking;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.Button BtnSearch;
    }
}

