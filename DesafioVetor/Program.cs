// See https://aka.ms/new-console-template for more information


/*
3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora de todos os dias de um ano, faça um programa, na linguagem que desejar, que calcule e retorne:

- O menor valor de faturamento ocorrido em um dia do ano;
- O maior valor de faturamento ocorrido em um dia do ano;
- Número de dias no ano em que o valor de faturamento diário foi superior à média anual.

a) Considerar o vetor já carregado com as informações de valor de faturamento.

b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média.

c) Utilize o algoritmo mais veloz que puder definir.
*/

double[] array = [123.12, 200.00, 0, 0, 0, 2135.12, 592, 1300, 912.22, 85, 90,780.12];

double media = array.Sum() / array.Where(a => a != 0).Count();
double maior = array.Max();
double menor = array.Where(a => a != 0).Min();

int qtdDias = array.Where(d => d > media).Count();

Console.WriteLine("Média: " + media + "\nMaior: " + maior + "\nMenor: " + menor + "\nQuantidade de dias: " + qtdDias); 