using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OPENSOURCEHOMEACCOUNTING
{
    public class Controller
    {
        public Data data;
        public mainView mainView;
        public SaveView sv;

        public Controller()
        {
            data = new Data(this);
            mainView = new mainView();
            sv = new SaveView(this);
        }


        public void run()
        {
            data.open();
            mainView.ShowDialog();
        }

        public void getDataPathUserinput()
        {
            this.sv.ShowDialog();
        }

        public void savePath(string value)
        {
            this.data.savePath(value);
        }
    }
}
