using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Atendimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int id_senha = 1;
        int id_guiche = 1;

        Senhas senhas1 = new Senhas();
        Guiches guiches1 = new Guiches();

        private void btn_chamar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtBox_guiche_atual.Text, out int guicheEscolhido) &&
                   guicheEscolhido > 0 && guicheEscolhido <= guiches1.ListaGuiches.Count)
            {
                if (guiches1.ListaGuiches[guicheEscolhido - 1].chamar(senhas1.FilaSenhas))
                {
                }
                else
                {
                    MessageBox.Show("Não há senhas na fila.");
                }
            }
            else
            {
                MessageBox.Show("Guichê inválido. Insira um número válido.");
            }
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            senhas1.gerar();
        }

        private void btn_listar_senhas_Click(object sender, EventArgs e)
        {
            string dados_incompletos = "";
            foreach (Senha senha in senhas1.FilaSenhas)
            {
                dados_incompletos += senha.dadosParciais() + "\n";
            }
            rTxtBox_parcial.Text = dados_incompletos;
        }

        private void btn_listar_atendimentos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtBox_guiche_atual.Text, out int guiche_escolhido) &&
                    guiche_escolhido > 0 &&
                    guiche_escolhido <= guiches1.ListaGuiches.Count)
            {
                string dados_completos = "";
                foreach (Senha senha in guiches1.ListaGuiches[guiche_escolhido - 1].Atendimentos)
                {
                    dados_completos += senha.dadosCompletos() + "\n";
                }
                rTxtBox_completo.Text = dados_completos;
            }
            else
            {
                MessageBox.Show("Guichê inválido. Insira um número válido.");
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Guiche novoGuiche = new Guiche(id_guiche);
            id_guiche++;
            guiches1.adicionar(novoGuiche);
            label_qtde_guiches.Text = guiches1.ListaGuiches.Count.ToString();
        }
    }
}
