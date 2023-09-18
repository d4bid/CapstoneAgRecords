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
            SuspendLayout();
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Location = new Point(11, 130);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(491, 60);
            flowLayoutPanelTags.TabIndex = 40;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(575, 117);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(372, 74);
            txtBoxDescription.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(575, 97);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 38;
            label7.Text = "Description";
            // 
            // txtBoxFrom
            // 
            txtBoxFrom.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFrom.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFrom.Location = new Point(626, 64);
            txtBoxFrom.Name = "txtBoxFrom";
            txtBoxFrom.Size = new Size(321, 25);
            txtBoxFrom.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(575, 66);
            label6.Name = "label6";
            label6.Size = new Size(43, 18);
            label6.TabIndex = 36;
            label6.Text = "From";
            // 
            // txtBoxTo
            // 
            txtBoxTo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTo.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTo.Location = new Point(626, 33);
            txtBoxTo.Name = "txtBoxTo";
            txtBoxTo.Size = new Size(321, 25);
            txtBoxTo.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(575, 36);
            label5.Name = "label5";
            label5.Size = new Size(26, 18);
            label5.TabIndex = 34;
            label5.Text = "To";
            // 
            // txtBoxTags
            // 
            txtBoxTags.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTags.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTags.Location = new Point(102, 96);
            txtBoxTags.Margin = new Padding(3, 2, 3, 2);
            txtBoxTags.Name = "txtBoxTags";
            txtBoxTags.Size = new Size(401, 25);
            txtBoxTags.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 98);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
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
            btnSave.Location = new Point(705, 414);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 33);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(829, 414);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 33);
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
            btnRemove.Location = new Point(135, 414);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(118, 33);
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
            btnBrowse.Location = new Point(11, 414);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(118, 33);
            btnBrowse.TabIndex = 28;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            // 
            // listViewLetters
            // 
            listViewLetters.ImeMode = ImeMode.Disable;
            listViewLetters.LargeImageList = imageList1;
            listViewLetters.Location = new Point(11, 206);
            listViewLetters.Name = "listViewLetters";
            listViewLetters.Size = new Size(936, 200);
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
            comboBoxType.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Incoming", "Outgoing", "Internal", "External" });
            comboBoxType.Location = new Point(102, 66);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(401, 25);
            comboBoxType.TabIndex = 26;
            // 
            // txtBoxTitle
            // 
            txtBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBoxTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxTitle.Location = new Point(102, 33);
            txtBoxTitle.Name = "txtBoxTitle";
            txtBoxTitle.Size = new Size(401, 25);
            txtBoxTitle.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 65);
            label1.Name = "label1";
            label1.Size = new Size(42, 18);
            label1.TabIndex = 24;
            label1.Text = "Type";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(11, 35);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(38, 18);
            labelTitle.TabIndex = 23;
            labelTitle.Text = "Title";
            // 
            // labelLetterId
            // 
            labelLetterId.AutoSize = true;
            labelLetterId.Font = new Font("Roboto", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelLetterId.Location = new Point(11, 11);
            labelLetterId.Name = "labelLetterId";
            labelLetterId.Size = new Size(65, 18);
            labelLetterId.TabIndex = 22;
            labelLetterId.Text = "Letter ID";
            // 
            // LettersEditView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "LettersEditView";
            Text = "LettersEditView";
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
    }
}