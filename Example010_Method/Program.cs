int[] array = { 11, 22, 13, 44, 52, 65, 17, 81 };

int n = array.Length;
int find = 2;

int index = 0;

while (index < n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}

