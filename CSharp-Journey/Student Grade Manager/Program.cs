namespace Student_Grade_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = GetStudentName();
            int[] grades = new int[3];

            for (int i = 0; i < 3; i++)
            {
                grades[i] = GetScore();    
            }

            double studentAverage = CalculateAverage(grades[0], grades[1], grades[2]);
            string studentGrade = GetGrade(studentAverage);

            PrintResult(studentName, studentAverage, studentGrade);
        }

        static string GetStudentName()
        {
            Console.Write("Please enter student name: ");
            string studentName = Console.ReadLine();
            return studentName;
        }

        static int GetScore()
        {
            Console.Write("Please enter grade: ");
            int grade = int.Parse(Console.ReadLine());
            return grade;
        }

        static string GetGrade(double average)
        {
            string studentGrade;

            if(average >= 90)
            {
                studentGrade = "A";    
            }
            else if(average >= 70 && average < 90)
            {
                studentGrade= "B";
            }
            else if(average >= 50 && average < 70)
            {
                studentGrade = "C";
            }
            else
            {
                studentGrade = "F";
            }
            return studentGrade;
        }

        static double CalculateAverage(int grade1, int grade2, int grade3)
        {
            double average = (grade1 + grade2 + grade3) / 3.0;
            return average;
        }

        static void PrintResult(string name, double average, string grade)
        {
            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
