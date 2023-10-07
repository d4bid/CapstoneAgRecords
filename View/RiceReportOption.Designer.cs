namespace AgRecords.View
{
    partial class RiceReportOption
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
            label1 = new Label();
            btnPlanting = new Button();
            btnStanding = new Button();
            btnHarvesting = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Select a category";
            // 
            // btnPlanting
            // 
            btnPlanting.BackColor = Color.FromArgb(43, 121, 223);
            btnPlanting.FlatAppearance.BorderSize = 0;
            btnPlanting.FlatStyle = FlatStyle.Flat;
            btnPlanting.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlanting.ForeColor = Color.White;
            btnPlanting.Location = new Point(65, 108);
            btnPlanting.Name = "btnPlanting";
            btnPlanting.Size = new Size(189, 40);
            btnPlanting.TabIndex = 1;
            btnPlanting.Text = "Planting";
            btnPlanting.UseVisualStyleBackColor = false;
            // 
            // btnStanding
            // 
            btnStanding.BackColor = Color.FromArgb(43, 121, 223);
            btnStanding.FlatAppearance.BorderSize = 0;
            btnStanding.FlatStyle = FlatStyle.Flat;
            btnStanding.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStanding.ForeColor = Color.White;
            btnStanding.Location = new Point(65, 166);
            btnStanding.Name = "btnStanding";
            btnStanding.Size = new Size(189, 40);
            btnStanding.TabIndex = 2;
            btnStanding.Text = "Standing";
            btnStanding.UseVisualStyleBackColor = false;
            // 
            // btnHarvesting
            // 
            btnHarvesting.BackColor = Color.FromArgb(43, 121, 223);
            btnHarvesting.FlatAppearance.BorderSize = 0;
            btnHarvesting.FlatStyle = FlatStyle.Flat;
            btnHarvesting.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHarvesting.ForeColor = Color.White;
            btnHarvesting.Location = new Point(65, 221);
            btnHarvesting.Name = "btnHarvesting";
            btnHarvesting.Size = new Size(189, 40);
            btnHarvesting.TabIndex = 3;
            btnHarvesting.Text = "Harvesting";
            btnHarvesting.UseVisualStyleBackColor = false;
            // 
            // RiceReportOption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 319);
            Controls.Add(btnHarvesting);
            Controls.Add(btnStanding);
            Controls.Add(btnPlanting);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "RiceReportOption";
            ShowIcon = false;
            Text = "Rice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPlanting;
        private Button btnStanding;
        private Button btnHarvesting;
    }
}