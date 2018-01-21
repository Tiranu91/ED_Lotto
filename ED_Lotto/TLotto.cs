using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Lotto
{
    class TLotto
    {

        private int ilottozahlen;
        private int itip;
        private bool bresult;

        private TLotto()
        {

        }

        private static TLotto lotto = new TLotto();

        public static TLotto getInstance()
        {
            return lotto;
        }

        public int Lottozahlen
        {
            get { return ilottozahlen; }
            set { ilottozahlen = value; }
        }

        public int Tip
        {
            get { return itip; }
            set { itip = value; }
        }

        public bool Result
        {
            get { return bresult; }
            set { bresult = value; }
        }


        public void CalculateResult()
        {
            if (ilottozahlen == itip)
            {
                bresult = true;
            }
            else if(ilottozahlen != itip)
            {
                bresult = false;
            }
        }



    }
}
