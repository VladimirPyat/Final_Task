// Задание написать программу которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 

int substringsCount(int substringLength, string[] userStringArray) //подсчет строк определенной длины в массиве string
{
  int count = 0;
  for (int i = 0; i < userStringArray.Length; i++)
  {
    if (userStringArray[i].Length <= substringLength) count++;
  }
  return count;
}

string[] substringsFill(int substringLength, int substringsNumber, string[] userStringArray) //заполнение нового массива строками с длиной меньше или равно заданной
{
  string[] shortStringsArray = new string[substringsNumber];
  int count = 0;
  for (int i = 0; i < userStringArray.Length; i++)
  {
    if (userStringArray[i].Length <= substringLength)
    {
      shortStringsArray[count] = userStringArray[i];
      count++;
    }
  }
  return shortStringsArray;
}

string[] stringArrayFill (int arrayLength)              //заполнение нового массива строк с клавиатуры
{
  string[] userStringArray = new string[arrayLength];
  for (int i = 0; i < arrayLength; i++)
  {
    Console.Write($"Ввод элемента {i} : ");
    userStringArray[i] = Console.ReadLine();
  }
  return userStringArray;
}

int userArrayLength = 4;          //число элементов пользовательского масива         
int shortStringLength = 3;         //длина строки для вхождения в новый массив по заданию
string[] sourceArray = stringArrayFill (userArrayLength);
Console.WriteLine("["+String.Join (", ", sourceArray)+"]");

string[] outcomeArray = substringsFill (shortStringLength, substringsCount (shortStringLength, sourceArray), sourceArray);

Console.WriteLine("|");
Console.WriteLine("V");
Console.WriteLine("["+String.Join (", ", outcomeArray)+"]");


