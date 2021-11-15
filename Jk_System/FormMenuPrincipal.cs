using BaseFirebase;
using FlatLoginWatermark;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMenuPrincipal : Form
    {
        //Constructor
        public FormMenuPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }


        private void hideSubMenu()
        {
            SubmenuHistorico.Visible = false;
          
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        //METODO PARA REDIMENCIONAR ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //------------
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR

        #region

        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        #region
        //METODO PARA ARRASTRAR O FOROMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        //METODOS PARA FECHAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------


        #region
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {


            //String de conexao
            SqlConnection conexao = new SqlConnection("Server=DESKTOP-C6NHVB9\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Banco;");
            //inserção sql

            String Sql = "DELETE FROM LOGIN ";



            try
            {

                SqlCommand c = new SqlCommand(Sql, conexao);


                conexao.Open();

                //executar sql
            }

            catch (SqlException ex)
            {
                 MessageBox.Show("OCORREU UM ERRO:" + ex);
            }

            if (MessageBox.Show("TEM CERTEZA QUE DESEJA DESLOGAR? ", "ATENÇÂO ", MessageBoxButtons.YesNo) == DialogResult.No) ;


            else
            {
    
                this.Close();
                FormLogin fm = new FormLogin();
                fm.Show();
                SqlCommand c = new SqlCommand(Sql, conexao);
                c.ExecuteNonQuery();
                conexao.Close();
            }
          
        
        }
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA DESLOGAR? ", "ATENÇAO ", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();

                FormLogin fm = new FormLogin();
                fm.Show();

                
            }
        }
        #endregion
        //METODOS PARA ANIMACÃO DE MENU SLIDING--


        #region
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------COM EFEITO SLIDING
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }

            //-------SEM EFEITO CASO EU QUEIRA USAR
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;

        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }
        #endregion
        //METODO PARA ABRIR FORM DENTRO DO PAINEL-----------------------------------------------------

        #region
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }

        #endregion
        //METODO PARA MOSTRAR FORMULARIO DE LOGO AO INICIAR ----------------------------------------------------------

        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FormLogo());
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO AO FECHAR OUTROS FORM ----------------------------------------------------------
        private void MostrarFormLogoAoFechar(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
        //METODOS PARA ABRIR OUTROS FORMULARIOS E MOSTRAR FORM DE LOGO AO FECHAR ----------------------------------------------------------
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes fm = new FormListaClientes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAoFechar);
            AbrirFormEnPanel(fm);
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            showSubMenu(SubmenuHistorico);
            
          
        
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

            //String de conexao
            SqlConnection conexao = new SqlConnection("Server=DESKTOP-C6NHVB9\\SQLEXPRESS;Integrated Security=true;Initial Catalog=Banco;");

            //inserção sql

            String Sql = "DELETE FROM LOGIN ";

            try
            {
                
             conexao.Open();
              //executar sql
                               
            }

            catch (SqlException ex)
            {
                //  MessageBox.Show("OCORREU UM ERRO:" + ex);

            }

            if (MessageBox.Show("DESEJA FAZER LOGOUT?  ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No) ;

            else
            {

                FormLogin fm = new FormLogin();
                fm.Show();
                this.Close();

                SqlCommand c = new SqlCommand(Sql, conexao);
                c.ExecuteNonQuery();
                conexao.Close();
            }


        }

        private void HistoricoCadastro_Click(object sender, EventArgs e)
        {

            FormHistrorico frm = new FormHistrorico();
            frm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAoFechar);
            AbrirFormEnPanel(frm);

            hideSubMenu();

        }

        private void HistoricoUsuarios_Click(object sender, EventArgs e)
        {

            Historico_de_acesso hist = new Historico_de_acesso();
            hist.FormClosed += new FormClosedEventHandler(MostrarFormLogoAoFechar);
            AbrirFormEnPanel(hist);

            hideSubMenu();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                FormInformacaoCadastral fm = new FormInformacaoCadastral
                    ();
                fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAoFechar);
                AbrirFormEnPanel(fm);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                HistoricoVisitante fm = new HistoricoVisitante();

                fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAoFechar);
                AbrirFormEnPanel(fm);
            }
        }


        //METODO PARA HORA E FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistrationForm());
        }

        

    }
}
