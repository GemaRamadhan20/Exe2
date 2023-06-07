namespace Exe2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pemesanan_bajuDataSet = new Exe2.Pemesanan_bajuDataSet();
            this.produkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkTableAdapter = new Exe2.Pemesanan_bajuDataSetTableAdapters.ProdukTableAdapter();
            this.iDProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanan_bajuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdukDataGridViewTextBoxColumn,
            this.namaProdukDataGridViewTextBoxColumn,
            this.hargaProdukDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(158, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // pemesanan_bajuDataSet
            // 
            this.pemesanan_bajuDataSet.DataSetName = "Pemesanan_bajuDataSet";
            this.pemesanan_bajuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produkBindingSource
            // 
            this.produkBindingSource.DataMember = "Produk";
            this.produkBindingSource.DataSource = this.pemesanan_bajuDataSet;
            // 
            // produkTableAdapter
            // 
            this.produkTableAdapter.ClearBeforeFill = true;
            // 
            // iDProdukDataGridViewTextBoxColumn
            // 
            this.iDProdukDataGridViewTextBoxColumn.DataPropertyName = "ID_Produk";
            this.iDProdukDataGridViewTextBoxColumn.HeaderText = "ID_Produk";
            this.iDProdukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProdukDataGridViewTextBoxColumn.Name = "iDProdukDataGridViewTextBoxColumn";
            this.iDProdukDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaProdukDataGridViewTextBoxColumn
            // 
            this.namaProdukDataGridViewTextBoxColumn.DataPropertyName = "Nama_Produk";
            this.namaProdukDataGridViewTextBoxColumn.HeaderText = "Nama_Produk";
            this.namaProdukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaProdukDataGridViewTextBoxColumn.Name = "namaProdukDataGridViewTextBoxColumn";
            this.namaProdukDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaProdukDataGridViewTextBoxColumn
            // 
            this.hargaProdukDataGridViewTextBoxColumn.DataPropertyName = "Harga_Produk";
            this.hargaProdukDataGridViewTextBoxColumn.HeaderText = "Harga_Produk";
            this.hargaProdukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaProdukDataGridViewTextBoxColumn.Name = "hargaProdukDataGridViewTextBoxColumn";
            this.hargaProdukDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanan_bajuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Pemesanan_bajuDataSet pemesanan_bajuDataSet;
        private System.Windows.Forms.BindingSource produkBindingSource;
        private Pemesanan_bajuDataSetTableAdapters.ProdukTableAdapter produkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}