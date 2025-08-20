namespace Sistema_Atendimento
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuTelaPrincipal = new MenuStrip();
            cadastrsToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            etapasToolStripMenuItem = new ToolStripMenuItem();
            statusToolStripMenuItem = new ToolStripMenuItem();
            atendimentoToolStripMenuItem = new ToolStripMenuItem();
            sistemasToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            novoAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            mnuTelaPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTelaPrincipal
            // 
            mnuTelaPrincipal.Items.AddRange(new ToolStripItem[] { cadastrsToolStripMenuItem, atendimentoToolStripMenuItem, sistemasToolStripMenuItem });
            mnuTelaPrincipal.Location = new Point(0, 0);
            mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            mnuTelaPrincipal.Size = new Size(800, 24);
            mnuTelaPrincipal.TabIndex = 0;
            mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // cadastrsToolStripMenuItem
            // 
            cadastrsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, usuáriosToolStripMenuItem, etapasToolStripMenuItem, statusToolStripMenuItem });
            cadastrsToolStripMenuItem.Name = "cadastrsToolStripMenuItem";
            cadastrsToolStripMenuItem.Size = new Size(71, 20);
            cadastrsToolStripMenuItem.Text = "Cadastros";

            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(184, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(184, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // etapasToolStripMenuItem
            // 
            etapasToolStripMenuItem.Name = "etapasToolStripMenuItem";
            etapasToolStripMenuItem.Size = new Size(184, 22);
            etapasToolStripMenuItem.Text = "Etapas";
            // 
            // statusToolStripMenuItem
            // 
            statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            statusToolStripMenuItem.Size = new Size(184, 22);
            statusToolStripMenuItem.Text = "Status Atendimentos";
            // 
            // atendimentoToolStripMenuItem
            // 
            atendimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAtendimentoToolStripMenuItem, consultasToolStripMenuItem });
            atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            atendimentoToolStripMenuItem.Size = new Size(94, 20);
            atendimentoToolStripMenuItem.Text = "Atendimentos";
            // 
            // sistemasToolStripMenuItem
            // 
            sistemasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem });
            sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            sistemasToolStripMenuItem.Size = new Size(60, 20);
            sistemasToolStripMenuItem.Text = "Sistema";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(180, 22);
            sistemaToolStripMenuItem.Text = "Sair";
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            novoAtendimentoToolStripMenuItem.Size = new Size(180, 22);
            novoAtendimentoToolStripMenuItem.Text = "Novo Atendimento";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(180, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuTelaPrincipal);
            MainMenuStrip = mnuTelaPrincipal;
            Name = "FrmTelaPrincipal";
            Text = "Sistema de Atendimento";
            mnuTelaPrincipal.ResumeLayout(false);
            mnuTelaPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuTelaPrincipal;
        private ToolStripMenuItem cadastrsToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem etapasToolStripMenuItem;
        private ToolStripMenuItem statusToolStripMenuItem;
        private ToolStripMenuItem atendimentoToolStripMenuItem;
        private ToolStripMenuItem sistemasToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
    }
}
