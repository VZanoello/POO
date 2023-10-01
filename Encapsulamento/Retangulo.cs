using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Retangulo
    {
        private double largura;
        private double altura;

        public double Largura { get { return largura; } 
            set {
                if (value < 0)
                {
                    throw new ArgumentException("O valor do largura não pode ser menor que zero");
                }
                else
                {
                    largura = value;
                }
            } 
        }
        public double Altura { get { return altura; } set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O valor do altura não pode ser menor que zero");
                }
                else
                {
                    altura = value;
                }
            } 
        }

        public double GetArea()
        {
            return largura * altura;
        }
    }
}
