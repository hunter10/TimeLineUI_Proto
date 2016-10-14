using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TimeLineUI_Proto_1
{
    public enum ICON_TYPE
    {
        NONE,
        START_POS,
        END_POS,
        FRAME_BODY
    }

    class TimeObject
    {
        public String Name { get; set; }
        public bool Lock { get; set; }
        public bool View { get; set; }

        public Point StartPos { get; set; }
        public Point EndPos { get; set; }
        public Image StartPosIcon { get; set; }
        public Image EndPosIcon { get; set; }

        int nStartX = 5;
        int nStartY = 5;

        int nGapOffset = 5;

        public TimeObject()
        {
            //StartPosIcon = Image.FromFile(@"D:\Work\GitProject\TimeLineUI_Proto\TimeLineUI_Proto_1\PNGS\emblem-new.png");
            //StartPosIcon = Image.FromFile(@"..\..\PNGS\emblem-new.png");
            StartPosIcon = Image.FromFile(@"..\..\PNGS\go-first.png");
            StartPos = new Point(nStartX, nStartY);

            //EndPosIcon = Image.FromFile(@"D:\Work\GitProject\TimeLineUI_Proto\TimeLineUI_Proto_1\PNGS\emblem-new.png");
            //EndPosIcon = Image.FromFile(@"..\..\PNGS\emblem-new.png");
            EndPosIcon = Image.FromFile(@"..\..\PNGS\go-last.png");
            EndPos = new Point(StartPosIcon.Width + nGapOffset, nStartY);
        }
        
        public void DrawIcon(Graphics g, Image image, Point point)
        {
            g.DrawImage(image, new Rectangle(point.X, point.Y, image.Width, image.Height));
        }

        public void DrawIcon(Graphics g, ICON_TYPE type)
        {
            Point? tempP;
            if (type == ICON_TYPE.START_POS)
            {
                DrawIcon(g, StartPosIcon, StartPos);
                tempP = StartPos;
            }
            else
            {
                DrawIcon(g, EndPosIcon, EndPos);
                tempP = EndPos;
            }

            //Console.WriteLine(string.Format("----------------"));
            //Console.WriteLine(string.Format("Type:{0} ({1},{2})", type, tempP.Value.X, tempP.Value.Y));
        }

        public bool CheckIconPos(Point p, out ICON_TYPE type)
        {

            if ((p.X > StartPos.X) &&
               (p.X < StartPos.X + StartPosIcon.Width) &&
               (p.Y > StartPos.Y) &&
               (p.Y < StartPos.Y + StartPosIcon.Height))
            {
                type = ICON_TYPE.START_POS;
                return true;
            }

            if ((p.X > EndPos.X) &&
               (p.X < EndPos.X + EndPosIcon.Width) &&
               (p.Y > EndPos.Y) &&
               (p.Y < EndPos.Y + EndPosIcon.Height))
            {
                type = ICON_TYPE.END_POS;
                return true;
            }

            if((p.X > (StartPos.X + StartPosIcon.Width)) &&
                (p.X < EndPos.X) &&
                (p.Y > StartPos.Y) &&
                (p.Y < StartPos.Y + StartPosIcon.Height))
            {
                type = ICON_TYPE.FRAME_BODY;
                return true;
            }

            type = ICON_TYPE.NONE;
            return false;
        }

        public void DrawFrameBox(Graphics g)
        {
            Pen drawLine = new Pen(Color.Black);
            Rectangle rect = new Rectangle(StartPos.X, 
                                           StartPos.Y, 
                                           (EndPos.X - StartPos.X) + EndPosIcon.Width, 
                                           (EndPos.Y - StartPos.Y) + EndPosIcon.Height);
            g.DrawRectangle(drawLine, rect);

            //Console.WriteLine(string.Format("Start:{0}, End:{1}", StartPos, EndPos));
        }
    }
}



