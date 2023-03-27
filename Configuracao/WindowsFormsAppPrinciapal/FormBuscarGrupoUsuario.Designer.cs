namespace WindowsFormsAppPrinciapal
{
    partial class FormBuscarGrupoUsuario
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
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBuscarGU = new System.Windows.Forms.Button();
            this.buttonAlterarGU = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAdicionarGU = new System.Windows.Forms.Button();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonExcluirGU = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(12, 68);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(610, 394);
            this.grupoUsuarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 47;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do grupo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 187;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(641, 68);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.Size = new System.Drawing.Size(517, 394);
            this.permissoesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 47;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 187;
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // buttonBuscarGU
            // 
            this.buttonBuscarGU.Location = new System.Drawing.Point(304, 39);
            this.buttonBuscarGU.Name = "buttonBuscarGU";
            this.buttonBuscarGU.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarGU.TabIndex = 2;
            this.buttonBuscarGU.Text = "Buscar";
            this.buttonBuscarGU.UseVisualStyleBackColor = true;
            this.buttonBuscarGU.Click += new System.EventHandler(this.buttonBuscarGU_Click);
            // 
            // buttonAlterarGU
            // 
            this.buttonAlterarGU.Location = new System.Drawing.Point(385, 39);
            this.buttonAlterarGU.Name = "buttonAlterarGU";
            this.buttonAlterarGU.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarGU.TabIndex = 2;
            this.buttonAlterarGU.Text = "Alterar";
            this.buttonAlterarGU.UseVisualStyleBackColor = true;
            this.buttonAlterarGU.Click += new System.EventHandler(this.buttonAlterarGU_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarGU
            // 
            this.buttonAdicionarGU.Location = new System.Drawing.Point(466, 39);
            this.buttonAdicionarGU.Name = "buttonAdicionarGU";
            this.buttonAdicionarGU.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarGU.TabIndex = 2;
            this.buttonAdicionarGU.Text = "Adicionar";
            this.buttonAdicionarGU.UseVisualStyleBackColor = true;
            this.buttonAdicionarGU.Click += new System.EventHandler(this.buttonAdicionarGU_Click);
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(1083, 40);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPermissao.TabIndex = 2;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.UseVisualStyleBackColor = true;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissao_Click);
            // 
            // buttonExcluirGU
            // 
            this.buttonExcluirGU.Location = new System.Drawing.Point(547, 39);
            this.buttonExcluirGU.Name = "buttonExcluirGU";
            this.buttonExcluirGU.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirGU.TabIndex = 2;
            this.buttonExcluirGU.Text = "Excluir";
            this.buttonExcluirGU.UseVisualStyleBackColor = true;
            this.buttonExcluirGU.Click += new System.EventHandler(this.buttonExcluirGU_Click);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(1002, 39);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissao.TabIndex = 2;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 3;
            // 
            // FormBuscarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 548);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAdicionarGU);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.buttonExcluirGU);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAlterarGU);
            this.Controls.Add(this.buttonBuscarGU);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de grupos de usuário";
            this.Load += new System.EventHandler(this.FormBuscarGrupoUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBuscarGrupoUsuario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.Button buttonBuscarGU;
        private System.Windows.Forms.Button buttonAlterarGU;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonAdicionarGU;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonExcluirGU;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}