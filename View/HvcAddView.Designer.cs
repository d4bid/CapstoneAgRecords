namespace AgRecords.View
{
    partial class HvcAddView
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
            groupBox1 = new GroupBox();
            textboxYear = new TextBox();
            label7 = new Label();
            searchBox6 = new SearchBox();
            label5 = new Label();
            cmbWeek = new ComboBox();
            searchBox5 = new SearchBox();
            label4 = new Label();
            cmbMonth = new ComboBox();
            searchBox4 = new SearchBox();
            labelHvcSrId = new Label();
            label2 = new Label();
            searchBox3 = new SearchBox();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textboxYear);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(searchBox6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbWeek);
            groupBox1.Controls.Add(searchBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbMonth);
            groupBox1.Controls.Add(searchBox4);
            groupBox1.Controls.Add(labelHvcSrId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(searchBox3);
            groupBox1.Location = new Point(32, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 265);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            // 
            // textboxYear
            // 
            textboxYear.BorderStyle = BorderStyle.None;
            textboxYear.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textboxYear.Location = new Point(221, 205);
            textboxYear.Name = "textboxYear";
            textboxYear.Size = new Size(158, 24);
            textboxYear.TabIndex = 65;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 175);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 64;
            label7.Text = "Year";
            // 
            // searchBox6
            // 
            searchBox6.Location = new Point(208, 198);
            searchBox6.Name = "searchBox6";
            searchBox6.Size = new Size(177, 39);
            searchBox6.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 175);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 59;
            label5.Text = "Week";
            // 
            // cmbWeek
            // 
            cmbWeek.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeek.FlatStyle = FlatStyle.Flat;
            cmbWeek.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbWeek.FormattingEnabled = true;
            cmbWeek.Location = new Point(25, 201);
            cmbWeek.Name = "cmbWeek";
            cmbWeek.Size = new Size(159, 33);
            cmbWeek.TabIndex = 1;
            // 
            // searchBox5
            // 
            searchBox5.Location = new Point(14, 198);
            searchBox5.Name = "searchBox5";
            searchBox5.Size = new Size(174, 39);
            searchBox5.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 101);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 56;
            label4.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FlatStyle = FlatStyle.Flat;
            cmbMonth.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            cmbMonth.Location = new Point(25, 127);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(356, 33);
            cmbMonth.TabIndex = 2;
            cmbMonth.SelectedIndexChanged += cmbMonth_SelectedIndexChanged;
            // 
            // searchBox4
            // 
            searchBox4.Location = new Point(14, 124);
            searchBox4.Name = "searchBox4";
            searchBox4.Size = new Size(371, 39);
            searchBox4.TabIndex = 55;
            // 
            // labelHvcSrId
            // 
            labelHvcSrId.AutoSize = true;
            labelHvcSrId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHvcSrId.Location = new Point(25, 57);
            labelHvcSrId.Name = "labelHvcSrId";
            labelHvcSrId.Size = new Size(79, 28);
            labelHvcSrId.TabIndex = 53;
            labelHvcSrId.Text = "hvcSrId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 49;
            label2.Text = "ID";
            // 
            // searchBox3
            // 
            searchBox3.Location = new Point(14, 53);
            searchBox3.Name = "searchBox3";
            searchBox3.Size = new Size(371, 39);
            searchBox3.TabIndex = 48;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(43, 121, 223);
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 242, 252);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 242, 252);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(43, 121, 223);
            btnCancel.Location = new Point(301, 344);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(43, 121, 223);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 109, 201);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 109, 201);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(165, 344);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 28);
            label1.TabIndex = 55;
            label1.Text = "Add";
            // 
            // HvcAddView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(463, 406);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "HvcAddView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HVC Accomplishment Report";
            Load += HvcAddView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textboxYear;
        private Label label7;
        private SearchBox searchBox6;
        private Label label5;
        private ComboBox cmbWeek;
        private SearchBox searchBox5;
        private Label label4;
        private ComboBox cmbMonth;
        private SearchBox searchBox4;
        private Label labelHvcSrId;
        private Label label2;
        private SearchBox searchBox3;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
    }
}