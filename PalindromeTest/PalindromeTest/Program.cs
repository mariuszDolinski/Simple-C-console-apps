// Program sprawadza czy podany string jest palindromem
// Uwaga 1: pomijane są znaki nie będące literami
// Uwaga 2: wielkość liter nie ma znaczenia
// Autor: Mariusz Doliński

using System.Text.RegularExpressions;

string txt = Console.ReadLine();

txt = txt.ToLower();

//Regex rgx = new Regex("[^a-zA-Z]");
//txt = rgx.Replace(txt, "");

string onlyLetters = "";
for(int i=0; i<txt.Length; i++)
{
    if (char.IsLetter(txt[i])) onlyLetters += txt[i];
}

txt = onlyLetters;
string reverseTxt = "";

for(int i=0; i<txt.Length; i++)
{
    reverseTxt += txt[txt.Length - i - 1];
}

bool isPalindrome = true;
for(int i = 0; i < reverseTxt.Length; i++)
{
    if (txt[i] != reverseTxt[i])
    {
        isPalindrome = false; break;
    } 
}

if (isPalindrome)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");

