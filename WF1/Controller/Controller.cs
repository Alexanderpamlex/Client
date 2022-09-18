using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public class Controller
    {

        private Model.Model _model;

        public Controller(Model.Model model)
        {
            _model = model;
        }


        public void setX(Label label)
        {

            _model.SetX(label);

        }

        public void setX(TableLayoutPanel tlp, int x, int y)
        {

            _model.SetX(tlp,x,y);

        }

        public void setO(Label label)
        {

            _model.SetO(label);

        }

        public void setO(TableLayoutPanel tlp, int x, int y)
        {

            _model.SetO(tlp,x,y);

        }

        public void Win(TableLayoutPanel tlp)
        {

            _model.WinCheck(tlp);

        }



    }

}

