namespace projekt_systemu_rejestracji
{
    partial class Historia_pobytow
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
            this.Id_mieszkanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_pokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_zameld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_wymeld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_mieszkanca,
            this.nr_pokoju,
            this.data_zameld,
            this.Data_wymeld});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(454, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_mieszkanca
            // 
            this.Id_mieszkanca.HeaderText = "Id mieszkańca";
            this.Id_mieszkanca.Name = "Id_mieszkanca";
            this.Id_mieszkanca.ReadOnly = true;
            // 
            // nr_pokoju
            // 
            this.nr_pokoju.HeaderText = "Nr pokoju";
            this.nr_pokoju.Name = "nr_pokoju";
            this.nr_pokoju.ReadOnly = true;
            // 
            // data_zameld
            // 
            this.data_zameld.HeaderText = "Data zameldowania";
            this.data_zameld.Name = "data_zameld";
            this.data_zameld.ReadOnly = true;
            // 
            // Data_wymeld
            // 
            this.Data_wymeld.HeaderText = "Data wymeldowania";
            this.Data_wymeld.Name = "Data_wymeld";
            this.Data_wymeld.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIA POBYTÓW";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(326, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Historia_pobytow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Historia_pobytow";
            this.Text = "Historia_pobytow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id_mieszkanca;
        private DataGridViewTextBoxColumn nr_pokoju;
        private DataGridViewTextBoxColumn data_zameld;
        private DataGridViewTextBoxColumn Data_wymeld;
        private Label label1;
        private Button button1;
    }
}