using Heranca.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Triangulo : FiguraGeometrica
    {
        private double _base;
        private double _altura;

        public double Base { get { return _base; } set { _base = value; } }
        public double Altura
        {
            get { return _altura; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O valor do altura não pode ser menor que zero");
                }
                _altura = value;
            }
        }
        public override double GetArea()
        {
            return (_base * _altura) / 2;
        }
    }
}
