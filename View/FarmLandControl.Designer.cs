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
            label1 = new Label();
            groupBox1 = new GroupBox();
            farmLoc = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelParcelNo
            // 
            labelParcelNo.AutoSize = true;
            labelParcelNo.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelParcelNo.Location = new Point(115, 7);
            labelParcelNo.Name = "labelParcelNo";
            labelParcelNo.Size = new Size(19, 24);
            labelParcelNo.TabIndex = 0;
            labelParcelNo.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 11);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "Farm Parcel No.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(farmLoc);
            groupBox1.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 271);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Farm Land";
            // 
            // farmLoc
            // 
            farmLoc.BorderStyle = BorderStyle.FixedSingle;
            farmLoc.Location = new Point(82, 52);
            farmLoc.Name = "farmLoc";
            farmLoc.Size = new Size(125, 31);
            farmLoc.TabIndex = 0;
            // 
            // FarmLandControl
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(labelParcelNo);
            Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FarmLandControl";
            Size = new Size(1119, 520);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelParcelNo;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox farmLoc;
    }
}
