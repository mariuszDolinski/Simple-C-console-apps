// Zwraca pozycję liczby o największej sumie cyfr
// Autor: Mariusz Doliński

using System.Net.Mail;

int N = Convert.ToInt32(Console.ReadLine());

//wczytuje liczby do stringa i usuwam spacje
string seq = Console.ReadLine();
string[] digits = seq.Split(" ");

//tworzę tablicę sum cyfr
int[] sums = new int[digits.Length];
int sum;
for (int i = 0; i < sums.Length; i++)
{
    sum = 0;
    for (int j = 0; j < digits[i].Length; j++)
        sum += (Convert.ToInt32(digits[i][j])-48);
    sums[i] = sum;
}

//szukam max w tablicu sums
int max = sums[0];
int maxIndex = 0;
for(int i = 1; i < sums.Length; i++)
{
    if (sums[i] >= max)
    {
        max = sums[i];
        maxIndex= i;
    }
}

Console.Write(maxIndex);