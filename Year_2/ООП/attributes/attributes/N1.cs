using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes
{
    class N1
    {
        private string _name;
        private int _value;
        public N1(string Name)
        {
            _name = Name;
            _value = 10;
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Val
        {
            get
            {
                return _value;
            }
            set
            {
                SetN2(value);
            }
        }

        public bool Odd
        {
            get
            {
                return Val % 2 == 1;
            }
        }

        public int D1
        {
            get
            {
                return Val / 10;
            }
            set
            {
                if((value >= 1 && value <= 9))
                {
                    Val = value * 10 + D2;
                }
            }
        }

        public int D2
        {
            get
            {
                return Val % 10;
            }
            set
            {
                if(value >= 0 && value <= 9)
                {
                    Val = D1 * 10 + value;
                }
            }
        }

        public void SetN2 (int value)
        {
            if(value >= 10 && value <= 90)
            {
                _value = value;
            }
        }

        public void Swap()
        {
            Val = D2 * 10 + D1;
        }

        public bool LessThan (N1 d)
        {
            return Val < d.Val;
        }

        public string Info()
        {
            string result = string.Format("Двузначное число '{0}' = {1}. Цифры {2} и {3} ", Name, Val, D1, D2);
            if (Odd)
            {
                result += "Нечетное";
            }
            else
            {
                result += "Четное";
            }
            return  result;
        }

        public void Show()
        {
            Console.WriteLine(Info());
        }

        public bool IsSimm(N1 d)
        {
            return (d.Val == this.Val);
        }
        public int DigSum()
        {
            int sum = 0;
            char[] cockAr = Val.ToString().ToCharArray();
            foreach(char cock in cockAr)
            {
                sum += Convert.ToInt32(cock);
            }
            return sum;
        }

        public int DigSum(int cock)
        {
            int dick = 0;
            while (true)
            {
                int sum = 0;
                char[] cockAr = dick.ToString().ToCharArray();
                foreach (char meme in cockAr)
                {
                    sum += Convert.ToInt32(meme);
                }
                dick++;
                if(sum == cock)
                {
                    return dick;
                }

            }
        } 

        public bool DigSimple()
        {

        }

    }
}
