using Atividade_1;

Horista horista = new Horista();
Assalariado assalariado = new Assalariado();
Comissionado comissionado = new Comissionado();

Console.WriteLine("Selecione:\n1 para Assalariado,\n2 para Horista,\n3 para Comissionado");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Digite o seu salario.");
        assalariado.salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Seu salario é: " + assalariado.vencimento() + "!");
        break;

    case 2:
        Console.WriteLine("Digite o seu preço por hora:");
        horista.precoHora = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de horas que você trabalhou:");
        horista.horasTrabalhadas = double.Parse(Console.ReadLine());
        Console.WriteLine("Seu salario é " + horista.vencimento());
        break;

    case 3:
        Console.WriteLine("Digite o valor total da venda:");
        comissionado.totalVenda = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a sua taxa de comissão: ");
        comissionado.taxaComissao = double.Parse(Console.ReadLine());
        Console.WriteLine("Seu salario é " + comissionado.vencimento());

        break;
}

