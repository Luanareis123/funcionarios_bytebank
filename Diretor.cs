using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    // Herança:Diretor é herança de funionario. 
    public class Diretor:Funcionario
    {
        // Override é necessário para estender ou modificar a implementação abstrata ou virtual de um método, propriedade, indexador ou evento herdado.
        // Um método override fornece uma nova implementação de um membro herdado de uma classe base.
        public override double GetBonificacao()
        {
            //base serve para ter a certeza que esta chamando o GetBonifiação da
            // super classe funcionario. 
            return this.Salario + base.GetBonificacao();
        }
        public Diretor(string cpf, double salario):base(cpf, salario)
        { 
            //Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
