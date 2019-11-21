using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace c_note1 { 
    enum DRAW_MODE : int
    {
        PENMODE = 0,
        SHAPEMODE = 1,
        PAINTMODE = 2,
        ERASERMODE = 3,
        EDITMODE = 4

    }
    public partial class note_P : Form
    {
        private bool Brush = true;                      //Uses either Brush or Eraser. Default is Brush
        private Shapes DrawingShapes = new Shapes();    //Stores all the drawing data
        private bool IsPainting = false;                //Is the mouse currently down (PAINTING)
        private bool IsEraseing = false;                //Is the mouse currently down (ERASEING)
        private Point LastPos = new Point(0, 0);        //Last Position, used to cut down on repative data.
        private Color CurrentColour = Color.Black;      //Deafult Colour
        private float CurrentWidth = 10;                //Deafult Pen width
        private int ShapeNum = 0;                       //record the shapes so they can be drawn sepratley.
        private Point MouseLoc = new Point(0, 0);       //Record the mouse position
        private bool IsMouseing = false;                //Draw the mouse?
        string BTnum = null;
        int i = 0;
        int curMode;
        Color curColor = Color.Black;
        int curLineSize = 1;
        Point mouseDownPoint;
        Bitmap pictureBoxBmp;
        bool draw = false;

        private void SetDrawMode(int mode)
        {
            switch (mode)
            {
                case (int)DRAW_MODE.PENMODE:
                    curMode = (int)DRAW_MODE.PENMODE;
                    this.Cursor = LoadCursor(Properties.Resources.PenCursor_small);
                    break;
                case (int)DRAW_MODE.SHAPEMODE:
                    curMode = (int)DRAW_MODE.SHAPEMODE;
                    this.Cursor = LoadCursor(Properties.Resources.ShapesCursor);
                    break;
                case (int)DRAW_MODE.PAINTMODE:
                    curMode = (int)DRAW_MODE.PAINTMODE;
                    this.Cursor = LoadCursor(Properties.Resources.PaintCursor);
                    break;
                case (int)DRAW_MODE.ERASERMODE:
                    curMode = (int)DRAW_MODE.ERASERMODE;
                    this.Cursor = LoadCursor(Properties.Resources.EraserCursor);
                    break;
                case (int)DRAW_MODE.EDITMODE:
                    this.Cursor = Cursors.Default;
                    break;
                default:
                    this.Cursor = Cursors.Default;
                    break;
            }
        }

        private Cursor LoadCursor(byte[] cursorFile)
        {
            MemoryStream cursorMemoryStream = new MemoryStream(cursorFile);
            Cursor hand = new Cursor(cursorMemoryStream);

            return hand;
        }
        private void doFloodFill(Point startPoint, Color preColor)
        {
            try
            {
                Stack<Point> pixels = new Stack<Point>();
                preColor = pictureBoxBmp.GetPixel(startPoint.X, startPoint.Y);
                pixels.Push(startPoint);

                while (pixels.Count > 0)
                {
                    Point i = pixels.Pop();
                    if (i.X < pictureBoxBmp.Width && i.X > 0 && i.Y < pictureBoxBmp.Height && i.Y > 0)
                    {
                        if (pictureBoxBmp.GetPixel(i.X, i.Y) == preColor)
                        {
                            pictureBoxBmp.SetPixel(i.X, i.Y, curColor);
                            pixels.Push(new Point(i.X - 1, i.Y));
                            pixels.Push(new Point(i.X + 1, i.Y));
                            pixels.Push(new Point(i.X, i.Y - 1));
                            pixels.Push(new Point(i.X, i.Y + 1));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public note_P()
        {
            InitializeComponent();
            panel2.BackColor = curColor;
            SetDrawMode((int)DRAW_MODE.PENMODE);
            SetDrawMode((int)DRAW_MODE.ERASERMODE);

        serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecieved); //데이터 받을때의 이벤트 생성
            pictureBoxBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.GetType().GetMethod("SetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(pictureBox1, new object[] { System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint | System.Windows.Forms.ControlStyles.DoubleBuffer, true });

        }

        #region
        delegate void SetTextHandler(string message);
        public void SetText(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetTextHandler(SetText), message);
            }
            else
            {
                txtBoxReceive.AppendText(message); //txtBoxReceive 맨밑에 message 적기
                txtBoxReceive.ScrollToCaret(); //자동으로 맨 밑 내용 보여주기

                // txtBoxReceive.Text = message; //텍스트박스 내용을 바로 message로 바꾸고싶은 경우.
            }
        }

        #endregion
        public void DataRecieved(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort spl = (SerialPort)sender;
                string recievedData = spl.ReadLine();
                SetText("Data" + " : " + recievedData + "\r\n");
                BTnum = " ";
                if(BTnum != null)
                {
                    if (i == 0)
                    {
                        curColor = color1.BackColor;
                        panel2.BackColor = curColor;
                        i = i + 1;
                    }
                    else if (i == 1)
                    {
                        curColor = color2.BackColor;
                        panel2.BackColor = curColor;
                        i = i + 1;
                    }
                    else if (i == 2)
                    {
                        curColor = color3.BackColor;
                        panel2.BackColor = curColor;
                        i = i + 1;
                    }
                    else if (i == 3)
                    {
                        curColor = color4.BackColor;
                        panel2.BackColor = curColor;
                        i = 0;
                    }
                    BTnum = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("데이타 리시브 실패\n\r" + ex.Message);
            }
            
        }

        private void DieaseUpdateEventMethod(object sender)
        {
            //폼2에서 델리게이트로 이벤트 발생하면 현재 함수 Call
            BTnum = sender.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetDrawMode((int)DRAW_MODE.PENMODE);
            Brush = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDrawMode((int)DRAW_MODE.SHAPEMODE);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetDrawMode((int)DRAW_MODE.PAINTMODE);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetDrawMode((int)DRAW_MODE.ERASERMODE);
            Brush = false;
            IsEraseing = true;
        }


        private void panel2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                curColor = colorDialog.Color;
                panel2.BackColor = curColor;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "paint1.png";
                sfd.Filter = "PNG File|*.png|Bitmap File|*.bmp|JPEG File|*.jpg";

                if (pictureBox1.Image == null)
                {
                    //MessageBox.Show("이미지가 없습니다!");
                    //return;
                    pictureBox1.Image = pictureBox1.BackgroundImage;

                }

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string strFilename = sfd.FileName;
                    pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                    bmp.Save(@strFilename);
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLoc = e.Location;
            CurrentWidth = curLineSize;


            //PAINTING
            if (IsPainting)
            {
            
                //check its not at the same place it was last time, saves on recording more data.
                if (LastPos != e.Location)
                {
                    //set this position as the last positon
                    LastPos = e.Location;
                    //store the position, width, colour and shape relation data

                    DrawingShapes.NewShape(LastPos, CurrentWidth, curColor, ShapeNum);
                    
                }
            }
            if (IsEraseing)
            {
                if (LastPos != e.Location)
                
                    //set this position as the last positon
                    LastPos = e.Location;
                    //Remove any point within a certain distance of the mouse
                    DrawingShapes.RemoveShape(e.Location, CurrentWidth);
            }
            //refresh the panel so it will be forced to re-draw.
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            //Hide the mouse cursor and tell the re-drawing function to draw the mouse
            Cursor.Hide();
            IsMouseing = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //show the mouse, tell the re-drawing function to stop drawing it and force the panel to re-draw.
            Cursor.Show();
            IsMouseing = false;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //If we're painting...
            if (Brush)
            {
                //set it to mouse down, illatrate the shape being drawn and reset the last position
                IsPainting = true;
                ShapeNum++;
                LastPos = new Point(0, 0);
            }
            //but if we're eraseing...
            else
            {
                IsEraseing = true;
                ShapeNum--;
                LastPos = new Point(0, 0);
            }
            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsPainting)
            {
                //Finished Painting.
                IsPainting = false;
            }
            if (IsEraseing)
            {
                //Finished Earsing.
                IsEraseing = false;
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            curLineSize = trackBar1.Value;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Apply a smoothing mode to smooth out the line.
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //DRAW THE LINES
            for (int i = 0; i < DrawingShapes.NumberOfShapes() - 1; i++)
            {
                Shape T = DrawingShapes.GetShape(i);
                Shape T1 = DrawingShapes.GetShape(i + 1);
                //make sure shape the two ajoining shape numbers are part of the same shape
                if (T.ShapeNumber == T1.ShapeNumber)
                {
                    //create a new pen with its width and colour
                    Pen p = new Pen(T.Colour, T.Width);
                    p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    //draw a line between the two ajoining points
                    e.Graphics.DrawLine(p, T.Location, T1.Location);
                    //get rid of the pen when finished
                   
                    p.Dispose();
                }
            }
            //If mouse is on the panel, draw the mouse
            if (IsMouseing)
            {
                e.Graphics.DrawEllipse(new Pen(curColor, 0.5f), MouseLoc.X - (CurrentWidth / 2), MouseLoc.Y - (CurrentWidth / 2), CurrentWidth, CurrentWidth);
            }
        }
       

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // 파일 열기 다이얼로그 생성
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "PNG File|*.png|Bitmap File|*.bmp|JPEG File|*.jpg";



                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.ImageLocation = openFileDialog1.FileName;

                }

            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "paint1.png";
                sfd.Filter = "PNG File|*.png|Bitmap File|*.bmp|JPEG File|*.jpg";

                if (pictureBox1.Image == null)
                {
                    //MessageBox.Show("이미지가 없습니다!");
                    //return;
                    pictureBox1.Image = pictureBox1.BackgroundImage;

                }

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string strFilename = sfd.FileName;
                    pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                    bmp.Save(@strFilename);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void color1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                curColor = colorDialog.Color;
                color1.BackColor = curColor;
            }
        }

        private void color2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                curColor = colorDialog.Color;
                color2.BackColor = curColor;
            }
        }
        private void color3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                curColor = colorDialog.Color;
                color3.BackColor = curColor;
            }
        }
        private void color4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                curColor = colorDialog.Color;
                color4.BackColor = curColor;
            }
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            
            if(i == 0)
            {
                curColor = color1.BackColor;
                panel2.BackColor = curColor;
                i = i + 1;
            }
            else if(i == 1)
            {
                curColor = color2.BackColor;
                panel2.BackColor = curColor;
                i = i + 1;
            }
            else if(i == 2)
            {
                curColor = color3.BackColor;
                panel2.BackColor = curColor;
                i = i + 1;
            }
            else if(i == 3)
            {
                curColor = color4.BackColor;
                panel2.BackColor = curColor;
                i = 0;
            }

           


        }

        private void pictureBox_Click(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(
                new Pen(Color.Red, 2f),
                new Point(0, 0),
                new Point(pictureBox1.Size.Width, pictureBox1.Size.Height));

        }
        private void BTConnet_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = txtBoxRecievePort.Text; //포트 이름 설정. txtBoxRecievePort의 텍스트 값으로 설정
            serialPort1.BaudRate = 9600; //통신속도를 9600으로 설정합니다.
            try
            {
                if (!serialPort1.IsOpen) serialPort1.Open(); //만약 포트가 열려있지 않다면 엽시다.
                MessageBox.Show("블루투스 연결 성공");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //예외일 때 보여주기
            }
        }

        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            note_T newFrom = new note_T();
            newFrom.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Image.FromFile("Paint.png");
        }
    }
    public class Shape
    {
        public Point Location;          //position of the point
        public float Width;             //width of the line
        public Color Colour;            //colour of the line
        public int ShapeNumber;         //part of which shape it belongs to

        //CONSTRUCTOR
        public Shape(Point L, float W, Color C, int S)
        {
            Location = L;               //Stores the Location
            Width = W;                  //Stores the width
            Colour = C;                 //Stores the colour
            ShapeNumber = S;            //Stores the shape number
        }
    }
    public class Shapes
    {
        private List<Shape> _Shapes;    //Stores all the shapes

        public Shapes()
        {
            _Shapes = new List<Shape>();
        }
        //Returns the number of shapes being stored.
        public int NumberOfShapes()
        {
            return _Shapes.Count;
        }
        //Add a shape to the database, recording its position, width, colour and shape relation information
        public void NewShape(Point L, float W, Color C, int S)
        {
            _Shapes.Add(new Shape(L, W, C, S));
        }
        //returns a shape of the requested data.
        public Shape GetShape(int Index)
        {
            return _Shapes[Index];
        }
        //Removes any point data within a certain threshold of a point.
        public void RemoveShape(Point L, float threshold)
        {
            SmoothingMode SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            for (int i = 0; i < _Shapes.Count; i++)
            {
                //Finds if a point is within a certain distance of the point to remove.
                if ((Math.Abs(L.X - _Shapes[i].Location.X) < threshold) && (Math.Abs(L.Y - _Shapes[i].Location.Y) < threshold))
                {
                    //removes all data for that number
                    _Shapes.RemoveAt(i);

                    //goes through the rest of the data and adds an extra 1 to defined them as a seprate shape and shuffles on the effect.
                    for (int n = i; n < _Shapes.Count; n++)
                    {
                        _Shapes[n].ShapeNumber += 1;
                    }
                    //Go back a step so we dont miss a point.
                    i -= 1;
                }
            }
        }
    }
}