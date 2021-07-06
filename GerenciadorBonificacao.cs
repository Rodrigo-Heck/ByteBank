using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao = 0;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        

        public double GetBonificacao()
        {
            return _totalBonificacao;

        }


    }
}
