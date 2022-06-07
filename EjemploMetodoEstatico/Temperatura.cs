using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMetodoEstatico
{
    public class Temperatura
    {
        private static int cantidad;
        public double Valor { get; set; }
        public Temperatura(double valor)
        {
            cantidad++;
            Valor = valor;
        }

        public double GetValor() => Valor;
        public static int GetCantidad()
        {
            return cantidad;
        }
    }
}
