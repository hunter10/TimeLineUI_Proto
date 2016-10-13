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
        private List<Line> _Lines = new List<Line>();
        Timer timer = new System.Windows.Forms.Timer();
        PictureBox p1 = new PictureBox();

        Graphics g;
        Bitmap canvas;
        Image smallIcon;

        Point smallIconPos;

        public TimeLineMain()
        {
            InitializeComponent();
            DataGridViewInit();
        }

        public void DataGridViewInit()
        {
            smallIcon = Image.FromFile(@"D:\Work\GitProject\TimeLineUI_Proto\TimeLineUI_Proto_1\PNGS\emblem-new.png");
            smallIconPos = new Point(0, 0);

            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

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
            }

            canvas = new Bitmap(4890, 174);

            p1.Height = 174;
            p1.Width = 4890;
            p1.SizeMode = PictureBoxSizeMode.Normal;
            p1.BackColor = Color.Transparent;
            p1.Image = canvas;
            p1.Paint += new PaintEventHandler(p1_Paint);
            p1.MouseClick += new MouseEventHandler(p1_Click);
            p1.MouseMove += new MouseEventHandler(p1_MouseMove);

            //g = this.CreateGraphics();
            g = Graphics.FromImage(canvas);

            flowLayoutPanel1.Controls.Add(p1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Object-1", true, false);
        }

        private void BtnLineAdd_Click(object sender, EventArgs e)
        {
            _Lines.Add(new TimeLineUI_Proto_1.TimeLineMain.Line(new Point(20, 0), new Point(20, 300)));
            p1.Invalidate();
        }

        public class Line
        {
            public Point Point1 { get; set; }
            public Point Point2 { get; set; }

            public Line(Point point1, Point point2)
            {
                this.Point1 = point1;
                this.Point2 = point2;
            }
        }

        private void p1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = e as MouseEventArgs;
            if (mouseEventArgs != null)
                Console.WriteLine(string.Format("{0},{1}", mouseEventArgs.X, mouseEventArgs.Y));
        }

        private void p1_MouseMove(object sender, EventArgs e)
        {
            //var mouseEventArgs = e as MouseEventArgs;
            //if (mouseEventArgs != null)
            //    Console.WriteLine(string.Format("{0},{1}", mouseEventArgs.X, mouseEventArgs.Y));
        }

        private void p1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(Color.Transparent);
            foreach (Line l in _Lines)
            {
                e.Graphics.DrawLine(Pens.Red, l.Point1, l.Point2);
            }

            e.Graphics.DrawImage(smallIcon, new Rectangle(smallIconPos.X, smallIconPos.Y, 16, 16));
            //e.Graphics.DrawImage(smallIcon, new Rectangle(50, 0, 16, 16));
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            // 윈폼 타이머 사용
            
            timer.Interval = 10; // 1초
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        // 매 1초마다 Tick 이벤트 핸들러 실행
        void timer_Tick(object sender, EventArgs e)
        {
            // UI 쓰레드에서 실행. 
            // UI 컨트롤 직접 엑세스 가능
            foreach (Line l in _Lines)
            {
                l.Point1 = new Point(l.Point1.X + 1, l.Point1.Y);
                l.Point2 = new Point(l.Point2.X + 1, l.Point2.Y);

                smallIconPos = new Point(smallIconPos.X + 1, smallIconPos.Y);
            }

            p1.Invalidate();
        }

        private void BtnTimeStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void BtnTimeAdd_Click(object sender, EventArgs e)
        {
            //Image smallIcon = Image.FromFile("D:\\Work\\GitProject\\TimeLineUI_Proto\\TimeLineUI_Proto_1\\Resources\\emblem-new.png");
            //Image smallIcon = Image.FromFile(@"D:\Work\GitProject\TimeLineUI_Proto\TimeLineUI_Proto_1\PNGS\emblem-new.png");
            //foreach (Line l in _Lines)
            //{
            //    g.DrawLine(Pens.Red, l.Point1, l.Point2);
            //}

            _Lines.Add(new TimeLineUI_Proto_1.TimeLineMain.Line(new Point(20, 0), new Point(20, 300)));
            p1.Invalidate();
        }
    }
}
