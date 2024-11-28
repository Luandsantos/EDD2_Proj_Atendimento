namespace Projeto_Atendimento
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_gerar = new System.Windows.Forms.Button();
            this.btn_chamar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_listar_senhas = new System.Windows.Forms.Button();
            this.btn_listar_atendimentos = new System.Windows.Forms.Button();
            this.rTxtBox_parcial = new System.Windows.Forms.RichTextBox();
            this.label_quantidade_guiche = new System.Windows.Forms.Label();
            this.label_guiche = new System.Windows.Forms.Label();
            this.TxtBox_guiche_atual = new System.Windows.Forms.TextBox();
            this.label_qtde_guiches = new System.Windows.Forms.Label();
            this.rTxtBox_completo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(97, 17);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(84, 38);
            this.btn_gerar.TabIndex = 0;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // btn_chamar
            // 
            this.btn_chamar.Location = new System.Drawing.Point(575, 17);
            this.btn_chamar.Name = "btn_chamar";
            this.btn_chamar.Size = new System.Drawing.Size(86, 38);
            this.btn_chamar.TabIndex = 1;
            this.btn_chamar.Text = "Chamar";
            this.btn_chamar.UseVisualStyleBackColor = true;
            this.btn_chamar.Click += new System.EventHandler(this.btn_chamar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(262, 199);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_listar_senhas
            // 
            this.btn_listar_senhas.Location = new System.Drawing.Point(84, 277);
            this.btn_listar_senhas.Name = "btn_listar_senhas";
            this.btn_listar_senhas.Size = new System.Drawing.Size(97, 33);
            this.btn_listar_senhas.TabIndex = 3;
            this.btn_listar_senhas.Text = "Listar senhas";
            this.btn_listar_senhas.UseVisualStyleBackColor = true;
            this.btn_listar_senhas.Click += new System.EventHandler(this.btn_listar_senhas_Click);
            // 
            // btn_listar_atendimentos
            // 
            this.btn_listar_atendimentos.Location = new System.Drawing.Point(445, 278);
            this.btn_listar_atendimentos.Name = "btn_listar_atendimentos";
            this.btn_listar_atendimentos.Size = new System.Drawing.Size(197, 32);
            this.btn_listar_atendimentos.TabIndex = 4;
            this.btn_listar_atendimentos.Text = "Listar atendimentos";
            this.btn_listar_atendimentos.UseVisualStyleBackColor = true;
            this.btn_listar_atendimentos.Click += new System.EventHandler(this.btn_listar_atendimentos_Click);
            // 
            // rTxtBox_parcial
            // 
            this.rTxtBox_parcial.Location = new System.Drawing.Point(24, 69);
            this.rTxtBox_parcial.Name = "rTxtBox_parcial";
            this.rTxtBox_parcial.Size = new System.Drawing.Size(229, 203);
            this.rTxtBox_parcial.TabIndex = 5;
            this.rTxtBox_parcial.Text = "";
            // 
            // label_quantidade_guiche
            // 
            this.label_quantidade_guiche.AutoSize = true;
            this.label_quantidade_guiche.Location = new System.Drawing.Point(267, 139);
            this.label_quantidade_guiche.Name = "label_quantidade_guiche";
            this.label_quantidade_guiche.Size = new System.Drawing.Size(70, 13);
            this.label_quantidade_guiche.TabIndex = 6;
            this.label_quantidade_guiche.Text = "Qtde guichês";
            // 
            // label_guiche
            // 
            this.label_guiche.AutoSize = true;
            this.label_guiche.Location = new System.Drawing.Point(391, 30);
            this.label_guiche.Name = "label_guiche";
            this.label_guiche.Size = new System.Drawing.Size(41, 13);
            this.label_guiche.TabIndex = 7;
            this.label_guiche.Text = "Guiche";
            // 
            // TxtBox_guiche_atual
            // 
            this.TxtBox_guiche_atual.Location = new System.Drawing.Point(445, 27);
            this.TxtBox_guiche_atual.Name = "TxtBox_guiche_atual";
            this.TxtBox_guiche_atual.Size = new System.Drawing.Size(97, 20);
            this.TxtBox_guiche_atual.TabIndex = 8;
            this.TxtBox_guiche_atual.Text = "guiche_atual";
            // 
            // label_qtde_guiches
            // 
            this.label_qtde_guiches.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_qtde_guiches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qtde_guiches.Location = new System.Drawing.Point(290, 161);
            this.label_qtde_guiches.Name = "label_qtde_guiches";
            this.label_qtde_guiches.Size = new System.Drawing.Size(26, 26);
            this.label_qtde_guiches.TabIndex = 10;
            this.label_qtde_guiches.Text = "0";
            this.label_qtde_guiches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTxtBox_completo
            // 
            this.rTxtBox_completo.Location = new System.Drawing.Point(361, 69);
            this.rTxtBox_completo.Name = "rTxtBox_completo";
            this.rTxtBox_completo.Size = new System.Drawing.Size(347, 203);
            this.rTxtBox_completo.TabIndex = 11;
            this.rTxtBox_completo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 318);
            this.Controls.Add(this.rTxtBox_completo);
            this.Controls.Add(this.label_qtde_guiches);
            this.Controls.Add(this.TxtBox_guiche_atual);
            this.Controls.Add(this.label_guiche);
            this.Controls.Add(this.label_quantidade_guiche);
            this.Controls.Add(this.rTxtBox_parcial);
            this.Controls.Add(this.btn_listar_atendimentos);
            this.Controls.Add(this.btn_listar_senhas);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_chamar);
            this.Controls.Add(this.btn_gerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button btn_chamar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_listar_senhas;
        private System.Windows.Forms.Button btn_listar_atendimentos;
        private System.Windows.Forms.Label label_guiche;
        private System.Windows.Forms.TextBox TxtBox_guiche_atual;
        private System.Windows.Forms.Label label_qtde_guiches;
        private System.Windows.Forms.RichTextBox rTxtBox_completo;
        private System.Windows.Forms.Label label_quantidade_guiche;
        private System.Windows.Forms.RichTextBox rTxtBox_parcial;
    }
}

