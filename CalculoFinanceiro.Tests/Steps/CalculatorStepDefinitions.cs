using JurosCompostos.Main;
using Xunit;
using System;
using TechTalk.SpecFlow;

namespace CalculoFinanceiro.Tests.Steps
{
    [Binding]
    public sealed class CalculoFinanceiroSteps
    {
        private double _valorEmprestimo;
        private double _taxa;
        private int _meses;
        private double _valorFinalPeriodo;

        private readonly ScenarioContext _scenarioContext;

        public CalculoFinanceiroSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("que o valor do emprestimo foi R\\$ (.*)")]
        public void CarregarValorEmprestimo(double valorEmprestimo)
        {

            _valorEmprestimo = valorEmprestimo;
        }

        [Given("foi definida a taxa de (.*) mensais")]
        public void CarregarTaxa(double taxa)
        {
            _taxa = taxa;
        }

        [Given("em um periodo de (.*) meses")]
        public void CarregarMeses(int meses)
        {
            _meses = meses;
        }

        [When("eu solicitar o valor ao final do periodo")]
        public void ProcessarCalculo()
        {        
           _valorFinalPeriodo = CalculoFinanc.CalcularValorComJurosCompostos(_valorEmprestimo, _meses, _taxa);
        }

        [Then("o valor total a ser pago sera R\\$ (.*)")]
        public void VerificarReultado(double valorFinalPeriodo)
        {
            Assert.Equal(valorFinalPeriodo, _valorFinalPeriodo);
        }
    }
}
