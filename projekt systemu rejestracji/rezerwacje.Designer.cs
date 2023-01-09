namespace projekt_systemu_rejestracji
{
    partial class rezerwacje
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
            this.id_rezerwacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_klienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_meldunku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_wymeldowania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_pokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzaj_pokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rezerwacji,
            this.id_klienta,
            this.data_meldunku,
            this.data_wymeldowania,
            this.nr_pokoju,
            this.rodzaj_pokoju});
            this.dataGridView1.Location = new System.Drawing.Point(0, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_rezerwacji
            // 
            this.id_rezerwacji.HeaderText = "Id rezerwacji";
            this.id_rezerwacji.Name = "id_rezerwacji";
            this.id_rezerwacji.ReadOnly = true;
            // 
            // id_klienta
            // 
            this.id_klienta.HeaderText = "Id klienta";
            this.id_klienta.Name = "id_klienta";
            this.id_klienta.ReadOnly = true;
            // 
            // data_meldunku
            // 
            this.data_meldunku.HeaderText = "Data meldunku";
            this.data_meldunku.Name = "data_meldunku";
            // 
            // data_wymeldowania
            // 
            this.data_wymeldowania.HeaderText = "Data wymeldowania";
            this.data_wymeldowania.Name = "data_wymeldowania";
            // 
            // nr_pokoju
            // 
            this.nr_pokoju.HeaderText = "Nr_pokoju";
            this.nr_pokoju.Name = "nr_pokoju";
            // 
            // rodzaj_pokoju
            // 
            this.rodzaj_pokoju.HeaderText = "Podzaj pokoju";
            this.rodzaj_pokoju.Name = "rodzaj_pokoju";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezerwacje lista";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(494, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rezerwacje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "rezerwacje";
            this.Text = "rezerwacje";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_rezerwacji;
        private DataGridViewTextBoxColumn id_klienta;
        private DataGridViewTextBoxColumn data_meldunku;
        private DataGridViewTextBoxColumn data_wymeldowania;
        private DataGridViewTextBoxColumn nr_pokoju;
        private DataGridViewTextBoxColumn rodzaj_pokoju;
        private Label label1;
        private Button button1;
    }
}