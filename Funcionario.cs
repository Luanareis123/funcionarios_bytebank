using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionario { get; private set; }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalDeFuncionario++;
            Console.WriteLine("Criando um Funcionario");
        }
     
        public virtual void AumentarSalario()
        {
            this.Salario *= 0.1;
        }
}    }   
