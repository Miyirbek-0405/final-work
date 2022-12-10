string[] array = { "misha", "nasha", "-)", "off", "ti" };

void CreateNewArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int cout = 0;
        for (int j = 0; j < arr[i].Length; j++)
        {
            cout++;
        }
        if (cout <= 3)
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}
CreateNewArray(array);