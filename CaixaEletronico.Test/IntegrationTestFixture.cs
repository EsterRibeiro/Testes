using CaixaEletronico.Domain;
using CaixaEletronico.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace CaixaEletronico.Test
{
    /// <summary>
    /// Contexto de teste - Código de configuração e limpeza compartilhado entre testes
    /// Essa configuração/injeção de dependência não será feita para cada teste, é compartilhada
    /// É herdada pelas classes de teste IClassFixture<NomeDaClasseFixture> e receber no construtor a Fixture com DI
    /// </summary>
    public class IntegrationTestFixture
    {
        public ServiceProvider ServiceProvider { get; private set; }

        //configurado dentro do construtor
        public IntegrationTestFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ICaixa, Caixa>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

        }
    }
}
