namespace AgRecords.View
{
    partial class LettersControl
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
            picBoxLetter = new PictureBox();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxLetter).BeginInit();
            SuspendLayout();
            // 
            // picBoxLetter
            // 
            picBoxLetter.Location = new Point(3, 3);
            picBoxLetter.Name = "picBoxLetter";
            picBoxLetter.Size = new Size(144, 118);
            picBoxLetter.TabIndex = 0;
            picBoxLetter.TabStop = false;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(45, 124);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(62, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Letter Title";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTitle);
            Controls.Add(picBoxLetter);
            Name = "UserControl1";
            Load += LetterControl_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxLetter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxLetter;
        private Label labelTitle;
    }
}
