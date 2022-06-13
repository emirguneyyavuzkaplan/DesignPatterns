using ChainOfResponsibility.Lab2.Abstract;
using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Lab2.Concrete
{
    public class CEO : MasrafYonetimiBase
    {
        public override void MasrafYonetimi(Masraf masraf)
        {
            if (masraf.Tutar>=
                500 && masraf.Tutar<5000)
            {
                Console.WriteLine("Bu masraf ceo tarafindan yapilmistir");
            }
            else if (masraf.Tutar>=5000)
            {
                Console.WriteLine("sirketimi sattin ???");
            }
        }
    }
}
