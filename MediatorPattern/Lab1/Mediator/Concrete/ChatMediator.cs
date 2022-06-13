using MediatorPattern.Lab1.Absract;
using MediatorPattern.Lab1.Mediator.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Lab1.Mediator.Concrete
{
    public class ChatMediator : IChatMediator
    {
        private List<IUser> Users;
        public ChatMediator()
        {
            Users = new List<IUser>();

        }
        public void AddUser(IUser user)
        {
            Users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (var user in Users)
            {

                if (user != sender)
                {
                    user.ReceiveMessage(message);

                }

            }
        }
    }
}
