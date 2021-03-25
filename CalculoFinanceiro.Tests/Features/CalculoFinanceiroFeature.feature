Funcionalidade: CalculoFinanceiroFeature

@mytag
Cenario: SimulacaoCalculo01
	Dado que o valor do emprestimo foi R$ 10000,00
	E foi definida a taxa de 2%
	E em um periodo de 12 meses
	Quando eu solicitar o valor ao final do periodo
	Entao o valor total a ser pago sera R$ 12682,42

	Cenario: SimulacaoCalculo02
	Dado que o valor do emprestimo foi R$ 11937,28
	E foi definida a taxa de 4%
	E em um periodo de 24 meses
	Quando eu solicitar o valor ao final do periodo
	Entao o valor total a ser pago sera R$ 30598,88

	Cenario: SimulacaoCalculo03
	Dado que o valor do emprestimo foi R$ 1500,00
	E foi definida a taxa de 6%
	E em um periodo de 36 meses
	Quando eu solicitar o valor ao final do periodo
	Entao o valor total a ser pago sera R$ 122208,78