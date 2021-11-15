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

namespace COMPLETE_FLAT_UI
{
    public partial class Historico_de_acesso : Form
    {
        public Historico_de_acesso()
        {
            InitializeComponent();
            #region Drag Form/ Mover Arrastar Formulario

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion 
        private void login_logBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.login_logBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.login);

        }

        private void Historico_de_acesso_Load(object sender, EventArgs e)
        {
         
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text.Trim()))
            {
            }
            string strpesquisa = txtPesquisa.Text.Trim().ToString();
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("(NOME LIKE'*" + "{0}" + "*')", strpesquisa);
          
          
            string strfilter = sb.ToString();
            loginlogBindingSource3.Filter = strfilter;

            if (loginlogBindingSource3.Count != 0)

            {

                loginlogBindingSource3.DataSource = loginlogBindingSource3;
            }

            else
            {
                MessageBox.Show("NEM UM DADO ENCONTRADO");

                
            }
        }
    }
    }

