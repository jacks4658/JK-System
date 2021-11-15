
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
    public partial class Morador : Form
    {
        public Morador()
        {
            InitializeComponent();
        }

        private void bntEnviarMoador_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Server=DESKTOP-C6NHVB9\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Banco;");

            //inserção sql

            String Sql = "INSERT INTO MORADOR(MORADOR,BLOCO_AP,PERFIL,TELEFONE_01,TELEFONE_02,VAGA,LIBERADOS,VEICULOS)VALUES(@MORADOR,@BLOCO_AP,@PERFIL,@TELEFONE_01,@TELEFONE_02,@VAGA,@LIBERADOS,@VEICULOS)";

           

            try
            {

                Random numeroID = new Random();
                numeroID.Next();



                SqlCommand c = new SqlCommand(Sql, conexao);
              
                c.Parameters.Add(new SqlParameter("@MORADOR", this.txtmorador.Text));
                txtmorador.Clear();
                c.Parameters.Add(new SqlParameter("@VAGA", this.txtVaga.Text));
                txtVaga.Clear();
                c.Parameters.Add(new SqlParameter("@TELEFONE_01", this.textTel1.Text));
                textTel1.Clear();
                c.Parameters.Add(new SqlParameter("@LIBERADOS", this.txtNomeLiberado.Text));
                txtNomeLiberado.Clear();
                c.Parameters.Add(new SqlParameter("@TELEFONE_02", this.txtTel2.Text));
                txtTel2.Clear();
                c.Parameters.Add(new SqlParameter("@BLOCO_AP", this.textAp.Text));
                textAp.Clear();
                c.Parameters.Add(new SqlParameter("@PERFIL", this.textPerfil.Text));
                textPerfil.Clear();
                c.Parameters.Add(new SqlParameter("@VEICULOS", this.textVeiculos.Text));
                textVeiculos.Clear();



                txtTel2.Clear();


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

        private void btnCancelarVisitante_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

