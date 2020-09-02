using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2HerenciaPOO
{
    public class Nomina
    {
        private double cantidadhoras;
        private double valorHora;
        public Nomina() 
        {
            double minimo;
            minimo = 900000;
            this.valorHora = minimo / 240;
        }
        public void setCantidadhoras(double valor) 
        {
            this.cantidadhoras = valor;

        }
        public double getCantidadhoras() 
        {
            return this.cantidadhoras;
        }
        public double getValorHora() 
        {
            return this.valorHora;
        }
    }
}
