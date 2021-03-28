using CaixaEletronico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CaixaEletronico.Test
{

    /// <summary>
    /// Valor de entrada mutável utilizando Theory para aproveitar asserts e métodos 
    /// InlineData para informar valores de entrada
    /// </summary>
    public class CaixaEletronicoTheoriesTests
    {
        private readonly Caixa caixa = new Caixa();

        [Theory(DisplayName = "Saque contém número de cédulas solicitado correto")]
        [InlineData(3,80)]
        [InlineData(3, 300)]
        [InlineData(5, 500)]
        public void SaqueComNumeroDeCedulasCorreto(int quantidadeCedulas, int valorDoSaque) 
        {
            var resultadoCedulas = caixa.Saque(valorDoSaque);
            Assert.Equal(quantidadeCedulas, resultadoCedulas.Count);
        
        }
    }
}
