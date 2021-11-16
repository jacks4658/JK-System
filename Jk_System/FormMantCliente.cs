using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Drawing.Text;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMantCliente : Form
    {
        public FormMantCliente()
        {
            InitializeComponent();

            this.ActiveControl = txtnome;
            txtnome.Focus();
        
        }
        #region
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "772yOUxFP6ul2XHKO8a4GOmkSaUkm3I755qY1Bd5",
            BasePath = "https://aplicativo-35650.firebaseio.com/"
        };

        IFirebaseClient client;
        #endregion  //CODIGO DE CONEXAO FIREBASE
        #region

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {


            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("VERIFIQUE SUA CONEXÃO!!!");

            }
        }


        //BOTAO QUE ENVIA DADOS

        #region
       
       
        
        private async void bntEnviarDb_Click(object sender, EventArgs e)
        {
            //String de conexao
            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");

            //inserção sql

            String Sql = "INSERT INTO CADASTRO(ID,RECEBIDO,CODIGO,ENDERECO,DESCRICAO,PROPRIETARIO)VALUES(@ID,@RECEBIDO,@CODIGO,@ENDERECO,@DESCRICAO,@PROPRIETARIO)";

            Random numeroID = new Random ();
           numeroID.Next();

            try
            {

               

                //SetResponse set = await client.SetAsync(@"Entregas/" + enco.ID, enco);

                SqlCommand c =new SqlCommand(Sql,conexao);
                c.Parameters.Add(new SqlParameter("@ID", numeroID.Next()));
               
                c.Parameters.Add(new SqlParameter("@RECEBIDO", this.txtnome.Text));
                txtnome.Clear();
                c.Parameters.Add(new SqlParameter("@CODIGO",this.txtcodigo.Text));
                txtcodigo.Clear();
                c.Parameters.Add(new SqlParameter("@ENDERECO",this.txtendereco.Text));
                txtendereco.Clear();
                c.Parameters.Add(new SqlParameter("@DESCRICAO",this.txtdescricao.Text));
                txtdescricao.Clear();
                c.Parameters.Add(new SqlParameter("@PROPRIETARIO", this.txtproprietario.Text));
                
                txtproprietario.Clear();
               

                //abrir conexao

                conexao.Open();

                //executar sql
                c.ExecuteNonQuery();
             
                MessageBox.Show("DADOS ENVIADO");
                    conexao.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("OCORREU UM ERRO:"+ex);

            }
 
            
        }
        #endregion
      //AS TEXTBOX
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

        private void txtdescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bntEnviarDb.PerformClick();
                txtnome.Focus();

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdescricao.Focus();

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
    }
}
