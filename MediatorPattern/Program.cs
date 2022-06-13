using MediatorPattern.Lab1.Absract;
using MediatorPattern.Lab1.Concrete;
using MediatorPattern.Lab1.Mediator.Absract;
using MediatorPattern.Lab1.Mediator.Concrete;
using MediatorPattern.Lab2.Concrete;
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region orenk1
            //IChatMediator mediator = new ChatMediator();
            //IUser ali = new BasicUser(mediator, "Ali");
            //IUser veli = new BasicUser(mediator, "veli");
            //IUser ayse = new GoldUser(mediator, "ayse");
            //IUser fatma = new GoldUser(mediator, "fatma");

            //mediator.AddUser(ali);
            //mediator.AddUser(veli);
            //mediator.AddUser(ayse);
            //mediator.AddUser(fatma);

            //ali.SendMessage("Herkese merhaba");
            //ayse.SendMessage("selam ali. Nasilsin");
            #endregion
            #region örnek2
            //CoreMediator coreMediator = new CoreMediator();
            //Teacher teacher = new Teacher(coreMediator);
            //teacher.Name = "Ercan";

            //Student arif = new Student(coreMediator);
            //arif.Name = "arif";        
            //Student emir =new Student(coreMediator);
            //emir.Name = "emir";
            //coreMediator.Students = new List<Student>();
            //coreMediator.Students.Add(arif);
            //coreMediator.Students.Add(emir);

            //arif.SendQuention("Hocam bu $ işaretini niçin kullaniyoruz Ben TL Kullanmak istiyorum");
            //teacher.AnswersQuestion("parayi Veren dudugu calar arif.. Burada tl gecmez ", arif);
            //emir.SendQuention("Hocam Bu pattern nasildir");
            //teacher.AnswersQuestion("Sabalari kahvaltidan sonra iyi gider ",emir);
            #endregion

           




        }
    }
}
