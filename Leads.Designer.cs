namespace WindowsFormsApp4
{
    partial class Leads
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
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Agent1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leads";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(16, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 28);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name1,
            this.lEmail,
            this.lPhone,
            this.Source1,
            this.Score1,
            this.Status1,
            this.Agent1,
            this.lEdit});
            this.dataGridView1.Location = new System.Drawing.Point(16, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 589);
            this.dataGridView1.TabIndex = 2;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.MinimumWidth = 6;
            this.Name1.Name = "Name1";
            this.Name1.Width = 125;
            // 
            // lEmail
            // 
            this.lEmail.HeaderText = "Email";
            this.lEmail.MinimumWidth = 6;
            this.lEmail.Name = "lEmail";
            this.lEmail.Width = 125;
            // 
            // lPhone
            // 
            this.lPhone.HeaderText = "Phone Number";
            this.lPhone.MinimumWidth = 6;
            this.lPhone.Name = "lPhone";
            this.lPhone.Width = 125;
            // 
            // Source1
            // 
            this.Source1.HeaderText = "Source";
            this.Source1.MinimumWidth = 6;
            this.Source1.Name = "Source1";
            this.Source1.Width = 125;
            // 
            // Score1
            // 
            this.Score1.HeaderText = "Score";
            this.Score1.MinimumWidth = 6;
            this.Score1.Name = "Score1";
            this.Score1.Width = 125;
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
            // Agent1
            // 
            this.Agent1.HeaderText = "Agent";
            this.Agent1.MinimumWidth = 6;
            this.Agent1.Name = "Agent1";
            this.Agent1.Width = 125;
            // 
            // lEdit
            // 
            this.lEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lEdit.HeaderText = "Edit";
            this.lEdit.MinimumWidth = 6;
            this.lEdit.Name = "lEdit";
            this.lEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lEdit.Text = "...";
            this.lEdit.UseColumnTextForButtonValue = true;
            this.lEdit.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1225, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Leads";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Leads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leads";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn lEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn lPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agent1;
        private System.Windows.Forms.DataGridViewButtonColumn lEdit;
    }
}