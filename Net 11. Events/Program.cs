// Events
List<Student> students = new()
{
    new Student(){FirstName="Salam", LastName="Salamzade", Age=18},
    new Student(){FirstName="Yuliya", LastName="Sezarsalatova", Age=25},
    new Student(){FirstName="Napoleona", LastName="Bonapartova", Age=118},
    new Student(){FirstName="Hubba", LastName="Bubba", Age=12},
    new Student(){FirstName="Simba", LastName="bin Mufasa", Age=45},
    new Student(){FirstName="Timon", LastName="Timonich", Age=58},
    new Student(){FirstName="Pumba", LastName="Pumbovich", Age=77},
    new Student(){FirstName="Hakuna", LastName="Matata", Age=42}
};

Teacher teacher = new Teacher();

foreach (Student student in students)
{
    teacher.examEvent += student.Exam;
}

teacher.examEvent -= students[6].Exam;
teacher.Exam("Кратные, криволинейные и поверхностные интегралы");

public delegate void ExamDelegate(string task);