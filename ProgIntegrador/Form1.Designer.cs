namespace ProgIntegrador
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
            this.components = new System.ComponentModel.Container();
            this.TB_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.TB_Desc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_XML = new System.Windows.Forms.Button();
            this.BTN_Adicionar = new System.Windows.Forms.Button();
            this.TB_Valor = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progintegraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progintegraDataSet = new ProgIntegrador.progintegraDataSet();
            this.produtosTableAdapter = new ProgIntegrador.progintegraDataSetTableAdapters.produtosTableAdapter();
            this.TB_Quant = new System.Windows.Forms.TextBox();
            this.lst_contatos = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progintegraDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progintegraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Nome
            // 
            this.TB_Nome.Location = new System.Drawing.Point(12, 263);
            this.TB_Nome.Name = "TB_Nome";
            this.TB_Nome.Size = new System.Drawing.Size(284, 20);
            this.TB_Nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Produto";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(99, 300);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(109, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Descrição do produto";
            // 
            // TB_Desc
            // 
            this.TB_Desc.Location = new System.Drawing.Point(12, 316);
            this.TB_Desc.Name = "TB_Desc";
            this.TB_Desc.Size = new System.Drawing.Size(284, 58);
            this.TB_Desc.TabIndex = 3;
            this.TB_Desc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade";
            // 
            // BTN_XML
            // 
            this.BTN_XML.BackColor = System.Drawing.Color.Lime;
            this.BTN_XML.Location = new System.Drawing.Point(551, 300);
            this.BTN_XML.Name = "BTN_XML";
            this.BTN_XML.Size = new System.Drawing.Size(139, 49);
            this.BTN_XML.TabIndex = 8;
            this.BTN_XML.Text = "Gerar XML";
            this.BTN_XML.UseVisualStyleBackColor = false;
            this.BTN_XML.Click += new System.EventHandler(this.BTN_XML_Click);
            // 
            // BTN_Adicionar
            // 
            this.BTN_Adicionar.Location = new System.Drawing.Point(490, 229);
            this.BTN_Adicionar.Name = "BTN_Adicionar";
            this.BTN_Adicionar.Size = new System.Drawing.Size(80, 42);
            this.BTN_Adicionar.TabIndex = 5;
            this.BTN_Adicionar.Text = "Adicionar";
            this.BTN_Adicionar.UseVisualStyleBackColor = true;
            this.BTN_Adicionar.Click += new System.EventHandler(this.BTN_Adicionar_Click);
            // 
            // TB_Valor
            // 
            this.TB_Valor.Location = new System.Drawing.Point(331, 263);
            this.TB_Valor.Name = "TB_Valor";
            this.TB_Valor.Size = new System.Drawing.Size(100, 20);
            this.TB_Valor.TabIndex = 2;
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(576, 229);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(80, 42);
            this.BTN_Clear.TabIndex = 6;
            this.BTN_Clear.Text = "Remover";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BtnRemover);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.progintegraDataSetBindingSource;
            // 
            // progintegraDataSetBindingSource
            // 
            this.progintegraDataSetBindingSource.DataSource = this.progintegraDataSet;
            this.progintegraDataSetBindingSource.Position = 0;
            // 
            // progintegraDataSet
            // 
            this.progintegraDataSet.DataSetName = "progintegraDataSet";
            this.progintegraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // TB_Quant
            // 
            this.TB_Quant.Location = new System.Drawing.Point(331, 345);
            this.TB_Quant.Name = "TB_Quant";
            this.TB_Quant.Size = new System.Drawing.Size(100, 20);
            this.TB_Quant.TabIndex = 4;
            // 
            // lst_contatos
            // 
            this.lst_contatos.HideSelection = false;
            this.lst_contatos.Location = new System.Drawing.Point(12, 12);
            this.lst_contatos.Name = "lst_contatos";
            this.lst_contatos.Size = new System.Drawing.Size(730, 202);
            this.lst_contatos.TabIndex = 9;
            this.lst_contatos.UseCompatibleStateImageBehavior = false;
            this.lst_contatos.SelectedIndexChanged += new System.EventHandler(this.lst_contatos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(754, 386);
            this.Controls.Add(this.lst_contatos);
            this.Controls.Add(this.TB_Quant);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.TB_Valor);
            this.Controls.Add(this.BTN_Adicionar);
            this.Controls.Add(this.BTN_XML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Desc);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Nome);
            this.Name = "Form1";
            this.Text = "Criador de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progintegraDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progintegraDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.RichTextBox TB_Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_XML;
        private System.Windows.Forms.Button BTN_Adicionar;
        private System.Windows.Forms.MaskedTextBox TB_Valor;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button button2;
        private progintegraDataSet progintegraDataSet;
        private System.Windows.Forms.BindingSource progintegraDataSetBindingSource;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private progintegraDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.TextBox TB_Quant;
        private System.Windows.Forms.ListView lst_contatos;
    }
}

