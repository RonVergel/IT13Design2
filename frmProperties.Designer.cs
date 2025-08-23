namespace WindowsFormsApp4
{
    partial class frmProperties
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
            this.pID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBedrooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBathrooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pmlsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Properties";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(16, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 28);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pID,
            this.pAddress,
            this.pPrice,
            this.pBedrooms,
            this.pBathrooms,
            this.Status1,
            this.pmlsNumber,
            this.cEdit});
            this.dataGridView1.Location = new System.Drawing.Point(16, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1399, 544);
            this.dataGridView1.TabIndex = 13;
            // 
            // pID
            // 
            this.pID.HeaderText = "Property ID";
            this.pID.MinimumWidth = 6;
            this.pID.Name = "pID";
            this.pID.Width = 125;
            // 
            // pAddress
            // 
            this.pAddress.HeaderText = "Address";
            this.pAddress.MinimumWidth = 6;
            this.pAddress.Name = "pAddress";
            this.pAddress.Width = 125;
            // 
            // pPrice
            // 
            this.pPrice.HeaderText = "Property Price";
            this.pPrice.MinimumWidth = 6;
            this.pPrice.Name = "pPrice";
            this.pPrice.Width = 125;
            // 
            // pBedrooms
            // 
            this.pBedrooms.HeaderText = "Bedrooms";
            this.pBedrooms.MinimumWidth = 6;
            this.pBedrooms.Name = "pBedrooms";
            this.pBedrooms.Width = 125;
            // 
            // pBathrooms
            // 
            this.pBathrooms.HeaderText = "Bathrooms";
            this.pBathrooms.MinimumWidth = 6;
            this.pBathrooms.Name = "pBathrooms";
            this.pBathrooms.Width = 125;
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
            // pmlsNumber
            // 
            this.pmlsNumber.HeaderText = "mls Number";
            this.pmlsNumber.MinimumWidth = 6;
            this.pmlsNumber.Name = "pmlsNumber";
            this.pmlsNumber.Width = 125;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1224, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 70);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Properties";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 779);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProperties";
            this.Text = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBedrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBathrooms;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmlsNumber;
        private System.Windows.Forms.DataGridViewButtonColumn cEdit;
        private System.Windows.Forms.Button button1;
    }
}