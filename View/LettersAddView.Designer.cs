namespace AgRecords.View
{
    partial class LettersAddView
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
            labelLetterId = new Label();
            openFileDialog1 = new OpenFileDialog();
            listViewLetters = new ListView();
            imageList1 = new ImageList(components);
            btnBrowse = new Button();
            btnRemove = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            flowLayoutPanelTags = new FlowLayoutPanel();
            txtBoxTags = new TextBox();
            label2 = new Label();
            comboBoxType = new ComboBox();
            txtBoxTitle = new TextBox();
            label1 = new Label();
            labelTitle = new Label();
            groupBox3 = new GroupBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtBoxDescription = new TextBox();
            label7 = new Label();
            txtBoxFrom = new TextBox();
            label6 = new Label();
            txtBoxTo = new TextBox();
            label5 = new Label();
            comboBoxAction = new ComboBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // labelLetterId
            // 
            labelLetterId.AutoSize = true;
            labelLetterId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLetterId.Location = new Point(10, 16);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(72, 20);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewLetters
            // 
            listViewLetters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(10, 258);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(935, 146);
            listViewLetters.SmallImageList = imageList1;
            listViewLetters.TabIndex = 5;
            listViewLetters.UseCompatibleStateImageBehavior = false;
            listViewLetters.DoubleClick += listViewLetters_DoubleClick;
            listViewLetters.KeyDown += listView1_KeyDown;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(64, 64);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(43, 121, 223);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(10, 412);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(118, 33);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(43, 121, 223);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(134, 412);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(118, 33);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(827, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 33);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(704, 412);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 33);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelLetterId);
            groupBox1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(10, 6);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(501, 44);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
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
            groupBox2.Location = new Point(10, 52);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(501, 201);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(75, 115);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(410, 77);
            flowLayoutPanelTags.TabIndex = 28;
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTags.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(75, 88);
            txtBoxTags.Margin = new Padding(3, 2, 3, 2);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(411, 25);
            txtBoxTags.TabIndex = 27;
            txtBoxTags.KeyPress += txtBoxTags_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
            label2.TabIndex = 26;
            label2.Text = "Tags";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal" });
            comboBoxType.Location = new Point(75, 52);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(411, 25);
            comboBoxType.TabIndex = 25;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(75, 17);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(411, 25);
            txtBoxTitle.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 54);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 23;
            label1.Text = "Type";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(10, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 18);
            labelTitle.TabIndex = 22;
            labelTitle.Text = "Title";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBoxAction);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(txtBoxDescription);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtBoxFrom);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtBoxTo);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(526, 6);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(420, 247);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 19);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 31;
            label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Checked = false;
            dateTimePicker1.Location = new Point(76, 16);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 25);
            dateTimePicker1.TabIndex = 30;
            dateTimePicker1.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBoxDescription.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(13, 160);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(391, 78);
            txtBoxDescription.TabIndex = 29;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 135);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 28;
            label7.Text = "Description";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFrom.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFrom.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(75, 98);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(329, 25);
            txtBoxFrom.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 100);
            label6.Name = "label6";
            label6.Size = new Size(43, 18);
            label6.TabIndex = 26;
            label6.Text = "From";
            // 
            // txtBoxTo
            // 
            txtBoxTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxTo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTo.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(75, 63);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(329, 25);
            txtBoxTo.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 64);
            label5.Name = "label5";
            label5.Size = new Size(26, 18);
            label5.TabIndex = 24;
            label5.Text = "To";
            // 
            // comboBoxAction
            // 
            comboBoxAction.FormattingEnabled = true;
            comboBoxAction.Items.AddRange(new object[] { "Pending", "Reviewed", "Responded", "Archived" });
            comboBoxAction.Location = new Point(269, 128);
            comboBoxAction.Name = "comboBoxAction";
            comboBoxAction.Size = new Size(121, 25);
            comboBoxAction.TabIndex = 32;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(211, 134);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 33;
            label4.Text = "Action";
            // 
            // LettersAddView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(959, 458);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowse);
            Controls.Add(listViewLetters);
            KeyPreview = true;
            Name = "LettersAddView";
            Text = "LettersAddView";
            Load += LettersAddView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelLetterId;
        private OpenFileDialog openFileDialog1;
        private ListView listViewLetters;
        private Button btnBrowse;
        private Button btnRemove;
        private Button btnCancel;
        private ImageList imageList1;
        private Button btnSave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanelTags;
        private TextBox txtBoxTags;
        private Label label2;
        private ComboBox comboBoxType;
        private TextBox txtBoxTitle;
        private Label label1;
        private Label labelTitle;
        private GroupBox groupBox3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBoxDescription;
        private Label label7;
        private TextBox txtBoxFrom;
        private Label label6;
        private TextBox txtBoxTo;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxAction;
    }
}