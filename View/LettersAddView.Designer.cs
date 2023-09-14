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
            labelLetterId.Location = new Point(12, 9);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(79, 22);
            labelLetterId.TabIndex = 0;
            labelLetterId.Text = "Letter ID";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(12, 44);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(45, 22);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(49, 22);
            label1.TabIndex = 2;
            label1.Text = "Type";
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(115, 41);
            txtBoxTitle.Margin = new Padding(3, 4, 3, 4);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(458, 29);
            txtBoxTitle.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal", "External" });
            comboBoxType.Location = new Point(115, 85);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(458, 30);
            comboBoxType.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listViewLetters
            // 
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(12, 272);
            listViewLetters.Margin = new Padding(3, 4, 3, 4);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(1069, 265);
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
            btnBrowse.BackColor = Color.FromArgb(43, 121, 223);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(12, 549);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(135, 44);
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
            btnRemove.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(153, 549);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(135, 44);
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
            btnCancel.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(946, 549);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 44);
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
            btnSave.Font = new Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(805, 549);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 44);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 10;
            label2.Text = "Tags";
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTags.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(115, 125);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(458, 29);
            txtBoxTags.TabIndex = 11;
            txtBoxTags.KeyPress += txtBoxTags_KeyPress;
            // 
            // txtBoxTo
            // 
            txtBoxTo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTo.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(714, 41);
            txtBoxTo.Margin = new Padding(3, 4, 3, 4);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(367, 29);
            txtBoxTo.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(656, 45);
            label5.Name = "label5";
            label5.Size = new Size(30, 22);
            label5.TabIndex = 14;
            label5.Text = "To";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFrom.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(714, 83);
            txtBoxFrom.Margin = new Padding(3, 4, 3, 4);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(367, 29);
            txtBoxFrom.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(656, 85);
            label6.Name = "label6";
            label6.Size = new Size(52, 22);
            label6.TabIndex = 16;
            label6.Text = "From";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(656, 153);
            txtBoxDescription.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(425, 97);
            txtBoxDescription.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(656, 127);
            label7.Name = "label7";
            label7.Size = new Size(100, 22);
            label7.TabIndex = 18;
            label7.Text = "Description";
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(12, 170);
            flowLayoutPanelTags.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(561, 80);
            flowLayoutPanelTags.TabIndex = 21;
            // 
            // LettersAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1096, 611);
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