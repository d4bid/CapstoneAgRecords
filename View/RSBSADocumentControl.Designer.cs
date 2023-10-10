namespace AgRecords.View
{
    partial class RSBSADocumentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRemove = new FontAwesome.Sharp.IconButton();
            cbDocType = new ComboBox();
            pbDocPhoto = new PictureBox();
            btnBrowse = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDocPhoto).BeginInit();
            SuspendLayout();
            // 
            // btnRemove
            // 
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnRemove.IconColor = Color.Black;
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 30;
            btnRemove.Location = new Point(117, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(30, 30);
            btnRemove.TabIndex = 30;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cbDocType
            // 
            cbDocType.FormattingEnabled = true;
            cbDocType.Items.AddRange(new object[] { "Type 1", "Type 2", "Type 3", "Type 4" });
            cbDocType.Location = new Point(49, 124);
            cbDocType.Name = "cbDocType";
            cbDocType.Size = new Size(85, 23);
            cbDocType.TabIndex = 31;
            // 
            // pbDocPhoto
            // 
            pbDocPhoto.BackgroundImageLayout = ImageLayout.Center;
            pbDocPhoto.Location = new Point(21, 3);
            pbDocPhoto.Name = "pbDocPhoto";
            pbDocPhoto.Size = new Size(90, 90);
            pbDocPhoto.TabIndex = 32;
            pbDocPhoto.TabStop = false;
            pbDocPhoto.Click += pbDocPhoto_Click;
            pbDocPhoto.DoubleClick += pbDocPhoto_DoubleClick;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(17, 95);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(97, 23);
            btnBrowse.TabIndex = 33;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 34;
            label1.Text = "Type";
            // 
            // RSBSADocumentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label1);
            Controls.Add(btnBrowse);
            Controls.Add(pbDocPhoto);
            Controls.Add(cbDocType);
            Controls.Add(btnRemove);
            Name = "RSBSADocumentControl";
            Load += RSBSADocumentControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbDocPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRemove;
        private Button btnBrowse;
        private Label label1;
        public ComboBox cbDocType;
        public PictureBox pbDocPhoto;
    }
}
