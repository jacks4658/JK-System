namespace COMPLETE_FLAT_UI
{
    partial class HistoricoVisitante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bancoBandB = new COMPLETE_FLAT_UI.BancoBandB();
            this.cADASTROvisit_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTROvisit_LogTableAdapter = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.CADASTROvisit_LogTableAdapter();
            this.tableAdapterManager = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager();
            this.ACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLACADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mORADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUADRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPARTAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Atualizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROvisit_LogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACAO,
            this.nOMEDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.pLACADataGridViewTextBoxColumn,
            this.mODELODataGridViewTextBoxColumn,
            this.cORDataGridViewTextBoxColumn,
            this.mORADORDataGridViewTextBoxColumn,
            this.rUADataGridViewTextBoxColumn,
            this.qUADRADataGridViewTextBoxColumn,
            this.aPARTAMENTODataGridViewTextBoxColumn,
            this.Dt_Atualizacao});
            this.dataGridView.DataSource = this.cADASTROvisit_LogBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.White;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(970, 450);
            this.dataGridView.TabIndex = 0;
            // 
            // bancoBandB
            // 
            this.bancoBandB.DataSetName = "BancoBandB";
            this.bancoBandB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADASTROvisit_LogBindingSource
            // 
            this.cADASTROvisit_LogBindingSource.DataMember = "CADASTROvisit_Log";
            this.cADASTROvisit_LogBindingSource.DataSource = this.bancoBandB;
            // 
            // cADASTROvisit_LogTableAdapter
            // 
            this.cADASTROvisit_LogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CADASTRO_LogTableAdapter = null;
            this.tableAdapterManager.CADASTRO_VISITANTETableAdapter = null;
            this.tableAdapterManager.CADASTROvisit_LogTableAdapter = this.cADASTROvisit_LogTableAdapter;
            this.tableAdapterManager.CHAVE_LogTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ACAO
            // 
            this.ACAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ACAO.DataPropertyName = "ACAO";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.ACAO.DefaultCellStyle = dataGridViewCellStyle2;
            this.ACAO.HeaderText = "ACAO";
            this.ACAO.Name = "ACAO";
            this.ACAO.Width = 61;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.Width = 64;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // pLACADataGridViewTextBoxColumn
            // 
            this.pLACADataGridViewTextBoxColumn.DataPropertyName = "PLACA";
            this.pLACADataGridViewTextBoxColumn.HeaderText = "PLACA";
            this.pLACADataGridViewTextBoxColumn.Name = "pLACADataGridViewTextBoxColumn";
            // 
            // mODELODataGridViewTextBoxColumn
            // 
            this.mODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO";
            this.mODELODataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.mODELODataGridViewTextBoxColumn.Name = "mODELODataGridViewTextBoxColumn";
            // 
            // cORDataGridViewTextBoxColumn
            // 
            this.cORDataGridViewTextBoxColumn.DataPropertyName = "COR";
            this.cORDataGridViewTextBoxColumn.HeaderText = "COR";
            this.cORDataGridViewTextBoxColumn.Name = "cORDataGridViewTextBoxColumn";
            // 
            // mORADORDataGridViewTextBoxColumn
            // 
            this.mORADORDataGridViewTextBoxColumn.DataPropertyName = "MORADOR";
            this.mORADORDataGridViewTextBoxColumn.HeaderText = "MORADOR";
            this.mORADORDataGridViewTextBoxColumn.Name = "mORADORDataGridViewTextBoxColumn";
            // 
            // rUADataGridViewTextBoxColumn
            // 
            this.rUADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rUADataGridViewTextBoxColumn.DataPropertyName = "RUA";
            this.rUADataGridViewTextBoxColumn.HeaderText = "OBSERVAÇÃO";
            this.rUADataGridViewTextBoxColumn.Name = "rUADataGridViewTextBoxColumn";
            this.rUADataGridViewTextBoxColumn.Width = 105;
            // 
            // qUADRADataGridViewTextBoxColumn
            // 
            this.qUADRADataGridViewTextBoxColumn.DataPropertyName = "QUADRA";
            this.qUADRADataGridViewTextBoxColumn.HeaderText = "TORRE";
            this.qUADRADataGridViewTextBoxColumn.Name = "qUADRADataGridViewTextBoxColumn";
            // 
            // aPARTAMENTODataGridViewTextBoxColumn
            // 
            this.aPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "APARTAMENTO";
            this.aPARTAMENTODataGridViewTextBoxColumn.HeaderText = "APARTAMENTO";
            this.aPARTAMENTODataGridViewTextBoxColumn.Name = "aPARTAMENTODataGridViewTextBoxColumn";
            // 
            // Dt_Atualizacao
            // 
            this.Dt_Atualizacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dt_Atualizacao.DataPropertyName = "Dt_Atualizacao";
            this.Dt_Atualizacao.HeaderText = "DATA/HORA";
            this.Dt_Atualizacao.Name = "Dt_Atualizacao";
            this.Dt_Atualizacao.Width = 97;
            // 
            // HistoricoVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.dataGridView);
            this.Name = "HistoricoVisitante";
            this.Text = "HistoricoVisitante";
            this.Load += new System.EventHandler(this.HistoricoVisitante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROvisit_LogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private BancoBandB bancoBandB;
        private System.Windows.Forms.BindingSource cADASTROvisit_LogBindingSource;
        private BancoBandBTableAdapters.CADASTROvisit_LogTableAdapter cADASTROvisit_LogTableAdapter;
        private BancoBandBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLACADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mORADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUADRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPARTAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Atualizacao;
    }
}