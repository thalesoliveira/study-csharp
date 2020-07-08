using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsability
{
    public class Cliente
    {
                
        // Codigo Para Validar Cliente
        private bool Validar() {  return true; }

        //Não é responsabilidade da classe cliente
        // Codigo para acessar o banco de dados e salvar
        private bool Salvar() { return true; }

        //Não é responsabilidade da classe cliente        
        private bool EnviarEmail() { return true; }

    }
}
