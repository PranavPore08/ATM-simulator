namespace ATM_Simulator
{
    partial class W_account_type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(W_account_type));
            this.btn_cash_withdrawal = new System.Windows.Forms.Button();
            this.btn_pin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cash_withdrawal
            // 
            this.btn_cash_withdrawal.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_cash_withdrawal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cash_withdrawal.Location = new System.Drawing.Point(399, 274);
            this.btn_cash_withdrawal.Name = "btn_cash_withdrawal";
            this.btn_cash_withdrawal.Size = new System.Drawing.Size(219, 40);
            this.btn_cash_withdrawal.TabIndex = 2;
            this.btn_cash_withdrawal.Text = "Saving Account";
            this.btn_cash_withdrawal.UseVisualStyleBackColor = false;
            this.btn_cash_withdrawal.Click += new System.EventHandler(this.btn_cash_withdrawal_Click);
            // 
            // btn_pin
            // 
            this.btn_pin.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_pin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pin.Location = new System.Drawing.Point(399, 200);
            this.btn_pin.Name = "btn_pin";
            this.btn_pin.Size = new System.Drawing.Size(219, 40);
            this.btn_pin.TabIndex = 1;
            this.btn_pin.Text = "Current Accout";
            this.btn_pin.UseVisualStyleBackColor = false;
            this.btn_pin.Click += new System.EventHandler(this.btn_pin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(117, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select Your Account type";
            // 
            // W_account_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cash_withdrawal);
            this.Controls.Add(this.btn_pin);
            this.Name = "W_account_type";
            this.Text = "W_account_type";
            this.Load += new System.EventHandler(this.W_account_type_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cash_withdrawal;
        private Button btn_pin;
        private Label label2;
    }
}