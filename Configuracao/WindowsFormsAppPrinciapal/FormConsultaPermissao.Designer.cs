﻿namespace WindowsFormsAppPrinciapal
{
    partial class FormConsultaPermissao
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
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancelarPe = new System.Windows.Forms.Button();
            this.buttonSelecionarPe = new System.Windows.Forms.Button();
            this.buttonBuscarPe = new System.Windows.Forms.Button();
            this.textBoxBuscarPermissao = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 113);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(776, 303);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // buttonCancelarPe
            // 
            this.buttonCancelarPe.Location = new System.Drawing.Point(711, 422);
            this.buttonCancelarPe.Name = "buttonCancelarPe";
            this.buttonCancelarPe.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarPe.TabIndex = 2;
            this.buttonCancelarPe.Text = "Cancelar";
            this.buttonCancelarPe.UseVisualStyleBackColor = true;
            this.buttonCancelarPe.Click += new System.EventHandler(this.buttonCancelarPe_Click);
            // 
            // buttonSelecionarPe
            // 
            this.buttonSelecionarPe.Location = new System.Drawing.Point(612, 422);
            this.buttonSelecionarPe.Name = "buttonSelecionarPe";
            this.buttonSelecionarPe.Size = new System.Drawing.Size(93, 23);
            this.buttonSelecionarPe.TabIndex = 2;
            this.buttonSelecionarPe.Text = "Selecionar";
            this.buttonSelecionarPe.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarPe
            // 
            this.buttonBuscarPe.Location = new System.Drawing.Point(711, 84);
            this.buttonBuscarPe.Name = "buttonBuscarPe";
            this.buttonBuscarPe.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPe.TabIndex = 2;
            this.buttonBuscarPe.Text = "Buscar";
            this.buttonBuscarPe.UseVisualStyleBackColor = true;
            this.buttonBuscarPe.Click += new System.EventHandler(this.buttonBuscarPe_Click);
            // 
            // textBoxBuscarPermissao
            // 
            this.textBoxBuscarPermissao.Location = new System.Drawing.Point(12, 84);
            this.textBoxBuscarPermissao.Name = "textBoxBuscarPermissao";
            this.textBoxBuscarPermissao.Size = new System.Drawing.Size(693, 22);
            this.textBoxBuscarPermissao.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consultar Permissões";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informe o nome da permissão";
            // 
            // FormConsultaPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscarPermissao);
            this.Controls.Add(this.buttonBuscarPe);
            this.Controls.Add(this.buttonSelecionarPe);
            this.Controls.Add(this.buttonCancelarPe);
            this.Controls.Add(this.permissaoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaPermissao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultaPermissao";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.Button buttonCancelarPe;
        private System.Windows.Forms.Button buttonSelecionarPe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonBuscarPe;
        private System.Windows.Forms.TextBox textBoxBuscarPermissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}