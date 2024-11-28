using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projeto_Atendimento
{
    internal class Senha
    {
        private int id = 0;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;
        public int Id
        {
            get { return id; }  
            set { id = value ; }  
        }

        public DateTime DataGerac
        {
            get { return dataGerac; }
            set { dataGerac = value; }
        }

        public DateTime HoraGerac
        {
            get { return horaGerac; }
            set { horaGerac = value; }
        }

        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }

        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }

        public Senha(int id)
        {
            Id = id;
            DataGerac = DateTime.Now;
            HoraGerac = DateTime.Now;
        }

        public string dadosParciais()
        {
            return Id + " - " + DataGerac.ToString("dd/MM/yyyy") + " - " + HoraGerac.ToString("HH:mm:ss");
        }

        public string dadosCompletos()
        {
            return Id + " - " + 
                   DataGerac.ToString("dd/MM/yyyy") + " - " + 
                   HoraGerac.ToString("HH:mm:ss") + " - " + 
                   DataAtend.ToString("dd/MM/yyyy") + " - " + 
                   HoraAtend.ToString("HH:mm:ss");
        }
    }
}
