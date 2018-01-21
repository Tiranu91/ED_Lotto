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

            lotto.Lottozahlen = Convert.ToInt32(tb_lotto.Text);

            Tips tips = new Tips();
            tips.Show();



        }
    }
}
