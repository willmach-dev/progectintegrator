using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;
using System.Xml.Linq;

namespace ProgIntegrador
{
    public partial class Form1 : Form
    {
        public string connectionString;

        public Form1()
        {
            InitializeComponent();
            //Conexão do banco aqui
            connectionString = "Data Source=GTW;Initial Catalog=progintegra;Integrated Security=True";
            //monta a list view
            lst_contatos.View = View.Details;
            lst_contatos.LabelEdit = true;
            lst_contatos.AllowColumnReorder = true;
            lst_contatos.FullRowSelect = true;
            lst_contatos.GridLines = true;

            lst_contatos.Columns.Add("ID", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Descrição", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Valor", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Quantidade", 150, HorizontalAlignment.Left);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarListView();

        }
        private void CarregarListView()
        {
            lst_contatos.Items.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM produtos";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(reader.GetOrdinal("ID"));
                    string nomeProduto = reader.GetString(reader.GetOrdinal("nome_produto"));
                    string descricaoProduto = reader.GetString(reader.GetOrdinal("descricao_produto"));
                    string valor = reader.GetString(reader.GetOrdinal("valor"));
                    string quantidade = reader.GetString(reader.GetOrdinal("quantidade"));

                    string[] row = { id.ToString(), nomeProduto, descricaoProduto, valor, quantidade };

                    var linhaListView = new ListViewItem(row);
                    lst_contatos.Items.Add(linhaListView);
                }

                reader.Close();
            }
        }

        private void BTN_XML_Click(object sender, EventArgs e)
        {
                string query = "SELECT nome_produto, descricao_produto, valor, quantidade FROM produtos";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            XElement produtos = new XElement("Produtos");
                            while (reader.Read())
                            {
                                XElement produto =
                                    new XElement("Produto",
                                        new XElement("nome", reader["nome_produto"].ToString()),
                                        new XElement("descricao", reader["descricao_produto"].ToString()),
                                        new XElement("valor", reader["valor"].ToString()),
                                        new XElement("quantidade", reader["quantidade"].ToString())
                                    );
                                produtos.Add(produto);
                            }

                            SaveFileDialog save = new SaveFileDialog();
                            save.FileName = "tb_produtos.xml";
                            save.DefaultExt = ".xml";

                            DialogResult resultado = save.ShowDialog();

                            if (resultado == DialogResult.OK)
                            {
                                using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
                                {
                                    using (StreamWriter writer = new StreamWriter(fs))
                                    {
                                        writer.Write(produtos + Environment.NewLine);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Operação cancelada");
                            con.Close();
                            }
                            con.Close();
                        }
                    }
                }
        }


        private void BTN_Limpa_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //Limpador de campos de texto
        private void LimparCampos()
        {
            // Limpar os campos de texto
            TB_Nome.Text = string.Empty;
            TB_Desc.Text = string.Empty;
            TB_Valor.Text = string.Empty;
            TB_Quant.Text = string.Empty;

            // Definir o foco para o campo TB_Nome
            TB_Nome.Focus();
        }

        private void BTN_Adicionar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "INSERT INTO produtos (nome_produto, descricao_produto, valor, quantidade) VALUES (@Nome, @Descricao, @Valor, @Quantidade)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Nome", TB_Nome.Text);
                command.Parameters.AddWithValue("@Descricao", TB_Desc.Text);
                command.Parameters.AddWithValue("@Valor", TB_Valor.Text);
                command.Parameters.AddWithValue("@Quantidade", TB_Quant.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Inseriu esse dado com sucesso!");
                con.Close();
                CarregarListView();
                LimparCampos();

            }
        }

        private void BtnRemover(object sender, EventArgs e)
        {
            if (lst_contatos.SelectedItems.Count > 0)
            {
                var selectedItem = lst_contatos.SelectedItems[0];
                string id = selectedItem.SubItems[0].Text; // Supondo que o ID esteja na primeira coluna (índice 0)

                // Excluir o item do banco de dados
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=GTW;Initial Catalog=progintegra;Integrated Security=True"))
                    {
                        con.Open();

                        string query = "DELETE FROM produtos WHERE id = @id"; // Substitua 'tabela' pelo nome correto da tabela e 'id' pelo nome correto da coluna de ID
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();

                        con.Close();
                    }

                    // Remover o item do ListView
                    lst_contatos.Items.Remove(selectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lst_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lst_contatos.SelectedItems.Count > 0)
                {
                    var selectedItem = lst_contatos.SelectedItems[0];
                    string id = selectedItem.SubItems[0].Text; // Supondo que o ID esteja na primeira coluna (índice 0)

                    // Obter os valores atualizados dos campos de texto
                    string nome = TB_Nome.Text;
                    string descricao = TB_Desc.Text;
                    string valor = TB_Valor.Text;
                    string quantidade = TB_Quant.Text;

                    // Atualizar o item no banco de dados
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=GTW;Initial Catalog=progintegra;Integrated Security=True"))
                        {
                            con.Open();

                            string query = "UPDATE produtos SET nome_produto = @nome, descricao_produto = @descricao, valor = @valor, quantidade = @quantidade WHERE id = @id"; // Ajuste o nome da tabela e os nomes das colunas conforme necessário
                            SqlCommand command = new SqlCommand(query, con);
                            command.Parameters.AddWithValue("@nome", nome);
                            command.Parameters.AddWithValue("@descricao", descricao);
                            command.Parameters.AddWithValue("@valor", valor);
                            command.Parameters.AddWithValue("@quantidade", quantidade);
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();

                            con.Close();
                        }

                        // Atualizar os valores exibidos no ListView
                        selectedItem.SubItems[1].Text = nome; // Índice 1 para o nome do produto
                        selectedItem.SubItems[2].Text = descricao; // Índice 2 para a descrição do produto
                        selectedItem.SubItems[3].Text = valor; // Índice 3 para o valor
                        selectedItem.SubItems[4].Text = quantidade; // Índice 4 para a quantidade

                        // Limpar os campos de texto após a atualização
                        TB_Nome.Text = string.Empty;
                        TB_Desc.Text = string.Empty;
                        TB_Valor.Text = string.Empty;
                        TB_Quant.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

    }
}