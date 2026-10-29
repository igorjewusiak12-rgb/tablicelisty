int [] zlotoWTurach = {5,12,0,8,15};

int tura = 1;
int lacznaIlosc = 0;
double srednia = 0;
int licznik = 0;

for (tura = 1;tura <= zlotoWTurach.Length;tura++)
{
    Console.WriteLine($"Tura {tura} : {zlotoWTurach[tura-1]} sztuk złota");
    lacznaIlosc += zlotoWTurach[tura-1];
    srednia = lacznaIlosc/tura;

    if (zlotoWTurach[tura-1] > 10)
    {
        licznik+=1;
    }

}


Console.WriteLine($"Lacznie: {lacznaIlosc}");
Console.WriteLine($"Srednio na ture: {srednia}");
Console.WriteLine($"Tury z wynikiem co najmniej 10: {licznik}");

Console.Write("Od konca: ");
for (int i = zlotoWTurach.Length -1; i>=0;i--)
{
    Console.Write($"{zlotoWTurach[i]}\t");
}