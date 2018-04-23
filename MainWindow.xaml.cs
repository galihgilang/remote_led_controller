using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kontrol_led
{
    public partial class MainWindow : Window
    {
        public string comport;
        public int posisi;
        public Int32 a, b, c, d, sudut;
        public byte aa, bb, cc, dd;
        int on, delay;
        char[] ki = new char[2];
        char[] ter = new char[4];
        SerialPort ser;
        
        SolidColorBrush borderstd = new SolidColorBrush();
        SolidColorBrush borderpilih = new SolidColorBrush();
        SolidColorBrush fill1 = new SolidColorBrush();
        SolidColorBrush fill2 = new SolidColorBrush();
        SolidColorBrush fill3 = new SolidColorBrush();
        SolidColorBrush fill4 = new SolidColorBrush();
        SolidColorBrush poly = new SolidColorBrush();
        SolidColorBrush hapus = new SolidColorBrush();
        Polygon myPolygon;

        public MainWindow()
        {
            InitializeComponent();
            comport = "COM41";
            a = b = c = d = 1;
            posisi = 1;
            ser = new SerialPort(comport, 9600, Parity.None, 8, StopBits.One);
            
            borderstd.Color = Color.FromArgb(255, 153, 170, 131);
            borderpilih.Color = Color.FromArgb(255, 226, 226, 194);
            poly.Color = Color.FromArgb(255, 147, 157, 129);

            on = 0;
            text2();
            for (delay = 0; delay < 2000; delay++)
            { }
            pilihkotak();
            brightness();
            jarum();
        }

        private void text2()
        {
            if (posisi==1){
                if(a==1)
                    textBox1.Text="0%";
                else if(a==2)
                    textBox1.Text="6.25%";
                else if(a==3)
                    textBox1.Text="9.375%";
                else if(a==4)
                    textBox1.Text="12.5%";
                else if(a==5)
                    textBox1.Text="15.625%";
                else if(a==6)
                    textBox1.Text="18.75%";
                else if(a==7)
                    textBox1.Text="21.875%";
                else if(a==8)
                    textBox1.Text="25%";
                else if(a==9)
                    textBox1.Text="28.175%";
                else if(a==10)
                    textBox1.Text="31.25%";
                else if(a==11)
                    textBox1.Text="34.375%";
                else if(a==12)
                    textBox1.Text="37.25%";
                else if(a==13)
                    textBox1.Text="40.625%";
                else if(a==14)
                    textBox1.Text="43.75%";
                else if(a==15)
                    textBox1.Text="46.875%";
                else if(a==16)
                    textBox1.Text="50%";
                else if(a==17)
                    textBox1.Text="53.125%";
                else if(a==18)
                    textBox1.Text="56.25%";
                else if(a==19)
                    textBox1.Text="59.375%";
                else if(a==20)
                    textBox1.Text="62.5%";
                else if(a==21)
                    textBox1.Text="65.625%";
                else if(a==22)
                    textBox1.Text="68.75%";
                else if(a==23)
                    textBox1.Text="71.875%";
                else if(a==24)
                    textBox1.Text="75%";
                else if(a==25)
                    textBox1.Text="78.125%";
                else if(a==26)
                    textBox1.Text="81.25%";
                else if(a==27)
                    textBox1.Text="84.375%";
                else if(a==28)
                    textBox1.Text="87.5%";
                else if(a==29)
                    textBox1.Text="90.625%";
                else if(a==30)
                    textBox1.Text="93.75%";
                else if(a==31)
                    textBox1.Text="96.875%";
                else if(a==32)
                    textBox1.Text="100%";}
            else if (posisi==2){
                if(b==1)
                    textBox1.Text="0%";
                else if(b==2)
                    textBox1.Text="6.25%";
                else if(b==3)
                    textBox1.Text="9.375%";
                else if(b==4)
                    textBox1.Text="12.5%";
                else if(b==5)
                    textBox1.Text="15.625%";
                else if(b==6)
                    textBox1.Text="18.75%";
                else if(b==7)
                    textBox1.Text="21.875%";
                else if(b==8)
                    textBox1.Text="25%";
                else if(b==9)
                    textBox1.Text="28.175%";
                else if(b==10)
                    textBox1.Text="31.25%";
                else if(b==11)
                    textBox1.Text="34.375%";
                else if(b==12)
                    textBox1.Text="37.25%";
                else if(b==13)
                    textBox1.Text="40.625%";
                else if(b==14)
                    textBox1.Text="43.75%";
                else if(b==15)
                    textBox1.Text="46.875%";
                else if(b==16)
                    textBox1.Text="50%";
                else if(b==17)
                    textBox1.Text="53.125%";
                else if(b==18)
                    textBox1.Text="56.25%";
                else if(b==19)
                    textBox1.Text="59.375%";
                else if(b==20)
                    textBox1.Text="62.5%";
                else if(b==21)
                    textBox1.Text="65.625%";
                else if(b==22)
                    textBox1.Text="68.75%";
                else if(b==23)
                    textBox1.Text="71.875%";
                else if(b==24)
                    textBox1.Text="75%";
                else if(b==25)
                    textBox1.Text="78.125%";
                else if(b==26)
                    textBox1.Text="81.25%";
                else if(b==27)
                    textBox1.Text="84.375%";
                else if(b==28)
                    textBox1.Text="87.5%";
                else if(b==29)
                    textBox1.Text="90.625%";
                else if(b==30)
                    textBox1.Text="93.75%";
                else if(b==31)
                    textBox1.Text="96.875%";
                else if(b==32)
                    textBox1.Text="100%";}
            else if (posisi==3){
                if(c==1)
                    textBox1.Text="0%";
                else if(c==2)
                    textBox1.Text="6.25%";
                else if(c==3)
                    textBox1.Text="9.375%";
                else if(c==4)
                    textBox1.Text="12.5%";
                else if(c==5)
                    textBox1.Text="15.625%";
                else if(c==6)
                    textBox1.Text="18.75%";
                else if(c==7)
                    textBox1.Text="21.875%";
                else if(c==8)
                    textBox1.Text="25%";
                else if(c==9)
                    textBox1.Text="28.175%";
                else if(c==10)
                    textBox1.Text="31.25%";
                else if(c==11)
                    textBox1.Text="34.375%";
                else if(c==12)
                    textBox1.Text="37.25%";
                else if(c==13)
                    textBox1.Text="40.625%";
                else if(c==14)
                    textBox1.Text="43.75%";
                else if(c==15)
                    textBox1.Text="46.875%";
                else if(c==16)
                    textBox1.Text="50%";
                else if(c==17)
                    textBox1.Text="53.125%";
                else if(c==18)
                    textBox1.Text="56.25%";
                else if(c==19)
                    textBox1.Text="59.375%";
                else if(c==20)
                    textBox1.Text="62.5%";
                else if(c==21)
                    textBox1.Text="65.625%";
                else if(c==22)
                    textBox1.Text="68.75%";
                else if(c==23)
                    textBox1.Text="71.875%";
                else if(c==24)
                    textBox1.Text="75%";
                else if(c==25)
                    textBox1.Text="78.125%";
                else if(c==26)
                    textBox1.Text="81.25%";
                else if(c==27)
                    textBox1.Text="84.375%";
                else if(c==28)
                    textBox1.Text="87.5%";
                else if(c==29)
                    textBox1.Text="90.625%";
                else if(c==30)
                    textBox1.Text="93.75%";
                else if(c==31)
                    textBox1.Text="96.875%";
                else if(c==32)
                    textBox1.Text="100%";}
            else if (posisi == 4)
            {
                if (d == 1)
                    textBox1.Text = "0%";
                else if (d == 2)
                    textBox1.Text = "6.25%";
                else if (d == 3)
                    textBox1.Text = "9.375%";
                else if (d == 4)
                    textBox1.Text = "12.5%";
                else if (d == 5)
                    textBox1.Text = "15.625%";
                else if (d == 6)
                    textBox1.Text = "18.75%";
                else if (d == 7)
                    textBox1.Text = "21.875%";
                else if (d == 8)
                    textBox1.Text = "25%";
                else if (d == 9)
                    textBox1.Text = "28.175%";
                else if (d == 10)
                    textBox1.Text = "31.25%";
                else if (d == 11)
                    textBox1.Text = "34.375%";
                else if (d == 12)
                    textBox1.Text = "37.25%";
                else if (d == 13)
                    textBox1.Text = "40.625%";
                else if (d == 14)
                    textBox1.Text = "43.75%";
                else if (d == 15)
                    textBox1.Text = "46.875%";
                else if (d == 16)
                    textBox1.Text = "50%";
                else if (d == 17)
                    textBox1.Text = "53.125%";
                else if (d == 18)
                    textBox1.Text = "56.25%";
                else if (d == 19)
                    textBox1.Text = "59.375%";
                else if (d == 20)
                    textBox1.Text = "62.5%";
                else if (d == 21)
                    textBox1.Text = "65.625%";
                else if (d == 22)
                    textBox1.Text = "68.75%";
                else if (d == 23)
                    textBox1.Text = "71.875%";
                else if (d == 24)
                    textBox1.Text = "75%";
                else if (d == 25)
                    textBox1.Text = "78.125%";
                else if (d == 26)
                    textBox1.Text = "81.25%";
                else if (d == 27)
                    textBox1.Text = "84.375%";
                else if (d == 28)
                    textBox1.Text = "87.5%";
                else if (d == 29)
                    textBox1.Text = "90.625%";
                else if (d == 30)
                    textBox1.Text = "93.75%";
                else if (d == 31)
                    textBox1.Text = "96.875%";
                else if (d == 32)
                    textBox1.Text = "100%";
            }
        }

        private void kirim()
        {
            ser.Open();
            if (posisi == 1)
            {
                ki[0] = Convert.ToChar(49);
                ki[1] = Convert.ToChar(a + 48);
            }
            else if (posisi == 2)
            {
                ki[0] = Convert.ToChar(50);
                ki[1] = Convert.ToChar(b + 48);
            }
            else if (posisi == 3)
            {
                ki[0] = Convert.ToChar(51);
                ki[1] = Convert.ToChar(c + 48);
            }
            else if (posisi == 4)
            {
                ki[0] = Convert.ToChar(52);
                ki[1] = Convert.ToChar(d + 48);
            }
            ser.Write(ki, 0, 2);
            ser.Close();
        }

        private void jarum()
        {
            grid1.Children.Clear();
            myPolygon = new Polygon();
            myPolygon.Stroke = poly;
            myPolygon.Fill = poly;
            myPolygon.StrokeThickness = 1;
            myPolygon.HorizontalAlignment = HorizontalAlignment.Left;
            myPolygon.VerticalAlignment = VerticalAlignment.Top;
            System.Windows.Point Point1 = new System.Windows.Point(103, 103);
            System.Windows.Point Point2 = new System.Windows.Point(101, 10);
            System.Windows.Point Point3 = new System.Windows.Point(103, 0);
            System.Windows.Point Point4 = new System.Windows.Point(105, 10);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            myPolygon.Points = myPointCollection;
            if (posisi == 1)
            {
                if ((a >= 1) & (a <= 4))
                    sudut = (11 * a) - 5;
                else if ((a >= 5) & (a <= 8))
                    sudut = (11 * a) - 4;
                else if ((a >= 9) & (a <= 12))
                    sudut = (11 * a) - 3;
                else if ((a >= 13) & (a <= 16))
                    sudut = (11 * a) - 2;
                else if ((a >= 17) & (a <= 20))
                    sudut = (11 * a) - 1;
                else if ((a >= 21) & (a <= 24))
                    sudut = 11 * a;
                else if ((a >= 25) & (a <= 28))
                    sudut = (11 * a) + 1;
                else if ((a >= 29) & (a <= 32))
                    sudut = (11 * a) + 2;
            }

            else if (posisi == 2)
            {
                if ((b >= 1) & (b <= 4))
                    sudut = (11 * b) - 5;
                else if ((b >= 5) & (b <= 8))
                    sudut = (11 * b) - 4;
                else if ((b >= 9) & (b <= 12))
                    sudut = (11 * b) - 3;
                else if ((b >= 13) & (b <= 16))
                    sudut = (11 * b) - 2;
                else if ((b >= 17) & (b <= 20))
                    sudut = (11 * b) - 1;
                else if ((b >= 21) & (b <= 24))
                    sudut = 11 * b;
                else if ((b >= 25) & (b <= 28))
                    sudut = (11 * b) + 1;
                else if ((b >= 29) & (b <= 32))
                    sudut = (11 * b) + 2;
            }

            else if (posisi == 3)
            {
                if ((c >= 1) & (c <= 4))
                    sudut = (11 * c) - 5;
                else if ((c >= 5) & (c <= 8))
                    sudut = (11 * c) - 4;
                else if ((c >= 9) & (c <= 12))
                    sudut = (11 * c) - 3;
                else if ((c >= 13) & (c <= 16))
                    sudut = (11 * c) - 2;
                else if ((c >= 17) & (c <= 20))
                    sudut = (11 * c) - 1;
                else if ((c >= 21) & (c <= 24))
                    sudut = 11 * c;
                else if ((c >= 25) & (c <= 28))
                    sudut = (11 * c) + 1;
                else if ((c >= 29) & (c <= 32))
                    sudut = (11 * c) + 2;
            }

            else if (posisi == 4)
            {
                if ((d >= 1) & (d <= 4))
                    sudut = (11 * d) - 5;
                else if ((d >= 5) & (d <= 8))
                    sudut = (11 * d) - 4;
                else if ((d >= 9) & (d <= 12))
                    sudut = (11 * d) - 3;
                else if ((d >= 13) & (d <= 16))
                    sudut = (11 * d) - 2;
                else if ((d >= 17) & (d <= 20))
                    sudut = (11 * d) - 1;
                else if ((d >= 21) & (d <= 24))
                    sudut = 11 * d;
                else if ((d >= 25) & (d <= 28))
                    sudut = (11 * d) + 1;
                else if ((d >= 29) & (d <= 32))
                    sudut = (11 * d) + 2;
            }

            RotateTransform rotateTransform1 = new RotateTransform(sudut, 103, 103);
            myPolygon.RenderTransform = rotateTransform1;
            grid1.Children.Add(myPolygon);
        }

        private void brightness()
        {
            aa = Convert.ToByte(200 - (4 * a));
            fill1.Color = Color.FromArgb(255, 248, 248, aa);
            bb = Convert.ToByte(200 - (4 * b));
            fill2.Color = Color.FromArgb(255, 248, 248, bb);
            cc = Convert.ToByte(200 - (4 * c));
            fill3.Color = Color.FromArgb(255, 248, 248, cc);
            dd = Convert.ToByte(200 - (4 * d));
            fill4.Color = Color.FromArgb(255, 248, 248, dd);

            rectangle1.Fill = fill1;
            rectangle2.Fill = fill2;
            rectangle3.Fill = fill3;
            rectangle4.Fill = fill4;
        }

        private void pilihkotak()
        {
            if (posisi == 1)
            {
                rectangle1.Stroke = borderpilih;
                rectangle2.Stroke = borderstd;
                rectangle3.Stroke = borderstd;
                rectangle4.Stroke = borderstd;
                textBox2.Text = "LED 1";
            }

            else if (posisi == 2)
            {
                rectangle1.Stroke = borderstd;
                rectangle2.Stroke = borderpilih;
                rectangle3.Stroke = borderstd;
                rectangle4.Stroke = borderstd;
                textBox2.Text = "LED 2";
            }

            else if (posisi == 3)
            {
                rectangle1.Stroke = borderstd;
                rectangle2.Stroke = borderstd;
                rectangle3.Stroke = borderpilih;
                rectangle4.Stroke = borderstd;
                textBox2.Text = "LED 3";
            }

            else if (posisi == 4)
            {
                rectangle1.Stroke = borderstd;
                rectangle2.Stroke = borderstd;
                rectangle3.Stroke = borderstd;
                rectangle4.Stroke = borderpilih;
                textBox2.Text = "LED 4";
            }
        }

        // ************************************************************************************************************

        private void rectangle1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 1;
            text2();
            pilihkotak();
            jarum();
        }

        private void rectangle2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 2;
            text2();
            pilihkotak();
            jarum();
        }

        private void rectangle3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 3;
            text2();
            pilihkotak();
            jarum();
        }

        private void rectangle4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 4;
            text2();
            pilihkotak();
            jarum();
        }

        private void label1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 1;
            text2();
            pilihkotak();
            jarum();
        }

        private void label2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 2;
            text2();
            pilihkotak();
            jarum();
        }

        private void label3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 3;
            text2();
            pilihkotak();
            jarum();
        }

        private void label4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            posisi = 4;
            text2();
            pilihkotak();
            jarum();
        }
        
        // ************************************************************************************************************

        private void polygon8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 1;
            else if (posisi == 2)
                b = 1;
            else if (posisi == 3)
                c = 1;
            else if (posisi == 4)
                d = 1;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 2;
            else if (posisi == 2)
                b = 2;
            else if (posisi == 3)
                c = 2;
            else if (posisi == 4)
                d = 2;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 3;
            else if (posisi == 2)
                b = 3;
            else if (posisi == 3)
                c = 3;
            else if (posisi == 4)
                d = 3;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 4;
            else if (posisi == 2)
                b = 4;
            else if (posisi == 3)
                c = 4;
            else if (posisi == 4)
                d = 4;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 5;
            else if (posisi == 2)
                b = 5;
            else if (posisi == 3)
                c = 5;
            else if (posisi == 4)
                d = 5;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 6;
            else if (posisi == 2)
                b = 6;
            else if (posisi == 3)
                c = 6;
            else if (posisi == 4)
                d = 6;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 7;
            else if (posisi == 2)
                b = 7;
            else if (posisi == 3)
                c = 7;
            else if (posisi == 4)
                d = 7;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 8;
            else if (posisi == 2)
                b = 8;
            else if (posisi == 3)
                c = 8;
            else if (posisi == 4)
                d = 8;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon32_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 9;
            else if (posisi == 2)
                b = 9;
            else if (posisi == 3)
                c = 9;
            else if (posisi == 4)
                d = 9;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon31_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 10;
            else if (posisi == 2)
                b = 10;
            else if (posisi == 3)
                c = 10;
            else if (posisi == 4)
                d = 10;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon30_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 11;
            else if (posisi == 2)
                b = 11;
            else if (posisi == 3)
                c = 11;
            else if (posisi == 4)
                d = 11;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon29_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 12;
            else if (posisi == 2)
                b = 12;
            else if (posisi == 3)
                c = 12;
            else if (posisi == 4)
                d = 12;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 13;
            else if (posisi == 2)
                b = 13;
            else if (posisi == 3)
                c = 13;
            else if (posisi == 4)
                d = 13;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 14;
            else if (posisi == 2)
                b = 14;
            else if (posisi == 3)
                c = 14;
            else if (posisi == 4)
                d = 14;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 15;
            else if (posisi == 2)
                b = 15;
            else if (posisi == 3)
                c = 15;
            else if (posisi == 4)
                d = 15;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 16;
            else if (posisi == 2)
                b = 16;
            else if (posisi == 3)
                c = 16;
            else if (posisi == 4)
                d = 16;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 17;
            else if (posisi == 2)
                b = 17;
            else if (posisi == 3)
                c = 17;
            else if (posisi == 4)
                d = 17;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 18;
            else if (posisi == 2)
                b = 18;
            else if (posisi == 3)
                c = 18;
            else if (posisi == 4)
                d = 18;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 19;
            else if (posisi == 2)
                b = 19;
            else if (posisi == 3)
                c = 19;
            else if (posisi == 4)
                d = 19;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 20;
            else if (posisi == 2)
                b = 20;
            else if (posisi == 3)
                c = 20;
            else if (posisi == 4)
                d = 20;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 21;
            else if (posisi == 2)
                b = 21;
            else if (posisi == 3)
                c = 21;
            else if (posisi == 4)
                d = 21;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 22;
            else if (posisi == 2)
                b = 22;
            else if (posisi == 3)
                c = 22;
            else if (posisi == 4)
                d = 22;
            kirim();
            jarum();
            brightness();
            text2();
        }

        private void polygon18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 23;
            else if (posisi == 2)
                b = 23;
            else if (posisi == 3)
                c = 23;
            else if (posisi == 4)
                d = 23;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 24;
            else if (posisi == 2)
                b = 24;
            else if (posisi == 3)
                c = 24;
            else if (posisi == 4)
                d = 24;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 25;
            else if (posisi == 2)
                b = 25;
            else if (posisi == 3)
                c = 25;
            else if (posisi == 4)
                d = 25;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 26;
            else if (posisi == 2)
                b = 26;
            else if (posisi == 3)
                c = 26;
            else if (posisi == 4)
                d = 26;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 27;
            else if (posisi == 2)
                b = 27;
            else if (posisi == 3)
                c = 27;
            else if (posisi == 4)
                d = 27;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 28;
            else if (posisi == 2)
                b = 28;
            else if (posisi == 3)
                c = 28;
            else if (posisi == 4)
                d = 28;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 29;
            else if (posisi == 2)
                b = 29;
            else if (posisi == 3)
                c = 29;
            else if (posisi == 4)
                d = 29;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 30;
            else if (posisi == 2)
                b = 30;
            else if (posisi == 3)
                c = 30;
            else if (posisi == 4)
                d = 30;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 31;
            else if (posisi == 2)
                b = 31;
            else if (posisi == 3)
                c = 31;
            else if (posisi == 4)
                d = 31;
            text2();
            kirim();
            jarum();
            brightness();
        }

        private void polygon9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            on = 1;
            if (posisi == 1)
                a = 32;
            else if (posisi == 2)
                b = 32;
            else if (posisi == 3)
                c = 32;
            else if (posisi == 4)
                d = 32;
            text2();
            kirim();
            jarum();
            brightness();
        }

        // ************************************************************************************************************

        private void polygon8_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                {
                    if (a != 32)
                    {
                        a = 1;
                        text2();
                    }
                    else
                        on = 0;
                }
                else if (posisi == 2)
                {
                    if (b != 32)
                    {
                        b = 1;
                        text2();
                    }
                    else
                        on = 0;
                }
                else if (posisi == 3)
                {
                    if (c != 32)
                    {
                        c = 1;
                        text2();
                    }
                    else
                        on = 0;
                }
                else if (posisi == 4)
                {
                    if (d != 32)
                    {
                        d = 1;
                        text2();
                    }
                    else
                        on = 0;
                }
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon7_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 2;
                else if (posisi == 2)
                    b = 2;
                else if (posisi == 3)
                    c = 2;
                else if (posisi == 4)
                    d = 2;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon6_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 3;
                else if (posisi == 2)
                    b = 3;
                else if (posisi == 3)
                    c = 3;
                else if (posisi == 4)
                    d = 3;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon5_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 4;
                else if (posisi == 2)
                    b = 4;
                else if (posisi == 3)
                    c = 4;
                else if (posisi == 4)
                    d = 4;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon4_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 5;
                else if (posisi == 2)
                    b = 5;
                else if (posisi == 3)
                    c = 5;
                else if (posisi == 4)
                    d = 5;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 6;
                else if (posisi == 2)
                    b = 6;
                else if (posisi == 3)
                    c = 6;
                else if (posisi == 4)
                    d = 6;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 7;
                else if (posisi == 2)
                    b = 7;
                else if (posisi == 3)
                    c = 7;
                else if (posisi == 4)
                    d = 7;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 8;
                else if (posisi == 2)
                    b = 8;
                else if (posisi == 3)
                    c = 8;
                else if (posisi == 4)
                    d = 8;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon32_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 9;
                else if (posisi == 2)
                    b = 9;
                else if (posisi == 3)
                    c = 9;
                else if (posisi == 4)
                    d = 9;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon31_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 10;
                else if (posisi == 2)
                    b = 10;
                else if (posisi == 3)
                    c = 10;
                else if (posisi == 4)
                    d = 10;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon30_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 11;
                else if (posisi == 2)
                    b = 11;
                else if (posisi == 3)
                    c = 11;
                else if (posisi == 4)
                    d = 11;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon29_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 12;
                else if (posisi == 2)
                    b = 12;
                else if (posisi == 3)
                    c = 12;
                else if (posisi == 4)
                    d = 12;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon28_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 13;
                else if (posisi == 2)
                    b = 13;
                else if (posisi == 3)
                    c = 13;
                else if (posisi == 4)
                    d = 13;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon27_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 14;
                else if (posisi == 2)
                    b = 14;
                else if (posisi == 3)
                    c = 14;
                else if (posisi == 4)
                    d = 14;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon26_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 15;
                else if (posisi == 2)
                    b = 15;
                else if (posisi == 3)
                    c = 15;
                else if (posisi == 4)
                    d = 15;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon25_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 16;
                else if (posisi == 2)
                    b = 16;
                else if (posisi == 3)
                    c = 16;
                else if (posisi == 4)
                    d = 16;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon24_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 17;
                else if (posisi == 2)
                    b = 17;
                else if (posisi == 3)
                    c = 17;
                else if (posisi == 4)
                    d = 17;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon23_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 18;
                else if (posisi == 2)
                    b = 18;
                else if (posisi == 3)
                    c = 18;
                else if (posisi == 4)
                    d = 18;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon22_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 19;
                else if (posisi == 2)
                    b = 19;
                else if (posisi == 3)
                    c = 19;
                else if (posisi == 4)
                    d = 19;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon21_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 20;
                else if (posisi == 2)
                    b = 20;
                else if (posisi == 3)
                    c = 20;
                else if (posisi == 4)
                    d = 20;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon20_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 21;
                else if (posisi == 2)
                    b = 21;
                else if (posisi == 3)
                    c = 21;
                else if (posisi == 4)
                    d = 21;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon19_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 22;
                else if (posisi == 2)
                    b = 22;
                else if (posisi == 3)
                    c = 22;
                else if (posisi == 4)
                    d = 22;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon18_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 23;
                else if (posisi == 2)
                    b = 23;
                else if (posisi == 3)
                    c = 23;
                else if (posisi == 4)
                    d = 23;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon17_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 24;
                else if (posisi == 2)
                    b = 24;
                else if (posisi == 3)
                    c = 24;
                else if (posisi == 4)
                    d = 24;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon16_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 25;
                else if (posisi == 2)
                    b = 25;
                else if (posisi == 3)
                    c = 25;
                else if (posisi == 4)
                    d = 25;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon15_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 26;
                else if (posisi == 2)
                    b = 26;
                else if (posisi == 3)
                    c = 26;
                else if (posisi == 4)
                    d = 26;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon14_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 27;
                else if (posisi == 2)
                    b = 27;
                else if (posisi == 3)
                    c = 27;
                else if (posisi == 4)
                    d = 27;
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon13_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 28;
                else if (posisi == 2)
                    b = 28;
                else if (posisi == 3)
                    c = 28;
                else if (posisi == 4)
                    d = 28;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon12_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 29;
                else if (posisi == 2)
                    b = 29;
                else if (posisi == 3)
                    c = 29;
                else if (posisi == 4)
                    d = 29;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon11_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 30;
                else if (posisi == 2)
                    b = 30;
                else if (posisi == 3)
                    c = 30;
                else if (posisi == 4)
                    d = 30;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon10_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                    a = 31;
                else if (posisi == 2)
                    b = 31;
                else if (posisi == 3)
                    c = 31;
                else if (posisi == 4)
                    d = 31;
                text2();
                kirim();
                jarum();
                brightness();
            }
        }

        private void polygon9_MouseEnter(object sender, MouseEventArgs e)
        {
            if (on == 1)
            {
                if (posisi == 1)
                {
                    if (a != 1)
                    {
                        a = 32;
                        text2();
                    }
                    else
                        on = 0;
                }
                else if (posisi == 2)
                {
                    if (b != 1)
                    {
                        b = 32;
                        text2();
                    }
                    else
                        on = 0;
                }
                else if (posisi == 3)
                {
                    if (c != 1)
                    {
                        c = 32;
                        text2();
                    }
                    else
                        on = 0;
                }
                else if (posisi == 4)
                {
                    if (d != 1)
                    {
                        d = 32;
                        text2();
                    }
                    else
                        on = 0;
                }
                kirim();
                jarum();
                brightness();
            }
        }

        // ************************************************************************************************************

        private void polygon8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon32_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon31_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon30_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon29_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon28_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon27_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon26_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon25_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon24_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon23_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon22_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon21_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon20_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon19_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon18_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon17_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon16_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon15_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon14_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon13_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon12_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon10_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        private void polygon9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            on = 0;
        }

        // ************************************************************************************************************

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            on = 0;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
