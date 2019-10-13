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
            char[] cockAr = this.Val.ToString().ToCharArray();
            for(int i = 0; i < cockAr.Length; i++)
            {
                sum += Convert.ToInt32(cockAr[i].ToString());
            }
            return sum;
        }

        public void DigSum(int value)
        {
            int num = 0;
            while (true)
            {
                int sum = 0;
                char[] araTyCho = num.ToString().ToCharArray();
                for(int i = 0; i < araTyCho.Length; i++)
                {
                    sum += Convert.ToInt32(araTyCho[i].ToString());
                }
                if(sum == value)
                {
                    this.Val = num;
                    break;
                }
                num++;
            }
        }

        public bool DigPrime()
        {
            if(this.Val == 1)
            {
                return false;
            }
            for (int i = 2; i < this.Val/2; i++)
            {
                if((this.Val%i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void DigPrime(bool flag)
        {
            int count1 = this.Val;
            int count2 = this.Val;
            int closest = 2;
            while (true)
            {
                bool flag1 = false;
                count1++;
                for (int i = 2; i < count1 / 2; i++)
                {
                    if ((this.Val % i) == 0)
                    {
                        closest = count1;
                        flag1 = true;
                        break;
                    }
                }
                if (flag1)
                {
                    break;
                }
                count2--;
                for (int i = 2; i < count2 / 2; i++)
                {
                    if ((this.Val % i) == 0)
                    {
                        closest = count2;
                        flag1 = true;
                        break;
                    }
                }
                if (flag1)
                {
                    break;
                }
                this.Val = closest;

            }
        }

    }
}
