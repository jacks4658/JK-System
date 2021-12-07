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
    public partial class Historico_Chaves : Form
    {
        public Historico_Chaves()
        {
            InitializeComponent();
        }

        private void cHAVE_LogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHAVE_LogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoBandB);

        }

        private void Historico_Chaves_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoBandB.CHAVE_Log' table. You can move, or remove it, as needed.
            this.cHAVE_LogTableAdapter.Fill(this.bancoBandB.CHAVE_Log);

        }
    }
}
