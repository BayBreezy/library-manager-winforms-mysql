namespace LibraryManager.Views
{
    partial class Dashboard
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
            this.welcomeBackLabel = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.bookCountLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userCountLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userCardDescription = new System.Windows.Forms.Label();
            this.booksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeBackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.welcomeBackLabel.Location = new System.Drawing.Point(24, 20);
            this.welcomeBackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(183, 26);
            this.welcomeBackLabel.TabIndex = 0;
            this.welcomeBackLabel.Text = "Welcome back!";
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.greetingLabel.Location = new System.Drawing.Point(24, 55);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(369, 21);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "Here is a quick overview of what is happening.";
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.Color.White;
            this.booksPanel.Controls.Add(this.bookCountLabel);
            this.booksPanel.Controls.Add(this.pictureBox1);
            this.booksPanel.Controls.Add(this.bookLabel);
            this.booksPanel.Location = new System.Drawing.Point(24, 127);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Size = new System.Drawing.Size(301, 211);
            this.booksPanel.TabIndex = 2;
            // 
            // bookCountLabel
            // 
            this.bookCountLabel.AutoSize = true;
            this.bookCountLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookCountLabel.Location = new System.Drawing.Point(135, 151);
            this.bookCountLabel.Name = "bookCountLabel";
            this.bookCountLabel.Size = new System.Drawing.Size(31, 36);
            this.bookCountLabel.TabIndex = 2;
            this.bookCountLabel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManager.Properties.Resources.book_front__1_;
            this.pictureBox1.Location = new System.Drawing.Point(120, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bookLabel
            // 
            this.bookLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookLabel.Location = new System.Drawing.Point(73, 91);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(154, 44);
            this.bookLabel.TabIndex = 0;
            this.bookLabel.Text = "Number of books in the system";
            this.bookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.userCountLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.userCardDescription);
            this.panel1.Location = new System.Drawing.Point(345, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 211);
            this.panel1.TabIndex = 3;
            // 
            // userCountLabel
            // 
            this.userCountLabel.AutoSize = true;
            this.userCountLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userCountLabel.Location = new System.Drawing.Point(135, 151);
            this.userCountLabel.Name = "userCountLabel";
            this.userCountLabel.Size = new System.Drawing.Size(31, 36);
            this.userCountLabel.TabIndex = 2;
            this.userCountLabel.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManager.Properties.Resources.lock_front;
            this.pictureBox2.Location = new System.Drawing.Point(120, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // userCardDescription
            // 
            this.userCardDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userCardDescription.Location = new System.Drawing.Point(73, 91);
            this.userCardDescription.Name = "userCardDescription";
            this.userCardDescription.Size = new System.Drawing.Size(154, 44);
            this.userCardDescription.TabIndex = 0;
            this.userCardDescription.Text = "Number of users in the system";
            this.userCardDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.booksPanel);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.welcomeBackLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.booksPanel.ResumeLayout(false);
            this.booksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeBackLabel;
        private Label greetingLabel;
        private Panel booksPanel;
        private Label bookLabel;
        private PictureBox pictureBox1;
        private Label bookCountLabel;
        private Panel panel1;
        private Label userCountLabel;
        private PictureBox pictureBox2;
        private Label userCardDescription;
    }
}