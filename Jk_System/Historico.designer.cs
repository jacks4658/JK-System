namespace COMPLETE_FLAT_UI
{
    partial class FormHistrorico
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
            this.tableAdapterManager2 = new COMPLETE_FLAT_UI.BancoDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cADASTRO_LogTableAdapter4 = new COMPLETE_FLAT_UI.BancoLocalhostTableAdapters.CADASTRO_LogTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavePdf = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mostrarCadastroTableAdapter = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.MostrarCadastroTableAdapter();
            this.bancoBandB = new COMPLETE_FLAT_UI.BancoBandB();
            this.cADASTRO_LogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADASTRO_LogTableAdapter = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.CADASTRO_LogTableAdapter();
            this.tableAdapterManager = new COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager();
            this.cADASTRO_LogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADASTROLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_LogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_LogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROLogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.CADASTRO_LogTableAdapter = null;
            this.tableAdapterManager2.CADASTRO_VISITANTETableAdapter = null;
            this.tableAdapterManager2.CADASTROTableAdapter = null;
            this.tableAdapterManager2.CADASTROvisit_LogTableAdapter = null;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.Login_logTableAdapter = null;
            this.tableAdapterManager2.LOGINARMAZENATableAdapter = null;
            this.tableAdapterManager2.LOGINTableAdapter = null;
            this.tableAdapterManager2.MORADORTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = COMPLETE_FLAT_UI.BancoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cADASTRO_LogDataGridView);
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 500);
            this.panel1.TabIndex = 24;
            // 
            // cADASTRO_LogTableAdapter4
            // 
            this.cADASTRO_LogTableAdapter4.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(397, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "HISTORICO DE TODAS ENTREGAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSavePdf
            // 
            this.btnSavePdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.btnSavePdf.CausesValidation = false;
            this.btnSavePdf.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSavePdf.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSavePdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnSavePdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnSavePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePdf.ForeColor = System.Drawing.Color.Black;
            this.btnSavePdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePdf.Location = new System.Drawing.Point(991, 3);
            this.btnSavePdf.Name = "btnSavePdf";
            this.btnSavePdf.Size = new System.Drawing.Size(95, 33);
            this.btnSavePdf.TabIndex = 21;
            this.btnSavePdf.Text = "Salvar Pdf";
            this.btnSavePdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePdf.UseVisualStyleBackColor = false;
            this.btnSavePdf.Click += new System.EventHandler(this.btnSavePdf_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(3, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(50, 17);
            this.BtnCerrar.TabIndex = 22;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.BtnCerrar);
            this.panel2.Controls.Add(this.btnSavePdf);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 38);
            this.panel2.TabIndex = 24;
            // 
            // mostrarCadastroTableAdapter
            // 
            this.mostrarCadastroTableAdapter.ClearBeforeFill = true;
            // 
            // bancoBandB
            // 
            this.bancoBandB.DataSetName = "BancoBandB";
            this.bancoBandB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADASTRO_LogBindingSource
            // 
            this.cADASTRO_LogBindingSource.DataMember = "CADASTRO_Log";
            this.cADASTRO_LogBindingSource.DataSource = this.bancoBandB;
            // 
            // cADASTRO_LogTableAdapter
            // 
            this.cADASTRO_LogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CADASTRO_LogTableAdapter = this.cADASTRO_LogTableAdapter;
            this.tableAdapterManager.CADASTROvisit_LogTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COMPLETE_FLAT_UI.BancoBandBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cADASTRO_LogDataGridView
            // 
            this.cADASTRO_LogDataGridView.AllowUserToAddRows = false;
            this.cADASTRO_LogDataGridView.AllowUserToDeleteRows = false;
            this.cADASTRO_LogDataGridView.AutoGenerateColumns = false;
            this.cADASTRO_LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cADASTRO_LogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.cADASTRO_LogDataGridView.DataSource = this.cADASTROLogBindingSource;
            this.cADASTRO_LogDataGridView.Location = new System.Drawing.Point(3, 3);
            this.cADASTRO_LogDataGridView.Name = "cADASTRO_LogDataGridView";
            this.cADASTRO_LogDataGridView.ReadOnly = true;
            this.cADASTRO_LogDataGridView.Size = new System.Drawing.Size(1092, 437);
            this.cADASTRO_LogDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_LOG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_LOG";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dt_Atualizacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dt_Atualizacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn3.HeaderText = "Login";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Hostname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Hostname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ACAO";
            this.dataGridViewTextBoxColumn5.HeaderText = "ACAO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RECEBIDO";
            this.dataGridViewTextBoxColumn7.HeaderText = "RECEBIDO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CODIGO";
            this.dataGridViewTextBoxColumn8.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn9.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DESCRICAO";
            this.dataGridViewTextBoxColumn10.HeaderText = "DESCRICAO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PROPRIETARIO";
            this.dataGridViewTextBoxColumn11.HeaderText = "PROPRIETARIO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // cADASTROLogBindingSource
            // 
            this.cADASTROLogBindingSource.DataMember = "CADASTRO_Log";
            this.cADASTROLogBindingSource.DataSource = this.bancoBandB;
            // 
            // FormHistrorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1098, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormHistrorico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBandB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_LogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTRO_LogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADASTROLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BancoDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Panel panel1;
        private BancoLocalhostTableAdapters.CADASTRO_LogTableAdapter cADASTRO_LogTableAdapter4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePdf;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel2;
        private BancoBandBTableAdapters.MostrarCadastroTableAdapter mostrarCadastroTableAdapter;
        private BancoBandB bancoBandB;
        private System.Windows.Forms.BindingSource cADASTRO_LogBindingSource;
        private BancoBandBTableAdapters.CADASTRO_LogTableAdapter cADASTRO_LogTableAdapter;
        private BancoBandBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cADASTRO_LogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource cADASTROLogBindingSource;
    }
}