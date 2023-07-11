// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] arr = new int[9];
FillArray(arr,-9,9);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(GetCount(arr));

void FillArray(int[] arr, int mini, int maxi)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(mini, maxi+1);
    }
}

int GetCount(int[] arr)
{
    int sum = 0; 
   for (int i=0; i<arr.Length; i++ )
   {
     
    if (i%2 == 1)
    {
       sum+=arr[i];
    }
   }
     return  sum;
}