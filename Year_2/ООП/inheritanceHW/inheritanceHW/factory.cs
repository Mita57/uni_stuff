using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceHW
{
    class Factory:Organization
    {

        public override void PoshelNaRabotu()
        {
            Console.WriteLine("Эх щас бы на завод после школы  24/7");
        }
    }
}
