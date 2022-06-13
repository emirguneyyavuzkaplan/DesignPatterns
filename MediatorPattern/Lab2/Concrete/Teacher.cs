using MediatorPattern.Lab2.Abstract;
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab2.Concrete
{
    public class Teacher:AssignedCourseMember
    {
      

        public Teacher(CoreMediator mediator) : base(mediator) { }
        public string Name { get; set; }
        public void ReceiveQuestion(string question, Student student) 
            => Console.WriteLine($"Teacher receive question from{student},{question}");
        public void AnswersQuestion(string question, Student student)
           => Console.WriteLine($"Teacher receive question from{student},{question}");

    }
}
