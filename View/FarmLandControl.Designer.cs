namespace AgRecords.View
{
    partial class FarmLandControl
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
            labelParcelNo = new Label();
            SuspendLayout();
            // 
            // labelParcelNo
            // 
            labelParcelNo.AutoSize = true;
            labelParcelNo.Location = new Point(17, 11);
            labelParcelNo.Name = "labelParcelNo";
            labelParcelNo.Size = new Size(13, 15);
            labelParcelNo.TabIndex = 0;
            labelParcelNo.Text = "1";
            // 
            // FarmLandControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelParcelNo);
            Name = "FarmLandControl";
            Size = new Size(414, 98);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelParcelNo;
    }
}
