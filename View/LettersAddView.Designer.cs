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
            labelTitle = new Label();
            label1 = new Label();
            txtBoxTitle = new TextBox();
            comboBoxType = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            listViewLetters = new ListView();
            imageList1 = new ImageList(components);
            btnBrowse = new Button();
            btnRemove = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            txtBoxTags = new TextBox();
            txtBoxTo = new TextBox();
            label5 = new Label();
            txtBoxFrom = new TextBox();
            label6 = new Label();
            txtBoxDescription = new TextBox();
            label7 = new Label();
            flowLayoutPanelTags = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // labelLetterId
            // 
            labelLetterId.AutoSize = true;
            labelLetterId.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelLetterId.Location = new Point(10, 9);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(65, 18);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(10, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 18);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 63);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(101, 31);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(401, 25);
            txtBoxTitle.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal", "External" });
            comboBoxType.Location = new Point(101, 64);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(401, 25);
            comboBoxType.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewLetters
            // 
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(10, 204);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(936, 200);
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
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(828, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 33);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 96);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
            label2.TabIndex = 10;
            label2.Text = "Tags";
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTags.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(101, 94);
            txtBoxTags.Margin = new Padding(3, 2, 3, 2);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(401, 25);
            txtBoxTags.TabIndex = 11;
            txtBoxTags.KeyPress += txtBoxTags_KeyPress;
            // 
            // txtBoxTo
            // 
            txtBoxTo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTo.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(625, 31);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(321, 25);
            txtBoxTo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(574, 34);
            label5.Name = "label5";
            label5.Size = new Size(26, 18);
            label5.TabIndex = 14;
            label5.Text = "To";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFrom.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(625, 62);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(321, 25);
            txtBoxFrom.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(574, 64);
            label6.Name = "label6";
            label6.Size = new Size(43, 18);
            label6.TabIndex = 16;
            label6.Text = "From";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(574, 115);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(372, 74);
            txtBoxDescription.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(574, 95);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 18;
            label7.Text = "Description";
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(10, 128);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(491, 60);
            flowLayoutPanelTags.TabIndex = 21;
            // 
            // LettersAddView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(959, 458);
            Controls.Add(flowLayoutPanelTags);
            Controls.Add(txtBoxDescription);
            Controls.Add(label7);
            Controls.Add(txtBoxFrom);
            Controls.Add(label6);
            Controls.Add(txtBoxTo);
            Controls.Add(label5);
            Controls.Add(txtBoxTags);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowse);
            Controls.Add(listViewLetters);
            Controls.Add(comboBoxType);
            Controls.Add(txtBoxTitle);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(labelLetterId);
            KeyPreview = true;
            Name = "LettersAddView";
            Text = "LettersAddView";
            Load += LettersAddView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLetterId;
        private Label labelTitle;
        private Label label1;
        private TextBox txtBoxTitle;
        private ComboBox comboBoxType;
        private OpenFileDialog openFileDialog1;
        private ListView listViewLetters;
        private Button btnBrowse;
        private Button btnRemove;
        private Button btnCancel;
        private ImageList imageList1;
        private Button btnSave;
        private Label label2;
        private TextBox txtBoxTags;
        private TextBox txtBoxTo;
        private Label label5;
        private TextBox txtBoxFrom;
        private Label label6;
        private TextBox txtBoxDescription;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanelTags;
    }
}