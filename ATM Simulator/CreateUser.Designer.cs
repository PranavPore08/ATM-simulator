namespace ATM_Simulator
{
    partial class CreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUser));
            this.txt_heading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_card = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.btn_fast = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_heading
            // 
            this.txt_heading.AutoSize = true;
            this.txt_heading.BackColor = System.Drawing.Color.Transparent;
            this.txt_heading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_heading.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_heading.Location = new System.Drawing.Point(169, 9);
            this.txt_heading.Name = "txt_heading";
            this.txt_heading.Size = new System.Drawing.Size(165, 30);
            this.txt_heading.TabIndex = 7;
            this.txt_heading.Text = "Fill Your Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(100, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(255, 54);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(147, 23);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Card No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(100, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(100, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mobile No.";
            // 
            // txt_card
            // 
            this.txt_card.Location = new System.Drawing.Point(255, 119);
            this.txt_card.Name = "txt_card";
            this.txt_card.Size = new System.Drawing.Size(147, 23);
            this.txt_card.TabIndex = 2;
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(255, 178);
            this.txt_pin.MaxLength = 4;
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.PasswordChar = '*';
            this.txt_pin.Size = new System.Drawing.Size(147, 23);
            this.txt_pin.TabIndex = 3;
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(255, 241);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(147, 23);
            this.txt_mobile.TabIndex = 4;
            // 
            // btn_fast
            // 
            this.btn_fast.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_fast.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fast.Location = new System.Drawing.Point(139, 361);
            this.btn_fast.Name = "btn_fast";
            this.btn_fast.Size = new System.Drawing.Size(110, 34);
            this.btn_fast.TabIndex = 6;
            this.btn_fast.Text = "Submit";
            this.btn_fast.UseVisualStyleBackColor = false;
            this.btn_fast.Click += new System.EventHandler(this.btn_fast_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(100, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Balance";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(255, 309);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(147, 23);
            this.txt_balance.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(255, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.BackColor = System.Drawing.Color.Transparent;
            this.lbl_text.Location = new System.Drawing.Point(255, 80);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(0, 15);
            this.lbl_text.TabIndex = 18;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 419);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_fast);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.txt_card);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_heading);
            this.Name = "CreateUser";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt_heading;
        private Label label2;
        private TextBox txt_name;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txt_card;
        private TextBox txt_pin;
        private TextBox txt_mobile;
        private Button btn_fast;
        private Label label5;
        private TextBox txt_balance;
        private Button button1;
        private Label lbl_text;
    }
}