﻿namespace ATM_Simulator
{
    partial class PIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PIN));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(431, 233);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(119, 37);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(278, 233);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(119, 37);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.GhostWhite;
            this.btn_deposit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deposit.Location = new System.Drawing.Point(104, 233);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(119, 37);
            this.btn_deposit.TabIndex = 2;
            this.btn_deposit.Text = "Submit";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(199, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter Your PIN";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_deposit);
            this.Name = "PIN";
            this.Text = "PIN";
            this.Load += new System.EventHandler(this.PIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_exit;
        private Button btn_back;
        private Button btn_deposit;
        private TextBox textBox1;
        private Label label1;
    }
}