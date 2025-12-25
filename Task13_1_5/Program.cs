int[] Check1 = { 1, 2, 4, 7, 9, 10 };
int[] Check2 = { 1, 2, 4, 7, 9, 8 };

bool boolCheck1 = CheckOnSorting(Check1);
bool boolCheck2 = CheckOnSorting(Check2);

Console.WriteLine($"{ boolCheck1} - { boolCheck2}");

static bool CheckOnSorting(int[] arrayForCheck)
{
    int arrayLeght = arrayForCheck.Length;

    bool check = true;

    for (int i = 1; i < arrayLeght; i++)
    {
        if (arrayForCheck[i] < arrayForCheck[i - 1])
        {
            check = false;
        }
    }

    return check;
}
