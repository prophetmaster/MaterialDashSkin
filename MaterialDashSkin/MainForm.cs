using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using MaterialDashSkin.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MaterialDashSkin
{
    public partial class MainForm : MaterialForm
    {
        //int pointCounter0, pointCounter1, pointCounter2, pointCounter3 = 0;

        // Define serial port
        readonly SerialPort ComPort0 = new SerialPort();
        readonly SerialPort ComPort1 = new SerialPort();
        readonly SerialPort ComPort2 = new SerialPort();
        readonly SerialPort ComPort3 = new SerialPort();


        public MainForm()
        {
            InitializeComponent();

            // Apply theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue900,
                Primary.Blue800,
                Primary.Blue500,
                Accent.Green400,
                TextShade.WHITE
            );

            // Open serial 0
            try
            {
                ComPort0.PortName = "COM21";       // Name of your COM port 
                ComPort0.BaudRate = 115200;           // Baudrate
                ComPort0.Parity = Parity.None;          // Parity bits = none  
                ComPort0.DataBits = 8;                  // No of Data bits = 8
                ComPort0.StopBits = StopBits.One;       // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort0.ReadTimeout = 1500;
                ComPort0.WriteTimeout = 1500;
                ComPort0.Open();

                //ComPort0.DataReceived += new SerialDataReceivedEventHandler(ComPort0_DataReceived);
            }
            catch { }

            // Open serial 1
            try
            {
                ComPort1.PortName = "COM23";       // Name of your COM port 
                ComPort1.BaudRate = 115200;           // Baudrate
                ComPort1.Parity = Parity.None;          // Parity bits = none  
                ComPort1.DataBits = 8;                  // No of Data bits = 8
                ComPort1.StopBits = StopBits.One;       // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort1.ReadTimeout = 1500;
                ComPort1.WriteTimeout = 1500;
                ComPort1.Open();

                //ComPort1.DataReceived += new SerialDataReceivedEventHandler(ComPort1_DataReceived);
            }
            catch { }

            // Open serial 1
            try
            {
                ComPort2.PortName = "COM25";       // Name of your COM port 
                ComPort2.BaudRate = 115200;           // Baudrate
                ComPort2.Parity = Parity.None;          // Parity bits = none  
                ComPort2.DataBits = 8;                  // No of Data bits = 8
                ComPort2.StopBits = StopBits.One;       // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort2.ReadTimeout = 1500;
                ComPort2.WriteTimeout = 1500;
                ComPort2.Open();

                //ComPort2.DataReceived += new SerialDataReceivedEventHandler(ComPort2_DataReceived);
            }
            catch { }

            // Open serial 1
            try
            {
                ComPort3.PortName = "COM27";       // Name of your COM port 
                ComPort3.BaudRate = 115200;           // Baudrate
                ComPort3.Parity = Parity.None;          // Parity bits = none  
                ComPort3.DataBits = 8;                  // No of Data bits = 8
                ComPort3.StopBits = StopBits.One;       // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort3.ReadTimeout = 1500;
                ComPort3.WriteTimeout = 1500;
                ComPort3.Open();

                //ComPort3.DataReceived += new SerialDataReceivedEventHandler(ComPort3_DataReceived);
            }
            catch { }

        }
        /*
        private void ComPort0_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //this.Invoke(new MethodInvoker(() => chart1.Series["Series1"].Points.AddXY("", yValue: (string)ComPort0.ReadLine())));
            //this.Invoke(new MethodInvoker(() => label2.Text = (string)ComPort0.ReadLine()));
            // Redraw the graph
        }

        private void ComPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //this.Invoke(new MethodInvoker(() => chart1.Series["Series2"].Points.AddXY("", yValue: (string)ComPort1.ReadLine())));
            //this.Invoke(new MethodInvoker(() => label3.Text = (string)ComPort1.ReadLine()));
            // Redraw the graph
        }

        private void ComPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //this.Invoke(new MethodInvoker(() => chart1.Series["Series3"].Points.AddXY("", yValue: (string)ComPort2.ReadLine())));
            //this.Invoke(new MethodInvoker(() => label6.Text = (string)ComPort2.ReadLine()));
            // Redraw the graph
        }

        private void ComPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //this.Invoke(new MethodInvoker(() => chart1.Series["Series4"].Points.AddXY("", yValue: (string)ComPort3.ReadLine())));
            //this.Invoke(new MethodInvoker(() => label8.Text = (string)ComPort3.ReadLine()));
            // Redraw the graph
        }
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            // Set text from settings
            materialComboBox1.Text = Settings.Default["baudrate0"].ToString();
            materialComboBox2.Text = Settings.Default["comport0"].ToString();

            // Get serial port name
            String[] ports = SerialPort.GetPortNames();

            // Populate listbox with serial port name
            for (int i = 0; i <= ports.Length - 1; i++)
            {
                materialComboBox1.Items.Add(ports[i]);
            }

            // Special tricks to initialise graph
            for (int i = 0; i < 100; i++)
            {
                chart1.Series["Series1"].Points.AddXY("", yValue: i);
                chart1.Series["Series2"].Points.AddXY("", yValue: i);
                chart1.Series["Series3"].Points.AddXY("", yValue: i);
                chart1.Series["Series4"].Points.AddXY("", yValue: i);
            }

            // Paint graph
            chart1.Update();



        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Start / pause graph live view
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Set settings from form
            Settings.Default["comport0"] = materialComboBox1.Text;
            Settings.Default["baudrate0"] = materialComboBox2.Text;
            Settings.Default.Save();
        }


        private void chart1_Click_1(object sender, EventArgs e)
        {
            /*
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Count graph point
            int pointCounter0 = chart1.Series["Series1"].Points.Count;
            int pointCounter1 = chart1.Series["Series2"].Points.Count;
            int pointCounter2 = chart1.Series["Series3"].Points.Count;
            int pointCounter3 = chart1.Series["Series4"].Points.Count;

            // Define graph scale
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 500;

            try
            {
                String mySerialData0 = (string)ComPort0.ReadLine();
                label2.Text = mySerialData0;
                chart1.Series["Series1"].Points.AddXY("", yValue: mySerialData0);
            } catch { }
            
            try
            {
                String mySerialData1 = (string)ComPort1.ReadLine();
                label3.Text = mySerialData1;
                chart1.Series["Series2"].Points.AddXY("", yValue: mySerialData1);
            }
            catch { }

            try
            {
                String mySerialData2 = (string)ComPort2.ReadLine();
                label6.Text = mySerialData2;
                chart1.Series["Series3"].Points.AddXY("", yValue: mySerialData2);
            }
            catch { }

            try
            {
                String mySerialData3 = (string)ComPort3.ReadLine();
                label8.Text = mySerialData3;
                chart1.Series["Series4"].Points.AddXY("", yValue: mySerialData3);
            }
            catch { }



            // Remove point if limit exceed

            if (pointCounter0 > 100) { chart1.Series["Series1"].Points.RemoveAt(0); }
            if (pointCounter1 > 100) { chart1.Series["Series2"].Points.RemoveAt(0); }
            if (pointCounter2 > 100) { chart1.Series["Series3"].Points.RemoveAt(0); }
            if (pointCounter3 > 100) { chart1.Series["Series4"].Points.RemoveAt(0); }
            


            // Redraw the graph
            chart1.Update();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
