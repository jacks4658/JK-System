
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{

    public partial class Morador : Form

          
    {
        SqlDataReader dr;
        public Morador()
        {
            InitializeComponent();
        }

        private void bntEnviarMoador_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");

            //inserção sql

            String Sql = "INSERT INTO MORADOR(RG,MORADOR,BLOCO_AP,PERFIL,TELEFONE_01,TELEFONE_02,VAGA,LIBERADOS,VEICULOS)VALUES(@RG,@MORADOR,@BLOCO_AP,@PERFIL,@TELEFONE_01,@TELEFONE_02,@VAGA,@LIBERADOS,@VEICULOS)";



            try
            {

                Random numeroID = new Random();
                numeroID.Next();



                SqlCommand c = new SqlCommand(Sql, conexao);
                c.Parameters.Add(new SqlParameter("@RG", this.textBoxRg.Text));
                textBoxRg.Clear();
                c.Parameters.Add(new SqlParameter("@MORADOR", this.txtmorador.Text));
                txtmorador.Clear();
                c.Parameters.Add(new SqlParameter("@VAGA", this.txtVaga.Text));
                txtVaga.Clear();
                c.Parameters.Add(new SqlParameter("@TELEFONE_01", this.textTel1.Text));
                textTel1.Clear();
                c.Parameters.Add(new SqlParameter("@LIBERADOS", this.txtNomeLiberado.Text));
                txtNomeLiberado.Clear();
                c.Parameters.Add(new SqlParameter("@TELEFONE_02", this.txtTel2.Text));
                txtTel2.Clear();
                c.Parameters.Add(new SqlParameter("@BLOCO_AP", this.textAp.Text));
                textAp.Clear();
                c.Parameters.Add(new SqlParameter("@PERFIL", this.textPerfil.Text));
                textPerfil.Clear();
                c.Parameters.Add(new SqlParameter("@VEICULOS", this.textVeiculos.Text));
                textVeiculos.Clear();



                txtTel2.Clear();


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

        private void btnCancelarVisitante_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxRg_KeyDown(object sender, KeyEventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");
            //inserção sql




            SqlCommand c = new SqlCommand("SELECT * FROM [dbo].[MORADOR] WHERE RG= @RG", conexao);

            c.Parameters.AddWithValue("@RG", textBoxRg.Text);
            conexao.Open();
            dr = c.ExecuteReader();

            while (dr.Read())
            {
                txtmorador.Text = (string)dr["morador"];
                textBoxRg.Text = (string)dr["rg"];
                textVeiculos.Text = (string)dr["VEICULOS"];
                txtTel2.Text = (string)dr["TELEFONE_02"];
                txtVaga.Text = (string)dr["VAGA"];
                txtNomeLiberado.Text = (string)dr["LIBERADOS"];
                textAp.Text = (string)dr["BLOCO_AP"];
                textPerfil.Text = (string)dr["PERFIL"];
                textTel1.Text = (string)dr["TELEFONE_01"];
             
            }


        }

        private void textAp_KeyDown(object sender, KeyEventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");
            //inserção sql




            SqlCommand c = new SqlCommand("SELECT * FROM [dbo].[MORADOR] WHERE BLOCO_AP= @BLOCO_AP", conexao);

            c.Parameters.AddWithValue("@BLOCO_AP", textAp.Text);
            conexao.Open();
            dr = c.ExecuteReader();

            while (dr.Read())
            {
                txtmorador.Text = (string)dr["morador"];
                textBoxRg.Text = (string)dr["rg"];
                textVeiculos.Text = (string)dr["VEICULOS"];
                txtTel2.Text = (string)dr["TELEFONE_02"];
                txtVaga.Text = (string)dr["VAGA"];
                txtNomeLiberado.Text = (string)dr["LIBERADOS"];
                textAp.Text = (string)dr["BLOCO_AP"];
                textPerfil.Text = (string)dr["PERFIL"];
                textTel1.Text = (string)dr["TELEFONE_01"];

            }


        }

        private void txtVaga_KeyDown(object sender, KeyEventArgs e)
        {

            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");
            //inserção sql




            SqlCommand c = new SqlCommand("SELECT * FROM [dbo].[MORADOR] WHERE VAGA= @VAGA", conexao);

            c.Parameters.AddWithValue("@VAGA", txtVaga.Text);
            conexao.Open();
            dr = c.ExecuteReader();

            while (dr.Read())
            {
                txtmorador.Text = (string)dr["morador"];
                textBoxRg.Text = (string)dr["rg"];
                textVeiculos.Text = (string)dr["VEICULOS"];
                txtTel2.Text = (string)dr["TELEFONE_02"];
                txtVaga.Text = (string)dr["VAGA"];
                txtNomeLiberado.Text = (string)dr["LIBERADOS"];
                textAp.Text = (string)dr["BLOCO_AP"];
                textPerfil.Text = (string)dr["PERFIL"];
                textTel1.Text = (string)dr["TELEFONE_01"];

            }


        }




        private void Morador_Load(object sender, EventArgs e)
        {


            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");
            //inserção sql


            SqlCommand c = new SqlCommand("SELECT [MORADOR] FROM [dbo].[MORADOR]", conexao);


            conexao.Open();
            c.ExecuteNonQuery();
            SqlDataReader sdr = c.ExecuteReader();
            AutoCompleteStringCollection complete = new AutoCompleteStringCollection();
         

            while (sdr.Read())
            {
                complete.Add(sdr.GetString(0));
               

            }

            txtmorador.AutoCompleteCustomSource = complete;
          

            conexao.Close();
        }

        private void txtmorador_KeyDown(object sender, KeyEventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source=bancoazure4658.database.windows.net;Initial Catalog=Banco;user id=azure4658;password=Meg46581279;");
            //inserção sql




            SqlCommand c = new SqlCommand("SELECT * FROM [dbo].[MORADOR] WHERE MORADOR= @MORADOR", conexao);

            c.Parameters.AddWithValue("@MORADOR", txtmorador.Text);
            conexao.Open();
            dr = c.ExecuteReader();

            while (dr.Read())
            {
                txtmorador.Text = (string)dr["morador"];
                textBoxRg.Text = (string)dr["rg"];
                textVeiculos.Text = (string)dr["VEICULOS"];
                txtTel2.Text = (string)dr["TELEFONE_02"];
                txtVaga.Text = (string)dr["VAGA"];
                txtNomeLiberado.Text = (string)dr["LIBERADOS"];
                textAp.Text = (string)dr["BLOCO_AP"];
                textPerfil.Text = (string)dr["PERFIL"];
                textTel1.Text = (string)dr["TELEFONE_01"];

            }

        }
    }
    }


