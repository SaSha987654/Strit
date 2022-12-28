Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task2": Task2(); break;
			case "Task4": Task4(); break;
			case "Task6": Task6(); break;
			case "Task8": Task8(); break;
			case "Task10": Task10(); break;
			case "Task19": Task19(); break;
			case "Task25": Task25(); break;
			case "Task29": Task29(); break;
			case "Task55": Task55(); break;
			case "Task53": Task53(); break;
			case "Task57": Task57(); break;
			case "Task34": Task34(); break;
			case "Task36": Task36(); break;
			case "Task38": Task38(); break;
			case "Task41": Task41(); break;
			case "Task43": Task43(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

void Task36()
{
    throw new NotImplementedException();
}

void Task57()
{
    throw new NotImplementedException();
}

void Task2()
{
	Console.WriteLine("Task2");

	int firstNumber = ReadInt("First number");
	int secondNumber = ReadInt("Second number");

	if (IsLargeThen(firstNumber, secondNumber))
	{
		Console.WriteLine("First number > Second number");
	}
	else
	{
		Console.WriteLine("Second number > First number");
	}
}

void Task4()
{
	Console.WriteLine("Task4:");

	int firstNumber = ReadInt("First number");
	int secondNumber = ReadInt("Second number");
	int thirdNumber = ReadInt("Third number");

	Console.WriteLine($"The largest value is {FindMax(firstNumber, secondNumber, thirdNumber)}");
}

void Task6()
{
	Console.WriteLine("Task 6:");

	int number = ReadInt("Number");
	string evenSuffix = string.Empty; // string.Empty = "";

	if (!IsEven(number)) // ! - слово "Не"
	{
		evenSuffix = "not";
	}

	Console.WriteLine($"Input number is {evenSuffix} even");
}

void Task8()
{
	Console.WriteLine("Task8");
	int n = ReadInt("N");

	Console.WriteLine(GetNumbersAsLineUntil(n));
}

void Task10()
{
	Console.WriteLine("Task10");
	int number = ReadInt("number");

	Console.WriteLine($"The second digit is {GetDigitFromNumber(number, 2)}");
}

void Task19()
{
	Console.WriteLine("Task19");

	string number = ReadInt("number").ToString();

	if (number[0] == number[4] && number[1] == number[3])
	{
		Console.WriteLine("It's a palindrom");
	}
	else
	{
		Console.WriteLine("It's not a palindrom");
	}
}

void Task25()
{
	Console.WriteLine("Task25");
int numberA = ReadInt("first number (A)");
	int numberB = ReadInt("second number (B)");

	Console.WriteLine($"The power {numberB} of number {numberA} is {Pow(numberA, numberB)}");
}

void Task29()
{
	Console.WriteLine("Task29");

	int[] array = GetArray(ReadInt("array length"));

	Console.WriteLine(ArrayToString(array));
}

int FindMax(int firstNumber, int secondNumber, int thirdNumber)
{
	int max = firstNumber;

	if (!IsLargeThen(firstNumber, secondNumber))
	{
		max = secondNumber;
	}

	if (IsLargeThen(thirdNumber, max))
	{
		max = thirdNumber;
	}

	return max;
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

bool IsLargeThen(int firstNumber, int secondNumber)
{
	return firstNumber > secondNumber;
}

bool IsEven(int number)
{
	return number % 2 == 0; // == - сравнение (результаты сравнения: true, false)
}

string GetNumbersAsLineUntil(int n)
{
	string result = string.Empty;

	for (int i = 1; i < n; i++)
	{
		if (IsEven(i))
		{
			result += $"{i} , ";
		}
	}

	return result;
}

int GetDigitFromNumber(int number, int digitPosition)
{
	string numberString = number.ToString();
	int move = numberString.Length - digitPosition;

	return int.Parse(numberString[numberString.Length - digitPosition].ToString());
}

int Pow(int firstNumber, int secondNumber)
{
	int result = 1;

	for (int i = 0; i < secondNumber; i++)
	{
		result *= firstNumber;
	}

	return result;
}

int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"elemtn {i}");
	}

	return array;
}

string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i]}, ";
	}

	return result;
}

//Task53();
Task55();

void Task53()
{
	int[,] array = GetTwoDimensionArray(ReadInt("First Length"), ReadInt("Secomd Length"));

	PrintArray(array);
	ChangeFirstAndLastRows(array);
	PrintArray(array);
}

#region CommonMethods
int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}

	Console.WriteLine();
}

int[,] GetTwoDimensionArray(int firstLength, int secondLength)
{
	int[,] array = new int[firstLength, secondLength];
	Random rnd = new Random();

	for (int i = 0; i < firstLength; i++)
	{
		for (int j = 0; j < secondLength; j++)
		{
			array[i, j] = rnd.Next(100);
		}
	}

	return array;
}

#endregion

#region Task53 
void ChangeFirstAndLastRows(int[,] array)
{
	int[] firstRow = GetFirstRow(array);
	PutLastRowOnFirstRow(array);
	PutFirstRowOnLastRow(array, firstRow);
}


int[] GetFirstRow(int[,] array)
{
	int[] tempArray = new int[array.GetLength(0)];

	for (int i = 0; i < array.GetLength(1); i++)
	{
		tempArray[i] = array[0, i];
	}

	return tempArray;
}

void PutLastRowOnFirstRow(int[,] array)
{
	int lastRowIndex = array.GetLength(0) - 1;

	for (int i = 0; i < array.GetLength(1); i++)
	{
		array[0, i] = array[lastRowIndex, i];
	}
}

void PutFirstRowOnLastRow(int[,] array, int[] firstRow)
{
	int lastRowIndex = array.GetLength(0) - 1;

	for (int i = 0; i < array.GetLength(1); i++)
	{
		array[lastRowIndex, i] = firstRow[i];
	}
}
#endregion


#region Task55

void Task55()
{
	int[,] array = GetTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
	PrintArray(array);

	if (!IsPossibleToChangeRowToColumns(array))
	{
		Console.WriteLine("Incorrect array");
		return;
	}

	int[,] copy = Copy(array);

	for (int i = 0; i < array.GetLength(0); i++)
	{
		ChangeRowOnColumn(array, copy, i);
	}

	PrintArray(array);
}

bool IsPossibleToChangeRowToColumns(int[,] array)
{
	return array.GetLength(0) < array.GetLength(1);
}

int[] GetRow(int[,] array, int rowNumber)
{
	int[] tempArray = new int[array.GetLength(0)];

	for (int i = 0; i < array.GetLength(0); i++)
	{
		tempArray[i] = array[rowNumber, i];
	}

	return tempArray;
}

void ChangeRowOnColumn(int[,] array, int[,] copy, int row)
{
	int[] changebaleRow = GetRow(copy, row);

	for (int i = 0; i < array.GetLength(1); i++)
	{
		if (i < changebaleRow.Length)
		{
			array[i, row] = changebaleRow[i];
		}
		else
		{

			array[row, array.GetLength(1) - (array.GetLength(1) - i)] = 0;
		}
	}

}

int[,] Copy(int[,] array)
{
	int[,] copy = new int[array.GetLength(0), array.GetLength(1)];

	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			copy[i, j] = array[i, j];
		}
	}

	return copy;
}

//Task34();
Task34();

void Task34()
{
	Console.WriteLine("Введите длину массива:  ");
}
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


//Task36();
Task36();

void Task36()

int size = 4;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sumNumbersEvenIndex = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sumNumbersEvenIndex += numbers[i];
}
Console.Write(sumNumbersEvenIndex);



void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}



/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/
void Task38()
int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
 
//Task41();
Task41();

void Task41()
{
    throw new NotImplementedException();
}

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
//Task43();
Task43();

void Task43()
{
    throw new NotImplementedException();
}

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");