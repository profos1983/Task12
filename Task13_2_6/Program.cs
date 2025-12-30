using System.Collections;

var inputArray = new ArrayList()
{
    1,
    "erer",
    3,
    "dfdf",
    6
};

var ouputArray = ArrayListWithInfo( inputArray);
foreach (var item in inputArray)
{
    Console.Write(item);
}

Console.WriteLine();

foreach (var item in ouputArray)
{
    Console.Write(item);
}





static ArrayList ArrayListWithInfo ( ArrayList input)
{
    ArrayList inputArrayForMetod = new ArrayList();
    inputArrayForMetod = (ArrayList)input.Clone();
    
    int sumIngInInput = 0;


    string allStringInInput ="";

    for(int i  = 0; i < inputArrayForMetod.Count; i++)
    {
        if (int.TryParse(inputArrayForMetod[i].ToString(), out int number))
        {
            sumIngInInput = sumIngInInput + number;
        }

        if (inputArrayForMetod[i].GetType() == typeof(string))
        {
            allStringInInput = String.Concat(allStringInInput, inputArrayForMetod[i].ToString());
        }
    }

    inputArrayForMetod.Insert(0, sumIngInInput);
    inputArrayForMetod.Add(allStringInInput);

    return inputArrayForMetod;
}
