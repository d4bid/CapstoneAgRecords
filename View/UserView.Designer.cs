namespace AgRecords.View
{
    partial class UserView
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
            dgvUsers = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Bottom;
            dgvUsers.Location = new Point(0, 172);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(800, 278);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 61);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Name = "UserView";
            Text = "UserView";
            Load += UserView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnAdd;
    }
}