﻿namespace AgRecords.View
{
    partial class LettersEditView
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
            components = new System.ComponentModel.Container();
            btnSave = new Button();
            btnCancel = new Button();
            btnRemove = new Button();
            btnBrowse = new Button();
            imageList1 = new ImageList(components);
            openFileDialog1 = new OpenFileDialog();
            groupBox2 = new GroupBox();
            flowLayoutPanelTags = new FlowLayoutPanel();
            txtBoxTags = new TextBox();
            label2 = new Label();
            comboBoxType = new ComboBox();
            txtBoxTitle = new TextBox();
            label1 = new Label();
            labelTitle = new Label();
            groupBox1 = new GroupBox();
            labelLetterId = new Label();
            listViewLetters = new ListView();
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            txtBoxDescription = new TextBox();
            label7 = new Label();
            txtBoxFrom = new TextBox();
            label6 = new Label();
            txtBoxTo = new TextBox();
            label5 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(806, 549);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 44);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(946, 549);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 44);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(43, 121, 223);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(154, 549);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(135, 44);
            btnRemove.TabIndex = 0;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(43, 121, 223);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(13, 549);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(135, 44);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(64, 64);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanelTags);
            groupBox2.Controls.Add(txtBoxTags);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBoxType);
            groupBox2.Controls.Add(txtBoxTitle);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(labelTitle);
            groupBox2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(13, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(573, 268);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(86, 153);
            flowLayoutPanelTags.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(469, 103);
            flowLayoutPanelTags.TabIndex = 28;
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTags.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(86, 117);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(469, 29);
            txtBoxTags.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 119);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 26;
            label2.Text = "Tags";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal" });
            comboBoxType.Location = new Point(86, 69);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(469, 30);
            comboBoxType.TabIndex = 2;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(86, 23);
            txtBoxTitle.Margin = new Padding(3, 4, 3, 4);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(469, 29);
            txtBoxTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 72);
            label1.Name = "label1";
            label1.Size = new Size(49, 22);
            label1.TabIndex = 23;
            label1.Text = "Type";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(11, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(45, 22);
            labelTitle.TabIndex = 22;
            labelTitle.Text = "Title";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelLetterId);
            groupBox1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(13, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 59);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // labelLetterId
            // 
            labelLetterId.AutoSize = true;
            labelLetterId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLetterId.Location = new Point(11, 21);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(85, 25);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // listViewLetters
            // 
            listViewLetters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(13, 341);
            listViewLetters.Margin = new Padding(3, 4, 3, 4);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(1068, 193);
            listViewLetters.SmallImageList = imageList1;
            listViewLetters.TabIndex = 32;
            listViewLetters.UseCompatibleStateImageBehavior = false;
            listViewLetters.DoubleClick += listViewLetters_DoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtBoxDescription);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtBoxFrom);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtBoxTo);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(601, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(480, 329);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(90, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(376, 29);
            dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 25);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 39;
            label3.Text = "Date";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBoxDescription.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(19, 209);
            txtBoxDescription.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(447, 103);
            txtBoxDescription.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 175);
            label7.Name = "label7";
            label7.Size = new Size(100, 22);
            label7.TabIndex = 36;
            label7.Text = "Description";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFrom.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFrom.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(90, 126);
            txtBoxFrom.Margin = new Padding(3, 4, 3, 4);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(376, 29);
            txtBoxFrom.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 128);
            label6.Name = "label6";
            label6.Size = new Size(52, 22);
            label6.TabIndex = 34;
            label6.Text = "From";
            // 
            // txtBoxTo
            // 
            txtBoxTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxTo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTo.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(90, 79);
            txtBoxTo.Margin = new Padding(3, 4, 3, 4);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(376, 29);
            txtBoxTo.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 81);
            label5.Name = "label5";
            label5.Size = new Size(30, 22);
            label5.TabIndex = 32;
            label5.Text = "To";
            // 
            // LettersEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1096, 611);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listViewLetters);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowse);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LettersEditView";
            Text = "s";
            Load += LettersEditView_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private Button btnCancel;
        private Button btnRemove;
        private Button btnBrowse;
        private ImageList imageList1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanelTags;
        private TextBox txtBoxTags;
        private Label label2;
        private ComboBox comboBoxType;
        private TextBox txtBoxTitle;
        private Label label1;
        private Label labelTitle;
        private GroupBox groupBox1;
        private Label labelLetterId;
        private ListView listViewLetters;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox txtBoxDescription;
        private Label label7;
        private TextBox txtBoxFrom;
        private Label label6;
        private TextBox txtBoxTo;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}