// Odwracanie kolejności w tablicy
// Autor: Mariusz Doliński

int n = Convert.ToInt32(Console.ReadLine());

string tabS = Console.ReadLine();
string[] liczbyS = tabS.Split(' ');

for(int i = n-1;i > -1; i--)
{
    Console.Write(liczbyS[i]+ " ");
}
