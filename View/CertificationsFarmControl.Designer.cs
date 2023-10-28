namespace AgRecords.View
{
    partial class CertificationsFarmControl
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
            groupBox2 = new GroupBox();
            btnRemove = new FontAwesome.Sharp.IconButton();
            labelParcelNo = new Label();
            label7 = new Label();
            rectangleRound8 = new RectangleRound();
            txtFarmInfo = new TextBox();
            txtFarmAddress = new TextBox();
            rectangleRound6 = new RectangleRound();
            label5 = new Label();
            rectangleRound5 = new RectangleRound();
            label8 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(labelParcelNo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(rectangleRound8);
            groupBox2.Controls.Add(txtFarmInfo);
            groupBox2.Controls.Add(txtFarmAddress);
            groupBox2.Controls.Add(rectangleRound6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(rectangleRound5);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(747, 299);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            // 
            // btnRemove
            // 
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnRemove.IconColor = Color.FromArgb(0, 35, 76);
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 30;
            btnRemove.Location = new Point(720, 13);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(25, 25);
            btnRemove.TabIndex = 35;
            btnRemove.TabStop = false;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // labelParcelNo
            // 
            labelParcelNo.AutoSize = true;
            labelParcelNo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelParcelNo.Location = new Point(31, 60);
            labelParcelNo.Name = "labelParcelNo";
            labelParcelNo.Size = new Size(41, 25);
            labelParcelNo.TabIndex = 34;
            labelParcelNo.Text = "No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(189, 31);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 33;
            label7.Text = "Farm Address";
            // 
            // rectangleRound8
            // 
            rectangleRound8.BackColor = Color.White;
            rectangleRound8.Location = new Point(22, 54);
            rectangleRound8.Name = "rectangleRound8";
            rectangleRound8.Size = new Size(146, 38);
            rectangleRound8.TabIndex = 32;
            // 
            // txtFarmInfo
            // 
            txtFarmInfo.BorderStyle = BorderStyle.None;
            txtFarmInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFarmInfo.Location = new Point(36, 132);
            txtFarmInfo.Margin = new Padding(3, 4, 3, 4);
            txtFarmInfo.Multiline = true;
            txtFarmInfo.Name = "txtFarmInfo";
            txtFarmInfo.Size = new Size(673, 134);
            txtFarmInfo.TabIndex = 31;
            // 
            // txtFarmAddress
            // 
            txtFarmAddress.BorderStyle = BorderStyle.None;
            txtFarmAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFarmAddress.Location = new Point(203, 57);
            txtFarmAddress.Margin = new Padding(3, 4, 3, 4);
            txtFarmAddress.Name = "txtFarmAddress";
            txtFarmAddress.Size = new Size(506, 27);
            txtFarmAddress.TabIndex = 29;
            txtFarmAddress.Text = "Address";
            // 
            // rectangleRound6
            // 
            rectangleRound6.BackColor = Color.White;
            rectangleRound6.Location = new Point(22, 129);
            rectangleRound6.Name = "rectangleRound6";
            rectangleRound6.Size = new Size(699, 150);
            rectangleRound6.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 31);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 28;
            label5.Text = "Parcel No.";
            // 
            // rectangleRound5
            // 
            rectangleRound5.BackColor = Color.White;
            rectangleRound5.Location = new Point(189, 54);
            rectangleRound5.Name = "rectangleRound5";
            rectangleRound5.Size = new Size(532, 38);
            rectangleRound5.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 106);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 26;
            label8.Text = "Farm Info";
            // 
            // CertificationsFarmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox2);
            Name = "CertificationsFarmControl";
            Size = new Size(754, 307);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label labelParcelNo;
        private Label label7;
        private RectangleRound rectangleRound8;
        private TextBox txtFarmInfo;
        private TextBox txtFarmAddress;
        private RectangleRound rectangleRound6;
        private Label label5;
        private RectangleRound rectangleRound5;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}
