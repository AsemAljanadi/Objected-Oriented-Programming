// See https://aka.ms/new-console-template for more information
using DocumentFormat.OpenXml.Drawing.Diagrams;
using oopTest;


Student student1 = new Student();
student1.Id = 1;
student1.Name = "Mahran";
student1.Age = 37;
student1._Gender = 'M';
student1.PhoneNumber = 003365459;
student1.Email = "mahranoudi@gmail.com";
student1.Adress = "1 Rue Louis Viardot 21000 Dijon";


Student student2 = new Student(2,"Asem",34, 'M',06885555,"asem@gmail.com","dijon france");
Student student3 = new Student(3, "Alaa", 34, 'M', 065844, "alaa@gmail.com", "vien autrich");
//////##############################################################################################

List<Student> students = new List<Student>() { student1,student2,student3};

students.Add(new Student(4, "Ammar", 40, 'M', 06544, "sdlfj@sdf.com", "lskj"));

students.Add(new Student
{
    Id = 5,
    Name = "Basel",
    Age = 45,
    _Gender = 'M',
    PhoneNumber = 03655,
    Email = "qkf@qlkf.com",
    Adress = "qkfjsd"
});

students.AddRange(new Student[] {
    new Student (6, "Wessal", 50, 'F', 05578, "ghjjk@sdf.com", "iotyuyuyu"),
    new Student (7, "Bassam", 50, 'M', 063004, "sdlfj@sdf.com", "sgslskj"),
    new Student (8, "Osamma", 55, 'M', 06932, "sdlfj@sdf.com", "ppsgrezztskj")
});

foreach (Student student in students)
{
    Console.WriteLine(student.showInfo());
    studentSplit(student);
}

//studrnt1.PrintInfo();
//Console.WriteLine(studrnt1.showInfo());

 void studentSplit(Student student)
{
    Console.WriteLine(".........");
    string[] arrayOfInfo = student.showInfo().Split(',');

    foreach (string str in arrayOfInfo)
    {
        Console.WriteLine(str);
    }
    Console.WriteLine("...............................................");

}
//Console.WriteLine("##############################");

//IPerson teacher = new Teacher(55, "Alaa", 34, 1111, "eng.alaa.janadi@gmail.com", "Ospelgasse 31/18b", 'M');


//Console.WriteLine(teacher.ShowInfo());