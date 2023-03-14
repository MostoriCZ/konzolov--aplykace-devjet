using Spectre.Console;
MENU:

var ukol = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
    .Title("Vyber jednu z možností [green]úkolů[/]")
    .PageSize(3)
    .MoreChoicesText("")
    .AddChoices("První", "Druhý", "Třetí"));
if  (ukol == "První")
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int pocitadlo = 1; pocitadlo < 100; pocitadlo++)
    {
        if (pocitadlo != 40)
        {
            if (pocitadlo != 60)
                Console.WriteLine(pocitadlo);
        }
    }
    Console.WriteLine("Konec");
    Console.WriteLine("Pokračovat dále? Y/N");
    string pismenko1 = Console.ReadLine();
    if (pismenko1 == "Y")
    {
        Console.Clear();
        goto MENU;
    }
}

if (ukol == "Druhý")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Zadej požadovanou šířku a výšku (např. 10x50)");
    string input = Console.ReadLine();
    string[] _size = input.Split("x");
    int[] size = new int[_size.Length];
    for (int i = 0; i < _size.Length; i++)
    {
        size[i] = int.Parse(_size[i]);
    }
    for (int i = 0; i < size[0]; i++)
    {
        for (int j = 0; j < size[1]; j++) Console.Write("* ");
        Console.Write("\n");
    }
    Console.WriteLine("Pokračovat dále? Y/N");
    string pismenko2 = Console.ReadLine();
    if (pismenko2 == "Y")
    {
        Console.Clear();
        goto MENU;
    }
}

if (ukol == "Třetí")
{
    Console.WriteLine("napiš čísla které program následně vypíše ( odděl čárkou )");
    string input = Console.ReadLine() ?? "";
    string[] array = input.Split(",");
    Console.WriteLine($"Počet čísel je: {array.Length}");
    Console.WriteLine("Pokračovat dále? Y/N");
    string pismenko3 = Console.ReadLine();
    if (pismenko3 == "Y")
    {
        Console.Clear();
        goto MENU;
    }
}