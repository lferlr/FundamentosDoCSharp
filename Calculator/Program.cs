//Main

Menu();

static void Menu()
{
  Console.Clear();

  Console.WriteLine("O que deseja fazer?");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtraçaão");
  Console.WriteLine("3 - Divisão");
  Console.WriteLine("4 - Multiplicação");
  Console.WriteLine("0 - Sair para o menu");

  Console.WriteLine("-------------------");

  Console.WriteLine("Selecione uma opção:");
  short menuSelecionado = short.Parse(Console.ReadLine());

  switch (menuSelecionado)
  {
    case 1: Soma(); break;
    case 2: Subtracao(); break;
    case 3: Divisao(); break;
    case 4: Multiplicacao(); break;
    case 0: Sair(); break;
    default: Menu(); break;
  }
}

static void Soma()
{
  Console.Clear();
  Console.WriteLine("!!Soma!!");
  Console.WriteLine("");

  Console.WriteLine("Primeiro valor: ");
  float v1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 + v2;

  Console.WriteLine($"O resultado da soma de {v1} e {v2} é igual a {resultado}");
  Console.ReadKey();

  Menu();
}

static void Subtracao()
{
  Console.Clear();
  Console.WriteLine("!!Subtração!!");
  Console.WriteLine("");

  Console.WriteLine("Primeiro valor:");
  float v1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 - v2;

  Console.WriteLine($"O resultado da subtração de {v1} e {v2} é igual a {resultado}");
  Console.ReadKey();

  Menu();
}

static void Divisao()
{
  Console.Clear();
  Console.WriteLine("!!Divisão!!");
  Console.WriteLine("");

  Console.WriteLine("Primeiro valor:");
  float v1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 / v2;

  Console.WriteLine($"O resultado da divisão de {v1} e {v2} é igual a {resultado}");
  Console.ReadKey();

  Menu();
}

static void Multiplicacao()
{
  Console.Clear();
  Console.WriteLine("!!Multiplicação!!");
  Console.WriteLine("");

  Console.WriteLine("Primeiro valor:");
  float v1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo valor:");
  float v2 = float.Parse(Console.ReadLine());

  Console.WriteLine("");

  float resultado = v1 * v2;

  Console.WriteLine($"O resultado da multiplicação de {v1} e {v2} é igual a {resultado}");
  Console.ReadKey();

  Menu();
}

static void Sair()
{
  System.Environment.Exit(0);

  Console.WriteLine("Obrigado!");
}