class Program
{
    static List<Students> students = new List<Students>();
    static void Main(string[] args)
    {
        int menuChoice = 0;

        students.Add(new Students("Stacy", "Read", "sread@wctc.edu"));
        students.Add(new Students("Brittney", "Schultz", "bschultz43@wctc.edu"));
        students.Add(new Students("Matthew", "Green", "mgreen14@wctc.edu"));

        do
        {
            menuChoice = GetMenuOption();

            switch (menuChoice)
            {
                case 1:
                    AddStudents();
                    Console.WriteLine(" ");
                    break;
                case 2:
                    DeleteStudents();
                    Console.WriteLine(" ");
                    break;
                case 3:
                    EditStudents();
                    Console.WriteLine(" ");
                    break;
                case 4:
                    ListStudents();
                    Console.WriteLine(" ");
                    break;
                case 5:
                    Console.WriteLine("Thank you for using this Student Club Manager! ");
                    break;
                default:
                    Console.WriteLine("Please Select 1-5");
                    Console.WriteLine(" ");
                    break;
            }
        } while (menuChoice !=5);
    }
    static int GetMenuOption()
    {
        Console.WriteLine("Student Club Management");
        Console.WriteLine("1. Add a Student");
        Console.WriteLine("2. Delete a Student");
        Console.WriteLine("3. Edit Student Information");
        Console.WriteLine("4. List Student Information");
        Console.WriteLine("5. Exit");
        Console.WriteLine(" ");
        Console.Write("Select An Option: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    static void AddStudents()
    {
        students.Add(new Students());
    }
    static void DeleteStudents()
    {
        ListStudents();
        Console.Write("Which student would you like to delete from the registry? ");
        int studentChoice = Convert.ToInt32(Console.ReadLine());
        students.RemoveAt(studentChoice-1);
        Console.WriteLine("Student deleted successfully ");
    }
    static void EditStudents()
    {
        ListStudents();
        Console.Write("Which student's information would you like to edit? ");
        int studentChoice = Convert.ToInt32(Console.ReadLine());
        
        Students currentStudent = students[studentChoice-1];
        Console.Write("Edit Student First Name: ");
        currentStudent.FirstName = Console.ReadLine();
        Console.Write("Edit Student Last Name: ");
        currentStudent.LastName = Console.ReadLine();
        Console.Write("Edit Student Email Address: ");
        currentStudent.Email = Console.ReadLine();
        Console.WriteLine("Student edited successfully");
        
    }
    static void ListStudents()
    {
        int studentCounter = 1;

        foreach(Students student in students)
        {
            Console.WriteLine($"{studentCounter++}. {student}");
        }
    }
}