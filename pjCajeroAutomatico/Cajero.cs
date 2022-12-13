using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCajeroAutomatico
{
    public class Cajero
    {
        public double Saldo { get; set; }
        public double Deposito { get; set; }
        public double Retiro { get; set; }

        public void Depositar(double deposito)
        {
            
            Saldo = Saldo + deposito;
            
        }

        public void Retirar(double retiro)
        {
            Saldo = Saldo - retiro;
            
        }
    }
}
