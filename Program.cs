/*
Написать программуб которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
*/

string[] stringArrey = new string[] { "abc1", "bce", "ce222", "ed", "0dfg" };
int symbols = 3;

int ScanArray(string[] stringArrey, int symbols)
{
    int count = 0;
    for (int i = 0; i < stringArrey.Length; i++)
    {
        if (stringArrey[i].Length <= symbols)
        {
            count++;
        }
    }
    return count;
}

string[] NewArrey(int count)
{
    string[] newArrey = new string[count];
    return newArrey;
}


string[] FillArrey(string[] stringArrey, string[] newArrey, int symbols)
{
    int j = 0;
    for (int i = 0; i < stringArrey.Length; i++)
    {
        if (stringArrey[i].Length <= symbols)
        {
            newArrey[j] = stringArrey[i];
            j++;
        }
    }
    return newArrey;
}

void PrintArrey(string[] arrey)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arrey.Length; i++)
    {
        System.Console.Write($" {arrey[i]} ");
    }
    System.Console.Write("]");
}

string[] arrey = NewArrey(ScanArray(stringArrey, symbols));

if (arrey.Length == 0)
{
    PrintArrey(arrey);
}
else
{
    PrintArrey(FillArrey(stringArrey, arrey, symbols));
}