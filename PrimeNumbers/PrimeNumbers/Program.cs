// Wypisuje ilosc liczb należących do podanego przedziału (powtarzane T razy)
// Autor: Mariusz Doliński

int T = Convert.ToInt32(Console.ReadLine());

//inicjalizuje tablicę krańców przedziałów
int[][] ab = new int[T][];
for (int i = 0; i < T; i++)
    ab[i] = new int[2];

//wczytuje tablicę z konsoli
string currentInput = "";
string[] tabS = new string[2];
for(int i = 0; i < T; i++)
{
    currentInput = Console.ReadLine();
    tabS = currentInput.Split(' ');
    ab[i][0] = Convert.ToInt32(tabS[0]);
    ab[i][1] = Convert.ToInt32(tabS[1]);
}

//wypisuje ilość liczb
int count;
bool isPrime;
for(int i = 0; i < T; i++)
{
    count = 0;
    for(int j = ab[i][0]; j <= ab[i][1]; j++)
    {
        isPrime = true;
        if (j == 0 || j == 1) //pomijam 0 i 1 które nie są pierwsze 
        { 
            continue; 
        }
        for (int k = 2; k < j/2; k++)
        {
            if (j % k == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime) count++;
    }
    Console.WriteLine(count);
}



