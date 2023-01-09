namespace projekt_systemu_rejestracji
{
    partial class Mieszkancy
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_rezerwacji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_klienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nr_pokoju = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista gości";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(417, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rezerwacji,
            this.id_klienta,
            this.imie,
            this.Nazwisko,
            this.Nr_pokoju});
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(552, 150);
            this.dataGridView1.TabIndex = 4;
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
            // imie
            // 
            this.imie.HeaderText = "Imię";
            this.imie.Name = "imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // Nr_pokoju
            // 
            this.Nr_pokoju.HeaderText = "Nr pokoju";
            this.Nr_pokoju.Name = "Nr_pokoju";
            // 
            // Mieszkancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Mieszkancy";
            this.Text = "Mieszkancy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_rezerwacji;
        private DataGridViewTextBoxColumn id_klienta;
        private DataGridViewTextBoxColumn imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn Nr_pokoju;
    }
}