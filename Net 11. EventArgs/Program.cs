using Net_11._EventArgs;

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

Teacher teacher = new Teacher() { FirstName="Tamerlan"};
Teacher teacher1 = new Teacher() { FirstName="Nadir"};

for (int i = 0; i < students.Count; i++)
{
    if (i % 2 == 0) teacher.examEvent += students[i].Exam;
    else teacher1.examEvent += students[i].Exam;
}

ExamEventArgs examEventArgs = 
    new ExamEventArgs { Task = "Napisat svoy kalkulyator" };
teacher.Exam(examEventArgs);
teacher1.Exam(new ExamEventArgs { Task = "Sozdat sayt" });


