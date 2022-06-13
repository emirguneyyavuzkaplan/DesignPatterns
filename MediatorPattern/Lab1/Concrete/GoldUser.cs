using MediatorPattern.Lab1.Absract;
using MediatorPattern.Lab1.Mediator.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab1.Concrete
{
    public class GoldUser : IUser
    {
        string _username;
        IChatMediator chatMediator;
        public GoldUser(IChatMediator chatMediator, string username)
        {
            this.chatMediator = chatMediator;
            this._username = username;

        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanici Tİpi:Gold\nKullanici Adi:{_username}\nAlinan Mesaj:{message}");
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }
    }
}
