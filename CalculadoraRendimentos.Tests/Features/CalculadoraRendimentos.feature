Feature: CalculadoraRendimentos

Scenario: Processar valor investido
	Given o deposito mensal é de 2500
	And a taxa de juros ao ano é de 2
	And a quantidade de anos é de 15
	When o sistema calcular o rendimento
	Then o valor acumulado deverá ser de 525156.44