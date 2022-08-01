int[] array = {1,2,83,14,55,6,27,8,9};

int n = array.Length;
int find = 14;
int index = 0;

while(index < n )
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}