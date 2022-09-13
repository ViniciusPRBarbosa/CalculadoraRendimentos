using Future_Value_Calculator.Models;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CalculadoraRendimentos.Tests.Steps
{
    [Binding]
    class CalculadoraRendimentosSteps
    {
        private decimal _valorFinal;
        private ValorAcumulado _valorAcumulado;
        private readonly ScenarioContext _scenarioContext;

        public CalculadoraRendimentosSteps(ScenarioContext scenarioContext)
        {
            _valorAcumulado = new ValorAcumulado();

            _scenarioContext = scenarioContext;
        }

        [Given("o deposito mensal é de (.*)")]
        public void Dado_que_o_deposito_mensal_e_de(int valorDepositoMensal)
        {
            _valorAcumulado.MonthlyDeposit = valorDepositoMensal;
        }

        [Given("a taxa de juros ao ano é de (.*)")]
        public void Dado_que_a_taxa_de_juros_anual_e_de(int valorTaxaJurosAnual)
        {
            _valorAcumulado.InterestRate = valorTaxaJurosAnual;
        }

        [Given("a quantidade de anos é de (.*)")]
        public void Dado_que_a_quantidade_de_anos_e_de(int quantidadeAnos)
        {
            _valorAcumulado.Years = quantidadeAnos;
        }

        [When("o sistema calcular o rendimento")]
        public void Quando_o_sistema_calcular_o_rendimento()
        {
            _valorFinal = _valorAcumulado.CalcularValorAcumulado();
        }

        [Then("o valor acumulado deverá ser de (.*)")]
        public void Entao_o_valor_acumulado_devera_ser_de(decimal valorProcessado)
        {
            Assert.AreEqual(decimal.Round(_valorFinal, 2), valorProcessado);
        }
    }
}
