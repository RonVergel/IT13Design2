namespace WindowsFormsApp4
{
    partial class Contacts
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastContacted1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contacts";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(16, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 28);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.Status1,
            this.Email1,
            this.Phone1,
            this.LastContacted1,
            this.cEdit});
            this.dataGridView1.Location = new System.Drawing.Point(16, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 489);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(883, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Contacts";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.MinimumWidth = 6;
            this.Name1.Name = "Name1";
            this.Name1.Width = 125;
            // 
            // Status1
            // 
            this.Status1.HeaderText = "Status";
            this.Status1.Items.AddRange(new object[] {
            "Lead",
            "Offered",
            "Client"});
            this.Status1.MinimumWidth = 6;
            this.Status1.Name = "Status1";
            this.Status1.Width = 125;
            // 
            // Email1
            // 
            this.Email1.HeaderText = "Email";
            this.Email1.MinimumWidth = 6;
            this.Email1.Name = "Email1";
            this.Email1.Width = 125;
            // 
            // Phone1
            // 
            this.Phone1.HeaderText = "Phone";
            this.Phone1.MinimumWidth = 6;
            this.Phone1.Name = "Phone1";
            this.Phone1.Width = 125;
            // 
            // LastContacted1
            // 
            this.LastContacted1.HeaderText = "Last Contacted";
            this.LastContacted1.MinimumWidth = 6;
            this.LastContacted1.Name = "LastContacted1";
            this.LastContacted1.Width = 125;
            // 
            // cEdit
            // 
            this.cEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cEdit.HeaderText = "Edit";
            this.cEdit.MinimumWidth = 6;
            this.cEdit.Name = "cEdit";
            this.cEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cEdit.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 693);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastContacted1;
        private System.Windows.Forms.DataGridViewButtonColumn cEdit;
    }
}