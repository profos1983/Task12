string filePath = "C:\\Code\\Repose\\Task12\\Task13_1_6\\cdev_Text.txt";

int wordCount = 0;

using (StreamReader sr = new StreamReader(filePath))
{
    string line;

    while ((line = sr.ReadLine()) != null)
    {
        string[] textString = line.Split(' ');
        for (int i = 0; i < textString.Length; i++)
        {
            if (!textString[i].Contains('\r') && textString[i].Length >= 1)
            {
                wordCount++;
            }
        }
    }

    Console.WriteLine(wordCount);
}




