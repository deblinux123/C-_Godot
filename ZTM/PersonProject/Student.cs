using System.Dynamic;

public class Student
{
    private String name;
    private int studentId;
    private double grade;

    public Student(String name, int studentId, double grade)
    {
        this.name = name;
        this.studentId = studentId;
        this.grade = grade;
    }

    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public int StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    public double Grade
    {
        get { return grade; }
        set
        {
            if (value >= 0 && value <= 20)
            {
                grade = value;
            }
            else
            {
                Console.WriteLine("Invlaid value for grade.");
            }
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"name: {name}\nStudent Id: {studentId}\nGrade: {grade}");
    }
}