using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Future_Value_Calculator.Models
{
    public class ValorAcumulado
    {
        [Required(ErrorMessage="Insira por favor o deposito mensal")]
        [Range(1, 4000, ErrorMessage ="O deposito mensal deve possuir um valor entre 1 e 4000")]
        public decimal MonthlyDeposit { get; set; }

        [Required(ErrorMessage = "Insira por favor a taxa de juros anual")]
        [Range(1, 5, ErrorMessage = "A taxa de juros anual deve estar entre 1 e 5")]
        public decimal InterestRate { get; set; }

        [Required(ErrorMessage = "Insira por favor a quantidade de anos")]
        [Range(1, 25, ErrorMessage = "A quantidade de anos deve estar entre 1 e 25")]
        public int Years { get; set; }

        public decimal CalcularValorAcumulado()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = InterestRate / 12 / 100;
            decimal futureValue = 0;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyDeposit) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

    }
}
