    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHelloWorld
{
    internal class linq
    {
        public static void linq_test()
        {
            #region linq
            List<Student> students = new List<Student> {
                new Student(1, "geraldo", "147985365-85",new string[]{"portugues", "geografia", "inglês"}, 58),
                new Student(2, "luiz",    "129852654-45",new string[]{"portugues", "matematica", "inglês","portugues"}, 100),
                 new Student(7, "luiz",    "129852654-45",new string[]{"portugues", "matematica", "inglês","portugues"}, 19),
                new Student(3, "Ronaldo", "987456258-55",new string[]{"portugues", "matematica", "inglês"}, 14),
                new Student(4, "Marcelo", "478159685-65",new string[]{"portugues", "matematica", "inglês","portugues", "matematica"}, 86),
                new Student(5, "douglas", "852657842-89",new string[]{"portugues", "matematica", "inglês"}, 69),
                new Student(6, "tifany",  "127584658-95",new string[]{"portugues", "matematica", "inglês"}, 95)
            };

            bool any = students.Any(); // se exite algum elemento na lista
            bool anyGrade = students.Any(l => l.Grade >= 70); // se existe algum elemeto que satisfaça a condição
            var singleeExcession = students.Single(s => s.Classes.Length > 4);// se tiver mais de um tem uma excessão
            var single = students.Single(s => s.Id == 3); // se existir ele retorna o valor
            var singleDefault = students.SingleOrDefault(s => s.Id == 8); // se não existir ele retorna nulo
            var first = students.First(s => s.Classes.Length > 4); // vai retornar o primeiro sempre se existir
           // var firstExcession = students.Single(s => s.Name.Equals("GERANDINHO", StringComparison.OrdinalIgnoreCase)); // excessão se não existir
            var firstDefault = students.SingleOrDefault(s => s.Name.Equals("GERANDINHO", StringComparison.OrdinalIgnoreCase)); // se não existir retorna null

            var orderedByGrade = students.OrderBy(s => s.Grade);
            var DecrescentOrderByID = students.OrderByDescending(s => s.Id);

            var whereStudentsApproved = students.Where(s => s.Grade >= 60); 

            var selectStudentsCpf = students.Select(students => students.Cpf);

            var studentsPhoneNumbers = students.SelectMany(s => s.PhoneNumbers); 

            var sum = students.Sum(s => s.Grade);
            var minGrade = students.Min(s => s.Grade);
            var maxGrade = students.Max(s => s.Grade);
            var count = students.Count();

            #endregion

            return;
        }
    }
    public class Student
    {
        public Student(int id, string name, string cpf, string[] classes, int grade)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Classes = classes;
            Grade = grade;
            PhoneNumbers = new List<string> {"995265849","998756544","998265874" };
            

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string[] Classes { get; set; }
        public int Grade { get; set; }
        public List<string> PhoneNumbers { get; set; }

    }
}

