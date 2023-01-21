// Wypisuje potegi dwójki występujące w dekompozycji na system dwójkowy podanych liczb
// Autor: Mariusz Doliński

//wczytuje liczby aż do pustej linii
string inputString = "";
string current = "";
do
{
    current = Console.ReadLine();
    inputString += current;
    inputString += " ";
}while(current != "");

//kasuje ostatnią spację
inputString= inputString.Trim(' ');

//tworzę tablicę pojedynczych wpisów
string[] liczbyS = inputString.Split(" ");

//parsuję na int
int[] liczby = new int[liczbyS.Length];
for(int i = 0;i < liczbyS.Length;i++)
    liczby[i] = Convert.ToInt32(liczbyS[i]);

int pom = 0;
//wykorzystuje operator bitowy OR tworząc liczbę zawierającą wszystkie potęgi 2 liczb z tablicy
//w efekcie zmienna pom zawiera wszystkie potegi dwojki danych liczb
for(int i=0;i<liczby.Length;i++)
{
    pom |= liczby[i];
}

//wykorzystuje przesunięcia bitowe do sprawdzenia czy dana potega 2 występuje w zmiennej pom
string wynik = "";
for (int i = 0; i < 32; i++)
{
    int potegaDwojki = 1 << i;
    if ((pom & potegaDwojki) != 0)
    {
        wynik += (potegaDwojki.ToString() + ",");
    }
}

if (wynik == "")
    Console.Write("NA");
else
{
    wynik = wynik.Trim(',');
    Console.Write(wynik);
}
    