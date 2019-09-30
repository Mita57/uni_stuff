using System;
using System.Collections.Generic;
using System.Text;

namespace inheritanceHW
{
    class InsuranceCompany : Organization
    {

        public override void PoshelNaRabotu()
        {
            Console.WriteLine("Страховка на почку 2281334$");
        }
    }
}
