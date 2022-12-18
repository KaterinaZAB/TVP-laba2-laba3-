using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    interface IRoomBuilder
    {
        public void BuildSofa();
        public void BuildChair();
        public void BuildTv();
        public void BuildCarpet();
        public void BuildCupboard();
        public void BuildArmChair();

        public Room GetRoom();
    }
}
