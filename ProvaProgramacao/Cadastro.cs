using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaProgramacao
{
    class Cadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string DataNasc { get; set; }
        public float Altura { get; set; }




        public override string ToString()
        {
            return "ID: " + Id + ", Nome: " + Nome + ", Telefone: " + Telefone + ", Data de Nascimento: " + DataNasc + ", Altura: " + Altura;
        }


    }
}
