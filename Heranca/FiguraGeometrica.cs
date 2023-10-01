using Heranca.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public abstract class FiguraGeometrica : IFiguraGeometrica
    {
        public abstract double GetArea();
    }
}
