
// vytvořit kalkulačku scitani/odcitani/deleni/nasobeni/mocnina

/*
1) vypsat menu a pres moznosti 1-6 zvolit matematickou funkci (mocina 2krat)
2) vytvorit samostatne funkce pro kazdou mat operaci
3) funkce nasobe bude resena rekurzi kdy bude volat sama sebe (druhe cislo se pri zavolani odecte -1 dokud nebude 0)
4) funkce mocniny bude resena rekurzi kdy bude volat obdobu funkce nasobeni  
5) cisla budou brana z uziv. vstupu readline()
*/

int Scitani(int cislo1, int cislo2)
{
    return cislo1 + cislo2;
}

int Odcitani(int cislo1, int cislo2)
{
    return cislo1 - cislo2;
}

int Nasobeni(int cislo1, int cislo2)
{
    return cislo1 * cislo2;
}

double Deleni(double cislo1, double cislo2)
{
    return cislo1 / cislo2;
}

int Mocnina(int cislo, int mocninaA)
{
    if (mocninaA == 0)
    {
        return 1;
    }
    else
    {
        return cislo * Mocnina(cislo, mocninaA - 1);
    }
}

int volba;
bool done = false;

Console.WriteLine("VYBERTE FUNKCI");
Console.WriteLine("1 - sčítání, 2 - odčítaní, 3 - násobení, 4 - dělení, 5 - mocnina, 6 - EXIT");

while ((Int32.TryParse(Console.ReadLine(), out volba)))
{
    switch (volba)
    {
        case 1:
            Console.WriteLine("SČÍTÁNÍ");
            
            Console.WriteLine("Napiš první číslo:");
            int scitani1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Napiš druhé číslo:");
            int scitani2 = Int32.Parse(Console.ReadLine());
            
            int vysledekScitani = Scitani(scitani1, scitani2);
            Console.WriteLine($"Výsledek: {vysledekScitani}");
            break;
        case 2:
            Console.WriteLine("ODČÍTÁNÍ");
            
            Console.WriteLine("Napiš první číslo:");
            int odcitani1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Napiš druhé číslo:");
            int odcitani2 = Int32.Parse(Console.ReadLine());
            
            int vysledekOdcitani = Odcitani(odcitani1, odcitani2);
            Console.WriteLine($"Výsledek: {vysledekOdcitani}");
            break;
        case 3:
            Console.WriteLine("NÁSOBENÍ");
            
            Console.WriteLine("Napiš první číslo:");
            int nasobeni1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Napiš druhé číslo:");
            int nasobeni2 = Int32.Parse(Console.ReadLine());
            
            int vysledekNasobeni = Nasobeni(nasobeni1, nasobeni2);
            Console.WriteLine($"Výsledek: {vysledekNasobeni}");
            break;
        case 4:
            Console.WriteLine("DĚLENÍ");
            
            Console.WriteLine("Napiš první číslo:");
            int deleni1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Napiš druhé číslo:");
            int deleni2 = Int32.Parse(Console.ReadLine());
            
            double vysledekDeleni = Deleni(deleni1, deleni2);
            Console.WriteLine($"Výsledek: {vysledekDeleni}");
            break;
        case 5:
            Console.WriteLine("MOCNINA");
            
            Console.WriteLine("Napiš číslo:");
            int mocnina1 = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Napiš mocninu:");
            int mocnina2 = Int32.Parse(Console.ReadLine());
            
            int vysledekMocniny = Mocnina(mocnina1, mocnina2);
            Console.WriteLine($"Výsledek: {vysledekMocniny}");
            break;
        case 6:
            done = true;
            break;

    }

    if (!done)
    {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("VYBERTE FUNKCI");
        Console.WriteLine("1 - sčítání, 2 - odčítaní, 3 - násobení, 4 - dělení, 5 - mocnina");
    }
    else
    {
        break;
    }
}