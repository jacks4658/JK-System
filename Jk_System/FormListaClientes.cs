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
    public partial class FormListaClientes : Form
    {

        CN_Productos objetoCN = new CN_Productos();
        object recebido = null;  private string id = null;
        private bool atualizar = false;
        public FormListaClientes()
        {   
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancoLocalhost.CADASTRO'. Você pode movê-la ou removê-la conforme necessário.
            this.cADASTROTableAdapter2.Fill(this.bancoLocalhost.CADASTRO);
            // TODO: esta linha de código carrega dados na tabela 'bancoLocalhost.CADASTRO_VISITANTE'. Você pode movê-la ou removê-la conforme necessário.
            this.cADASTRO_VISITANTETableAdapter.Fill(this.bancoLocalhost.CADASTRO_VISITANTE);
           

        }

       private void MostrarProdctos()
        {

            CN_Productos objeto = new CN_Productos();
          dataGridView1.DataSource = objeto.MostrarProd();
}
        
        //CODIGO DA PESQUISA


        
        
        private void RefreshData()
        {


             cADASTROBindingSource2.Filter = null;
            this.cADASTROTableAdapter2.Fill(this.bancoLocalhost.CADASTRO);

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
        
            
            if (dataGridView1.SelectedRows.Count > 0)
            {


               
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtnome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtcodigo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtproprietario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txtendereco.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.txtdescricao.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                frm.ShowDialog();

            }
            else
                MessageBox.Show("SELECIONE UMA LINHA");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.ShowDialog();
            

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
            cADASTROBindingSource2.Filter = strfilter;

            if (cADASTROBindingSource2.Count != 0)

            {

                dataGridView1.DataSource = cADASTROBindingSource2;
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


            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objetoCN.EliminarPRod(id);
                MessageBox.Show("ENCOMENDA ENTREGUE");
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
            if
               (MessageBox.Show("QUER REALMENTE DA BAIXA NESSA ENCOMENDA?  ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                RefreshData();
                return;
            }


            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objetoCN.EliminarPRod(id);
                MessageBox.Show("ENCOMENDA ENTREGUE");
                MostrarProdctos();
            }
            else
                MessageBox.Show("SELECIONE A LINHA DA ENCOMENDA");
        }
    }
    }

        
    




