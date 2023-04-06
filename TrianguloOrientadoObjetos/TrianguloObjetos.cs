using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOrientadoObjetos
{
    internal class TrianguloObjetos
    {
       public double lado1;
       public double lado2;
       public double lado3;     
        public string Triangulo()
        {
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    return "Triangulo equilatero";
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    return "Triangulo isosceles";
                }
                else
                {
                    return "Triangulo escaleno";
                }
            }
            else
            {
                return "Não é possível formar um triangulo com isso.";
            }
        }
    }

}

     
