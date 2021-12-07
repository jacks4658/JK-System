namespace COMPLETE_FLAT_UI
{
    partial class ListaChavesRetiradas
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
            this.bancoBandB = new COMPLETE_FLAT_UI.BancoBandB();
            this.mostrarChaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mostrarChaveTableAdapter = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.MostrarChaveTableAdapter();
            this.tableAdapterManager = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager();
            this.mostrarChaveDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarChaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarChaveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoBandB
            // 
            this.bancoBandB.DataSetName = "BancoBandB";
            this.bancoBandB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mostrarChaveBindingSource
            // 
            this.mostrarChaveBindingSource.DataMember = "MostrarChave";
            this.mostrarChaveBindingSource.DataSource = this.bancoBandB;
            // 
            // mostrarChaveTableAdapter
            // 
            this.mostrarChaveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CADASTRO_LogTableAdapter = null;
            this.tableAdapterManager.CADASTROvisit_LogTableAdapter = null;
            this.tableAdapterManager.CHAVE_LogTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mostrarChaveDataGridView
            // 
            this.mostrarChaveDataGridView.AutoGenerateColumns = false;
            this.mostrarChaveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarChaveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.mostrarChaveDataGridView.DataSource = this.mostrarChaveBindingSource;
            this.mostrarChaveDataGridView.Location = new System.Drawing.Point(12, 28);
            this.mostrarChaveDataGridView.Name = "mostrarChaveDataGridView";
            this.mostrarChaveDataGridView.Size = new System.Drawing.Size(702, 370);
            this.mostrarChaveDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ENTREGUE";
            this.dataGridViewTextBoxColumn2.HeaderText = "AGENTE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RETIRADO";
            this.dataGridViewTextBoxColumn3.HeaderText = "MORADOR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 88;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CHAVES";
            this.dataGridViewTextBoxColumn4.HeaderText = "CHAVES";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TORRE";
            this.dataGridViewTextBoxColumn5.HeaderText = "TORRE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OBSERVACAO";
            this.dataGridViewTextBoxColumn6.HeaderText = "OBSERVACAO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 105;
            // 
            // delete
            // 
            this.delete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete.Location = new System.Drawing.Point(720, 63);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // ListaChavesRetiradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.mostrarChaveDataGridView);
            this.Name = "ListaChavesRetiradas";
            this.Text = "ListaChavesRetiradas";
            this.Load += new System.EventHandler(this.ListaChavesRetiradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarChaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarChaveDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BancoBandB bancoBandB;
        private System.Windows.Forms.BindingSource mostrarChaveBindingSource;
        private BancoBandBTableAdapters.MostrarChaveTableAdapter mostrarChaveTableAdapter;
        private BancoBandBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView mostrarChaveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button delete;
    }
}