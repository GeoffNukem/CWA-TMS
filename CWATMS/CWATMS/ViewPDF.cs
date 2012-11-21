using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CWATMS
{
    public partial class ViewPDF : Form
    {
        public ViewPDF()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = "-restrict";

            Process x = Process.Start(p);
        }
    }
}
