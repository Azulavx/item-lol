using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    public class BFsword : Item
    {
        public BFsword()
        {
            name = "B.F sword";
            price = 1300;
            AddStat(Stat.AD, 40);
        }
    }
}
