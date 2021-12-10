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
    public partial class Chave : Form
    {
        public Chave()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                Refresh();

                MessageBox.Show("DADOS ENVIADO");
                conexao.Close();

              
            }
            catch (SqlException ex)
            {
                MessageBox.Show("OCORREU UM ERRO:" + ex);

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtAgente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMorador.Focus();

            }
        }

        private void txtMorador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtChave.Focus();

            }
        }

        private void txtChave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTorre.Focus();

            }
        }

        private void txtTorre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtObservacao.Focus();

            }
        }
    }
}
