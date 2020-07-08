using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public interface ICliente
    {
        void Criar();
        bool TornarPrime();
    }
}
