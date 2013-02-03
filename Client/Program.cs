using System;
using System.Linq;

namespace Client
{
    /// <summary>
    /// Casos de uso.
    /// </summary>
    class Program
    {
        static void Main()
        {
            //using (var context = new School())
            //{
            //    var group1 = new Group { Name = "Matemanticas" };
            //    var group2 = new Group { Name = "Literatura" };
            //    var group3 = new Group { Name = "Sociales" };
            //    context.Groups.Add(group1);
            //    context.Groups.Add(group2);
            //    context.Groups.Add(group3);

            //    context.SaveChange();
            //    var stu1 = new User { LastName = "Peres1", Name = "Juan1", Group = group3 };
            //    var stu2 = new User { LastName = "Peres2", Name = "Juan2", Group = group1 };
            //    var stu3 = new User { LastName = "Peres3", Name = "Juan3", Group = group2 };
            //    var stu4 = new User { LastName = "Peres4", Name = "Juan4", Group = group1 };

            //    context.Users.Add(stu1);
            //    context.Users.Add(stu2);
            //    context.Users.Add(stu3);
            //    context.Users.Add(stu4);

            //    context.SaveChange();
            //}

            using (var context = new School())
            {
                
                var pedro = from p in context.Users
                            where p.Name == "Juan" && p.LastName == "Peres"
                            select new {p.Name, p.LastName};

                var people = context.Users.Where(p => p.Name == "Juan");
                foreach (var gente in people)
                {
                    Console.WriteLine(gente.Name);
                }
            }
        }
    }
}
