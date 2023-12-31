﻿namespace AgRecords.View
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
            txtFarmInfo = new TextBox();
            txtFarmAddress = new TextBox();
            label5 = new Label();
            label8 = new Label();
            rectangleBlue1 = new RectangleBlue();
            rectangleBlue2 = new RectangleBlue();
            rectangleBlue3 = new RectangleBlue();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(labelParcelNo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtFarmInfo);
            groupBox2.Controls.Add(txtFarmAddress);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(rectangleBlue1);
            groupBox2.Controls.Add(rectangleBlue2);
            groupBox2.Controls.Add(rectangleBlue3);
            groupBox2.Location = new Point(2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 301);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatAppearance.MouseDownBackColor = Color.White;
            btnRemove.FlatAppearance.MouseOverBackColor = Color.White;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnRemove.IconColor = Color.FromArgb(0, 35, 76);
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.IconSize = 30;
            btnRemove.Location = new Point(739, 17);
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
            labelParcelNo.Location = new Point(31, 67);
            labelParcelNo.Name = "labelParcelNo";
            labelParcelNo.Size = new Size(41, 25);
            labelParcelNo.TabIndex = 34;
            labelParcelNo.Text = "No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(189, 38);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 33;
            label7.Text = "Farm Address";
            // 
            // txtFarmInfo
            // 
            txtFarmInfo.BorderStyle = BorderStyle.None;
            txtFarmInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFarmInfo.Location = new Point(36, 139);
            txtFarmInfo.Margin = new Padding(3, 4, 3, 4);
            txtFarmInfo.Multiline = true;
            txtFarmInfo.Name = "txtFarmInfo";
            txtFarmInfo.Size = new Size(693, 134);
            txtFarmInfo.TabIndex = 31;
            // 
            // txtFarmAddress
            // 
            txtFarmAddress.BorderStyle = BorderStyle.None;
            txtFarmAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFarmAddress.Location = new Point(203, 64);
            txtFarmAddress.Margin = new Padding(3, 4, 3, 4);
            txtFarmAddress.Name = "txtFarmAddress";
            txtFarmAddress.Size = new Size(526, 27);
            txtFarmAddress.TabIndex = 29;
            txtFarmAddress.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 38);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 28;
            label5.Text = "Parcel No.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 113);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 26;
            label8.Text = "Farm Info";
            // 
            // rectangleBlue1
            // 
            rectangleBlue1.Location = new Point(22, 61);
            rectangleBlue1.Name = "rectangleBlue1";
            rectangleBlue1.Size = new Size(146, 38);
            rectangleBlue1.TabIndex = 36;
            // 
            // rectangleBlue2
            // 
            rectangleBlue2.Location = new Point(189, 61);
            rectangleBlue2.Name = "rectangleBlue2";
            rectangleBlue2.Size = new Size(552, 38);
            rectangleBlue2.TabIndex = 37;
            // 
            // rectangleBlue3
            // 
            rectangleBlue3.Location = new Point(22, 136);
            rectangleBlue3.Name = "rectangleBlue3";
            rectangleBlue3.Size = new Size(719, 150);
            rectangleBlue3.TabIndex = 38;
            // 
            // CertificationsFarmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox2);
            Name = "CertificationsFarmControl";
            Size = new Size(779, 307);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        public Label labelParcelNo;
        private Label label7;
        public TextBox txtFarmInfo;
        public TextBox txtFarmAddress;
        private Label label5;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnRemove;
        private RectangleBlue rectangleBlue1;
        private RectangleBlue rectangleBlue2;
        private RectangleBlue rectangleBlue3;
    }
}
