using ChainOfResponsibility.Lab2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Lab2.Abstract
{
    public abstract class MasrafYonetimiBase
    {
        protected MasrafYonetimiBase _sonraki;
        public void MasrafMErkezi(MasrafYonetimiBase sonraki)
        {
            _sonraki = sonraki;
        }
        public abstract void MasrafYonetimi(Masraf masraf);
    }
}
