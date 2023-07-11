// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

int[] arr = new int[8];
FillArray(arr,99,999);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(GetCount(arr));
void FillArray(int[] arr, int mini, int maxi)
{
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        arr[i] = new Random().Next(mini, maxi+1);
    }
}

int GetCount(int[] arr)
{
    int count = 0; 
   foreach (var item in arr)
   {
    if (item%2 == 0)
    {
       count++; 
    }
   }
     return  count;
}