using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Lotto
{
    class TLotto
    {
        int[] lottery = new int[6];
        int[] tip = new int[6];
        bool[] result = new bool[6];
        int countedresult;
               

        private TLotto()
        {
            
        }

        private static TLotto lotto = new TLotto();

        public static TLotto getInstance()
        {
            return lotto;
        }

        public int[] Lottery
        {
            get { return lottery; }
            set { lottery = value; }
        }

        public int[] Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public bool[] Result
        {
            get { return result; }
            set { result = value; }
        }

        public int Countedresult
        {
            get { return countedresult; }
            set { countedresult = value; }
        }



        public void CalculateResultNumber1()
        {
            if (lottery[0] == tip[0])
            {
                result[0] = true;
            }
            else if(lottery[0] == tip[0])
            {
                result[0] = false;
            }
        }

        public void CalculateResultNumber2()
        {
            if (lottery[1] == tip[1])
            {
                result[1] = true;
            }
            else if (lottery[1] == tip[1])
            {
                result[1] = false;
            }
        }

        public void CalculateResultNumber3()
        {
            if (lottery[2] == tip[2])
            {
                result[2] = true;
            }
            else if (lottery[2] == tip[2])
            {
                result[2] = false;
            }
        }

        public void CalculateResultNumber4()
        {
            if (lottery[3] == tip[3])
            {
                result[3] = true;
            }
            else if (lottery[3] == tip[3])
            {
                result[3] = false;
            }
        }

        public void CalculateResultNumber5()
        {
            if (lottery[4] == tip[4])
            {
                result[4] = true;
            }
            else if (lottery[4] == tip[4])
            {
                result[4] = false;
            }
        }
            public void CalculateResultNumber6()
        {
                if (lottery[5] == tip[5])
                {
                    result[5] = true;
                }
                else if (lottery[5] == tip[5])
                {
                    result[0] = false;
                }
            }

        public void CalculateValues()
        {
            Countedresult = result.Count(c => c == true);
        }

    }
}
