using CaixaEletronico.Domain;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CaixaEletronico.Test
{
    /// <summary>
    /// Usando FluentAssertions, para assegurar valores de atributos (se foi alterado ou está incorreto, nulo)
    /// Vantagem: A programação fica mais funcional e aparentemente limpa
    /// </summary>
    public class FluentAssertionsTest
    {
        [Fact(DisplayName ="Valores do modelo cedula estão corretos")]
        public void ValoresModeloCedulaEstaoCorretos()
        {
            Cedula.Cem.Should().Be(100);
            Cedula.Cinquenta.Should().BeOfType(typeof(int)).And.Be(50);
            Cedula.Vinte.Should().BeOfType(typeof(int)).And.Be(20);
        }

        [Fact(DisplayName ="Intervalos de valores do modelo cedula estao corretos")]
        public void IntervalosValoresModeloCedulasCorretos()
        {
            Cedula.Cinquenta.Should().BeLessThan(Cedula.Cem);
            Cedula.Dez.Should().BeLessThan(Cedula.Vinte);
        }
    }
}
