namespace LISTVIEW
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox1ID = new System.Windows.Forms.TextBox();
            this.txtBox2PRODUTO = new System.Windows.Forms.TextBox();
            this.txtBox3Quantidade = new System.Windows.Forms.TextBox();
            this.txtBox4Preco = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnObter = new System.Windows.Forms.Button();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tratativa com exemplo utilizando LISTVIEW";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_Produto,
            this.colQuantidade,
            this.colPreco});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 182);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRODUTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "QUANTIDADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "PREÇO";
            // 
            // txtBox1ID
            // 
            this.txtBox1ID.Location = new System.Drawing.Point(41, 308);
            this.txtBox1ID.Name = "txtBox1ID";
            this.txtBox1ID.Size = new System.Drawing.Size(54, 20);
            this.txtBox1ID.TabIndex = 6;
            // 
            // txtBox2PRODUTO
            // 
            this.txtBox2PRODUTO.Location = new System.Drawing.Point(190, 308);
            this.txtBox2PRODUTO.Name = "txtBox2PRODUTO";
            this.txtBox2PRODUTO.Size = new System.Drawing.Size(207, 20);
            this.txtBox2PRODUTO.TabIndex = 7;
            // 
            // txtBox3Quantidade
            // 
            this.txtBox3Quantidade.Location = new System.Drawing.Point(452, 307);
            this.txtBox3Quantidade.Name = "txtBox3Quantidade";
            this.txtBox3Quantidade.Size = new System.Drawing.Size(100, 20);
            this.txtBox3Quantidade.TabIndex = 8;
            // 
            // txtBox4Preco
            // 
            this.txtBox4Preco.Location = new System.Drawing.Point(601, 307);
            this.txtBox4Preco.Name = "txtBox4Preco";
            this.txtBox4Preco.Size = new System.Drawing.Size(100, 20);
            this.txtBox4Preco.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(38, 361);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(190, 360);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnObter
            // 
            this.btnObter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObter.Location = new System.Drawing.Point(335, 359);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(75, 23);
            this.btnObter.TabIndex = 12;
            this.btnObter.Text = "OBTER";
            this.btnObter.UseVisualStyleBackColor = true;
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            // 
            // col_Produto
            // 
            this.col_Produto.Text = "PRODUTO";
            // 
            // colQuantidade
            // 
            this.colQuantidade.Text = "QUANTIDADE";
            // 
            // colPreco
            // 
            this.colPreco.Text = "PRECO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtBox4Preco);
            this.Controls.Add(this.txtBox3Quantidade);
            this.Controls.Add(this.txtBox2PRODUTO);
            this.Controls.Add(this.txtBox1ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LISTVIEW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_Produto;
        private System.Windows.Forms.ColumnHeader colQuantidade;
        private System.Windows.Forms.ColumnHeader colPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox1ID;
        private System.Windows.Forms.TextBox txtBox2PRODUTO;
        private System.Windows.Forms.TextBox txtBox3Quantidade;
        private System.Windows.Forms.TextBox txtBox4Preco;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnObter;
    }
}

