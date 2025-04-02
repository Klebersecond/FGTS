double FGTS, salario;

Console.Write("Digite o salário:");
salario = Convert.ToDouble(Console.ReadLine());

Console.Clear();
Console.WriteLine($"valor do salario {salario}");
Console.Write("valor do FGTS: ");

//  Cálculo correto do FGTS (8% do salário)
FGTS = salario * 0.08;
Console.WriteLine($"{FGTS}");





