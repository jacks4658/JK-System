using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

            FormListaClientes filho = new FormListaClientes();
            AddOwnedForm(filho);
            filho.FormBorderStyle = FormBorderStyle.None;
            filho.TopLevel = false;
            filho.Dock = DockStyle.Fill;
            this.Controls.Add(filho);
            this.Tag = filho;
            filho.BringToFront();
           
            filho.Show    ();  
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cADASTROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cADASTROBindingSource.EndEdit   ();
            this.tableAdapterManager.UpdateAll(this.bancoAzureDataSet1);
            

        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoAzureDataSet1.CADASTRO' table. You can move, or remove it, as needed.
            this.cADASTROTableAdapter.Fill(this.bancoAzureDataSet1.CADASTRO);
            this.cADASTROTableAdapter.frm_proprietario(this.bancoAzureDataSet1.CADASTRO,txtnombre.Text);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            this.cADASTROTableAdapter.frm_proprietario(this.bancoAzureDataSet1.CADASTRO, txtnombre.Text);
        }
    }
}
