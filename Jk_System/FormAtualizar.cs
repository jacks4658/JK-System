using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormAtualizar : Form
    {
        public FormAtualizar()
        {
            InitializeComponent();
            this.ActiveControl = txtnome;
            txtnome.Focus();
        }



        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        #region CONEXAO/E ENVIO DE DADOS
        SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");

        String Sql = "update cadastro set recebido=@recebido, codigo=@codigo, endereco=@endereco, descricao=@descricao, proprietario=@proprietario where Id=@id";

        private void bntEnviarDb_Click(object sender, EventArgs e)
        {

      

            try
            {

                SqlCommand c = new SqlCommand(Sql, conexao);

                c.Parameters.Add(new SqlParameter("@ID",this.txtid.Text));

                c.Parameters.Add(new SqlParameter("@RECEBIDO", this.txtnome.Text));
                txtnome.Clear();
                c.Parameters.Add(new SqlParameter("@CODIGO", this.txtcodigo.Text));
                txtcodigo.Clear();
                c.Parameters.Add(new SqlParameter("@ENDERECO", this.txtendereco.Text));
                txtendereco.Clear();
                c.Parameters.Add(new SqlParameter("@DESCRICAO", this.txtdescricao.Text));
                txtdescricao.Clear();
                c.Parameters.Add(new SqlParameter("@PROPRIETARIO", this.txtproprietario.Text));
                txtproprietario.Clear();
              


                conexao.Open();

                //executar sql

                c.ExecuteNonQuery();

                MessageBox.Show("DADOS ATUALIZADOS COM SUCESSO");
             
                conexao.Close();

            }
            catch
            {


            }

    }
        #endregion/
       
        
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtnome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcodigo.Focus();

            }
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtproprietario.Focus();

            }
        }

        private void txtproprietario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtendereco.Focus();

            }
        }

        private void txtendereco_KeyDown(object sender, KeyEventArgs e)
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
                bntEnviarDb.PerformClick();

            }
        }
    }
}
