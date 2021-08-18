using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSegundoParcialProg
{
    public static class MiExtension
    {
        public static string ExtensionPicture(this PictureBox str)
        {
            string aux;
            aux = str.Name;
            return aux.Substring(aux.Length - 1, 1);
        }
    }
}
