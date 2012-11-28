using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWATMS
{
    public class ButtonView : ToolStripMenuItem
    {
        private Data m_data;

        public ButtonView(Data data)
        {
            m_data = data;
            this.Text = data.Name;
            this.AutoSize = true;
        }

        public Data Data
        {
            get { return m_data; }
            set { m_data = value; }
        }
    }
}
