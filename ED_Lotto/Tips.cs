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

            lotto.Tip = Convert.ToInt32(tb_tip.Text);

            lotto.CalculateResult();

            if (lotto.Result == true)
            {
                lbl_result.Text = "Richtig";
            }
            else if (lotto.Result == false)
            {
                lbl_result.Text = "Falsch";
            }
        }
    }
}
