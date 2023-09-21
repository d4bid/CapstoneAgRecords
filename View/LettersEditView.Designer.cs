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
            flowLayoutPanelTags = new FlowLayoutPanel();
            txtBoxDescription = new TextBox();
            label7 = new Label();
            txtBoxFrom = new TextBox();
            label6 = new Label();
            txtBoxTo = new TextBox();
            label5 = new Label();
            txtBoxTags = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            btnRemove = new Button();
            btnBrowse = new Button();
            listViewLetters = new ListView();
            imageList1 = new ImageList(components);
            comboBoxType = new ComboBox();
            txtBoxTitle = new TextBox();
            label1 = new Label();
            labelTitle = new Label();
            labelLetterId = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(13, 173);
            flowLayoutPanelTags.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(561, 80);
            flowLayoutPanelTags.TabIndex = 40;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(657, 156);
            txtBoxDescription.Margin = new Padding(3, 4, 3, 4);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(425, 97);
            txtBoxDescription.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(657, 129);
            label7.Name = "label7";
            label7.Size = new Size(100, 22);
            label7.TabIndex = 38;
            label7.Text = "Description";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFrom.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(715, 85);
            txtBoxFrom.Margin = new Padding(3, 4, 3, 4);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(367, 28);
            txtBoxFrom.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(657, 88);
            label6.Name = "label6";
            label6.Size = new Size(51, 22);
            label6.TabIndex = 36;
            label6.Text = "From";
            // 
            // txtBoxTo
            // 
            txtBoxTo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTo.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(715, 44);
            txtBoxTo.Margin = new Padding(3, 4, 3, 4);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(367, 28);
            txtBoxTo.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(657, 48);
            label5.Name = "label5";
            label5.Size = new Size(32, 22);
            label5.TabIndex = 34;
            label5.Text = "To";
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTags.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(117, 128);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(458, 28);
            txtBoxTags.TabIndex = 33;
            txtBoxTags.KeyDown += txtBoxTags_KeyDown;
            txtBoxTags.KeyPress += txtBoxTags_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 131);
            label2.Name = "label2";
            label2.Size = new Size(51, 22);
            label2.TabIndex = 32;
            label2.Text = "Tags";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(806, 552);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 44);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(947, 552);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 44);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(43, 121, 223);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(154, 552);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(135, 44);
            btnRemove.TabIndex = 29;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(43, 121, 223);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(13, 552);
            btnBrowse.Margin = new Padding(3, 4, 3, 4);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(135, 44);
            btnBrowse.TabIndex = 28;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // listViewLetters
            // 
            listViewLetters.ImeMode = ImeMode.Disable;
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(13, 275);
            listViewLetters.Margin = new Padding(3, 4, 3, 4);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(1069, 265);
            listViewLetters.TabIndex = 27;
            listViewLetters.UseCompatibleStateImageBehavior = false;
            listViewLetters.KeyDown += listViewLetters_KeyDown;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(64, 64);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal", "External" });
            comboBoxType.Location = new Point(117, 88);
            comboBoxType.Margin = new Padding(3, 4, 3, 4);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(458, 30);
            comboBoxType.TabIndex = 26;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitle.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(117, 44);
            txtBoxTitle.Margin = new Padding(3, 4, 3, 4);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(458, 28);
            txtBoxTitle.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 22);
            label1.TabIndex = 24;
            label1.Text = "Type";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(13, 47);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(45, 22);
            labelTitle.TabIndex = 23;
            labelTitle.Text = "Title";
            // 
            // labelLetterId
            // 
            labelLetterId.AutoSize = true;
            labelLetterId.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelLetterId.Location = new Point(13, 15);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(78, 22);
            labelLetterId.TabIndex = 22;
            labelLetterId.Text = "Letter ID";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // LettersEditView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "LettersEditView";
            Text = "s";
            Load += LettersEditView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTags;
        private TextBox txtBoxDescription;
        private Label label7;
        private TextBox txtBoxFrom;
        private Label label6;
        private TextBox txtBoxTo;
        private Label label5;
        private TextBox txtBoxTags;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private Button btnRemove;
        private Button btnBrowse;
        private ListView listViewLetters;
        private ComboBox comboBoxType;
        private TextBox txtBoxTitle;
        private Label label1;
        private Label labelTitle;
        private Label labelLetterId;
        private ImageList imageList1;
        private OpenFileDialog openFileDialog1;
    }
}