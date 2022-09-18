using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1.Model
{
    public class Model
    {


        public void SetX(Label label)
        {

            label.Text = "X";

        }

        public void SetX(TableLayoutPanel tlp, int x, int y)
        {

            tlp.GetControlFromPosition(x, y).Invoke((MethodInvoker)delegate ()
            {

                tlp.GetControlFromPosition(x, y).Text = "X";

            });

        }

        public void SetO(Label label)
        {

            label.Text = "O";

        }

        public void SetO(TableLayoutPanel tlp, int x, int y)
        {

            tlp.GetControlFromPosition(x, y).Invoke((MethodInvoker)delegate ()
            {

                tlp.GetControlFromPosition(x, y).Text = "O";

            });

        }

        public void WinCheck(TableLayoutPanel tlp)
        {


            win(
                tlp.GetControlFromPosition(0, 0),
                tlp.GetControlFromPosition(0, 1),
                tlp.GetControlFromPosition(0, 2)
                );

            win(
                tlp.GetControlFromPosition(1, 0),
                tlp.GetControlFromPosition(1, 1),
                tlp.GetControlFromPosition(1, 2)
                );

            win(
                tlp.GetControlFromPosition(2, 0),
                tlp.GetControlFromPosition(2, 1),
                tlp.GetControlFromPosition(2, 2)
                );

            win(
                tlp.GetControlFromPosition(0, 0),
                tlp.GetControlFromPosition(1, 0),
                tlp.GetControlFromPosition(2, 0)
                );

            win(
                tlp.GetControlFromPosition(0, 1),
                tlp.GetControlFromPosition(1, 1),
                tlp.GetControlFromPosition(2, 1)
                );

            win(
                tlp.GetControlFromPosition(0, 2),
                tlp.GetControlFromPosition(1, 2),
                tlp.GetControlFromPosition(2, 2)
                );

            win(
                tlp.GetControlFromPosition(1, 1),
                tlp.GetControlFromPosition(0, 0),
                tlp.GetControlFromPosition(2, 2)
                );

            win(
                tlp.GetControlFromPosition(1, 1),
                tlp.GetControlFromPosition(0, 2),
                tlp.GetControlFromPosition(2, 0)
                );

        }


        public void win(Control x, Control y, Control z)
        {

            string s = x.Text;

            if (x.Text == y.Text && y.Text == z.Text)
            {
                switch (s)
                {
                    case "X":
                        MessageBox.Show("Вы победили!");
                        break;

                    case "O":
                        MessageBox.Show("Вы проиграли!");
                        break;
                }
            }

        }

    }

}

