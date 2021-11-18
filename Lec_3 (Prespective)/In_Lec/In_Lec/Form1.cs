using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace In_Lec
{
    public partial class Form1 : Form
    {
        Bitmap off;

        _3D_Model Cube = new _3D_Model();
        
        _3D_Model Cubem = new _3D_Model();
        _3D_Model Cubem1 = new _3D_Model();
        _3D_Model Cubem2 = new _3D_Model();
        _3D_Model Cubem3 = new _3D_Model();
        _3D_Model Cubem4 = new _3D_Model();
        _3D_Model Cubem5 = new _3D_Model();
        _3D_Model Cubem6 = new _3D_Model();
        _3D_Model Cubem7 = new _3D_Model();
        _3D_Model Cubem8 = new _3D_Model();
        _3D_Model Cubem9 = new _3D_Model();

        Timer tt = new Timer();
        int countTick = 0;
        int f = 0;

        int one = 0;

        float[] vert1 = 
                            { 
                                    300,0,300,    //0
                                    300,0,350,    //1
                                    200,0,350,    //2
                                    200,0,300,    //3
                                    300,60,300,    //0
                                    300,60,350,    //1
                                    200,60,350,    //2
                                    200,60,300     //3
                                
                            };

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Load += new EventHandler(Form1_Load);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            tt.Tick += new EventHandler(tt_Tick);
            tt.Start();
   
        }

        void tt_Tick(object sender, EventArgs e)
        {
            if (f == 9)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {

                        vert1[i] -= 100;
                    }
                    CreateminiCube(Cubem9, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem9.L_3D_Pts, 10);

                if (Cubem9.L_3D_Pts[4].Y >= Cubem6.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }
            
            if (f == 8)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {

                        vert1[i] += 100;
                    }
                    CreateminiCube(Cubem8, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem8.L_3D_Pts, 10);

                if (Cubem8.L_3D_Pts[4].Y >= Cubem5.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }

            if (f == 7)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {

                        vert1[i] += 100;
                    }
                    CreateminiCube(Cubem7, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem7.L_3D_Pts, 10);

                if (Cubem7.L_3D_Pts[4].Y >= Cubem4.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }
            
            if (f == 6)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {

                        vert1[i] -= 200;
                    }
                    CreateminiCube(Cubem6, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem6.L_3D_Pts, 10);

                if (Cubem6.L_3D_Pts[4].Y >= Cubem3.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }

            if (f == 5)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {

                        vert1[i] += 100;
                    }
                    CreateminiCube(Cubem5, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem5.L_3D_Pts, 10);

                if (Cubem5.L_3D_Pts[4].Y >= Cubem2.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }

            if (f == 4)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {

                        vert1[i] += 100;
                    }
                    CreateminiCube(Cubem4, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem4.L_3D_Pts, 10);

                if (Cubem4.L_3D_Pts[4].Y >= Cubem1.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }
           
            if (f == 3)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {

                        vert1[i] -= 200;
                    }
                    CreateminiCube(Cubem3, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem3.L_3D_Pts, 10);

                if (Cubem3.L_3D_Pts[4].Y >= Cubem.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }
            
            if (f == 2)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {
                        vert1[i] += 100;
                    }
                    CreateminiCube(Cubem2, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem2.L_3D_Pts, 10);

                if (Cubem2.L_3D_Pts[4].Y >= Cube.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }
            
            if (f == 1)
            {
                if (one == 0)
                {
                    for (int i = 0; i < 24; i+=3)
                    {
                        vert1[i] += 100;
                    }
                    CreateminiCube(Cubem1, vert1, 100, 100, 0);
                    one++;
                }

                Transformation.TranslateY(Cubem1.L_3D_Pts, 10);

                if (Cubem1.L_3D_Pts[4].Y >= Cube.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }
            
            if (f == 0)
            {
                if (one == 0)
                {
                    CreateminiCube(Cubem, vert1, 100, 100, 0);
                    one++;
                }
                
                Transformation.TranslateY(Cubem.L_3D_Pts, 10);
             
                if (Cubem.L_3D_Pts[4].Y >= Cube.L_3D_Pts[0].Y)
                {
                    f++;
                    one = 0;
                }
            }


            countTick++;
            DrawDubble(this.CreateGraphics());
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.X:
                    //Cube.RotX(1);
                    break;
                case Keys.Y:
                    //Cube.RotY(1);
                    break;
                case Keys.Z:
                    //Cube.RotZ(1);
                    break;
                
                case Keys.Right:
                    //Cube.TransX(5);
                    break;
                case Keys.Left:
                    //Cube.TransX(-5);
                    break;

                case Keys.Up:
                    //Cube.TransZ(5);
                    break;
                case Keys.Down:
                    //Cube.TransZ(-5);
                    break;

                case Keys.Space:
                    //Cube.RotateAroundEdge(2, 1);
                    break;
            }

            DrawDubble(this.CreateGraphics());
        }

        void CreateCube(_3D_Model M , float XS , float YS , float ZS)
        {
            float[] vert = 
                            { 
                                    500,340,300,    //0
                                    500,340,500,    //1
                                    200,340,500,    //2
                                    200,340,300,    //3
                                    500,100,300,    //0
                                    500,100,500,    //1
                                    200,100,500,    //2
                                    200,100,300     //3
                                
                            };


            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j]+XS, vert[j + 1]+YS, vert[j + 2]+ZS);
                j += 3;
                M.AddPoint(pnn);
            }


            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            //Color[] cl = { Color.Red, Color.Yellow, Color.Black, Color.Blue };
            for (int i = 0; i < 12; i++)
            {
                M.AddEdge(Edges[j], Edges[j + 1], Color.Red); //cl[i % 4]);

                j += 2;
            }
        }

        void CreateminiCube(_3D_Model M, float[] vert, float XS, float YS, float ZS)
        {
            


            _3D_Point pnn;
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                pnn = new _3D_Point(vert[j] + XS, vert[j + 1] + YS, vert[j + 2] + ZS);
                j += 3;
                M.AddPoint(pnn);
            }


            int[] Edges = {
                                0,1,
                                1,2,
                                2,3,
                                3,0,
                                4,5,
                                5,6,
                                6,7,
                                7,4,
                                0,4,
                                3,7,
                                2,6,
                                1,5
                          };
            j = 0;
            Color[] cl = { Color.Red, Color.Yellow, Color.SkyBlue, Color.Blue, Color.Gold, Color.Beige };

            for (int i = 0; i < 12; i++)
            {
                Random r=new Random();
                int d= r.Next(0,5);

                M.AddEdge(Edges[j], Edges[j + 1], cl[d]); //cl[i % 4]);

                j += 2;
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width , this.ClientSize.Height);

            CreateCube(Cube , 100,100,0);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubble(e.Graphics);
        }

        void DrawScene(Graphics g)
        {
            g.Clear(Color.White);

            
            Cube.DrawYourSelf(g);

            Cubem.DrawYourSelf(g);
            Cubem1.DrawYourSelf(g);
            Cubem2.DrawYourSelf(g);
            Cubem3.DrawYourSelf(g);
            Cubem4.DrawYourSelf(g);
            Cubem5.DrawYourSelf(g);
            Cubem6.DrawYourSelf(g);
            Cubem7.DrawYourSelf(g);
            Cubem8.DrawYourSelf(g);
            Cubem9.DrawYourSelf(g);
        }

        void DrawDubble(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
