// Sprawdza czy dwa podane ciągi cyfr są wzajemnymi permutacjami
// Autor: Mariusz Doliński

//sczytuję stringi z konsoli
string s1 = Console.ReadLine();
string s2 = Console.ReadLine();

bool isPermutation(string s1, string s2)
{
    if (s1.Length != s2.Length ) return false;

    //dzielę na tablicę spacjami
    string[] tab1 = s1.Split(" ");
    string[] tab2 = s2.Split(" ");

    //konwertuję na inty
    int[] num1 = new int[tab1.Length];
    int[] num2 = new int[tab2.Length];

    for (int i = 0; i < tab1.Length; i++)
    {
        num1[i] = int.Parse(tab1[i]);
        num2[i] = int.Parse(tab2[i]);
    }

    //tworzę listy
    List<int> list1 = new List<int>();
    List<int> list2 = new List<int>();

    for (int i = 0; i < tab1.Length; i++)
    {
        list1.Add(num1[i]);
        list2.Add(num2[i]);
    }

    //sortuję listy
    list1.Sort();
    list2.Sort();

    // sprawdzam czy listy są takie same
    if (list1.SequenceEqual(list2))
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (isPermutation(s1,s2))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}



