using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class logger
    {
        //constructer private'e çekilir ki new'lenmesin
        private logger() { }
        private static logger _logger;

        public static logger Logger
        {
            get { if (_logger == null)
                {
                    _logger = new logger();
                    return _logger;
                }
            else
                {
                    return _logger;
                }
            }
            
        }

    }
}
