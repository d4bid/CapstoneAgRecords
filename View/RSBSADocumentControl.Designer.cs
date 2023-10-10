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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(17, 95);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 33;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
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
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(cbDocType);
            Controls.Add(btnRemove);
            Name = "RSBSADocumentControl";
            Load += RSBSADocumentControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRemove;
        private ComboBox cbDocType;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
    }
}
