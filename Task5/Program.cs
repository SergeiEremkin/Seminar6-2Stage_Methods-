int[] CopyArr (int [] arr)
{
    int[] newArray = new int [arr.Length];
    for(int i = 0; i<arr.Length; i++)
    {
        arr[i] = newArray[i];
    }
    return newArray;
}

void ShowArray(int [] arr)
{
    for(int i =0; i<arr.Length;i++)
    {
        Console.Write($"{arr.Length-i-1}  ");
        
    }
    System.Console.WriteLine();
}
int[] array = new int [] {1,2,3,4,5,6};
ShowArray(array);
int[] newArr = CopyArr(array);
ShowArray(newArr);