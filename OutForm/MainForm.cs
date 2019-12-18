using OutForm.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomeShit;
using static SomeShit.TrippleGen;

namespace OutForm
{
    public partial class MainForm : Form
    {

        TrippleGen forform = new TrippleGen();

        public MainForm()
        {
            InitializeComponent();

            int ss = Convert.ToInt32(TextL.Text);


            for (int i = 0; i < ss; i++)
            {
                this.SignGraph.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series()
                {
                    Name = "Series" + i,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line

                });
                this.Load += Form1_Load;
            }

            SignGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            SignGraph.Series[0].Color = Color.Red;
            SignGraph.Series[0].BorderWidth = 1;


            this.Load += Form1_Load;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            sinPanel1.tbB.Text = Convert.ToString(0.08);
        }

        List<dot> sign = new List<dot>();

        private void Start_Click_1(object sender, EventArgs e)
        {

            ////////////////// ОЧИСТКА ГРАФИКОВ И ФОРМЫ /////////////////////

            SignGraph.Series[0].Points.Clear();
            SignGraph.Series[1].Points.Clear();
            SignGraph.Series[2].Points.Clear();
            forform.Clear();

            ////////////////// ОПРЕДЕЛЕНИЕ ПЕРЕМЕННЫХ /////////////////////

            UInt32 _end = Convert.ToUInt32(this.end.Text);
            int length = 0;

            SinPanel tb = sinPanel1;

            SignGraph.Series[0].Points.Clear();


            int ampl = Convert.ToInt32(sinPanel1.tbA.Text); //амлитуда
            double freq = Convert.ToDouble(sinPanel1.tbB.Text);  //частота  
            double phase = 0.0;   //фаза начальная
            UInt16 first = 0;     //начало
            UInt32 last = _end;   //конец



            forform.SinGen(ampl, freq, phase, first, last);

            sign = forform.SignReturn();

            ////////////////// СОЗДАНИЕ ГРАФИКОВ /////////////////////

            //SignGraph.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //SignGraph.Series[0].Color = Color.Red;
            //SignGraph.Series[0].BorderWidth = 3;
            //SignGraph.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //SignGraph.Series[1].Color = Color.Blue;
            //SignGraph.Series[1].BorderWidth = 3;
            //SignGraph.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            //SignGraph.Series[2].Color = Color.Green;
            //SignGraph.Series[2].BorderWidth = 3;


            length = forform.GetS();



            ////////////////// ПОСТРОЕНИЕ /////////////////////


            for (int i = 0; i < length; i++)
            {
                //double x;
                int x;
                x = i;
                double y = forform.GetYPoints(i);

                SignGraph.Series[0].Points.AddXY(x, y);
                                                              
               // this.SignGraph.ChartAreas[0].AxisX.Interval = length / 10;
                this.SignGraph.ChartAreas[0].AxisX.Minimum = 0;
            }

        }
                 

        private void Clear_Click(object sender, EventArgs e)
        {
            int ss = Convert.ToInt32(TextL.Text);

            for (int i = 0; i < ss; i++)
            {
                SignGraph.Series[i].Points.Clear();
            }

            sign.Clear();
            forform.Clear();
            param.Clear();
            fo = null;
            corr.Clear();
            Console.Clear();

        }
        
        List<int> param = new List<int>();
        List<dot> corr = new List<dot>();
        double[] fo;
        
        private void Corr_Click(object sender, EventArgs e)
        {
            int ss = Convert.ToInt32(TextL.Text);

            for (int i = 0; i < ss; i++)
            {
                SignGraph.Series[i].Points.Clear();
            }

            int full_length = forform.GetS();

            int count = Convert.ToInt16(TextL.Text);
            List<dot> sg = new List<dot>();

            sg = forform.Corr(count, full_length);

            int iter = sg.Count();

            while (iter!= full_length)
            {
                sg.Add(new dot(0, 0, Convert.ToUInt32(iter)));
                iter++;
            }

            fo = new double[count];

            for (int i = 0; i < count; i++)
            {
                var l = new List<dot>();
                l.AddRange(sg);

                for (int j = count; j >= count - i; j--)
                {
                    l[j] = new dot(0, 0, Convert.ToUInt32(count - i - 1));
                }
                
                forform.Fourea(l, full_length, -1);

                double max = 0.0, itr = 0.0;
                
                for (int j = 0; j < full_length; j++)
                {                    
                    if (Math.Sqrt(l[j].im_amplitude * l[j].im_amplitude + l[j].real_amplitude * l[j].real_amplitude) >= max)
                    { max = Math.Sqrt(l[j].im_amplitude * l[j].im_amplitude + l[j].real_amplitude * l[j].real_amplitude); itr = full_length-j; }
                }

                if (itr == full_length)
                {
                    itr = 0;
                }


                for (int j = 0; j < full_length; j++)
                {
                    int x;
                    double y;
                    x = j;
                    y = Math.Sqrt(l[j].im_amplitude * l[j].im_amplitude + l[j].real_amplitude * l[j].real_amplitude);

                    SignGraph.Series[i].Points.AddXY(x, y);
                }
                
                
                fo[i] = (itr) * 2 / Convert.ToDouble(full_length);



                Console.WriteLine(i + " itr  " + itr + "    fo   " + fo[i]);
            }
        }

        private void Paint_Click(object sender, EventArgs e)
        {

            Console.Clear();

            int ss = Convert.ToInt32(TextL.Text);

            for (int i = 0; i < ss; i++)
            {
                SignGraph.Series[i].Points.Clear();
            }
            
            UInt16 count = Convert.ToUInt16(TextL.Text);

            double[] disp = new double[count];
            double f = Convert.ToDouble(sinPanel1.tbB.Text) / (2 * Math.PI);

            for (int i = 1; i <= count; i++)
            {
                double diff = 0.0;
                for (int j = count - i; j < count; j++)
                {
                    diff += (f - fo[count - j-1]) * (f - fo[count - j-1]);
                }

                Console.WriteLine(i + "   f   " + f + "    fo   " + fo[i - 1] + "     " + "    disp   " + diff/i);

                disp[i - 1] = diff / i;

            }


            for (int i = 0; i < count; i++)
            {
                int x;
                double y;
                x = i;
                y = disp[i];

                SignGraph.Series[1].Points.AddXY(x, y);

                this.SignGraph.ChartAreas[0].AxisX.Interval = 1;
                this.SignGraph.ChartAreas[0].AxisX.Minimum = 0;
            }

            disp = null;
        }

        private void TextL_TextChanged(object sender, EventArgs e)
        {
            this.SignGraph.Series.Clear();

            int ss = Convert.ToInt32(TextL.Text);


            for (int i = 0; i < ss; i++)
            {
                this.SignGraph.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series()
                {
                    Name = "Series" + i,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line

                });
                this.Load += Form1_Load;
            }

        }

        private void GraphNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ss = Convert.ToInt32(TextL.Text);

                for (int i = 0; i < ss; i++)
                {
                    if (i == Convert.ToInt32(GraphNum.Text))
                        continue;

                    this.SignGraph.Series[i].Points.Clear();
                }
            
            }
        }
    }
}

