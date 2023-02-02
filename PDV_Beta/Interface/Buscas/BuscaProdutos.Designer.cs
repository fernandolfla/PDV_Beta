namespace PDV_Beta.Interface
{
    partial class BuscaProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataListaProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaProdutos
            // 
            this.dataListaProdutos.AllowUserToAddRows = false;
            this.dataListaProdutos.AllowUserToDeleteRows = false;
            this.dataListaProdutos.AllowUserToResizeColumns = false;
            this.dataListaProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataListaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Estoque,
            this.Custo,
            this.Preco1,
            this.Preco2,
            this.Preco3});
            this.dataListaProdutos.Location = new System.Drawing.Point(12, 104);
            this.dataListaProdutos.Name = "dataListaProdutos";
            this.dataListaProdutos.ReadOnly = true;
            this.dataListaProdutos.Size = new System.Drawing.Size(760, 240);
            this.dataListaProdutos.TabIndex = 9;
            this.dataListaProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduto_CellClick);
            this.dataListaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaProdutos_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 207;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 50;
            // 
            // Custo
            // 
            this.Custo.HeaderText = "Custo";
            this.Custo.Name = "Custo";
            this.Custo.ReadOnly = true;
            this.Custo.Width = 90;
            // 
            // Preco1
            // 
            this.Preco1.HeaderText = "Preco1";
            this.Preco1.Name = "Preco1";
            this.Preco1.ReadOnly = true;
            this.Preco1.Width = 90;
            // 
            // Preco2
            // 
            this.Preco2.HeaderText = "Preco2";
            this.Preco2.Name = "Preco2";
            this.Preco2.ReadOnly = true;
            this.Preco2.Width = 90;
            // 
            // Preco3
            // 
            this.Preco3.HeaderText = "Preco3";
            this.Preco3.Name = "Preco3";
            this.Preco3.ReadOnly = true;
            this.Preco3.Width = 90;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(263, 19);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(345, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 19);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // BuscaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.dataListaProdutos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "BuscaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscaProdutos";
            this.Load += new System.EventHandler(this.BuscaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaProdutos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco3;
    }
}