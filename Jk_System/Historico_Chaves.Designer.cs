namespace COMPLETE_FLAT_UI
{
    partial class Historico_Chaves
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cHAVE_LogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHAVE_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoBandB = new COMPLETE_FLAT_UI.BancoBandB();
            this.cHAVE_LogTableAdapter = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.CHAVE_LogTableAdapter();
            this.tableAdapterManager = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.cHAVE_LogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAVE_LogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).BeginInit();
            this.SuspendLayout();
            // 
            // cHAVE_LogDataGridView
            // 
            this.cHAVE_LogDataGridView.AutoGenerateColumns = false;
            this.cHAVE_LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cHAVE_LogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn2});
            this.cHAVE_LogDataGridView.DataSource = this.cHAVE_LogBindingSource;
            this.cHAVE_LogDataGridView.Location = new System.Drawing.Point(12, 2);
            this.cHAVE_LogDataGridView.Name = "cHAVE_LogDataGridView";
            this.cHAVE_LogDataGridView.Size = new System.Drawing.Size(1000, 700);
            this.cHAVE_LogDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ENTREGUE";
            this.dataGridViewTextBoxColumn7.HeaderText = "AGENTE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 76;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RETIRADO";
            this.dataGridViewTextBoxColumn8.HeaderText = "MORADOR";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 88;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ACAO";
            this.dataGridViewTextBoxColumn5.HeaderText = "ACAO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CHAVES";
            this.dataGridViewTextBoxColumn9.HeaderText = "CHAVES";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TORRE";
            this.dataGridViewTextBoxColumn10.HeaderText = "TORRE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OBSERVACAO";
            this.dataGridViewTextBoxColumn11.HeaderText = "OBSERVACAO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 105;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dt_Atualizacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "DATA";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cHAVE_LogBindingSource
            // 
            this.cHAVE_LogBindingSource.DataMember = "CHAVE_Log";
            this.cHAVE_LogBindingSource.DataSource = this.bancoBandB;
            // 
            // bancoBandB
            // 
            this.bancoBandB.DataSetName = "BancoBandB";
            this.bancoBandB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHAVE_LogTableAdapter
            // 
            this.cHAVE_LogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CADASTRO_LogTableAdapter = null;
            this.tableAdapterManager.CADASTROvisit_LogTableAdapter = null;
            this.tableAdapterManager.CHAVE_LogTableAdapter = this.cHAVE_LogTableAdapter;
            this.tableAdapterManager.UpdateOrder = COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Historico_Chaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.cHAVE_LogDataGridView);
            this.Name = "Historico_Chaves";
            this.Text = "Historico_Chaves";
            this.Load += new System.EventHandler(this.Historico_Chaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHAVE_LogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHAVE_LogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BancoBandB bancoBandB;
        private System.Windows.Forms.BindingSource cHAVE_LogBindingSource;
        private BancoBandBTableAdapters.CHAVE_LogTableAdapter cHAVE_LogTableAdapter;
        private BancoBandBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cHAVE_LogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}