using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Conta
    {
        private readonly ICliente _cliente;


        public Conta(ICliente cliente)
        {
            _cliente = cliente;
        }

        public bool CriarPrime()
        {
           
            _cliente.Criar();
            _cliente.TornarPrime();

            return true;
            
        }

       
    }
}
