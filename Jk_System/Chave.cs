using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class Chave : Form
    {
        public Chave()
        {
            InitializeComponent();
        }

        private void bntEnviarDb_Click(object sender, EventArgs e)
        {

            //String de conexao
            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");

            //inserção sql

            String Sql = "INSERT INTO CHAVES(ID,ENTREGUE,RETIRADO,CHAVES,TORRE,OBSERVACAO)VALUES(@ID,@ENTREGUE,@RETIRADO,@CHAVES,@TORRE,@OBSERVACAO)";

            Random numeroID = new Random();
            numeroID.Next();

            try
            {



                //SetResponse set = await client.SetAsync(@"Entregas/" + enco.ID, enco);

                SqlCommand c = new SqlCommand(Sql, conexao);
                c.Parameters.Add(new SqlParameter("@ID", numeroID.Next()));

                c.Parameters.Add(new SqlParameter("@ENTREGUE", this.txtAgente.Text));
                txtAgente.Clear();
                c.Parameters.Add(new SqlParameter("@RETIRADO", this.txtMorador.Text));
                txtMorador.Clear();
                c.Parameters.Add(new SqlParameter("@TORRE", this.txtTorre.Text));
                txtTorre.Clear();
                c.Parameters.Add(new SqlParameter("@OBSERVACAO", this.txtObservacao.Text));
                txtObservacao.Clear();
                c.Parameters.Add(new SqlParameter("@CHAVES", this.txtChave.Text));

                txtChave.Clear();


                //abrir conexao

                conexao.Open();

                //executar sql
                c.ExecuteNonQuery();

                MessageBox.Show("DADOS ENVIADO");
                conexao.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("OCORREU UM ERRO:" + ex);

            }
        }
    }
}
