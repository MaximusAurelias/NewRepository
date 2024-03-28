namespace assignment1;
class Program
{
    static void Main(string[] args)
    {
        Program myProgram = new Program();
        myProgram.Start();
    }

    void Start()
    {
        List<Course> gradeList = ReadGradeList(3);

        DisplayGradeList(gradeList);
       
    }

    PracticalGrade ReadPracticalGrade(string question)
    {
        Console.WriteLine(question);
        Console.ForegroundColor = ConsoleColor.Green;
        int grade = int.Parse(Console.ReadLine());
        Console.ResetColor();

       switch (grade)
        {
            case 0:
                return PracticalGrade.None;
            case 1:
                return PracticalGrade.Absent;
            case 2:
                return PracticalGrade.Insufficient;
            case 3:
                return PracticalGrade.Sufficient;
            case 4:
                return PracticalGrade.Good;

            default:
                Console.WriteLine("Invalid Input");
                return PracticalGrade.None;
        }

       


    }

    void DisplayPracticalGrade(PracticalGrade practical)
    {
        Console.WriteLine($"Practical grade :  {practical}");
    }

    Course ReadCourse(string question)
    {
        Console.WriteLine("Enter a course. ");
        Course c = new Course();

       
        c.name = ReadString($"Name of the course: ");
        Console.ResetColor();
        
        c.TheoryGrade = ReadInt($"Theory grade for {c.name}: ");
        Console.ResetColor();


        c.Practical = ReadPracticalGrade($"Practical grade for {c.name}");

        return c;

    }

    void DisplayCourse(Course c)
    {
        Console.WriteLine($"{c.name} : {c.TheoryGrade}");
        DisplayPracticalGrade(c.Practical);
    }

    List<Course> ReadGradeList(int nrOfCourses)
    {
        List<Course> gradeList = new List<Course>();

        for(int i = 0; i< nrOfCourses; i++)
        {
            Course course = new Course();

            course = ReadCourse("Name of course: ");
            gradeList.Add(course);
            
        }

        return gradeList;
    }

    void DisplayGradeList(List<Course> gradeList)
    {
        foreach(Course course in gradeList)
        {
            DisplayCourse(course);
            Console.WriteLine();
        }
    }

    

    int ReadInt(string question)
    {

        Console.Write(question);
        Console.ForegroundColor = ConsoleColor.Green;

        int input = int.Parse(Console.ReadLine());

        return input;
    }

    string ReadString(string question)
    {
        
        Console.Write(question);
        Console.ForegroundColor = ConsoleColor.Green;

        return Console.ReadLine();
    }
}

