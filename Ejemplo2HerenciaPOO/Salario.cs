﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2HerenciaPOO
{
    public class Salario: Nomina
    {
        public double calcularSalarioBase() 
        {
            return (this.getCantidadhoras() * this.getValorHora());              
            
               
            
        }
    }
}
