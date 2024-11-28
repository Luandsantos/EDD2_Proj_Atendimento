using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    internal class Guiche
    {
        private int id = 0;
        private Queue<Senha> atendimentos;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
            set { atendimentos = value; }
        }

        public Guiche()
        {
            Atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            Id = id;
            Atendimentos = new Queue<Senha>();
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if (filaSenhas.Count > 0) 
            {
                Senha primeiraSenha = filaSenhas.Dequeue();
                primeiraSenha.DataAtend = DateTime.Now;
                primeiraSenha.HoraAtend = DateTime.Now;
                Atendimentos.Enqueue(primeiraSenha);
                return true;
            }
            return false; 
        }

    }
}
