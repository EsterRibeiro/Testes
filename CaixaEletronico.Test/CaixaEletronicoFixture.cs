using CaixaEletronico.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CaixaEletronico.Test
{
    public class CaixaEletronicoFixture : IClassFixture<IntegrationTestFixture>
    {

        private ICaixa _caixa;

        //chamada conf de fixture
        public CaixaEletronicoFixture(IntegrationTestFixture integrationFixture)
        {
            _caixa = integrationFixture.ServiceProvider.GetRequiredService<ICaixa>();
        }

        [Fact]
        public void SaqueContemMenorNumeroDeCedulas()
        {
            int quantidadeDeCedulas = 3;
            int valorDoSaque = 80;

            var resultadoCedulas = _caixa.Saque(valorDoSaque);

            Assert.Equal(quantidadeDeCedulas, resultadoCedulas.Count);
        }
    }
}
