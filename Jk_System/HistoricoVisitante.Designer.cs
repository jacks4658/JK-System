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
            this.bancoLocalhost = new COMPLETE_FLAT_UI.BancoLocalhost();
            this.cADASTRO_VISITANTELOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new COMPLETE_FLAT_UI.BancoLocalhostTableAdapters.TableAdapterManager();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cADASTROvisitLogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bancoBandB = new COMPLETE_FLAT_UI.BancoBandB();
            this.cADASTROvisitLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTROVISITANTELOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTROvisit_LogTableAdapter = new COMPLETE_FLAT_UI.BancoLocalhostTableAdapters.CADASTROvisit_LogTableAdapter();
            this.cADASTROvisit_LogTableAdapter1 = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.CADASTROvisit_LogTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.bancoLocalhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_VISITANTELOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROvisitLogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROvisitLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROVISITANTELOGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoLocalhost
            // 
            this.bancoLocalhost.DataSetName = "BancoLocalhost";
            this.bancoLocalhost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADASTRO_VISITANTELOGBindingSource
            // 
            this.cADASTRO_VISITANTELOGBindingSource.DataMember = "CADASTRO_VISITANTELOG";
            this.cADASTRO_VISITANTELOGBindingSource.DataSource = this.bancoLocalhost;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CADASTRO_LogTableAdapter = null;
            this.tableAdapterManager.CADASTRO_VISITANTETableAdapter = null;
            this.tableAdapterManager.CADASTROTableAdapter = null;
            this.tableAdapterManager.CADASTROvisit_LogTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Login_logTableAdapter = null;
            this.tableAdapterManager.LOGINARMAZENATableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COMPLETE_FLAT_UI.BancoLocalhostTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.dataGridView.DataSource = this.cADASTROvisitLogBindingSource1;
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
            // cADASTROvisitLogBindingSource1
            // 
            this.cADASTROvisitLogBindingSource1.DataMember = "CADASTROvisit_Log";
            this.cADASTROvisitLogBindingSource1.DataSource = this.bancoBandB;
            // 
            // bancoBandB
            // 
            this.bancoBandB.DataSetName = "BancoBandB";
            this.bancoBandB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADASTROvisitLogBindingSource
            // 
            this.cADASTROvisitLogBindingSource.DataMember = "CADASTROvisit_Log";
            this.cADASTROvisitLogBindingSource.DataSource = this.bancoLocalhost;
            // 
            // cADASTROVISITANTELOGBindingSource
            // 
            this.cADASTROVISITANTELOGBindingSource.DataMember = "CADASTRO_VISITANTELOG";
            this.cADASTROVISITANTELOGBindingSource.DataSource = this.bancoLocalhost;
            // 
            // cADASTROvisit_LogTableAdapter
            // 
            this.cADASTROvisit_LogTableAdapter.ClearBeforeFill = true;
            // 
            // cADASTROvisit_LogTableAdapter1
            // 
            this.cADASTROvisit_LogTableAdapter1.ClearBeforeFill = true;
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
            this.rGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.Width = 48;
            // 
            // pLACADataGridViewTextBoxColumn
            // 
            this.pLACADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pLACADataGridViewTextBoxColumn.DataPropertyName = "PLACA";
            this.pLACADataGridViewTextBoxColumn.HeaderText = "PLACA";
            this.pLACADataGridViewTextBoxColumn.Name = "pLACADataGridViewTextBoxColumn";
            this.pLACADataGridViewTextBoxColumn.Width = 66;
            // 
            // mODELODataGridViewTextBoxColumn
            // 
            this.mODELODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mODELODataGridViewTextBoxColumn.DataPropertyName = "MODELO";
            this.mODELODataGridViewTextBoxColumn.HeaderText = "MODELO";
            this.mODELODataGridViewTextBoxColumn.Name = "mODELODataGridViewTextBoxColumn";
            this.mODELODataGridViewTextBoxColumn.Width = 78;
            // 
            // cORDataGridViewTextBoxColumn
            // 
            this.cORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cORDataGridViewTextBoxColumn.DataPropertyName = "COR";
            this.cORDataGridViewTextBoxColumn.HeaderText = "COR";
            this.cORDataGridViewTextBoxColumn.Name = "cORDataGridViewTextBoxColumn";
            this.cORDataGridViewTextBoxColumn.Width = 55;
            // 
            // mORADORDataGridViewTextBoxColumn
            // 
            this.mORADORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mORADORDataGridViewTextBoxColumn.DataPropertyName = "MORADOR";
            this.mORADORDataGridViewTextBoxColumn.HeaderText = "VISITADO";
            this.mORADORDataGridViewTextBoxColumn.Name = "mORADORDataGridViewTextBoxColumn";
            this.mORADORDataGridViewTextBoxColumn.Width = 82;
            // 
            // rUADataGridViewTextBoxColumn
            // 
            this.rUADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rUADataGridViewTextBoxColumn.DataPropertyName = "RUA";
            this.rUADataGridViewTextBoxColumn.HeaderText = "RUA";
            this.rUADataGridViewTextBoxColumn.Name = "rUADataGridViewTextBoxColumn";
            this.rUADataGridViewTextBoxColumn.Width = 55;
            // 
            // qUADRADataGridViewTextBoxColumn
            // 
            this.qUADRADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qUADRADataGridViewTextBoxColumn.DataPropertyName = "QUADRA";
            this.qUADRADataGridViewTextBoxColumn.HeaderText = "TORRE";
            this.qUADRADataGridViewTextBoxColumn.Name = "qUADRADataGridViewTextBoxColumn";
            this.qUADRADataGridViewTextBoxColumn.Width = 70;
            // 
            // aPARTAMENTODataGridViewTextBoxColumn
            // 
            this.aPARTAMENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aPARTAMENTODataGridViewTextBoxColumn.DataPropertyName = "APARTAMENTO";
            this.aPARTAMENTODataGridViewTextBoxColumn.HeaderText = "APARTAMENTO";
            this.aPARTAMENTODataGridViewTextBoxColumn.Name = "aPARTAMENTODataGridViewTextBoxColumn";
            this.aPARTAMENTODataGridViewTextBoxColumn.Width = 114;
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
            ((System.ComponentModel.ISupportInitialize)(this.bancoLocalhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_VISITANTELOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROvisitLogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROvisitLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROVISITANTELOGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BancoLocalhost bancoLocalhost;
        private System.Windows.Forms.BindingSource cADASTRO_VISITANTELOGBindingSource;
        private BancoLocalhostTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource cADASTROVISITANTELOGBindingSource;
        private System.Windows.Forms.BindingSource cADASTROvisitLogBindingSource;
        private BancoLocalhostTableAdapters.CADASTROvisit_LogTableAdapter cADASTROvisit_LogTableAdapter;
        private BancoBandB bancoBandB;
        private System.Windows.Forms.BindingSource cADASTROvisitLogBindingSource1;
        private BancoBandBTableAdapters.CADASTROvisit_LogTableAdapter cADASTROvisit_LogTableAdapter1;
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