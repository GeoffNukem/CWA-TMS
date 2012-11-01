using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //this.Parent.Save += new System.EventHandler(this.Save);     
        }

        public void Save(object sender, EventArgs e)
        {
        }
            // for (int row = 0; row < count; row++)
            // {
            //int colCount = dgv.Rows[row].Cells.Count;
            //for (int col = 0; col < colCount; col++)
            //{
            // objWriter.WriteLine(dgv.Rows[row].Cells[col].Value.ToString());

            // }
            // record seperator could be written here.
            // }
            
            //--------------------------------------------------------------------
            //var strValue = new StringBuilder();

            //foreach (DataGridViewRow row in dataGridView1.Rows)
           // {
               // strValue.AppendLine(row.Cells[0].Value + "," + row.Cells[1].Value);
           // }

           // string strFile = Properties.Settings.Default.AutoCompleteFile; //File Path

           // if (!string.IsNullOrEmpty(strValue.ToString()))
           // {
               // File.WriteAllText(strFile, strValue.ToString(), Encoding.UTF8);
           // }

        }
        

    public class HMergedCell : DataGridViewTextBoxCell
    {
        private int m_nLeftColumn = 0;
        private int m_nRightColumn = 0;

        /// <summary>
        /// Column Index of the left-most cell to be merged.
        /// This cell controls the merged text.
        /// </summary>
        public int LeftColumn
        {
            get
            {
                return m_nLeftColumn;
            }
            set
            {
                m_nLeftColumn = value;
            }
        }

        /// <summary>
        /// Column Index of the right-most cell to be merged
        /// </summary>
        public int RightColumn
        {
            get
            {
                return m_nRightColumn;
            }
            set
            {
                m_nRightColumn = value;
            }
        }



    }// class
}
       // private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
       // {
           // DataGridView gridView = sender as DataGridView;

               // gridView.Rows[0].HeaderCell.Value = "2009";
                //gridView.Rows[1].HeaderCell.Value = "2009";
               // gridView.Rows[2].HeaderCell.Value = "2009";
                //gridView.Rows[3].HeaderCell.Value = "2009";
                //gridView.Rows[4].HeaderCell.Value = "2009";
            
        //}

        //private void Form2_Load(object sender, EventArgs e)
        //{
            //this.dataGridView1.Rows.Item(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // private void Form2_Load(object sender, EventArgs e)
        //{
            //DataGridView dt = new DataGridView();
            //dt.Columns.Add("Id", typeof(int));
            //for (int i = 1; i < 6; i++)
            //{
             //   dt.Rows.Add(i);
            //}
            //dataGridView1.DataSource = dt;
            //dataGridView1.Rows[0].HeaderCell.Value = "Id";
            
            
           // DataGridViewRowHeaderCell vHeader = this.dataGridView1.Rows[0].HeaderCell;
	        //vHeader.ValueType = typeof(String);
            //vHeader.Value = "oh herro!";

 


