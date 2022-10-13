namespace LibraryManager.Views
{
    partial class CreateFirstAdminForm
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
            this.imagePanel = new System.Windows.Forms.Panel();
            this.authImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.createAdminButton = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authImage)).BeginInit();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.authImage);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(324, 527);
            this.imagePanel.TabIndex = 0;
            // 
            // authImage
            // 
            this.authImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authImage.Image = global::LibraryManager.Properties.Resources.pexels_element_digital_1370298;
            this.authImage.InitialImage = null;
            this.authImage.Location = new System.Drawing.Point(0, 0);
            this.authImage.Name = "authImage";
            this.authImage.Size = new System.Drawing.Size(324, 527);
            this.authImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.authImage.TabIndex = 0;
            this.authImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(59, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Admin Account";
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.White;
            this.formPanel.Controls.Add(this.createAdminButton);
            this.formPanel.Controls.Add(this.passwordInput);
            this.formPanel.Controls.Add(this.passwordLabel);
            this.formPanel.Controls.Add(this.emailInput);
            this.formPanel.Controls.Add(this.emailLabel);
            this.formPanel.Controls.Add(this.nameInput);
            this.formPanel.Controls.Add(this.nameLabel);
            this.formPanel.Controls.Add(this.descriptionLabel);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.formPanel.Location = new System.Drawing.Point(323, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(343, 527);
            this.formPanel.TabIndex = 2;
            // 
            // createAdminButton
            // 
            this.createAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.createAdminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.createAdminButton.FlatAppearance.BorderSize = 0;
            this.createAdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.createAdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.createAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAdminButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAdminButton.ForeColor = System.Drawing.Color.White;
            this.createAdminButton.Location = new System.Drawing.Point(41, 379);
            this.createAdminButton.Name = "createAdminButton";
            this.createAdminButton.Size = new System.Drawing.Size(267, 36);
            this.createAdminButton.TabIndex = 4;
            this.createAdminButton.Text = "Create Admin";
            this.createAdminButton.UseVisualStyleBackColor = false;
            this.createAdminButton.Click += new System.EventHandler(this.createAdminButton_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordInput.Location = new System.Drawing.Point(41, 324);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(267, 26);
            this.passwordInput.TabIndex = 3;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(38, 302);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.Location = new System.Drawing.Point(41, 260);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(267, 26);
            this.emailInput.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(38, 238);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(43, 17);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.Location = new System.Drawing.Point(41, 197);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(267, 26);
            this.nameInput.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(38, 175);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 17);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.Location = new System.Drawing.Point(80, 109);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(194, 34);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Please enter the credentials for\r\nthe first admin user below.";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateFirstAdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(666, 527);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateFirstAdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create First Admin";
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authImage)).EndInit();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel imagePanel;
        private PictureBox authImage;
        private Label label1;
        private Panel formPanel;
        private Button createAdminButton;
        private TextBox passwordInput;
        private Label passwordLabel;
        private TextBox emailInput;
        private Label emailLabel;
        private TextBox nameInput;
        private Label nameLabel;
        private Label descriptionLabel;
    }
}