using CapaNegocio;
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
    public partial class ListaChavesRetiradas : Form



    {


        CN_Productos objetoCN = new CN_Productos();
        object recebido = null; private string id = null;
        private bool atualizar = false;
     
        public ListaChavesRetiradas()
        {
            InitializeComponent();
        }

        private void ListaChavesRetiradas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoBandB.MostrarChave' table. You can move, or remove it, as needed.
            this.mostrarChaveTableAdapter.Fill(this.bancoBandB.MostrarChave);

        }
        private void MostrarChaves()
        {

            CN_Productos objeto = new CN_Productos();
            mostrarChaveDataGridView.DataSource = objeto.MostrarChave();
        }
        private void RefreshData()
        {


            mostrarChaveBindingSource.Filter = null;
            this.mostrarChaveTableAdapter.Fill(this.bancoBandB.MostrarChave);


        }

        private void delete_Click(object sender, EventArgs e)
        {
            if
                            (MessageBox.Show("QUER REALMENTE DA BAIXA NESSA ENCOMENDA?  ", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

                RefreshData();
                return;
            }


            if (mostrarChaveDataGridView.SelectedRows.Count > 0)
            {
                id = mostrarChaveDataGridView.CurrentRow.Cells[0].Value.ToString();
                objetoCN.EliminarChave(id);
                MessageBox.Show("ENCOMENDA ENTREGUE");
                RefreshData();

            }
            else
                MessageBox.Show("SELECIONE A LINHA DA ENCOMENDA");
        }
    }
    }

