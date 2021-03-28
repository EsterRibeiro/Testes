using CaixaEletronico.Domain;
using System;
using Xunit;

namespace CaixaEletronico.Test
{
    /// <summary>
    /// Criando testes normais utilizando Facts (sinaliza o teste) e 
    /// Asserts (resultado esperado)
    /// </summary>
    public class CaixaEletronicoAssertsTests
    {

        private readonly Caixa caixa = new Caixa();

        [Fact]
        public void SaqueValido()
        {
            int valorDoSaque = 510;
            bool saqueEValido = caixa.ValidaCedulasDisponiveis(valorDoSaque);

            Assert.True(saqueEValido); //saque � v�lido?
        }

        [Fact] //deve acionar uma exception devido �s c�dulas insuficientes
        public void SaqueInvalido()
        {
            int valorDoSaque = 5;
            Assert.Throws<Exception>(() => caixa.Saque(valorDoSaque)); //verifica se a exce��o � realmente lan�ada
        }
    }
}
