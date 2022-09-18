/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами */
string[] InjectArray(string[] arrayInput)
{
    int count = 0;
    string readValue = "";
    System.Console.WriteLine("Введите массив строк. Разделение элементов - клавиша \"Enter\" ");
    System.Console.WriteLine("Для окончания ввода введите пустую строку, нажав \"Enter\"");
    do
    {
        readValue = Console.ReadLine();
        if (readValue.Length == 0) return (arrayInput);
        Array.Resize(ref arrayInput, ++count);
        arrayInput[count - 1] = readValue;
    } while (!(readValue.Length == 0));
    return (arrayInput);
}

string[] MakeResultArray(string[] arrayInput)
{
    string[] arrayResult = new string[0];
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
        if (arrayInput[i].Length <= 3)
        {
            Array.Resize(ref arrayResult, arrayResult.Length + 1);
            arrayResult[count] = arrayInput[i];
            count++;
        }
    }
    return (arrayResult);
}

void OutputArray(string[] arrayResult)
{
    System.Console.Write("Элементы массива, длиной менее 4-х символов --->  ");
    for (int i = 0; i < arrayResult.Length; i++)
    {
        System.Console.Write($"{arrayResult[i]}  ");
    }
System.Console.WriteLine();
}

string[] arrayInput = new string[0];
arrayInput = InjectArray(arrayInput);

string[] arrayResult = MakeResultArray(arrayInput);

OutputArray(arrayResult);

System.Console.WriteLine("The End");