/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа
*/

string[] InitArr(int n)
{
    string[] new_arr = new string[n];

    Console.WriteLine($"Please enter {n} strings:");
    for (int i = 0; i < n; i++)
    {
        new_arr[i] = Console.ReadLine() ?? "";
    }

    return new_arr;
}

string[] SelectArr(string[] arr)
{
    int count = 0;
    string[] add_arr, out_arr;
    out_arr = new string[count];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
            add_arr = new string[count]; //создаем массив в котором на 1 строку больше

            //копируем все элементы из имеющегося массива в новый
            for (int j = 0; j < add_arr.Length - 1; j++)
            {
                add_arr[j] = out_arr[j];
            }

            add_arr[count - 1] = arr[i];

            //переназначаем ссылку
            out_arr = add_arr;

        }
    }

    return out_arr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int count = GetNumber("Please enter number of the strings in the array: ");
string[] array = InitArr(count);
string[] out_arr = SelectArr(array);
 Console.WriteLine();

if (out_arr.Length > 0)
{
    Console.WriteLine("Strings less than 4 characters:");
    for(int i = 0; i <out_arr.Length; i++)
    {
        Console.WriteLine(out_arr[i]);
    }
}
else
    Console.WriteLine("There are no strings less than 4 characters in the array");


