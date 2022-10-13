namespace LibraryManager.Views.BookModals
{
    partial class EditBookForm
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
            this.updateBookButton = new System.Windows.Forms.Button();
            this.pageCountInput = new System.Windows.Forms.TextBox();
            this.pageCountLabel = new System.Windows.Forms.Label();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookTitleLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.bookTitleLabel.Location = new System.Drawing.Point(13, 22);
            this.bookTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(95, 23);
            this.bookTitleLabel.TabIndex = 3;
            this.bookTitleLabel.Text = "Edit Book";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.descriptionLabel.Location = new System.Drawing.Point(13, 54);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(194, 17);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Add details and click create.";
            // 
            // updateBookButton
            // 
            this.updateBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.updateBookButton.FlatAppearance.BorderSize = 0;
            this.updateBookButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.updateBookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(217)))));
            this.updateBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBookButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBookButton.ForeColor = System.Drawing.Color.White;
            this.updateBookButton.Location = new System.Drawing.Point(13, 323);
            this.updateBookButton.Name = "updateBookButton";
            this.updateBookButton.Size = new System.Drawing.Size(119, 37);
            this.updateBookButton.TabIndex = 4;
            this.updateBookButton.Text = "Update Book";
            this.updateBookButton.UseVisualStyleBackColor = false;
            this.updateBookButton.Click += new System.EventHandler(this.updateBookButton_Click);
            // 
            // pageCountInput
            // 
            this.pageCountInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageCountInput.Location = new System.Drawing.Point(13, 260);
            this.pageCountInput.Name = "pageCountInput";
            this.pageCountInput.Size = new System.Drawing.Size(283, 26);
            this.pageCountInput.TabIndex = 3;
            // 
            // pageCountLabel
            // 
            this.pageCountLabel.AutoSize = true;
            this.pageCountLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pageCountLabel.Location = new System.Drawing.Point(13, 238);
            this.pageCountLabel.Name = "pageCountLabel";
            this.pageCountLabel.Size = new System.Drawing.Size(87, 17);
            this.pageCountLabel.TabIndex = 17;
            this.pageCountLabel.Text = "Page Count";
            // 
            // authorInput
            // 
            this.authorInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authorInput.Location = new System.Drawing.Point(13, 193);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(283, 26);
            this.authorInput.TabIndex = 2;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorLabel.Location = new System.Drawing.Point(13, 171);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(95, 17);
            this.AuthorLabel.TabIndex = 18;
            this.AuthorLabel.Text = "Author Name";
            // 
            // titleInput
            // 
            this.titleInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleInput.Location = new System.Drawing.Point(13, 126);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(283, 26);
            this.titleInput.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(13, 104);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(68, 17);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Book Title";
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(159, 323);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(137, 37);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditBookForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 394);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateBookButton);
            this.Controls.Add(this.pageCountInput);
            this.Controls.Add(this.pageCountLabel);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Book Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bookTitleLabel;
        private Label descriptionLabel;
        private Button updateBookButton;
        private TextBox pageCountInput;
        private Label pageCountLabel;
        private TextBox authorInput;
        private Label AuthorLabel;
        private TextBox titleInput;
        private Label titleLabel;
        private Button deleteButton;
    }
}