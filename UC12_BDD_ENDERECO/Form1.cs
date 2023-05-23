using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_BDD_ENDERECO
{
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public Form1()
        {
            InitializeComponent();

           
            servidor = "Server=localhost;Database=pessoa_endereco;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {//insere endereço 
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_endereco(logradouro, bairro, estado, cidade, uf) VALUES ('" + textBoxLOG.Text + "', '" + textBoxBAIRRO.Text + "', '" + textBoxCIDADE.Text + "', '" + comboBoxESTADO.Text + "', '" + comboBoxUF.Text + "');";
                comando.ExecuteNonQuery();
                MessageBox.Show("cadastrado");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }

            //pegar o ultimo id de endereço na tbl 


            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_endereco;";
                MySqlDataReader readerID = comando.ExecuteReader();
                string ultimoID;
                if (readerID.Read())
                {
                   // ultimoID = readerID.GetString(0);  
                   ultimoID = 
                }
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
