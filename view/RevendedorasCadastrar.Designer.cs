
namespace ControleRevendaWF.view
{
    partial class RevendedorasCadastrar
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.gridCatalogos = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tableConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.flowNome = new System.Windows.Forms.FlowLayoutPanel();
            this.flowSobrenome = new System.Windows.Forms.FlowLayoutPanel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogos)).BeginInit();
            this.tableConteudo.SuspendLayout();
            this.flowNome.SuspendLayout();
            this.flowSobrenome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(3, 16);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(255, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(3, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // gridCatalogos
            // 
            this.gridCatalogos.AllowUserToAddRows = false;
            this.gridCatalogos.AllowUserToDeleteRows = false;
            this.gridCatalogos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCatalogos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridCatalogos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridCatalogos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCatalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCatalogos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Catalogo,
            this.Porcentagem});
            this.gridCatalogos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCatalogos.Location = new System.Drawing.Point(3, 113);
            this.gridCatalogos.Name = "gridCatalogos";
            this.gridCatalogos.Size = new System.Drawing.Size(794, 300);
            this.gridCatalogos.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 419);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 24);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tableConteudo
            // 
            this.tableConteudo.ColumnCount = 1;
            this.tableConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableConteudo.Controls.Add(this.flowNome, 0, 0);
            this.tableConteudo.Controls.Add(this.btnSalvar, 0, 3);
            this.tableConteudo.Controls.Add(this.flowSobrenome, 0, 1);
            this.tableConteudo.Controls.Add(this.gridCatalogos, 0, 2);
            this.tableConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableConteudo.Location = new System.Drawing.Point(0, 0);
            this.tableConteudo.Name = "tableConteudo";
            this.tableConteudo.RowCount = 4;
            this.tableConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tableConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.45221F));
            this.tableConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.42657F));
            this.tableConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableConteudo.Size = new System.Drawing.Size(800, 450);
            this.tableConteudo.TabIndex = 6;
            // 
            // flowNome
            // 
            this.flowNome.Controls.Add(this.lblNome);
            this.flowNome.Controls.Add(this.txtNome);
            this.flowNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowNome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowNome.Location = new System.Drawing.Point(3, 3);
            this.flowNome.Name = "flowNome";
            this.flowNome.Size = new System.Drawing.Size(794, 44);
            this.flowNome.TabIndex = 0;
            // 
            // flowSobrenome
            // 
            this.flowSobrenome.Controls.Add(this.lblSobrenome);
            this.flowSobrenome.Controls.Add(this.txtSobrenome);
            this.flowSobrenome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSobrenome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSobrenome.Location = new System.Drawing.Point(3, 53);
            this.flowSobrenome.Name = "flowSobrenome";
            this.flowSobrenome.Size = new System.Drawing.Size(794, 54);
            this.flowSobrenome.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 41;
            // 
            // Catalogo
            // 
            this.Catalogo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Catalogo.HeaderText = "Catalogo";
            this.Catalogo.Name = "Catalogo";
            this.Catalogo.ReadOnly = true;
            this.Catalogo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Catalogo.Width = 74;
            // 
            // Porcentagem
            // 
            this.Porcentagem.HeaderText = "Porcentagem";
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Width = 95;
            // 
            // RevendedorasCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableConteudo);
            this.Name = "RevendedorasCadastrar";
            this.Text = "RevendedorasCadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.gridCatalogos)).EndInit();
            this.tableConteudo.ResumeLayout(false);
            this.flowNome.ResumeLayout(false);
            this.flowNome.PerformLayout();
            this.flowSobrenome.ResumeLayout(false);
            this.flowSobrenome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.DataGridView gridCatalogos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TableLayoutPanel tableConteudo;
        private System.Windows.Forms.FlowLayoutPanel flowNome;
        private System.Windows.Forms.FlowLayoutPanel flowSobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentagem;
    }
}