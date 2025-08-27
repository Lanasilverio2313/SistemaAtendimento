namespace SistemaAtendimento
{
    partial class FrmCadastroCliente
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
            grdDadosCliente = new GroupBox();
            cbxEstado = new ComboBox();
            lblSituacao = new Label();
            rdbInativo = new RadioButton();
            pnlSituacao = new Panel();
            rdbAtivo = new RadioButton();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            lblNumero = new Label();
            lblEndereço = new Label();
            txtEndereço = new TextBox();
            lblCep = new Label();
            txtCep = new TextBox();
            txtCpfCnpj = new TextBox();
            lblCpfCnpj = new Label();
            pnlTipoPessoa = new Panel();
            rdbJuridica = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            btnEditar = new Button();
            btn = new Button();
            btnExluir = new Button();
            btnCancelar = new Button();
            lblPesquisar = new Label();
            textBox1 = new TextBox();
            btnPesquisar = new Button();
            grbListaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            grdDadosCliente.SuspendLayout();
            pnlSituacao.SuspendLayout();
            pnlTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // grdDadosCliente
            // 
            grdDadosCliente.Controls.Add(cbxEstado);
            grdDadosCliente.Controls.Add(lblSituacao);
            grdDadosCliente.Controls.Add(rdbInativo);
            grdDadosCliente.Controls.Add(pnlSituacao);
            grdDadosCliente.Controls.Add(lblEstado);
            grdDadosCliente.Controls.Add(txtCidade);
            grdDadosCliente.Controls.Add(lblCidade);
            grdDadosCliente.Controls.Add(lblComplemento);
            grdDadosCliente.Controls.Add(txtComplemento);
            grdDadosCliente.Controls.Add(lblBairro);
            grdDadosCliente.Controls.Add(txtBairro);
            grdDadosCliente.Controls.Add(txtNumero);
            grdDadosCliente.Controls.Add(lblNumero);
            grdDadosCliente.Controls.Add(lblEndereço);
            grdDadosCliente.Controls.Add(txtEndereço);
            grdDadosCliente.Controls.Add(lblCep);
            grdDadosCliente.Controls.Add(txtCep);
            grdDadosCliente.Controls.Add(txtCpfCnpj);
            grdDadosCliente.Controls.Add(lblCpfCnpj);
            grdDadosCliente.Controls.Add(pnlTipoPessoa);
            grdDadosCliente.Controls.Add(lblTipoPessoa);
            grdDadosCliente.Controls.Add(txtCelular);
            grdDadosCliente.Controls.Add(lblCelular);
            grdDadosCliente.Controls.Add(lblTelefone);
            grdDadosCliente.Controls.Add(txtTelefone);
            grdDadosCliente.Controls.Add(lblEmail);
            grdDadosCliente.Controls.Add(txtEmail);
            grdDadosCliente.Controls.Add(txtNome);
            grdDadosCliente.Controls.Add(lblNome);
            grdDadosCliente.Controls.Add(txtCodigo);
            grdDadosCliente.Controls.Add(lblCodigo);
            grdDadosCliente.Location = new Point(12, 12);
            grdDadosCliente.Name = "grdDadosCliente";
            grdDadosCliente.Size = new Size(838, 307);
            grdDadosCliente.TabIndex = 0;
            grdDadosCliente.TabStop = false;
            grdDadosCliente.Text = "Dados do  Cliente";
            grdDadosCliente.Enter += groupBox1_Enter;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MS", "MT", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxEstado.Location = new Point(6, 260);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 13;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(199, 243);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 29;
            lblSituacao.Text = "Situaçao";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(254, 264);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(196, 260);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(119, 34);
            pnlSituacao.TabIndex = 14;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(-1, 4);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(6, 243);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 27;
            lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(633, 212);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(199, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(633, 194);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(305, 194);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 23;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(305, 212);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(277, 23);
            txtComplemento.TabIndex = 11;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(8, 193);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 21;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(6, 212);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(259, 23);
            txtBairro.TabIndex = 10;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(633, 155);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(199, 23);
            txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(633, 137);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 18;
            lblNumero.Text = "Numero";
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.Location = new Point(278, 137);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(56, 15);
            lblEndereço.TabIndex = 17;
            lblEndereço.Text = "Endereço";
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(278, 155);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(308, 23);
            txtEndereço.TabIndex = 8;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(6, 136);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 15;
            lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(6, 154);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(231, 23);
            txtCep.TabIndex = 7;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(608, 92);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(224, 23);
            txtCpfCnpj.TabIndex = 6;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(608, 74);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(60, 15);
            lblCpfCnpj.TabIndex = 12;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // pnlTipoPessoa
            // 
            pnlTipoPessoa.Controls.Add(rdbJuridica);
            pnlTipoPessoa.Controls.Add(rdbFisica);
            pnlTipoPessoa.Location = new Point(437, 88);
            pnlTipoPessoa.Name = "pnlTipoPessoa";
            pnlTipoPessoa.Size = new Size(149, 27);
            pnlTipoPessoa.TabIndex = 5;
            pnlTipoPessoa.Paint += pnlTipoPessoa_Paint;
            // 
            // rdbJuridica
            // 
            rdbJuridica.AutoSize = true;
            rdbJuridica.Location = new Point(80, 4);
            rdbJuridica.Name = "rdbJuridica";
            rdbJuridica.Size = new Size(65, 19);
            rdbJuridica.TabIndex = 1;
            rdbJuridica.TabStop = true;
            rdbJuridica.Text = "Juridica";
            rdbJuridica.UseVisualStyleBackColor = true;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Location = new Point(0, 4);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 0;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Fisica";
            rdbFisica.UseVisualStyleBackColor = true;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(437, 70);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(69, 15);
            lblTipoPessoa.TabIndex = 10;
            lblTipoPessoa.Text = "Tipo Pessoa";
            lblTipoPessoa.Click += lblTipoPessoa_Click;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(186, 92);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(203, 23);
            txtCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(186, 74);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(6, 74);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 92);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(163, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(523, 19);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail";
            lblEmail.Click += label1_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(523, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(186, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(186, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            lblNome.Click += label1_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(6, 37);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(131, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(6, 19);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(18, 350);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(106, 350);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Location = new Point(198, 350);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 17;
            btn.Text = "Salvar";
            btn.UseVisualStyleBackColor = true;
            // 
            // btnExluir
            // 
            btnExluir.Location = new Point(279, 350);
            btnExluir.Name = "btnExluir";
            btnExluir.Size = new Size(75, 23);
            btnExluir.TabIndex = 18;
            btnExluir.Text = "Exluir";
            btnExluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(360, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(465, 332);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 6;
            lblPesquisar.Text = "Pesquisar";
            lblPesquisar.Click += lblPesquisar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(465, 350);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(769, 350);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Location = new Point(18, 395);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(826, 223);
            grbListaClientes.TabIndex = 25;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(802, 167);
            dgvClientes.TabIndex = 0;
            // 
            // FrmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 621);
            Controls.Add(grbListaClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(textBox1);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExluir);
            Controls.Add(btn);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grdDadosCliente);
            Name = "FrmCadastroCliente";
            Text = "Cadastro de Clientes";
            grdDadosCliente.ResumeLayout(false);
            grdDadosCliente.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            pnlTipoPessoa.ResumeLayout(false);
            pnlTipoPessoa.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grdDadosCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtCelular;
        private Label lblCelular;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Panel pnlTipoPessoa;
        private Label lblTipoPessoa;
        private Label lblCpfCnpj;
        private RadioButton rdbJuridica;
        private RadioButton rdbFisica;
        private TextBox txtNumero;
        private Label lblNumero;
        private Label lblEndereço;
        private TextBox txtEndereço;
        private Label lblCep;
        private TextBox txtCep;
        private TextBox txtCpfCnpj;
        private Label lblCidade;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblBairro;
        private TextBox txtBairro;
        private Panel pnlSituacao;
        private RadioButton rdbAtivo;
        private Label lblEstado;
        private TextBox txtCidade;
        private Label lblSituacao;
        private RadioButton rdbInativo;
        private ComboBox cbxEstado;
        private Button btnNovo;
        private Button btnEditar;
        private Button btn;
        private Button btnExluir;
        private Button btnCancelar;
        private Label lblPesquisar;
        private TextBox textBox1;
        private Button btnPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgvClientes;
    }
}