string testinput = "29535123p48723487597645723645";

string substring = ""; // saves found substring

string preMatch = " "; // saves string before found substring

string postMatch = ""; // saves string coming after found substring

long tot = 0;

for (int i = 0; i < testinput.Length; i++)
{
    int temp = 0;
    bool isNumber = int.TryParse(testinput[i] + "", out temp);
    if (isNumber == false)
    {
        continue;

    }

    for (int k = i + 1; k < testinput.Length; k++) 
    {
        if (!char.IsDigit(testinput[k])) // if not digit stop loop
        {
            break;
        }
        if (testinput[i] == testinput[k]) 
        {
            substring = testinput.Substring(i, k - i + 1); // Checks all indexes and saves the correct numbers as substring

            long match;
            long.TryParse(substring, out match);

            tot += match;

            preMatch = testinput.Substring(0, testinput.IndexOf(substring));

            postMatch = testinput.Substring(substring.Length + 
                preMatch.Length, (testinput.Length) - (substring.Length + preMatch.Length));

            Console.Write(preMatch);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(substring);
            Console.ResetColor();
            Console.WriteLine(postMatch);
            break;

        }
    }
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write($"All Substrings added together: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write($"**********{tot}**********");
Console.ResetColor();






