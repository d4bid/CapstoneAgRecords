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
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnRemove.IconColor = Color.FromArgb(0, 35, 76);
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 30;
            btnRemove.Location = new Point(276, 3);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(23, 34);
            btnRemove.TabIndex = 30;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // cbDocType
            // 
            cbDocType.FormattingEnabled = true;
            cbDocType.Items.AddRange(new object[] { "Certificate of Land Transfer", "Emancipation Patent", "Individual Certificate of Land", "Collective CLOA", "Co-Ownership CLOA", "Agricultural sales patent", "Homestead patent", "Free Patent", "Certificate of Title or Regular Title", "Ceritificate of Ancestral Domain Title", "Certificate of Ancestral Land Title", "Tax Declaration", "Barangay Certification" });
            cbDocType.Location = new Point(28, 276);
            cbDocType.Margin = new Padding(3, 4, 3, 4);
            cbDocType.Name = "cbDocType";
            cbDocType.Size = new Size(243, 28);
            cbDocType.TabIndex = 31;
            // 
            // pbDocPhoto
            // 
            pbDocPhoto.BackgroundImageLayout = ImageLayout.Center;
            pbDocPhoto.Location = new Point(28, 32);
            pbDocPhoto.Margin = new Padding(3, 4, 3, 4);
            pbDocPhoto.Name = "pbDocPhoto";
            pbDocPhoto.Size = new Size(243, 166);
            pbDocPhoto.TabIndex = 32;
            pbDocPhoto.TabStop = false;
            pbDocPhoto.Click += pbDocPhoto_Click;
            pbDocPhoto.DoubleClick += pbDocPhoto_DoubleClick;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(255, 221, 100);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.Location = new Point(28, 206);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(243, 31);
            btnBrowse.TabIndex = 33;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 252);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 34;
            label1.Text = "Type";
            // 
            // RSBSADocumentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Controls.Add(btnBrowse);
            Controls.Add(pbDocPhoto);
            Controls.Add(cbDocType);
            Controls.Add(btnRemove);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RSBSADocumentControl";
            Size = new Size(304, 321);
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
