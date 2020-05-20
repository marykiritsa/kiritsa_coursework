using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiritsa_coursework
{
    class WorkWithFileClass
    {
        private readonly string path = Environment.CurrentDirectory + "\\translator.txt";

        public void writeIntoFile(String translatedString)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, true, Encoding.Default))
                {
                    streamWriter.Write(translatedString);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
