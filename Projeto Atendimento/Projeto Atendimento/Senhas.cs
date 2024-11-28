using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Atendimento
{
    internal class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public int ProximoAtendimento
        {
            get { return proximoAtendimento; }
            set { proximoAtendimento = value; }
        }

        public Queue<Senha> FilaSenhas
        {
            get { return filaSenhas; }
            set { filaSenhas = value; }
        }

        public Senhas()
        {
            ProximoAtendimento = 1;
            FilaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            Senha senha = new Senha(ProximoAtendimento);
            FilaSenhas.Enqueue(senha);
            ProximoAtendimento++; 
        }
    }
}
