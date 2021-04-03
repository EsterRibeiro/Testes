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

    /// <summary>
    /// Traits permitem a organização dos testes no Test Explorer
    /// Passando por parâmetro 1- nome, 2 - valor da trait
    /// </summary>
    public class TraitsTest : IClassFixture<IntegrationTestFixture>
    {
        private ICaixa _caixa;

        //consiguração pelo fixture
        public TraitsTest(IntegrationTestFixture fixture) 
        {
            _caixa = fixture.ServiceProvider.GetRequiredService<ICaixa>();
        }

        [Fact(DisplayName = "Saque contem numero de cedulas igual ao predito")]
        [Trait("Operacao", "Saque")]
        public void SaqueContemNumeroDeCedulasIgualPredito()
        {
            int quantidadeDeCedulas = 3;
            int valorDoSaque = 80;

            var resultadoCedulas = _caixa.Saque(valorDoSaque);

            Assert.Equal(quantidadeDeCedulas, resultadoCedulas.Count);
        }
    }
}
