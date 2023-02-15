Menu:
DateTime cas = DateTime.Now;
int cisloMesice = cas.Month;
string[] poleMesicu = {"prosinec", "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen","Listopad", "prosinec", "Leden" };
Console.WriteLine("Nyní je " + poleMesicu[cisloMesice]);
Console.WriteLine("----------------------------");
Console.WriteLine("Zadej číslo měsíce, chceš-li");
int momentum = int.Parse(Console.ReadLine());
Console.WriteLine("Minulý měsíc byl " + poleMesicu[momentum - 1] + " a příští měsíc bude " + poleMesicu[momentum + 1]);
Console.WriteLine("chceš začít znovu?  (True/False)");
if (Console.ReadLine() == "True")
{
    goto Menu;
}
else 
{
    Console.Clear();
}
Console.WriteLine("Děkuji za využití kalendáře");
//a to je konec.///