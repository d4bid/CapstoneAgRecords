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
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            btnBrowse = new Button();
            btnRemove = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            txtBoxTitle.Size = new Size(114, 27);
            txtBoxTitle.TabIndex = 3;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Ingoing", "Outgoing" });
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
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(16, 322);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(886, 265);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.KeyDown += listView1_KeyDown;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(64, 64);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(626, 255);
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
            btnRemove.Location = new Point(768, 255);
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
            btnCancel.Location = new Point(768, 597);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 59);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(626, 597);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 59);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(135, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 27);
            textBox1.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(135, 214);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 28);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 3);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton1.IconColor = Color.FromArgb(43, 121, 223);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(63, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(29, 23);
            iconButton1.TabIndex = 1;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(iconButton2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(242, 213);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 28);
            panel2.TabIndex = 13;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton2.IconColor = Color.FromArgb(43, 121, 223);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(63, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(29, 23);
            iconButton2.TabIndex = 1;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 3);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // LettersAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 687);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnRemove);
            Controls.Add(btnBrowse);
            Controls.Add(listView1);
            Controls.Add(comboBoxType);
            Controls.Add(txtBoxTitle);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(labelLetterId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LettersAddView";
            Text = "LettersAddView";
            Load += LettersAddView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ListView listView1;
        private Button btnBrowse;
        private Button btnRemove;
        private Button btnCancel;
        private ImageList imageList1;
        private Button btnSave;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label4;
    }
}