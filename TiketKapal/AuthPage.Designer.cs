namespace TiketKapal
{
    partial class AuthPage
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UNameLabel = new System.Windows.Forms.Label();
            this.UPassLabel = new System.Windows.Forms.Label();
            this.UPassText = new System.Windows.Forms.TextBox();
            this.UNameText = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(12, 238);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 39);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UNameLabel
            // 
            this.UNameLabel.AutoSize = true;
            this.UNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameLabel.Location = new System.Drawing.Point(94, 24);
            this.UNameLabel.Name = "UNameLabel";
            this.UNameLabel.Size = new System.Drawing.Size(117, 31);
            this.UNameLabel.TabIndex = 1;
            this.UNameLabel.Text = "Username";
            this.UNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPassLabel
            // 
            this.UPassLabel.AutoSize = true;
            this.UPassLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPassLabel.Location = new System.Drawing.Point(94, 129);
            this.UPassLabel.Name = "UPassLabel";
            this.UPassLabel.Size = new System.Drawing.Size(110, 31);
            this.UPassLabel.TabIndex = 2;
            this.UPassLabel.Text = "Password";
            this.UPassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPassText
            // 
            this.UPassText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPassText.Location = new System.Drawing.Point(56, 163);
            this.UPassText.Name = "UPassText";
            this.UPassText.Size = new System.Drawing.Size(189, 38);
            this.UPassText.TabIndex = 3;
            this.UPassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UNameText
            // 
            this.UNameText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameText.Location = new System.Drawing.Point(56, 58);
            this.UNameText.Name = "UNameText";
            this.UNameText.Size = new System.Drawing.Size(189, 38);
            this.UNameText.TabIndex = 4;
            this.UNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register
            // 
            this.Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Register.Location = new System.Drawing.Point(175, 238);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(126, 39);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "/";
            // 
            // AuthPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(313, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.UNameText);
            this.Controls.Add(this.UPassText);
            this.Controls.Add(this.UPassLabel);
            this.Controls.Add(this.UNameLabel);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AuthPage";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoginButton;
        private Label UNameLabel;
        private Label UPassLabel;
        private TextBox UPassText;
        private TextBox UNameText;
        private Button Register;
        private Label label1;
    }
}