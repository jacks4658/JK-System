using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class PainelCadastroVisitante : Form
    {

        SqlDataReader dr;
        public PainelCadastroVisitante()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void bntEnviarDb_Click(object sender, EventArgs e)
        {

        }

        private void bntEnviarVisitante_Click(object sender, EventArgs e)
        {
            
            if(txtrg.Text== "")
            {
                MessageBox.Show("O RG É UM CAMPO OBRIGATORIO");
                txtrg.Focus();
                return;
            }
            
            
            
            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");

            //inserção sql

            String Sql = "INSERT INTO CADASTRO_VISITANTE(ID,NOME,RG,PLACA,MODELO,COR,MORADOR,RUA,QUADRA,APARTAMENTO)VALUES(@ID,@NOME,@RG,@PLACA,@MODELO,@COR,@MORADOR,@RUA,@QUADRA,@APARTAMENTO)";

            //Random numeroID = new Random();
            //  numeroID.Next();

            try
            {



                Random numeroID = new Random();
                numeroID.Next();



                SqlCommand c = new SqlCommand(Sql, conexao);
                c.Parameters.Add(new SqlParameter("@ID", numeroID.Next()));

                c.Parameters.Add(new SqlParameter("@NOME", this.txtnome.Text));
                txtnome.Clear();
                c.Parameters.Add(new SqlParameter("@RG", this.txtrg.Text));
                txtrg.Clear();
                c.Parameters.Add(new SqlParameter("@PLACA", this.txtendereco.Text));
                txtendereco.Clear();
                c.Parameters.Add(new SqlParameter("@MODELO", this.txtdescricao.Text));
                txtdescricao.Clear();
                c.Parameters.Add(new SqlParameter("@COR", this.txtcor.Text));
                txtcor.Clear();
                c.Parameters.Add(new SqlParameter("@MORADOR", this.txtNomeVisitado.Text));
                txtNomeVisitado.Clear();
                c.Parameters.Add(new SqlParameter("@RUA", this.txtObersevacao.Text));
                txtObersevacao.Clear();
                c.Parameters.Add(new SqlParameter("@QUADRA", this.textQuadraVisitado.Text));
                textQuadraVisitado.Clear();
                c.Parameters.Add(new SqlParameter("@APARTAMENTO", this.textBox1.Text));
                textBox1.Clear();



                txtcor.Clear();


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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PainelCadastroVisitante_Load(object sender, EventArgs e)
        { 

    





    }

        private void txtnome_KeyDown(object sender, KeyEventArgs e)
        {

        

                if (e.KeyCode == Keys.Enter)
                {
                    txtNomeVisitado.Focus();

                }
            }
         


            

        private void txtrg_KeyDown(object sender, KeyEventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");
            //inserção sql




            SqlCommand c = new SqlCommand("SELECT * FROM [dbo].[CADASTROvisit_Log] WHERE RG= @RG", conexao);

            c.Parameters.AddWithValue("@RG", txtrg.Text);
            conexao.Open();
            dr = c.ExecuteReader();

            while (dr.Read())
            {
                txtnome.Text = (string)dr["nome"];
                txtrg.Text = (string)dr["rg"];
                txtcor.Text = (string)dr["cor"];
                txtendereco.Text = (string)dr["placa"];
                txtdescricao.Text = (string)dr["modelo"];
                txtObersevacao.Text = (string)dr["rua"];


                if (e.KeyCode == Keys.Enter)
                {
                    txtNomeVisitado.Focus();

                }
            }

        }

        private void txtendereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcor.Focus();

            }
        }

        private void txtcor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdescricao.Focus();

            }
        }

        private void txtdescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNomeVisitado.Focus();

            }
        }

        private void txtNomeVisitado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtObersevacao.Focus();

            }
        }

        private void txtRuaVisitado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textQuadraVisitado.Focus();

            }
        }

        private void textQuadraVisitado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    bntEnviarVisitante.PerformClick();
                    txtnome.Focus();

                }
            }

        }

        private void PainelCadastroVisitante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void BarraTituloViitante_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}




