namespace WindowsFormsApp4
{
    partial class Deals
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOfferDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dClosing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dID,
            this.pName1,
            this.dOfferDate,
            this.dClosing,
            this.dClientID,
            this.dPropertyID,
            this.dAgent,
            this.pEdit});
            this.dataGridView1.Location = new System.Drawing.Point(16, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1332, 559);
            this.dataGridView1.TabIndex = 3;
            // 
            // dID
            // 
            this.dID.HeaderText = "Deal ID";
            this.dID.MinimumWidth = 6;
            this.dID.Name = "dID";
            this.dID.Width = 125;
            // 
            // pName1
            // 
            this.pName1.HeaderText = "Stage";
            this.pName1.MinimumWidth = 6;
            this.pName1.Name = "pName1";
            this.pName1.Width = 125;
            // 
            // dOfferDate
            // 
            this.dOfferDate.HeaderText = "Offer Date";
            this.dOfferDate.MinimumWidth = 6;
            this.dOfferDate.Name = "dOfferDate";
            this.dOfferDate.Width = 125;
            // 
            // dClosing
            // 
            this.dClosing.HeaderText = "Closing Date";
            this.dClosing.MinimumWidth = 6;
            this.dClosing.Name = "dClosing";
            this.dClosing.Width = 125;
            // 
            // dClientID
            // 
            this.dClientID.HeaderText = "Client ID";
            this.dClientID.MinimumWidth = 6;
            this.dClientID.Name = "dClientID";
            this.dClientID.Width = 125;
            // 
            // dPropertyID
            // 
            this.dPropertyID.HeaderText = "Property ID";
            this.dPropertyID.MinimumWidth = 6;
            this.dPropertyID.Name = "dPropertyID";
            this.dPropertyID.Width = 125;
            // 
            // dAgent
            // 
            this.dAgent.HeaderText = "Agent (user_id)";
            this.dAgent.MinimumWidth = 6;
            this.dAgent.Name = "dAgent";
            this.dAgent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dAgent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dAgent.Width = 125;
            // 
            // pEdit
            // 
            this.pEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pEdit.HeaderText = "Edit";
            this.pEdit.MinimumWidth = 6;
            this.pEdit.Name = "pEdit";
            this.pEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pEdit.Text = "...";
            this.pEdit.UseColumnTextForButtonValue = true;
            this.pEdit.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Deals";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(16, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 28);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1205, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Deals";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 810);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deals";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOfferDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dClosing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPropertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAgent;
        private System.Windows.Forms.DataGridViewButtonColumn pEdit;
    }
}