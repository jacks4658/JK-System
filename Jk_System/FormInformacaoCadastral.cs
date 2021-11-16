
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;


namespace COMPLETE_FLAT_UI
{
    public partial class FormInformacaoCadastral : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        object nome = null; private string id = null;
        private bool atualizar = false;

        public FormInformacaoCadastral()
        {
            InitializeComponent();
        }

        private void FormInformacaoCadastral_Load(object sender, EventArgs e)
        {
        
        }


        private void MostrarProdctos()
        {

            CN_Productos objeto = new CN_Productos();
            cADASTRO_VISITANTEDataGridView.DataSource = objeto.MostrarProd();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PainelCadastroVisitante frm = new PainelCadastroVisitante();
            frm.ShowDialog();
        }


        private void RefreshData()
        {


            cADASTROVISITANTEBindingSource.Filter = null;
            this.cADASTRO_VISITANTETableAdapter1.Fill(this.bancoLocalhost.CADASTRO_VISITANTE);

            if (txtPesquisa.CanSelect)
            {
                txtPesquisa.Clear();
                txtPesquisa.Select();
            }


        }

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            FormAtualizar frm = new FormAtualizar();


            if (cADASTRO_VISITANTEDataGridView.SelectedRows.Count > 0)
            {



                frm.txtid.Text = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[0].Value.ToString();
                frm.txtnome.Text = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[1].Value.ToString();
                frm.txtcodigo.Text = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[2].Value.ToString();
                frm.txtproprietario.Text = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[3].Value.ToString();
                frm.txtendereco.Text = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[4].Value.ToString();
                frm.txtdescricao.Text = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[5].Value.ToString();
           

                frm.ShowDialog();

            }
            else
                MessageBox.Show("SELECIONE UMA LINHA");
        }

      

    

        //  private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        // {
        //
        // }

        private void pesquisa_Click(object sender, EventArgs e)
        {

            pesquisaDataazure();


        }

        private void pesquisaDataazure()
        {


            if (string.IsNullOrEmpty(txtPesquisa.Text.Trim()))
            {
                RefreshData();
                return;
            }
            string strpesquisa = txtPesquisa.Text.Trim().ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("(Convert(ID,'System.String')LIKE'" + "{0}" + "')", strpesquisa);
            sb.AppendFormat("OR(CODIGO LIKE'*" + "{0}" + "*')", strpesquisa);
            sb.AppendFormat("OR(ENDERECO LIKE'*" + "{0}" + "*')", strpesquisa);
            sb.AppendFormat("OR(DESCRICAO LIKE'*" + "{0}" + "*')", strpesquisa);
            sb.AppendFormat("OR(PROPRIETARIO LIKE'*" + "{0}" + "*')", strpesquisa);

            string strfilter = sb.ToString();
            cADASTROVISITANTEBindingSource.Filter = strfilter;

            if (cADASTROVISITANTEBindingSource.Count != 0)

            {

                cADASTRO_VISITANTEDataGridView.DataSource = cADASTROVISITANTEBindingSource;
            }

            else
            {
                MessageBox.Show("DESCULPA NIGUEM CADASTRADO");

                RefreshData();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if
                (MessageBox.Show("QUER REALMENTE DA BAIXA NESSA ENCOMENDA?  ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                RefreshData();
                return;
            }


            if (cADASTRO_VISITANTEDataGridView.SelectedRows.Count > 0)
            {
                id = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[1].Value.ToString();
                objetoCN.EliminarPRod(id);
                MessageBox.Show("VISITANTE SAIU");
                MostrarProdctos();
            }
            else
                MessageBox.Show("SELECIONE A LINHA DA ENCOMENDA");
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisa.PerformClick();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            PainelCadastroVisitante frm = new PainelCadastroVisitante();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if
            (MessageBox.Show("EFETUAR A SAIDA DO VISITANTE?  ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                RefreshData();
                return;
            }


            if (cADASTRO_VISITANTEDataGridView.SelectedRows.Count > 0)
            {
                id = cADASTRO_VISITANTEDataGridView.CurrentRow.Cells[0].Value.ToString();
                objetoCN.EliminarPRod02(id);
                MessageBox.Show("SAIDA REALIZADA");
                RefreshData();
                return;
            }
            else
                MessageBox.Show("SELECIONE A LINHA DO VISITANTE");

        }
    }
}
         
    
