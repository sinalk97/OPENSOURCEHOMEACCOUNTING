using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OPENSOURCEHOMEACCOUNTING
{
    public class Data
    {
        private string _filePath;
        private Controller _controller;

        public string FilePath { get => _filePath; set => _filePath = value; }
        public Controller Controller { get => _controller; set => _controller = value; }

        public Data(string path)
        {
            this.FilePath = path;
        }

        public Data(Controller con)
        {
            this.Controller = con;
        }

        public void open()
        {
            if (!File.Exists("path.dat"))
            {
                //Ask user where to save Data?
                Controller.getDataPathUserinput();
            }
            else
            {

            }
        }

        public void savePath(string path)
        {
            FileStream fs = new FileStream("path.dat",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(path + "\\");
            sw.Close();
            fs.Close();
            
        }

        public void saveData()
        {

        }
        
    }
}
