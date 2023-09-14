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
            labelLetterId.Location = new Point(53, 25);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(66, 20);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(53, 68);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 20);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 115);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(135, 68);
            txtBoxTitle.Margin = new Padding(3, 4, 3, 4);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(140, 27);
            txtBoxTitle.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal", "External" });
            comboBoxType.Location = new Point(137, 120);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(138, 28);
            comboBoxType.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewLetters
            // 
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(16, 348);
            listViewLetters.Margin = new Padding(3, 4, 3, 4);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(886, 265);
            listViewLetters.SmallImageList = imageList1;
            listViewLetters.TabIndex = 5;
            listViewLetters.UseCompatibleStateImageBehavior = false;
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
            btnBrowse.Location = new Point(333, 623);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(135, 59);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(474, 623);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(135, 59);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(768, 623);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 59);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(626, 623);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 59);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 165);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 10;
            label2.Text = "Tags";
            // 
            // txtBoxTags
            // 
            txtBoxTags.Location = new Point(135, 165);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(306, 27);
            txtBoxTags.TabIndex = 11;
            txtBoxTags.KeyPress += txtBoxTags_KeyPress;
            // 
            // txtBoxTo
            // 
            txtBoxTo.Location = new Point(434, 64);
            txtBoxTo.Margin = new Padding(3, 4, 3, 4);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(114, 27);
            txtBoxTo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 68);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 14;
            label5.Text = "To";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.Location = new Point(434, 104);
            txtBoxFrom.Margin = new Padding(3, 4, 3, 4);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(114, 27);
            txtBoxFrom.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 108);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 16;
            label6.Text = "From";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(691, 68);
            txtBoxDescription.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(174, 96);
            txtBoxDescription.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(691, 44);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 18;
            label7.Text = "Description";
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(53, 203);
            flowLayoutPanelTags.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(848, 80);
            flowLayoutPanelTags.TabIndex = 21;
            // 
            // LettersAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 687);
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
            Margin = new Padding(3, 4, 3, 4);
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