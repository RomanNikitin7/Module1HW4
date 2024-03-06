Console.WriteLine("Enter the amount of elements at the array");

string? iStr = Console.ReadLine();

int n = 0;

if (iStr != null && int.TryParse(iStr, out n))
{
    var r = new Random();
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = r.Next(1, 27);
    }

    int[] evenArray = new int[n];
    int[] oddArray = new int[n];

    int evenCounter = 0;
    int oddCounter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenArray[evenCounter] = array[i];
            evenCounter++;
        }
        else
        {
            oddArray[oddCounter] = array[i];
            oddCounter++;
        }
    }
    Console.WriteLine("amount of even");
    Console.WriteLine(evenCounter);
    Console.WriteLine("amount of odd");
    Console.WriteLine(oddCounter);
    Array.Resize(ref evenArray, evenCounter);
    Array.Resize(ref oddArray, oddCounter);
    Console.WriteLine("even numbers");
    for (int i = 0; i < evenArray.Length; i++)
    {
        Console.Write(evenArray[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("odd numbers");
    for (int i = 0; i < oddArray.Length; i++)
    {
        Console.Write(oddArray[i] + " ");
    }

    string alphabet = "0abcdefghijklmnopqrstuvwxyz";

    char[] evenLettersArray = new char[evenCounter];
    char[] oddLettersArray = new char[oddCounter];

    Console.WriteLine();
    Console.WriteLine("first array alphabet");
    int firstArrayUpperAmount = 0;
    int secondArrayUpperAmount = 0;
    for (int i = 0; i < evenArray.Length; i++)
    {
        char letter = alphabet[evenArray[i]];
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'd' || letter == 'h' || letter == 'j')
        {
            letter = char.ToUpper(letter);
            firstArrayUpperAmount++;
        }

        evenLettersArray[i] = letter;
        Console.Write(evenLettersArray[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("second array alphabet");
    for (int i = 0; i < oddArray.Length; i++)
    {
        char letter = alphabet[oddArray[i]];
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'd' || letter == 'h' || letter == 'j')
        {
            letter = char.ToUpper(letter);
            secondArrayUpperAmount++;
        }

        oddLettersArray[i] = letter;
        Console.Write(oddLettersArray[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine($"first array contains {firstArrayUpperAmount} uppercase letters");
    Console.WriteLine($"second array contains {secondArrayUpperAmount} uppercase letters");
}