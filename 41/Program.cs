Console.Write("Введите числа через пробел: ");
int[] array =  Console.ReadLine().Split().Select(int.Parse).ToArray();
int result = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        result++;
    }
}
 
Console.WriteLine(result);