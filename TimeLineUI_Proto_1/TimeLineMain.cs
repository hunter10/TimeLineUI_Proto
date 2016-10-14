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
            dataGridView1.RowHeadersVisible = true;

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
            /*
            ListViewItem lvi = new ListViewItem();
            lvi.Text = "Object-1";
            lvi.Name = "Name";
            ListViewItem.ListViewSubItem subItem1 = new ListViewItem.ListViewSubItem(lvi, "Lock");
            ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem(lvi, "View");

            lvi.SubItems.Add(subItem1);
            lvi.SubItems.Add(subItem2);
            */
            //dataGridView1.Rows.Add("Object-1", true, false);
            //dataGridView1.Rows.Add(lvi);

            List<TimeObject> childObj = new List<TimeObject>();
            childObj.Add(new TimeObject() { Name = "child", Lock = true, View = false });

            List<TimeObject> obj = new List<TimeObject>();
            obj.Add(new TimeObject() { Name = "aaa", Lock = false, View = false, child = childObj });

            var bindingList = new BindingList<TimeObject>(obj);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;



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
