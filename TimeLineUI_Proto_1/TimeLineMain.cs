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
        PictureBox timeLinePicBox = new PictureBox();
        
        //private Bitmap m_OriginalImage = null;
        //private int X0, Y0, X1, Y1;
        //private bool SelectingArea = false;
        //private Bitmap SelectedImage = null;
        //private Graphics SelectedGraphics = null;


        Boolean mouseClicked;
        Point startPoint = new Point();
        Point endPoint = new Point();
        Rectangle rectCropArea;

        ICON_TYPE selectType = ICON_TYPE.NONE;

        private List<TimeObject> timeObj_List = new List<TimeObject>();

        public TimeLineMain()
        {
            InitializeComponent();
            DataGridViewInit();
        }

        public void DataGridViewInit()
        {
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



            timeLinePicBox.Height = 174;
            timeLinePicBox.Width = 4890;
            timeLinePicBox.SizeMode = PictureBoxSizeMode.Normal;
            timeLinePicBox.BackColor = Color.Transparent;
            timeLinePicBox.Paint += new PaintEventHandler(timeLinePicBox_Paint);
            timeLinePicBox.MouseClick += new MouseEventHandler(timeLinePicBox_MouseClick);
            timeLinePicBox.MouseMove += new MouseEventHandler(timeLinePicBox_MouseMove);
            timeLinePicBox.MouseUp += new MouseEventHandler(timeLinePicBox_MouseUp);
            timeLinePicBox.MouseDown += new MouseEventHandler(timeLinePicBox_MouseDown);

            //m_OriginalImage = new Bitmap(timeLinePicBox.Image);
            //m_OriginalImage = new Bitmap(timeLinePicBox.Width, timeLinePicBox.Height);

            // 이것때문에 PictureBox가 자동으로 스크롤됨
            flowLayoutPanel1.Controls.Add(timeLinePicBox);

            //flowLayoutPanel1
        }

        private void BtnObjectAdd_Click(object sender, EventArgs e)
        {
            TimeObject obj = new TimeObject();
            obj.Name = "test 1";
            obj.Lock = true;
            obj.View = false;
            timeObj_List.Add(obj);

            // 좌측 판넬 세팅
            dataGridView1.Rows.Add(timeObj_List[0].Name, 
                                   timeObj_List[0].Lock, 
                                   timeObj_List[0].View);

            // 우측 판넬 세팅
            //timeObj_List[0].DrawIcon(g, timeObj_List[0].StartPosIcon, timeObj_List[0].StartPos);
            //timeObj_List[0].DrawIcon(g, timeObj_List[0].EndPosIcon, timeObj_List[0].EndPos);
            timeLinePicBox.Invalidate();

            
        }


        private void BtnLineAdd_Click(object sender, EventArgs e)
        {
            _Lines.Add(new TimeLineUI_Proto_1.TimeLineMain.Line(new Point(20, 0), new Point(20, 300)));
            timeLinePicBox.Invalidate();
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

        private Rectangle MakeRectangle(int x0, int y0, int x1, int y1)
        {
            return new Rectangle(
                Math.Min(x0, x1),
                Math.Min(y0, y1),
                Math.Abs(x0 - x1),
                Math.Abs(y0 - y1));
        }

        private void timeLinePicBox_MouseClick(object sender, MouseEventArgs e)
        {
            timeLinePicBox.Refresh();

            // 아이콘 선택처리
            //Console.WriteLine(string.Format("({0},{1})", e.X, e.Y));
        }

        int startposoffset = -1;
        int endposoffset = -1;
        private void timeLinePicBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;

            startPoint.X = e.X;
            startPoint.Y = e.Y;
            endPoint.X = -1;
            endPoint.Y = -1;

            rectCropArea = new Rectangle(new Point(e.X, e.Y), new Size());

            bool result = timeObj_List[0].CheckIconPos(new Point(e.X, e.Y), out selectType);

            if (selectType == ICON_TYPE.FRAME_BODY)
            {
                startposoffset = e.X - timeObj_List[0].StartPos.X;
                endposoffset = timeObj_List[0].EndPos.X - e.X;
            }

            Console.WriteLine("type={0}", selectType);
        }

        private void timeLinePicBox_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            // 러버밴드 그리기
            Point ptCurrent = new Point(e.X, e.Y);

            if (mouseClicked)
            {
                if (endPoint.X != -1)
                {
                    // Display Coordinates
                    //X1.Text = startPoint.X.ToString();
                    //Y1.Text = startPoint.Y.ToString();
                    //X2.Text = e.X.ToString();
                    //Y2.Text = e.Y.ToString();
                }

                endPoint = ptCurrent;

                if (e.X > startPoint.X && e.Y > startPoint.Y)
                {
                    rectCropArea.Width = e.X - startPoint.X;
                    rectCropArea.Height = e.Y - startPoint.Y;
                }
                else if (e.X < startPoint.X && e.Y > startPoint.Y)
                {
                    rectCropArea.Width = startPoint.X - e.X;
                    rectCropArea.Height = e.Y - startPoint.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = startPoint.Y;
                }
                else if (e.X > startPoint.X && e.Y < startPoint.Y)
                {
                    rectCropArea.Width = e.X - startPoint.X;
                    rectCropArea.Height = startPoint.Y - e.Y;
                    rectCropArea.X = startPoint.X;
                    rectCropArea.Y = e.Y;
                }
                else
                {
                    rectCropArea.Width = startPoint.X - e.X;
                    rectCropArea.Height = startPoint.Y - e.Y;
                    rectCropArea.X = e.X;
                    rectCropArea.Y = e.Y;
                }

                timeLinePicBox.Refresh();
            }
            */

            //Point ptCurrent = new Point(e.X, e.Y);

            if (mouseClicked)
            {
                if(selectType == ICON_TYPE.START_POS)
                    timeObj_List[0].StartPos = new Point(e.X, timeObj_List[0].StartPos.Y);
                else if (selectType == ICON_TYPE.END_POS)
                    timeObj_List[0].EndPos = new Point(e.X, timeObj_List[0].EndPos.Y);
                else
                {
                    //int startposoffset = e.X - timeObj_List[0].StartPos.X;
                    //int endposoffset = timeObj_List[0].EndPos.X - e.X;
                    
                    timeObj_List[0].StartPos = new Point(e.X - startposoffset, timeObj_List[0].StartPos.Y);
                    timeObj_List[0].EndPos = new Point(e.X + endposoffset, timeObj_List[0].EndPos.Y);
                }


                CheckFlowLayoutPanelBound(new Point(e.X, 0));

                timeLinePicBox.Refresh();
            }
        }

        private void CheckFlowLayoutPanelBound(Point p)
        {
            // 일단 오른쪽 옆면부터
            int nEnd_Right = timeObj_List[0].EndPos.X + timeObj_List[0].EndPosIcon.Width;

            if(nEnd_Right > flowLayoutPanel1.Width)
            {
                flowLayoutPanel1.AutoScrollPosition = new Point(nEnd_Right - flowLayoutPanel1.Width, 0);
            }
        }

        private void timeLinePicBox_MouseUp(object sender, MouseEventArgs e)
        {
            //if (!SelectingArea) return;
            //SelectingArea = false;
            //SelectedImage = null;
            //SelectedGraphics = null;
            //timeLinePicBox.Image = m_OriginalImage;
            //timeLinePicBox.Refresh();

            //mouseClicked = false;


            mouseClicked = false;

            Console.WriteLine(string.Format("MouseUp e.X:{0}", e.X));
            Console.WriteLine(string.Format("EndPos.X :{0}", timeObj_List[0].EndPos.X));

            if (endPoint.X != -1)
            {
                Point currentPoint = new Point(e.X, e.Y);
                // Display coordinates
                //X2.Text = e.X.ToString();
                //Y2.Text = e.Y.ToString();

                //Console.WriteLine(string.Format("MouseUp e:{0}", e));
                //Console.WriteLine(string.Format("EndPos.X :{0}", timeObj_List[0].EndPos.X));

            }
            endPoint.X = -1;
            endPoint.Y = -1;
            startPoint.X = -1;
            startPoint.Y = -1;
        }

        private void timeLinePicBox_Paint(object sender, PaintEventArgs e)
        {
            //foreach (Line l in _Lines)
            //{
            //    e.Graphics.DrawLine(Pens.Red, l.Point1, l.Point2);
            //}

            if (timeObj_List.Count > 0)
            {
                timeObj_List[0].DrawIcon(e.Graphics, ICON_TYPE.START_POS);
                timeObj_List[0].DrawIcon(e.Graphics, ICON_TYPE.END_POS);

                timeObj_List[0].DrawFrameBox(e.Graphics);
            }

            Pen drawLine = new Pen(Color.Red);
            drawLine.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawRectangle(drawLine, rectCropArea);
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
            }

            timeLinePicBox.Invalidate();
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
            timeLinePicBox.Invalidate();
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
