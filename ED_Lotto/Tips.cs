using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_Lotto
{
    public partial class Tips : Form
    {
        public Tips()
        {
            InitializeComponent();
        }

        private void btn_tip_Click(object sender, EventArgs e)
        {
            TLotto lotto = TLotto.getInstance();
            THighscore highscore = THighscore.getInstance();

            lotto.Tip[0] = Convert.ToInt32(tb_tip0.Text);
            lotto.Tip[1] = Convert.ToInt32(tb_tip1.Text);
            lotto.Tip[2] = Convert.ToInt32(tb_tip2.Text);
            lotto.Tip[3] = Convert.ToInt32(tb_tip3.Text);
            lotto.Tip[4] = Convert.ToInt32(tb_tip4.Text);
            lotto.Tip[5] = Convert.ToInt32(tb_tip5.Text);

            lotto.CalculateResultNumber1();
            lotto.CalculateResultNumber2();
            lotto.CalculateResultNumber3();
            lotto.CalculateResultNumber4();
            lotto.CalculateResultNumber5();
            lotto.CalculateResultNumber6();

            if (lotto.Result[0] == true)
            {
                lbl_number1.Text = "Richtig";
            }
            else if (lotto.Result[0] == false)
            {
                lbl_number1.Text = "Falsch";
            }

            if (lotto.Result[1] == true)
            {
                lbl_number2.Text = "Richtig";
            }
            else if (lotto.Result[1] == false)
            {
                lbl_number2.Text = "Falsch";
            }

            if (lotto.Result[2] == true)
            {
                lbl_number3.Text = "Richtig";
            }
            else if (lotto.Result[2] == false)
            {
                lbl_number3.Text = "Falsch";
            }

            if (lotto.Result[3] == true)
            {
                lbl_number4.Text = "Richtig";
            }
            else if (lotto.Result[3] == false)
            {
                lbl_number4.Text = "Falsch";
            }

            if (lotto.Result[4] == true)
            {
                lbl_number5.Text = "Richtig";
            }
            else if (lotto.Result[4] == false)
            {
                lbl_number5.Text = "Falsch";
            }

            if (lotto.Result[5] == true)
            {
                lbl_number6.Text = "Richtig";
            }
            else if (lotto.Result[5] == false)
            {
                lbl_number6.Text = "Falsch";
            }

            lotto.CalculateValues();
            lbl_result.Text = lotto.Countedresult.ToString();

            highscore.Ahighscore[0].name = tb_name.Text;
            highscore.Ahighscore[0].points = lotto.Countedresult;
        }

        private void btn_highscore_Click(object sender, EventArgs e)
        {
            
            THighscore highscore = THighscore.getInstance();
            /*
            TLotto lotto = TLotto.getInstance();

            highscore.Ahighscore[0].name = tb_name.Text;
            highscore.Ahighscore[0].points = lotto.Countedresult;
            */

            MessageBox.Show(highscore.Ahighscore[0].name.ToString() + highscore.Ahighscore[0].points.ToString());
        }
    }
}
