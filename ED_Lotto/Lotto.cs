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
    public partial class Lotto : Form
    {
        public Lotto()
        {
            InitializeComponent();
        }

        private void btn_digits_Click(object sender, EventArgs e)
        {
            TLotto lotto = TLotto.getInstance();

            lotto.Lottery[0] = Convert.ToInt32(tb_lotto0.Text);
            lotto.Lottery[1] = Convert.ToInt32(tb_lotto1.Text);
            lotto.Lottery[2] = Convert.ToInt32(tb_lotto2.Text);
            lotto.Lottery[3] = Convert.ToInt32(tb_lotto3.Text);
            lotto.Lottery[4] = Convert.ToInt32(tb_lotto4.Text);
            lotto.Lottery[5] = Convert.ToInt32(tb_lotto5.Text);

            Tips tips = new Tips();
            tips.Show();



        }
    }
}
