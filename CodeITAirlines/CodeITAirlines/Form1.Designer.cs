using CodeITAirlines.Models.DTO;

namespace CodeITAirlines
{
    partial class CodeITAirlines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpTerminal = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnDefinePassageiro = new System.Windows.Forms.Button();
            this.btnEmbarcar = new System.Windows.Forms.Button();
            this.btnDefinePiloto = new System.Windows.Forms.Button();
            this.dataGridTerminal = new System.Windows.Forms.DataGridView();
            this.pessoaDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpAviao = new System.Windows.Forms.GroupBox();
            this.btnDefinePassageiroVolta = new System.Windows.Forms.Button();
            this.btnCancelarVolta = new System.Windows.Forms.Button();
            this.dataGridAviao = new System.Windows.Forms.DataGridView();
            this.btnConfirmarVolta = new System.Windows.Forms.Button();
            this.btnDefinePilotoVolta = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPessoaFisicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoTripulacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColorAviao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPessoaFisicaIdAviao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeAviao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFuncaoAviao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrupoTripulacaoAviao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTerminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDTOBindingSource)).BeginInit();
            this.grpAviao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAviao)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTerminal
            // 
            this.grpTerminal.Controls.Add(this.btnCancelar);
            this.grpTerminal.Controls.Add(this.btnConfirmar);
            this.grpTerminal.Controls.Add(this.btnDefinePassageiro);
            this.grpTerminal.Controls.Add(this.btnEmbarcar);
            this.grpTerminal.Controls.Add(this.btnDefinePiloto);
            this.grpTerminal.Controls.Add(this.dataGridTerminal);
            this.grpTerminal.Location = new System.Drawing.Point(9, 10);
            this.grpTerminal.Margin = new System.Windows.Forms.Padding(2);
            this.grpTerminal.Name = "grpTerminal";
            this.grpTerminal.Padding = new System.Windows.Forms.Padding(2);
            this.grpTerminal.Size = new System.Drawing.Size(357, 280);
            this.grpTerminal.TabIndex = 7;
            this.grpTerminal.TabStop = false;
            this.grpTerminal.Text = "Terminal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 53);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 19);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(226, 53);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(62, 19);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnDefinePassageiro
            // 
            this.btnDefinePassageiro.Location = new System.Drawing.Point(109, 53);
            this.btnDefinePassageiro.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefinePassageiro.Name = "btnDefinePassageiro";
            this.btnDefinePassageiro.Size = new System.Drawing.Size(100, 19);
            this.btnDefinePassageiro.TabIndex = 8;
            this.btnDefinePassageiro.Text = "Definir Passageiro";
            this.btnDefinePassageiro.UseVisualStyleBackColor = true;
            this.btnDefinePassageiro.Click += new System.EventHandler(this.btnDefinePassageiro_Click);
            // 
            // btnEmbarcar
            // 
            this.btnEmbarcar.Location = new System.Drawing.Point(164, 17);
            this.btnEmbarcar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmbarcar.Name = "btnEmbarcar";
            this.btnEmbarcar.Size = new System.Drawing.Size(185, 19);
            this.btnEmbarcar.TabIndex = 6;
            this.btnEmbarcar.Text = "Embarcar com Smart Fortwo";
            this.btnEmbarcar.UseVisualStyleBackColor = true;
            this.btnEmbarcar.Click += new System.EventHandler(this.btnEmbarcar_Click);
            // 
            // btnDefinePiloto
            // 
            this.btnDefinePiloto.Location = new System.Drawing.Point(4, 53);
            this.btnDefinePiloto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefinePiloto.Name = "btnDefinePiloto";
            this.btnDefinePiloto.Size = new System.Drawing.Size(100, 19);
            this.btnDefinePiloto.TabIndex = 7;
            this.btnDefinePiloto.Text = "Definir  Piloto";
            this.btnDefinePiloto.UseVisualStyleBackColor = true;
            this.btnDefinePiloto.Click += new System.EventHandler(this.btnDefinirPiloto_Click);
            // 
            // dataGridTerminal
            // 
            this.dataGridTerminal.AllowUserToAddRows = false;
            this.dataGridTerminal.AllowUserToDeleteRows = false;
            this.dataGridTerminal.AutoGenerateColumns = false;
            this.dataGridTerminal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTerminal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColor,
            this.colPessoaFisicaId,
            this.colNome,
            this.funcaoDataGridViewTextBoxColumn,
            this.grupoTripulacaoDataGridViewTextBoxColumn});
            this.dataGridTerminal.DataSource = this.pessoaDTOBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTerminal.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTerminal.Location = new System.Drawing.Point(4, 76);
            this.dataGridTerminal.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridTerminal.MultiSelect = false;
            this.dataGridTerminal.Name = "dataGridTerminal";
            this.dataGridTerminal.ReadOnly = true;
            this.dataGridTerminal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridTerminal.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridTerminal.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTerminal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridTerminal.RowTemplate.Height = 24;
            this.dataGridTerminal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTerminal.Size = new System.Drawing.Size(345, 199);
            this.dataGridTerminal.TabIndex = 5;
            // 
            // pessoaDTOBindingSource
            // 
            this.pessoaDTOBindingSource.DataSource = typeof(PessoaDTO);
            // 
            // grpAviao
            // 
            this.grpAviao.Controls.Add(this.btnDefinePassageiroVolta);
            this.grpAviao.Controls.Add(this.btnCancelarVolta);
            this.grpAviao.Controls.Add(this.dataGridAviao);
            this.grpAviao.Controls.Add(this.btnConfirmarVolta);
            this.grpAviao.Controls.Add(this.btnDefinePilotoVolta);
            this.grpAviao.Controls.Add(this.btnVoltar);
            this.grpAviao.Location = new System.Drawing.Point(370, 11);
            this.grpAviao.Margin = new System.Windows.Forms.Padding(2);
            this.grpAviao.Name = "grpAviao";
            this.grpAviao.Padding = new System.Windows.Forms.Padding(2);
            this.grpAviao.Size = new System.Drawing.Size(363, 280);
            this.grpAviao.TabIndex = 8;
            this.grpAviao.TabStop = false;
            this.grpAviao.Text = "Aviao";
            // 
            // btnDefinePassageiroVolta
            // 
            this.btnDefinePassageiroVolta.Location = new System.Drawing.Point(109, 53);
            this.btnDefinePassageiroVolta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefinePassageiroVolta.Name = "btnDefinePassageiroVolta";
            this.btnDefinePassageiroVolta.Size = new System.Drawing.Size(100, 19);
            this.btnDefinePassageiroVolta.TabIndex = 13;
            this.btnDefinePassageiroVolta.Text = "Definir Passageiro";
            this.btnDefinePassageiroVolta.UseVisualStyleBackColor = true;
            this.btnDefinePassageiroVolta.Click += new System.EventHandler(this.btnDefinePassageiroVolta_Click);
            // 
            // btnCancelarVolta
            // 
            this.btnCancelarVolta.Location = new System.Drawing.Point(298, 53);
            this.btnCancelarVolta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarVolta.Name = "btnCancelarVolta";
            this.btnCancelarVolta.Size = new System.Drawing.Size(56, 19);
            this.btnCancelarVolta.TabIndex = 12;
            this.btnCancelarVolta.Text = "Cancelar";
            this.btnCancelarVolta.UseVisualStyleBackColor = true;
            this.btnCancelarVolta.Click += new System.EventHandler(this.btnCancelarVolta_Click);
            // 
            // dataGridAviao
            // 
            this.dataGridAviao.AllowUserToAddRows = false;
            this.dataGridAviao.AllowUserToDeleteRows = false;
            this.dataGridAviao.AutoGenerateColumns = false;
            this.dataGridAviao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridAviao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAviao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColorAviao,
            this.colPessoaFisicaIdAviao,
            this.colNomeAviao,
            this.colFuncaoAviao,
            this.colGrupoTripulacaoAviao});
            this.dataGridAviao.DataSource = this.pessoaDTOBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAviao.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridAviao.Location = new System.Drawing.Point(4, 76);
            this.dataGridAviao.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAviao.MultiSelect = false;
            this.dataGridAviao.Name = "dataGridAviao";
            this.dataGridAviao.ReadOnly = true;
            this.dataGridAviao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAviao.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dataGridAviao.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridAviao.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridAviao.RowTemplate.Height = 24;
            this.dataGridAviao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAviao.Size = new System.Drawing.Size(350, 199);
            this.dataGridAviao.TabIndex = 11;
            // 
            // btnConfirmarVolta
            // 
            this.btnConfirmarVolta.Enabled = false;
            this.btnConfirmarVolta.Location = new System.Drawing.Point(231, 53);
            this.btnConfirmarVolta.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarVolta.Name = "btnConfirmarVolta";
            this.btnConfirmarVolta.Size = new System.Drawing.Size(62, 19);
            this.btnConfirmarVolta.TabIndex = 10;
            this.btnConfirmarVolta.Text = "Confirmar";
            this.btnConfirmarVolta.UseVisualStyleBackColor = true;
            this.btnConfirmarVolta.Click += new System.EventHandler(this.btnConfirmaVolta_Click);
            // 
            // btnDefinePilotoVolta
            // 
            this.btnDefinePilotoVolta.Location = new System.Drawing.Point(4, 53);
            this.btnDefinePilotoVolta.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefinePilotoVolta.Name = "btnDefinePilotoVolta";
            this.btnDefinePilotoVolta.Size = new System.Drawing.Size(100, 19);
            this.btnDefinePilotoVolta.TabIndex = 9;
            this.btnDefinePilotoVolta.Text = "Definir  Piloto";
            this.btnDefinePilotoVolta.UseVisualStyleBackColor = true;
            this.btnDefinePilotoVolta.Click += new System.EventHandler(this.btnDefinePilotoVolta_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(298, 17);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(56, 19);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Realizar Voo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // colColor
            // 
            this.colColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colColor.HeaderText = "";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            this.colColor.Width = 30;
            // 
            // colPessoaFisicaId
            // 
            this.colPessoaFisicaId.DataPropertyName = "PessoaFisicaId";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.colPessoaFisicaId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPessoaFisicaId.HeaderText = "PessoaFisicaId";
            this.colPessoaFisicaId.Name = "colPessoaFisicaId";
            this.colPessoaFisicaId.ReadOnly = true;
            this.colPessoaFisicaId.Visible = false;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // funcaoDataGridViewTextBoxColumn
            // 
            this.funcaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "Funcao";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.funcaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.funcaoDataGridViewTextBoxColumn.HeaderText = "Funcao";
            this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
            this.funcaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoTripulacaoDataGridViewTextBoxColumn
            // 
            this.grupoTripulacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.grupoTripulacaoDataGridViewTextBoxColumn.DataPropertyName = "GrupoTripulacao";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.grupoTripulacaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.grupoTripulacaoDataGridViewTextBoxColumn.HeaderText = "GrupoTripulacao";
            this.grupoTripulacaoDataGridViewTextBoxColumn.Name = "grupoTripulacaoDataGridViewTextBoxColumn";
            this.grupoTripulacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colColorAviao
            // 
            this.colColorAviao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colColorAviao.HeaderText = "";
            this.colColorAviao.Name = "colColorAviao";
            this.colColorAviao.ReadOnly = true;
            this.colColorAviao.Width = 30;
            // 
            // colPessoaFisicaIdAviao
            // 
            this.colPessoaFisicaIdAviao.DataPropertyName = "PessoaFisicaId";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.colPessoaFisicaIdAviao.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPessoaFisicaIdAviao.HeaderText = "PessoaFisicaId";
            this.colPessoaFisicaIdAviao.Name = "colPessoaFisicaIdAviao";
            this.colPessoaFisicaIdAviao.ReadOnly = true;
            this.colPessoaFisicaIdAviao.Visible = false;
            // 
            // colNomeAviao
            // 
            this.colNomeAviao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNomeAviao.DataPropertyName = "Nome";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.colNomeAviao.DefaultCellStyle = dataGridViewCellStyle8;
            this.colNomeAviao.HeaderText = "Nome";
            this.colNomeAviao.Name = "colNomeAviao";
            this.colNomeAviao.ReadOnly = true;
            // 
            // colFuncaoAviao
            // 
            this.colFuncaoAviao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFuncaoAviao.DataPropertyName = "Funcao";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.colFuncaoAviao.DefaultCellStyle = dataGridViewCellStyle9;
            this.colFuncaoAviao.HeaderText = "Funcao";
            this.colFuncaoAviao.Name = "colFuncaoAviao";
            this.colFuncaoAviao.ReadOnly = true;
            // 
            // colGrupoTripulacaoAviao
            // 
            this.colGrupoTripulacaoAviao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGrupoTripulacaoAviao.DataPropertyName = "GrupoTripulacao";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.colGrupoTripulacaoAviao.DefaultCellStyle = dataGridViewCellStyle10;
            this.colGrupoTripulacaoAviao.HeaderText = "GrupoTripulacao";
            this.colGrupoTripulacaoAviao.Name = "colGrupoTripulacaoAviao";
            this.colGrupoTripulacaoAviao.ReadOnly = true;
            // 
            // CodeITAirlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpAviao);
            this.Controls.Add(this.grpTerminal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CodeITAirlines";
            this.Text = "CodeITAirlines";
            this.Load += new System.EventHandler(this.CodeITAirlines_Load);
            this.grpTerminal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDTOBindingSource)).EndInit();
            this.grpAviao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAviao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource pessoaDTOBindingSource;
        private System.Windows.Forms.GroupBox grpTerminal;
        private System.Windows.Forms.Button btnEmbarcar;
        private System.Windows.Forms.DataGridView dataGridTerminal;
        private System.Windows.Forms.GroupBox grpAviao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripulanteIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passageiroIdEmbarcada;
        private System.Windows.Forms.Button btnDefinePassageiro;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnDefinePiloto;
        private System.Windows.Forms.DataGridView dataGridAviao;
        private System.Windows.Forms.Button btnConfirmarVolta;
        private System.Windows.Forms.Button btnDefinePilotoVolta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDefinePassageiroVolta;
        private System.Windows.Forms.Button btnCancelarVolta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPessoaFisicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoTripulacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColorAviao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPessoaFisicaIdAviao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeAviao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuncaoAviao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrupoTripulacaoAviao;
    }
}

