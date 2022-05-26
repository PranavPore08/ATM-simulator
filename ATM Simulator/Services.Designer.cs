namespace ATM_Simulator
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_fast = new System.Windows.Forms.Button();
            this.btn_pin = new System.Windows.Forms.Button();
            this.btn_cash_withdrawal = new System.Windows.Forms.Button();
            this.btn_mini_state = new System.Windows.Forms.Button();
            this.btn_balance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_deposit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deposit.Location = new System.Drawing.Point(21, 78);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(219, 40);
            this.btn_deposit.TabIndex = 1;
            this.btn_deposit.Text = "DEPOSIT";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_fast
            // 
            this.btn_fast.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_fast.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fast.Location = new System.Drawing.Point(21, 177);
            this.btn_fast.Name = "btn_fast";
            this.btn_fast.Size = new System.Drawing.Size(219, 40);
            this.btn_fast.TabIndex = 2;
            this.btn_fast.Text = "FAST CASH";
            this.btn_fast.UseVisualStyleBackColor = false;
            this.btn_fast.Click += new System.EventHandler(this.btn_fast_Click);
            // 
            // btn_pin
            // 
            this.btn_pin.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_pin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pin.Location = new System.Drawing.Point(21, 278);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(219, 40);
            this.btn_pin.TabIndex = 3;
            this.btn_pin.Text = "PIN CHANGE";
            this.btn_pin.UseVisualStyleBackColor = false;
            this.btn_pin.Click += new System.EventHandler(this.btn_pin_Click);
            // 
            // btn_cash_withdrawal
            // 
            this.btn_cash_withdrawal.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_cash_withdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cash_withdrawal.Location = new System.Drawing.Point(443, 78);
            this.btn_cash_withdrawal.Name = "btn_cash_withdrawal";
            this.btn_cash_withdrawal.Size = new System.Drawing.Size(219, 40);
            this.btn_cash_withdrawal.TabIndex = 4;
            this.btn_cash_withdrawal.Text = "CASH WITHDRAWAL";
            this.btn_cash_withdrawal.UseVisualStyleBackColor = false;
            this.btn_cash_withdrawal.Click += new System.EventHandler(this.btn_cash_withdrawal_Click);
            // 
            // btn_mini_state
            // 
            this.btn_mini_state.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_mini_state.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_mini_state.Location = new System.Drawing.Point(443, 177);
            this.btn_mini_state.Name = "btn_mini_state";
            this.btn_mini_state.Size = new System.Drawing.Size(219, 40);
            this.btn_mini_state.TabIndex = 5;
            this.btn_mini_state.Text = "FUND TRANSFER";
            this.btn_mini_state.UseVisualStyleBackColor = false;
            this.btn_mini_state.Click += new System.EventHandler(this.btn_mini_state_Click);
            // 
            // btn_balance
            // 
            this.btn_balance.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_balance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_balance.Location = new System.Drawing.Point(443, 278);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(219, 40);
            this.btn_balance.TabIndex = 6;
            this.btn_balance.Text = "BALANCE ENQUIRY";
            this.btn_balance.UseVisualStyleBackColor = false;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please Select Your Transaction";
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_balance);
            this.Controls.Add(this.btn_mini_state);
            this.Controls.Add(this.btn_cash_withdrawal);
            this.Controls.Add(this.btn_pin);
            this.Controls.Add(this.btn_fast);
            this.Controls.Add(this.btn_deposit);
            this.Name = "Services";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_deposit;
        private Button btn_fast;
        private Button btn_pin;
        private Button btn_cash_withdrawal;
        private Button btn_mini_state;
        private Button btn_balance;
        private Label label1;
    }
}