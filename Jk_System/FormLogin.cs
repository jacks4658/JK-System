using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data.Sql;
using COMPLETE_FLAT_UI;
using CircularProgressBar;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using BaseFirebase;

namespace FlatLoginWatermark
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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



        private void btnlogin_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");


            String Sql = "INSERT INTO LOGIN(ID,USUARIO,SENHA)VALUES(@ID,@USUARIO,@SENHA)";

            Random numeroID = new Random();
            numeroID.Next();


            SqlCommand c = new SqlCommand(Sql, conexao);




            c.Parameters.Add(new SqlParameter("@ID", numeroID.Next()));


            c.Parameters.Add(new SqlParameter("@USUARIO", this.txtuser.Text));
            c.Parameters.Add(new SqlParameter("@SENHA", this.txtuser.Text));
            conexao.Open();
            c.ExecuteNonQuery();



            //executar sql






            string query = "Select * from [dbo].[LOGINARMAZENA] Where usuario = '" + txtuser.Text.Trim() + "' and senha = '" + txtpass.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conexao);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                Formvindo bemvindo = new Formvindo();
                bemvindo.ShowDialog();
                FormMenuPrincipal objFrmMain = new FormMenuPrincipal();





                conexao.Close();

                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("OPERADOR NAO CADASTRADO!!!");
            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Senha")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Senha";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();

            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }
    }
}
    


