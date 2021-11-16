using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace COMPLETE_FLAT_UI
{
    public partial class FormHistrorico : Form
    {
      

        public FormHistrorico()
        {
            InitializeComponent();
        }



        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cADASTROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();                                                                                                                                                    
          

        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
           


        }


        public void exportarPdf(DataGridView dgw, string filename) {
            {

                
                BaseFont bf = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.EMBEDDED);
               
                PdfPTable pdfTabela = new PdfPTable(dgw.Columns.Count);
                pdfTabela.DefaultCell.Padding = 3;
                pdfTabela.WidthPercentage = 100;
                pdfTabela.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTabela.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 9, iTextSharp.text.Font.BOLD);
                //adicionar leitor
                foreach (DataGridViewColumn column in dgw.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTabela.AddCell(cell);

                }
                //Adicinar dataRow

                foreach (DataGridViewRow row in dgw.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTabela.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }
                var saveFiledialoge = new SaveFileDialog();
                saveFiledialoge.FileName = filename;
                saveFiledialoge.DefaultExt = ".pdf";
                if (saveFiledialoge.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFiledialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdfTabela);
                        pdfdoc.Close();
                        stream.Close();
                    }
                }
            }
           
        }

        private void btnSavePdf_Click(object sender, EventArgs e)
        {
            exportarPdf(cADASTRO_LogDataGridView, "Encomendas");
        }
    }
}


