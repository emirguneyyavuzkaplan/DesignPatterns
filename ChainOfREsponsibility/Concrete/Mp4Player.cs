using ChainOfResponsibility.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concrete
{
    public class Mp4Player : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".mp4"))
            {

                Console.WriteLine($"{fileType}tipinde dosya oynatilabiliyor");
            }
            else
            {
                Console.WriteLine("gecersiz dosya bicimi");
            }
        }
    }
}
