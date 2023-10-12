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
            labelLetterId = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            comboBoxAction = new ComboBox();
            rectangleRound6 = new RectangleRound();
            label4 = new Label();
            txtBoxTags = new TextBox();
            rectangleRound3 = new RectangleRound();
            comboBoxType = new ComboBox();
            rectangleRound2 = new RectangleRound();
            txtBoxTitle = new TextBox();
            rectangleRound1 = new RectangleRound();
            flowLayoutPanelTags = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            labelTitle = new Label();
            groupBox3 = new GroupBox();
            txtBoxDescription = new TextBox();
            rectangleRound7 = new RectangleRound();
            txtBoxFrom = new TextBox();
            rectangleRound5 = new RectangleRound();
            txtBoxTo = new TextBox();
            rectangleRound4 = new RectangleRound();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            btnSave.Location = new Point(1307, 666);
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
            btnCancel.Location = new Point(1448, 666);
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
            btnRemove.Location = new Point(156, 666);
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
            btnBrowse.Location = new Point(15, 666);
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
            listViewLetters.Location = new Point(11, 428);
            listViewLetters.Margin = new Padding(3, 4, 3, 4);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(1572, 230);
            listViewLetters.SmallImageList = imageList1;
            listViewLetters.TabIndex = 32;
            listViewLetters.UseCompatibleStateImageBehavior = false;
            listViewLetters.DoubleClick += listViewLetters_DoubleClick;
            // 
            // labelLetterId
            // 
            labelLetterId.AutoSize = true;
            labelLetterId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLetterId.Location = new Point(16, 21);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(95, 28);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelLetterId);
            groupBox1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(11, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 64);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxAction);
            groupBox2.Controls.Add(rectangleRound6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtBoxTags);
            groupBox2.Controls.Add(rectangleRound3);
            groupBox2.Controls.Add(comboBoxType);
            groupBox2.Controls.Add(rectangleRound2);
            groupBox2.Controls.Add(txtBoxTitle);
            groupBox2.Controls.Add(rectangleRound1);
            groupBox2.Controls.Add(flowLayoutPanelTags);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(labelTitle);
            groupBox2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(11, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(752, 325);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // comboBoxAction
            // 
            comboBoxAction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAction.FlatStyle = FlatStyle.Flat;
            comboBoxAction.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxAction.FormattingEnabled = true;
            comboBoxAction.Items.AddRange(new object[] { "Pending", "Reviewed", "Responded", "Archived" });
            comboBoxAction.Location = new Point(115, 126);
            comboBoxAction.Margin = new Padding(3, 4, 3, 4);
            comboBoxAction.Name = "comboBoxAction";
            comboBoxAction.Size = new Size(603, 33);
            comboBoxAction.TabIndex = 34;
            // 
            // rectangleRound6
            // 
            rectangleRound6.BackColor = Color.White;
            rectangleRound6.Location = new Point(104, 124);
            rectangleRound6.Name = "rectangleRound6";
            rectangleRound6.Size = new Size(620, 38);
            rectangleRound6.TabIndex = 35;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 135);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 36;
            label4.Text = "Action";
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.None;
            txtBoxTags.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(115, 180);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(597, 27);
            txtBoxTags.TabIndex = 27;
            // 
            // rectangleRound3
            // 
            rectangleRound3.BackColor = Color.White;
            rectangleRound3.Location = new Point(104, 176);
            rectangleRound3.Name = "rectangleRound3";
            rectangleRound3.Size = new Size(620, 38);
            rectangleRound3.TabIndex = 31;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal" });
            comboBoxType.Location = new Point(115, 77);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(603, 33);
            comboBoxType.TabIndex = 25;
            // 
            // rectangleRound2
            // 
            rectangleRound2.BackColor = Color.White;
            rectangleRound2.Location = new Point(104, 75);
            rectangleRound2.Name = "rectangleRound2";
            rectangleRound2.Size = new Size(620, 38);
            rectangleRound2.TabIndex = 30;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.None;
            txtBoxTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(115, 30);
            txtBoxTitle.Margin = new Padding(3, 4, 3, 4);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(597, 27);
            txtBoxTitle.TabIndex = 24;
            // 
            // rectangleRound1
            // 
            rectangleRound1.BackColor = Color.White;
            rectangleRound1.Location = new Point(104, 26);
            rectangleRound1.Name = "rectangleRound1";
            rectangleRound1.Size = new Size(620, 38);
            rectangleRound1.TabIndex = 29;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(104, 221);
            flowLayoutPanelTags.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(620, 86);
            flowLayoutPanelTags.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 187);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 26;
            label2.Text = "Tags";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 85);
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
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(txtBoxDescription);
            groupBox3.Controls.Add(rectangleRound7);
            groupBox3.Controls.Add(txtBoxFrom);
            groupBox3.Controls.Add(rectangleRound5);
            groupBox3.Controls.Add(txtBoxTo);
            groupBox3.Controls.Add(rectangleRound4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(781, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(799, 395);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxDescription.BorderStyle = BorderStyle.None;
            txtBoxDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(162, 198);
            txtBoxDescription.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(601, 171);
            txtBoxDescription.TabIndex = 29;
            // 
            // rectangleRound7
            // 
            rectangleRound7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleRound7.BackColor = Color.White;
            rectangleRound7.Location = new Point(152, 194);
            rectangleRound7.Name = "rectangleRound7";
            rectangleRound7.Size = new Size(623, 183);
            rectangleRound7.TabIndex = 36;
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxFrom.BorderStyle = BorderStyle.None;
            txtBoxFrom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(162, 144);
            txtBoxFrom.Margin = new Padding(3, 4, 3, 4);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(601, 27);
            txtBoxFrom.TabIndex = 27;
            // 
            // rectangleRound5
            // 
            rectangleRound5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleRound5.BackColor = Color.White;
            rectangleRound5.Location = new Point(153, 141);
            rectangleRound5.Name = "rectangleRound5";
            rectangleRound5.Size = new Size(622, 38);
            rectangleRound5.TabIndex = 35;
            // 
            // txtBoxTo
            // 
            txtBoxTo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxTo.BorderStyle = BorderStyle.None;
            txtBoxTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(162, 96);
            txtBoxTo.Margin = new Padding(3, 4, 3, 4);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(601, 27);
            txtBoxTo.TabIndex = 25;
            // 
            // rectangleRound4
            // 
            rectangleRound4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rectangleRound4.BackColor = Color.White;
            rectangleRound4.Location = new Point(153, 92);
            rectangleRound4.Name = "rectangleRound4";
            rectangleRound4.Size = new Size(624, 38);
            rectangleRound4.TabIndex = 34;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 25);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 31;
            label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Checked = false;
            dateTimePicker1.Location = new Point(152, 21);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(623, 29);
            dateTimePicker1.TabIndex = 30;
            dateTimePicker1.Value = new DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 205);
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
            label6.Location = new Point(19, 151);
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
            label5.Location = new Point(19, 104);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 24;
            label5.Text = "To";
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label labelLetterId;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBoxAction;
        private RectangleRound rectangleRound6;
        private Label label4;
        private TextBox txtBoxTags;
        private RectangleRound rectangleRound3;
        private ComboBox comboBoxType;
        private RectangleRound rectangleRound2;
        private TextBox txtBoxTitle;
        private RectangleRound rectangleRound1;
        private FlowLayoutPanel flowLayoutPanelTags;
        private Label label2;
        private Label label1;
        private Label labelTitle;
        private GroupBox groupBox3;
        private TextBox txtBoxDescription;
        private RectangleRound rectangleRound7;
        private TextBox txtBoxFrom;
        private RectangleRound rectangleRound5;
        private TextBox txtBoxTo;
        private RectangleRound rectangleRound4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}