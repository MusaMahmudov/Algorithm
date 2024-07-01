using System.Text;

int GetBinary(int number)
{
    if(number < 0)
        throw new ArgumentException();

    int result = 0;
    int charge = 1;

    while (number != 0)
    {

        int module = number % 2;
        result = result + charge * module;
        charge =  charge * 10;
        number = number / 2;

    }
    return result;

}
int GetReverse(int number)
{
    if(number < 0)
        throw new ArgumentException();

    var result = 0;
    int i = 0;
    while (number != 0)
    {
        var module = number % 10;
        result +=  module * (int)Math.Pow(2,i);
        number /=  10;
        i++;
    }

    return result;
}


Console.WriteLine(GetReverse(1100));
string GetWords(string sentence)
{
    StringBuilder smallest = new StringBuilder();
    StringBuilder longest = new StringBuilder();
    StringBuilder smallestTest = new StringBuilder();
    StringBuilder longestTest = new StringBuilder();
    sentence = sentence.Trim();
    bool firstSpace = false;
    for(int i = 0;i < sentence.Length; i++)
    {
        if(sentence[i] != ' ')
        {
            smallestTest.Append(sentence[i]);
            longestTest.Append(sentence[i]);
         
            if (!firstSpace)
            {
                smallest.Append(sentence[i]);
                longest.Append(sentence[i]);
            }

        }
        if (sentence[i] == ' ' || i == sentence.Length-1)
        {
            if(!firstSpace)
            firstSpace = true;

            if(smallest.Length > smallestTest.Length)
            {
                smallest = smallestTest;
            }
            if (longest.Length < longestTest.Length)
            {
                longest = longestTest;
            }

            smallestTest = new StringBuilder();
            longestTest = new StringBuilder();
        }
    }
    return smallest.ToString() + " " + longest.ToString();
}


Console.WriteLine(GetWords("Salam Musa Yaxwiyam Necesiz Salam"));

int GetMostPopular(int[] numbers)
{
    int result = 0;
    int resultAmount = 0;
    for (int i = 0;i < numbers.Length;i++)
    {
       
        int amount = 0;
        for (int j = i; j < numbers.Length; j++)
        {
            if (numbers[j] == numbers[i])
            {
                amount++;
            }

        }
        if (amount > resultAmount)
        {
            resultAmount = amount;
            result = numbers[i];
        }


    }
    return result;
}

Console.WriteLine(GetMostPopular(new int[] {0,6,6,6, 2,1, 2,3,3,2, 3, 4, 5,2,2, 6, 6 }));