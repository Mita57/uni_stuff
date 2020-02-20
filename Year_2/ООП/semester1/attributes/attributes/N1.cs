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
                if ((value >= 1 && value <= 9))
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
                if (value >= 0 && value <= 9)
                {
                    Val = D1 * 10 + value;
                }
            }
        }

        public void SetN2(int value)
        {
            if (value >= 10 && value <= 100)
            {
                _value = value;
            }
        }

        public void Swap()
        {
            Val = D2 * 10 + D1;
        }

        public bool LessThan(N1 d)
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
            return result;
        }

        public void Show()
        {
            Console.WriteLine(Info());
        }

        public bool IsSimm(N1 d)
        {
            return (d.Val == this.Val);
        }


        public int DigSum {
            get
            {
                int sum = 0;
                char[] cockAr = this.Val.ToString().ToCharArray();
                for (int i = 0; i < cockAr.Length; i++)
                {
                    sum += Convert.ToInt32(cockAr[i].ToString());
                }
                return sum;
            }

            set
            {
                string N2 = "9";
                string N1 = Convert.ToString(value - 9);
                string kek = N1 + N2;
                this.Val = Convert.ToInt32(kek);
            }

        }

        public int DigPrime
        {
            get
            {
                if (this.Val == 1)
                {
                    return 0;
                }
                for (int i = 2; i < this.Val / 2; i++)
                {
                    if ((this.Val % i) == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }


            set
            {
                int count1 = value;
                int count2 = value;
                while (true)
                {
                    for (int i = 2; i <= count1 / 2; i++)
                    {
                        if (count1 % i == 0)
                        {
                            break;
                        }
                        if (i == count1 / 2)
                        {
                            this.Val = count1;
                            return;
                        }
                    }
                    count1++;
                    count2--;
                    for (int i = 2; i <= count2 / 2; i++)
                    {
                        if (count2 % i == 0)
                        {
                            break;
                        }
                        if (i == count2 / 2)
                        {
                            this.Val = count2;
                            return;
                        }

                    }
                }
            }
        

        }
    }
}