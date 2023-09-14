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
            labelLetterId.Location = new Point(46, 19);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(51, 15);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(46, 51);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 86);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.Location = new Point(118, 51);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(123, 23);
            txtBoxTitle.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Ingoing", "Outgoing" });
            comboBoxType.Location = new Point(120, 90);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewLetters
            // 
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(14, 261);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(776, 200);
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
            btnBrowse.Location = new Point(291, 467);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(118, 44);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(415, 467);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(118, 44);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(672, 467);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 44);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(548, 467);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 44);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 124);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 10;
            label2.Text = "Tags";
            // 
            // txtBoxTags
            // 
            txtBoxTags.Location = new Point(118, 124);
            txtBoxTags.Margin = new Padding(3, 2, 3, 2);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(268, 23);
            txtBoxTags.TabIndex = 11;
            txtBoxTags.KeyPress += txtBoxTags_KeyPress;
            // 
            // txtBoxTo
            // 
            txtBoxTo.Location = new Point(380, 48);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(100, 23);
            txtBoxTo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 51);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 14;
            label5.Text = "To";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.Location = new Point(380, 78);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(100, 23);
            txtBoxFrom.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(345, 81);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 16;
            label6.Text = "From";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(605, 51);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(153, 73);
            txtBoxDescription.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(605, 33);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 18;
            label7.Text = "Description";
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(46, 152);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(742, 60);
            flowLayoutPanelTags.TabIndex = 21;
            // 
            // LettersAddView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 515);
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