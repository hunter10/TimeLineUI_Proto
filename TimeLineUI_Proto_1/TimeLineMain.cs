using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLineUI_Proto_1
{
    public partial class TimeLineMain : Form
    {
        public TimeLineMain()
        {
            InitializeComponent();
            DataGridViewInit();
        }

        public void DataGridViewInit()
        {
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

            //dataGridView3.ColumnHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;

            //pictureBox1.Image = Image.FromFile();

            for (int i = 0; i < 30; i++)
            {
                var editColumn = new DataGridViewTextBoxColumn
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    Width = 20,
                    Resizable = System.Windows.Forms.DataGridViewTriState.False
                };

                dataGridView2.Columns.Add(editColumn);
            }

            for (int i = 0; i < 30; i++)
            {
                string hText = ":";
                if ((i % 2) == 0)
                    hText = ".";

                var editColumn = new DataGridViewTextBoxColumn
                {
                    CellTemplate = new DataGridViewTextBoxCell(),
                    Width = 20,
                    HeaderText = hText,
                    //Visible = false,
                    Resizable = System.Windows.Forms.DataGridViewTriState.False
                };

                

                dataGridView3.Columns.Add(editColumn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Object-1", true, false);
            dataGridView2.Rows.Add("");
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                dataGridView3.HorizontalScrollingOffset = e.NewValue;
            }
        }
    }
}
