namespace LibraryManager.Views.BookModals
{
    partial class CreateBookForm
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
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.pageCountLabel = new System.Windows.Forms.Label();
            this.pageCountInput = new System.Windows.Forms.TextBox();
            this.createBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookTitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.bookTitleLabel.Location = new System.Drawing.Point(13, 21);
            this.bookTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(190, 23);
            this.bookTitleLabel.TabIndex = 2;
            this.bookTitleLabel.Text = "Create A New Book";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.descriptionLabel.Location = new System.Drawing.Point(16, 54);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(194, 17);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Add details and click create.";
            // 
            // titleInput
            // 
            this.titleInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleInput.Location = new System.Drawing.Point(20, 121);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(283, 26);
            this.titleInput.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(20, 99);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(68, 17);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Book Title";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorLabel.Location = new System.Drawing.Point(20, 166);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(95, 17);
            this.AuthorLabel.TabIndex = 12;
            this.AuthorLabel.Text = "Author Name";
            // 
            // authorInput
            // 
            this.authorInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorInput.Location = new System.Drawing.Point(20, 188);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(283, 26);
            this.authorInput.TabIndex = 2;
            // 
            // pageCountLabel
            // 
            this.pageCountLabel.AutoSize = true;
            this.pageCountLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageCountLabel.Location = new System.Drawing.Point(20, 233);
            this.pageCountLabel.Name = "pageCountLabel";
            this.pageCountLabel.Size = new System.Drawing.Size(87, 17);
            this.pageCountLabel.TabIndex = 12;
            this.pageCountLabel.Text = "Page Count";
            // 
            // pageCountInput
            // 
            this.pageCountInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageCountInput.Location = new System.Drawing.Point(20, 255);
            this.pageCountInput.Name = "pageCountInput";
            this.pageCountInput.Size = new System.Drawing.Size(283, 26);
            this.pageCountInput.TabIndex = 3;
            // 
            // createBookButton
            // 
            this.createBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.createBookButton.FlatAppearance.BorderSize = 0;
            this.createBookButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.createBookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.createBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBookButton.ForeColor = System.Drawing.Color.White;
            this.createBookButton.Location = new System.Drawing.Point(20, 310);
            this.createBookButton.Name = "createBookButton";
            this.createBookButton.Size = new System.Drawing.Size(283, 37);
            this.createBookButton.TabIndex = 4;
            this.createBookButton.Text = "Create Book";
            this.createBookButton.UseVisualStyleBackColor = false;
            this.createBookButton.Click += new System.EventHandler(this.createBookButton_Click);
            // 
            // CreateBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 384);
            this.Controls.Add(this.createBookButton);
            this.Controls.Add(this.pageCountInput);
            this.Controls.Add(this.pageCountLabel);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create A New Book";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bookTitleLabel;
        private Label descriptionLabel;
        private TextBox titleInput;
        private Label titleLabel;
        private Label AuthorLabel;
        private TextBox authorInput;
        private Label pageCountLabel;
        private TextBox pageCountInput;
        private Button createBookButton;
    }
}