﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {   
        public static int TotalDeFuncionarios { get; private set; }


        public string Nome { get; set; }
                

        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;            
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
        
    }
}
