using System;
using static System.Console;
class Admission
{
    static void Main()
    {
        double GPA;
        string GPAString;
        Write("Enter your GPA >> ");
        GPAString = ReadLine();
        GPA = Convert.ToDouble(GPAString);
        double testscore;
        string score;
        Write("Enter your test score >> ");
        score = ReadLine();
        testscore = Convert.ToDouble(score);
        if (GPA >= 3.6 && testscore >= 80)
            WriteLine("You are accepted");
        else if (GPA <= 3.6 && testscore >= 90)
            WriteLine("You are accepted");
        else
            WriteLine("You are rejected");
    }
}