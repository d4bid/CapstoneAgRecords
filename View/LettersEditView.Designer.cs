namespace AgRecords.View
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
            listViewLetters = new ListView();
            groupBox2 = new GroupBox();
            comboBoxAction = new ComboBox();
            label4 = new Label();
            txtBoxTags = new TextBox();
            comboBoxType = new ComboBox();
            txtBoxTitle = new TextBox();
            flowLayoutPanelTags = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            labelTitle = new Label();
            rectangleBlue2 = new RectangleBlue();
            rectangleBlue3 = new RectangleBlue();
            rectangleBlue4 = new RectangleBlue();
            rectangleBlue5 = new RectangleBlue();
            groupBox1 = new GroupBox();
            labelLetterId = new Label();
            rectangleBlue1 = new RectangleBlue();
            label8 = new Label();
            groupBox3 = new GroupBox();
            txtBoxDescription = new TextBox();
            txtBoxFrom = new TextBox();
            txtBoxTo = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            rectangleBlue6 = new RectangleBlue();
            rectangleBlue7 = new RectangleBlue();
            rectangleBlue8 = new RectangleBlue();
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
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(1307, 785);
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
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(1448, 785);
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
            btnRemove.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(153, 785);
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
            btnBrowse.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(12, 785);
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
            // listViewLetters
            // 
            listViewLetters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(11, 468);
            listViewLetters.Margin = new Padding(3, 4, 3, 4);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(1572, 309);
            listViewLetters.SmallImageList = imageList1;
            listViewLetters.TabIndex = 32;
            listViewLetters.UseCompatibleStateImageBehavior = false;
            listViewLetters.DoubleClick += listViewLetters_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxAction);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtBoxTags);
            groupBox2.Controls.Add(comboBoxType);
            groupBox2.Controls.Add(txtBoxTitle);
            groupBox2.Controls.Add(flowLayoutPanelTags);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(labelTitle);
            groupBox2.Controls.Add(rectangleBlue2);
            groupBox2.Controls.Add(rectangleBlue3);
            groupBox2.Controls.Add(rectangleBlue4);
            groupBox2.Controls.Add(rectangleBlue5);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(752, 334);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // comboBoxAction
            // 
            comboBoxAction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAction.FlatStyle = FlatStyle.Flat;
            comboBoxAction.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxAction.FormattingEnabled = true;
            comboBoxAction.Items.AddRange(new object[] { "Pending", "Reviewed", "Responded", "Archived" });
            comboBoxAction.Location = new Point(115, 135);
            comboBoxAction.Margin = new Padding(3, 4, 3, 4);
            comboBoxAction.Name = "comboBoxAction";
            comboBoxAction.Size = new Size(603, 33);
            comboBoxAction.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 142);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 36;
            label4.Text = "Status";
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.None;
            txtBoxTags.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(115, 192);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(597, 27);
            txtBoxTags.TabIndex = 4;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal" });
            comboBoxType.Location = new Point(115, 83);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(603, 33);
            comboBoxType.TabIndex = 2;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.None;
            txtBoxTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(115, 30);
            txtBoxTitle.Margin = new Padding(3, 4, 3, 4);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(597, 27);
            txtBoxTitle.TabIndex = 1;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(104, 233);
            flowLayoutPanelTags.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(620, 86);
            flowLayoutPanelTags.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 199);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 26;
            label2.Text = "Tags";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 92);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 23;
            label1.Text = "Type";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(16, 34);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 22;
            labelTitle.Text = "Title";
            // 
            // rectangleBlue2
            // 
            rectangleBlue2.Location = new Point(104, 27);
            rectangleBlue2.Name = "rectangleBlue2";
            rectangleBlue2.Size = new Size(620, 38);
            rectangleBlue2.TabIndex = 37;
            // 
            // rectangleBlue3
            // 
            rectangleBlue3.Location = new Point(104, 81);
            rectangleBlue3.Name = "rectangleBlue3";
            rectangleBlue3.Size = new Size(620, 38);
            rectangleBlue3.TabIndex = 38;
            // 
            // rectangleBlue4
            // 
            rectangleBlue4.Location = new Point(104, 133);
            rectangleBlue4.Name = "rectangleBlue4";
            rectangleBlue4.Size = new Size(620, 38);
            rectangleBlue4.TabIndex = 39;
            // 
            // rectangleBlue5
            // 
            rectangleBlue5.Location = new Point(104, 188);
            rectangleBlue5.Name = "rectangleBlue5";
            rectangleBlue5.Size = new Size(620, 38);
            rectangleBlue5.TabIndex = 40;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelLetterId);
            groupBox1.Controls.Add(rectangleBlue1);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 95);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // labelLetterId
            // 
            labelLetterId.AutoSize = true;
            labelLetterId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLetterId.Location = new Point(115, 35);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(91, 28);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // rectangleBlue1
            // 
            rectangleBlue1.Location = new Point(104, 32);
            rectangleBlue1.Name = "rectangleBlue1";
            rectangleBlue1.Size = new Size(620, 38);
            rectangleBlue1.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 41);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 23;
            label8.Text = "Letter ID";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(txtBoxDescription);
            groupBox3.Controls.Add(txtBoxFrom);
            groupBox3.Controls.Add(txtBoxTo);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(rectangleBlue6);
            groupBox3.Controls.Add(rectangleBlue7);
            groupBox3.Controls.Add(rectangleBlue8);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(784, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(799, 438);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxDescription.BorderStyle = BorderStyle.None;
            txtBoxDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(162, 242);
            txtBoxDescription.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(601, 172);
            txtBoxDescription.TabIndex = 7;
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFrom.BorderStyle = BorderStyle.None;
            txtBoxFrom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(162, 188);
            txtBoxFrom.Margin = new Padding(3, 4, 3, 4);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(601, 27);
            txtBoxFrom.TabIndex = 6;
            // 
            // txtBoxTo
            // 
            txtBoxTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxTo.BorderStyle = BorderStyle.None;
            txtBoxTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(162, 135);
            txtBoxTo.Margin = new Padding(3, 4, 3, 4);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(601, 27);
            txtBoxTo.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 43);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 31;
            label3.Text = "Date Received";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Checked = false;
            dateTimePicker1.Location = new Point(162, 41);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(623, 28);
            dateTimePicker1.TabIndex = 30;
            dateTimePicker1.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 246);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 28;
            label7.Text = "Description";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 194);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 26;
            label6.Text = "From";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 141);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 24;
            label5.Text = "To";
            // 
            // rectangleBlue6
            // 
            rectangleBlue6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleBlue6.Location = new Point(152, 131);
            rectangleBlue6.Name = "rectangleBlue6";
            rectangleBlue6.Size = new Size(620, 38);
            rectangleBlue6.TabIndex = 41;
            // 
            // rectangleBlue7
            // 
            rectangleBlue7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleBlue7.Location = new Point(153, 237);
            rectangleBlue7.Name = "rectangleBlue7";
            rectangleBlue7.Size = new Size(620, 186);
            rectangleBlue7.TabIndex = 42;
            // 
            // rectangleBlue8
            // 
            rectangleBlue8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleBlue8.Location = new Point(152, 182);
            rectangleBlue8.Name = "rectangleBlue8";
            rectangleBlue8.Size = new Size(620, 38);
            rectangleBlue8.TabIndex = 43;
            // 
            // LettersEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1595, 926);
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
        private ListView listViewLetters;
        private GroupBox groupBox2;
        private ComboBox comboBoxAction;
        private Label label4;
        private TextBox txtBoxTags;
        private ComboBox comboBoxType;
        private TextBox txtBoxTitle;
        private FlowLayoutPanel flowLayoutPanelTags;
        private Label label2;
        private Label label1;
        private Label labelTitle;
        private RectangleBlue rectangleBlue2;
        private RectangleBlue rectangleBlue3;
        private RectangleBlue rectangleBlue4;
        private RectangleBlue rectangleBlue5;
        private GroupBox groupBox1;
        private Label labelLetterId;
        private RectangleBlue rectangleBlue1;
        private Label label8;
        private GroupBox groupBox3;
        private TextBox txtBoxDescription;
        private TextBox txtBoxFrom;
        private TextBox txtBoxTo;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label5;
        private RectangleBlue rectangleBlue6;
        private RectangleBlue rectangleBlue7;
        private RectangleBlue rectangleBlue8;
    }
}