using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2_LISTA_1_V2
{
    class Quadrado
    {
        #region atributos
        private double lado;
        private double area;
        #endregion
        #region construtor
        public Quadrado()
        {
            lado = 0;
            calcularArea();
        }
        #endregion
        #region set e gets
        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double getLado()
        {
            return lado;
        }

        public double getArea()
        {
            return area;
        }

        #endregion
        #region metodos
        public void calcularArea()
        {
            area = Math.Pow(lado, 2);
        }
        #endregion
    }
}
