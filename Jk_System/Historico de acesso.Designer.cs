namespace COMPLETE_FLAT_UI
{
    partial class Historico_de_acesso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.login = new COMPLETE_FLAT_UI.Login();
            this.login_logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_logTableAdapter = new COMPLETE_FLAT_UI.LoginTableAdapters.Login_logTableAdapter();
            this.tableAdapterManager = new COMPLETE_FLAT_UI.LoginTableAdapters.TableAdapterManager();
            this.loginlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoLocalhost = new COMPLETE_FLAT_UI.BancoLocalhost();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.pesquisa = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.login_logTableAdapter1 = new COMPLETE_FLAT_UI.BancoLocalhostTableAdapters.Login_logTableAdapter();
            this.loginlogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginlogBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.loginlogBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dtAtualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hostname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLocalhost)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.DataSetName = "Login";
            this.login.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // login_logBindingSource
            // 
            this.login_logBindingSource.DataMember = "Login_log";
            this.login_logBindingSource.DataSource = this.login;
            // 
            // login_logTableAdapter
            // 
            this.login_logTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Login_logTableAdapter = this.login_logTableAdapter;
            this.tableAdapterManager.UpdateOrder = COMPLETE_FLAT_UI.LoginTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loginlogBindingSource
            // 
            this.loginlogBindingSource.DataMember = "Login_log";
            this.loginlogBindingSource.DataSource = this.login;
            // 
            // bancoLocalhost
            // 
            this.bancoLocalhost.DataSetName = "BancoLocalhost";
            this.bancoLocalhost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(181, 71);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(383, 30);
            this.txtPesquisa.TabIndex = 9;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // pesquisa
            // 
            this.pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pesquisa.Cursor = System.Windows.Forms.Cursors.Default;
            this.pesquisa.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.pesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.pesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisa.ForeColor = System.Drawing.Color.Silver;
            this.pesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pesquisa.Location = new System.Drawing.Point(559, 71);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(100, 30);
            this.pesquisa.TabIndex = 10;
            this.pesquisa.Text = "PESQUISAR";
            this.pesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pesquisa.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(616, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Black;
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(870, 38);
            this.BarraTitulo.TabIndex = 12;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(197, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "HISTORICOS DE ACESSOS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::COMPLETE_FLAT_UI.Properties.Resources.Close;
            this.button1.Location = new System.Drawing.Point(665, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_logTableAdapter1
            // 
            this.login_logTableAdapter1.ClearBeforeFill = true;
            // 
            // loginlogBindingSource1
            // 
            this.loginlogBindingSource1.DataMember = "Login_log";
            this.loginlogBindingSource1.DataSource = this.bancoLocalhost;
            // 
            // loginlogBindingSource3
            // 
            this.loginlogBindingSource3.DataMember = "Login_log";
            this.loginlogBindingSource3.DataSource = this.bancoLocalhost;
            // 
            // loginlogBindingSource2
            // 
            this.loginlogBindingSource2.DataMember = "Login_log";
            this.loginlogBindingSource2.DataSource = this.bancoLocalhost;
            // 
            // dtAtualizacaoDataGridViewTextBoxColumn
            // 
            this.dtAtualizacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtAtualizacaoDataGridViewTextBoxColumn.DataPropertyName = "Dt_Atualizacao";
            this.dtAtualizacaoDataGridViewTextBoxColumn.HeaderText = "DATA E HORA";
            this.dtAtualizacaoDataGridViewTextBoxColumn.Name = "dtAtualizacaoDataGridViewTextBoxColumn";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // ACAO
            // 
            this.ACAO.DataPropertyName = "ACAO";
            this.ACAO.HeaderText = "ACAO";
            this.ACAO.Name = "ACAO";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn1.HeaderText = "Login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Hostname
            // 
            this.Hostname.DataPropertyName = "Hostname";
            this.Hostname.HeaderText = "Hostname";
            this.Hostname.Name = "Hostname";
            // 
            // aCAODataGridViewTextBoxColumn
            // 
            this.aCAODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aCAODataGridViewTextBoxColumn.DataPropertyName = "ACAO";
            this.aCAODataGridViewTextBoxColumn.HeaderText = "ACAO";
            this.aCAODataGridViewTextBoxColumn.Name = "aCAODataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCAODataGridViewTextBoxColumn,
            this.Hostname,
            this.dataGridViewTextBoxColumn1,
            this.ACAO,
            this.NOME,
            this.dtAtualizacaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginlogBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(636, 329);
            this.dataGridView1.TabIndex = 3;
            // 
            // Historico_de_acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(870, 453);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historico_de_acesso";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico_de_acesso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Historico_de_acesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoLocalhost)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginlogBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Login login;
        private System.Windows.Forms.BindingSource login_logBindingSource;
        private LoginTableAdapters.Login_logTableAdapter login_logTableAdapter;
        private LoginTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource loginlogBindingSource;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button pesquisa;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private BancoLocalhost bancoLocalhost;
        private BancoLocalhostTableAdapters.Login_logTableAdapter login_logTableAdapter1;
        private System.Windows.Forms.BindingSource loginlogBindingSource1;
        private System.Windows.Forms.BindingSource loginlogBindingSource3;
        private System.Windows.Forms.BindingSource loginlogBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtAtualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hostname;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}