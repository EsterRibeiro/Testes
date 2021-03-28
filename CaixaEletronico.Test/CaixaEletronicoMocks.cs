using CaixaEletronico.Interface;
using Moq;
using NSubstitute;
using Xunit;

namespace CaixaEletronico.Test
{
    public class CaixaEletronicoMocks
    {
        [Fact(DisplayName = "Mock saque com sucesso NSubstitute")]
        public void SaqueComSucessoNSubs()
        {
            int valorDoSaque = 50;
            var caixa = Substitute.For<ICaixa>();

            caixa.Saque(valorDoSaque).Returns(new int[] { }); //simula o saque e assegura o retorno de um array de int
            caixa.Received(1); //confirma execução do método apenas 1x

        }

        [Fact(DisplayName ="Mock saque coms sucesso Moq")]
        public void SaqueComSucessoMoq()
        {
            int valorDoSaque = 50;
            var caixa = new Mock<ICaixa>();

            caixa.Object.Saque(valorDoSaque);
            caixa.Verify(e => e.Saque(valorDoSaque), Times.Once); //verifica se o teste foi executado apenas 1x


        }
    }
}
