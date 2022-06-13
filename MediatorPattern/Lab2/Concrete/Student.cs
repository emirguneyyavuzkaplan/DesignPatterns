using MediatorPattern.Lab2.Abstract;
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab2.Concrete
{
    public class Student : AssignedCourseMember
    {
        //Student sinifi initialize edilirken icerisinde coremediator tirpinde bir parametre alacak
        //aldiği parametreye sinif icerinden kullanmadigimizdan dolayi sadece temel sinifa gobndermek icin aldik.

        public Student(CoreMediator coreMediator) : base(coreMediator)
        {


        }
        public string Name { get; set; }
        public void SendQuention(string message)
        {
            Console.WriteLine($"{Name}:{message}");

        }
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Student receive answer:{message}");

        }
    }
}
