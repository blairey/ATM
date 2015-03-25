namespace BlaireAtm
{
    partial class AtmDisplay
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
            this.LoginContainer = new System.Windows.Forms.GroupBox();
            this.PinNoInput = new System.Windows.Forms.TextBox();
            this.AccountNoInput = new System.Windows.Forms.TextBox();
            this.PinNoLbl = new System.Windows.Forms.Label();
            this.AccountNoLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ActionsContainer = new System.Windows.Forms.GroupBox();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.MoneyInput = new System.Windows.Forms.TextBox();
            this.CheckBalance = new System.Windows.Forms.Button();
            this.balanceDisplay = new System.Windows.Forms.TextBox();
            this.WithdrawThreadSafeBtn = new System.Windows.Forms.Button();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.LoginContainer.SuspendLayout();
            this.ActionsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginContainer
            // 
            this.LoginContainer.Controls.Add(this.PinNoInput);
            this.LoginContainer.Controls.Add(this.AccountNoInput);
            this.LoginContainer.Controls.Add(this.PinNoLbl);
            this.LoginContainer.Controls.Add(this.AccountNoLbl);
            this.LoginContainer.Controls.Add(this.LoginBtn);
            this.LoginContainer.Location = new System.Drawing.Point(12, 12);
            this.LoginContainer.Name = "LoginContainer";
            this.LoginContainer.Size = new System.Drawing.Size(457, 362);
            this.LoginContainer.TabIndex = 0;
            this.LoginContainer.TabStop = false;
            this.LoginContainer.Text = "Login";
            // 
            // PinNoInput
            // 
            this.PinNoInput.Location = new System.Drawing.Point(146, 136);
            this.PinNoInput.Name = "PinNoInput";
            this.PinNoInput.Size = new System.Drawing.Size(100, 22);
            this.PinNoInput.TabIndex = 4;
            // 
            // AccountNoInput
            // 
            this.AccountNoInput.Location = new System.Drawing.Point(146, 91);
            this.AccountNoInput.Name = "AccountNoInput";
            this.AccountNoInput.Size = new System.Drawing.Size(100, 22);
            this.AccountNoInput.TabIndex = 3;
            // 
            // PinNoLbl
            // 
            this.PinNoLbl.AutoSize = true;
            this.PinNoLbl.Location = new System.Drawing.Point(143, 116);
            this.PinNoLbl.Name = "PinNoLbl";
            this.PinNoLbl.Size = new System.Drawing.Size(52, 17);
            this.PinNoLbl.TabIndex = 2;
            this.PinNoLbl.Text = "Pin no.";
            // 
            // AccountNoLbl
            // 
            this.AccountNoLbl.AutoSize = true;
            this.AccountNoLbl.Location = new System.Drawing.Point(143, 71);
            this.AccountNoLbl.Name = "AccountNoLbl";
            this.AccountNoLbl.Size = new System.Drawing.Size(83, 17);
            this.AccountNoLbl.TabIndex = 1;
            this.AccountNoLbl.Text = "Account no.";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(363, 327);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(88, 29);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ActionsContainer
            // 
            this.ActionsContainer.Controls.Add(this.LogoutBtn);
            this.ActionsContainer.Controls.Add(this.DepositBtn);
            this.ActionsContainer.Controls.Add(this.WithdrawThreadSafeBtn);
            this.ActionsContainer.Controls.Add(this.WithdrawBtn);
            this.ActionsContainer.Controls.Add(this.MoneyInput);
            this.ActionsContainer.Controls.Add(this.CheckBalance);
            this.ActionsContainer.Controls.Add(this.balanceDisplay);
            this.ActionsContainer.Location = new System.Drawing.Point(12, 12);
            this.ActionsContainer.Name = "ActionsContainer";
            this.ActionsContainer.Size = new System.Drawing.Size(457, 362);
            this.ActionsContainer.TabIndex = 6;
            this.ActionsContainer.TabStop = false;
            this.ActionsContainer.Text = "Actions";
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(272, 136);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(179, 23);
            this.WithdrawBtn.TabIndex = 3;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            this.WithdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // MoneyInput
            // 
            this.MoneyInput.Location = new System.Drawing.Point(166, 136);
            this.MoneyInput.Name = "MoneyInput";
            this.MoneyInput.Size = new System.Drawing.Size(100, 22);
            this.MoneyInput.TabIndex = 2;
            // 
            // CheckBalance
            // 
            this.CheckBalance.Location = new System.Drawing.Point(272, 98);
            this.CheckBalance.Name = "CheckBalance";
            this.CheckBalance.Size = new System.Drawing.Size(75, 23);
            this.CheckBalance.TabIndex = 1;
            this.CheckBalance.Text = "Refresh";
            this.CheckBalance.UseVisualStyleBackColor = true;
            this.CheckBalance.Click += new System.EventHandler(this.CheckBalance_Click);
            // 
            // balanceDisplay
            // 
            this.balanceDisplay.Location = new System.Drawing.Point(166, 99);
            this.balanceDisplay.Name = "balanceDisplay";
            this.balanceDisplay.ReadOnly = true;
            this.balanceDisplay.Size = new System.Drawing.Size(100, 22);
            this.balanceDisplay.TabIndex = 0;
            // 
            // WithdrawThreadSafeBtn
            // 
            this.WithdrawThreadSafeBtn.Location = new System.Drawing.Point(272, 165);
            this.WithdrawThreadSafeBtn.Name = "WithdrawThreadSafeBtn";
            this.WithdrawThreadSafeBtn.Size = new System.Drawing.Size(179, 23);
            this.WithdrawThreadSafeBtn.TabIndex = 4;
            this.WithdrawThreadSafeBtn.Text = "Withdraw Thread Safe";
            this.WithdrawThreadSafeBtn.UseVisualStyleBackColor = true;
            this.WithdrawThreadSafeBtn.Click += new System.EventHandler(this.WithdrawThreadSafeBtn_Click);
            // 
            // DepositBtn
            // 
            this.DepositBtn.Location = new System.Drawing.Point(272, 194);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(179, 23);
            this.DepositBtn.TabIndex = 5;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            this.DepositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(272, 253);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(179, 23);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AtmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 386);
            this.Controls.Add(this.ActionsContainer);
            this.Controls.Add(this.LoginContainer);
            this.Name = "AtmDisplay";
            this.Text = "AtmDisplay";
            this.LoginContainer.ResumeLayout(false);
            this.LoginContainer.PerformLayout();
            this.ActionsContainer.ResumeLayout(false);
            this.ActionsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginContainer;
        private System.Windows.Forms.TextBox PinNoInput;
        private System.Windows.Forms.TextBox AccountNoInput;
        private System.Windows.Forms.Label PinNoLbl;
        private System.Windows.Forms.Label AccountNoLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.GroupBox ActionsContainer;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.TextBox MoneyInput;
        private System.Windows.Forms.Button CheckBalance;
        private System.Windows.Forms.TextBox balanceDisplay;
        private System.Windows.Forms.Button WithdrawThreadSafeBtn;
        private System.Windows.Forms.Button DepositBtn;
        private System.Windows.Forms.Button LogoutBtn;
    }
}