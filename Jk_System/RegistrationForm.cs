using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace BaseFirebase
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            this.ActiveControl = UsernameTbox;
            UsernameTbox.Focus();
        }

        //DLL DE EFEITO DA JANELA 
        #region

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //AUTENTICAÇÃO BASE DE DADOS DO FIREBASE
        
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "772yOUxFP6ul2XHKO8a4GOmkSaUkm3I755qY1Bd5",
            BasePath = "https://aplicativo-35650.firebaseio.com/"
        };

        IFirebaseClient client;


        #endregion
        private void RegistrationForm_Load(object sender, EventArgs e)
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

        private void RegBtn_Click(object sender, EventArgs e)
        {


            //String de conexao
            SqlConnection conexao = new SqlConnection("Server=DESKTOP-C6NHVB9\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Banco;");

            //inserção sql

            String Sql = "INSERT INTO [dbo].[LOGINARMAZENA](ID,USUARIO,SENHA)VALUES(@ID,@USUARIO,@SENHA)";

            Random numeroID = new Random();
            numeroID.Next();

            try
            {



                //SetResponse set = await client.SetAsync(@"Entregas/" + enco.ID, enco);

                SqlCommand c = new SqlCommand(Sql, conexao);
                c.Parameters.Add(new SqlParameter("@ID", numeroID.Next()));

                c.Parameters.Add(new SqlParameter("@USUARIO", this.UsernameTbox.Text));
                UsernameTbox.Clear();
                c.Parameters.Add(new SqlParameter("@SENHA", this.passTbox.Text));
                passTbox.Clear();
                TxtSenhavazio.Clear();




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

    

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsernameTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passTbox.Focus();

            }
        }

        private void passTbox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                TxtSenhavazio.Focus();

            }
        }

        private void TxtSenhavazio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GenderCbox.Focus();

            }
        }

        private void GenderCbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                regBtn.PerformClick();

            }
        }
    }
}
