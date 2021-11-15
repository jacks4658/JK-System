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


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string id=null;
        private bool Editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoFormulario.MostrarCadastro' table. You can move, or remove it, as needed.
            this.mostrarCadastroTableAdapter.Fill(this.bancoFormulario.MostrarCadastro);
            MostrarProdctos();
        }

        private void MostrarProdctos() {

            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarPRod(txtRecebido.Text, txtCodigo.Text, txtEndereco.Text, txtDescricao.Text, txtProprietario.Text);
                    MessageBox.Show("Dados inseridos");
                    MostrarProdctos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Os dados nao foram inseridos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true) {

                try
                {
                    objetoCN.EditarProd(txtRecebido.Text, txtCodigo.Text, txtEndereco.Text, txtDescricao.Text, txtProprietario.Text);
                    MessageBox.Show("Dados Editados");
                    MostrarProdctos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex) {
                    MessageBox.Show("Os dados nao podem ser Editados: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtRecebido.Text = dataGridView1.CurrentRow.Cells["recebido"].Value.ToString();
                txtEndereco.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["proprietario"].Value.ToString();
                txtDescricao.Text = dataGridView1.CurrentRow.Cells["descricao"].Value.ToString();
                txtProprietario.Text = dataGridView1.CurrentRow.Cells["endereco"].Value.ToString();
                id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();// Objeto que sera deletado
            }
            else
                MessageBox.Show("Selecione uma Fila Por favor");
        }

        private void limpiarForm() {
            txtCodigo.Clear();
            txtEndereco.Text = "";
            txtDescricao.Clear();
            txtProprietario.Clear();
            txtRecebido.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                objetoCN.EliminarPRod(id);
                MessageBox.Show("Excluido");
                    MostrarProdctos();
            }
            else
                MessageBox.Show("selecione uma fila por favor");

        }
    }
}
