// Zwraca cyfrę powtarzającą się najczęściej w podanym ciągu liczb
// Autor: Mariusz Doliński

int N = Convert.ToInt32(Console.ReadLine());

//wczytuje liczby do stringa i usuwam spacje
string seq = Console.ReadLine();
string digits = string.Join("", seq.Split(' '));

//tworze tablice przechowującą ilość każdej z cyfr i inicjuje zerami
int[] countDigits= new int[10];
for (int i = 0; i < 10; i++)
    countDigits[i] = 0;

//zliczam powtórzenia cyfr
int digit;
for(int i=0; i < digits.Length; i++) 
{
    digit = Convert.ToInt32(digits[i]) - 48;
    countDigits[digit]++;
}

int maxRepeted = 0; //najwiecej powtórzeń
for(int i=0; i < 10; i++)
{
    if (countDigits[i]>maxRepeted) 
        maxRepeted= countDigits[i];
}

int result = 0; //największa cyfra z najwiekszą ilością powtórzeń
for(int i=0; i < 10; i++)
{
    if (countDigits[i] == maxRepeted)
        result = i;
}

Console.Write(result);
