void ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[arr.Length-i-1]} ");
    }
    System.Console.WriteLine();
}

void ShowArray(int [] arr)
{
    for(int i =0; i<arr.Length;i++)
    {
        Console.Write($"{arr[i]}  ");
        
    }
    System.Console.WriteLine();
}
int [] array = new int[] {1,2,3,4,5,6};
ShowArray(array);
ReversArray(array);
