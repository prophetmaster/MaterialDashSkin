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
using System.Diagnostics;
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

        // Define serial port object
        SerialPort ComPort0, ComPort1, ComPort2, ComPort3;

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
                ComPort0 = new SerialPort();

                ComPort0.PortName = Settings.Default.comport0;       // Name of your COM port 
                ComPort0.BaudRate = Settings.Default.baudrate0;      // Baudrate
                ComPort0.Parity   = Settings.Default.parity0;        // Parity bits = none  
                ComPort0.DataBits = Settings.Default.databit0;       // No of Data bits = 8
                ComPort0.StopBits = Settings.Default.stopbit0;       // No of Stop bits = 1

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
                ComPort1 = new SerialPort();

                ComPort1.PortName = Settings.Default.comport1;      // Name of your COM port 
                ComPort1.BaudRate = Settings.Default.baudrate1;     // Baudrate
                ComPort1.Parity   = Settings.Default.parity1;       // Parity bits = none  
                ComPort1.DataBits = Settings.Default.databit1;      // No of Data bits = 8
                ComPort1.StopBits = Settings.Default.stopbit1;      // No of Stop bits = 1

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
                ComPort2 = new SerialPort();

                ComPort2.PortName = Settings.Default.comport2;      // Name of your COM port 
                ComPort2.BaudRate = Settings.Default.baudrate2;     // Baudrate
                ComPort2.Parity   = Settings.Default.parity2;       // Parity bits = none  
                ComPort2.DataBits = Settings.Default.databit2;      // No of Data bits = 8
                ComPort2.StopBits = Settings.Default.stopbit2;      // No of Stop bits = 1

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
                ComPort3 = new SerialPort();

                ComPort3.PortName = Settings.Default.comport3;      // Name of your COM port 
                ComPort3.BaudRate = Settings.Default.baudrate3;     // Baudrate
                ComPort3.Parity   = Settings.Default.parity3;       // Parity bits = none  
                ComPort3.DataBits = Settings.Default.databit3;      // No of Data bits = 8
                ComPort3.StopBits = Settings.Default.stopbit3;      // No of Stop bits = 1

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
            


            // Populate listbox with serial port name
            string[] ports = SerialPort.GetPortNames();
            

            materialComboBoxsensor1port.Items.Clear();
            foreach (string comport in ports)
            {
                materialComboBoxsensor1port.Items.Add(comport);
            }
            if (materialComboBoxsensor1port.Items.Count > 0)
            {
                int index = materialComboBoxsensor1port.FindString(Settings.Default.comport0);
                materialComboBoxsensor1port.SelectedIndex = index;
            }
            else
            {
                materialComboBoxsensor1port.Text = " "; //if there are no com ports ,write Empty
            }

            materialComboBoxsensor2port.Items.Clear();
            foreach (string comport in ports)
            {
                materialComboBoxsensor2port.Items.Add(comport);
            }
            if (materialComboBoxsensor2port.Items.Count > 0)
            {
                materialComboBoxsensor2port.SelectedIndex = 0;
            }
            else
            {
                materialComboBoxsensor2port.Text = " "; //if there are no com ports ,write Empty
            }

            materialComboBoxsensor3port.Items.Clear();
            foreach (string comport in ports)
            {
                materialComboBoxsensor3port.Items.Add(comport);
            }
            if (materialComboBoxsensor3port.Items.Count > 0)
            {
                materialComboBoxsensor3port.SelectedIndex = 0;
            }
            else
            {
                materialComboBoxsensor3port.Text = " "; //if there are no com ports ,write Empty
            }

            materialComboBoxsensor4port.Items.Clear();
            foreach (string comport in ports)
            {
                materialComboBoxsensor4port.Items.Add(comport);
            }
            if (materialComboBoxsensor4port.Items.Count > 0)
            {
                materialComboBoxsensor4port.SelectedIndex = 0;
            }
            else
            {
                materialComboBoxsensor1port.Text = " "; //if there are no com ports ,write Empty
            }
            
            /*
            string[] baudrates = new string[] { "150", "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400" };

            foreach (string baudrate in baudrates) { materialComboBoxsensor1baud.Items.Add(baudrate); }
            foreach (string baudrate in baudrates) { materialComboBoxsensor2baud.Items.Add(baudrate); }
            foreach (string baudrate in baudrates) { materialComboBoxsensor3baud.Items.Add(baudrate); }
            foreach (string baudrate in baudrates) { materialComboBoxsensor4baud.Items.Add(baudrate); }


            int[] dataBits = new int[] { 5,6,7,8,9 };

            foreach (int databit in dataBits) { materialComboBoxdatabit1.Items.Add(databit); }
            foreach (int databit in dataBits) { materialComboBoxdatabit2.Items.Add(databit); }
            foreach (int databit in dataBits) { materialComboBoxdatabit3.Items.Add(databit); }
            foreach (int databit in dataBits) { materialComboBoxdatabit4.Items.Add(databit); }

            string[] Paritys = new string[] { "None", "Odd", "Even", "Mark", "Space" };

            foreach (string parity in Paritys) { materialComboBoxparity1.Items.Add(parity); }
            foreach (string parity in Paritys) { materialComboBoxparity2.Items.Add(parity); }
            foreach (string parity in Paritys) { materialComboBoxparity3.Items.Add(parity); }
            foreach (string parity in Paritys) { materialComboBoxparity4.Items.Add(parity); }

            int[] stopBits = new int[] { 0,1,2 };

            foreach (int stopbit in stopBits) { materialComboBoxstopbit1.Items.Add(stopbit); }
            foreach (int stopbit in stopBits) { materialComboBoxstopbit2.Items.Add(stopbit); }
            foreach (int stopbit in stopBits) { materialComboBoxstopbit3.Items.Add(stopbit); }
            foreach (int stopbit in stopBits) { materialComboBoxstopbit4.Items.Add(stopbit); }
            */
            

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

            // Set text from settings

            materialComboBoxsensor1baud.SelectedIndex   = Settings.Default.baudrate0;
            materialComboBoxdatabit1.SelectedIndex      = materialComboBoxdatabit1.FindString(Settings.Default.databit0.ToString());

            //materialComboBoxsensor1baud.Text = Settings.Default.baudrate0.ToString();
            materialComboBoxsensor1port.Text = Settings.Default.comport0.ToString();
            //materialComboBoxdatabit1.Text    = Settings.Default.databit0.ToString();
            materialComboBoxparity1.Text     = Settings.Default.parity0.ToString();
            materialComboBoxstopbit1.Text    = Settings.Default.stopbit0.ToString();
            /*
            materialComboBoxsensor2baud.Text = Settings.Default.baudrate1.ToString();
            materialComboBoxsensor2port.Text = Settings.Default.comport1.ToString();
            materialComboBoxdatabit2.Text    = Settings.Default.databit1.ToString();
            materialComboBoxparity2.Text     = Settings.Default.parity1.ToString();
            materialComboBoxstopbit2.Text    = Settings.Default.stopbit1.ToString();

            materialComboBoxsensor3baud.Text = Settings.Default.baudrate2.ToString();
            materialComboBoxsensor3port.Text = Settings.Default.comport2.ToString();
            materialComboBoxdatabit3.Text    = Settings.Default.databit2.ToString();
            materialComboBoxparity3.Text     = Settings.Default.parity2.ToString();
            materialComboBoxstopbit3.Text    = Settings.Default.stopbit2.ToString();

            materialComboBoxsensor4baud.Text = Settings.Default.baudrate3.ToString();
            materialComboBoxsensor4port.Text = Settings.Default.comport3.ToString();
            materialComboBoxdatabit4.Text    = Settings.Default.databit3.ToString();
            materialComboBoxparity4.Text     = Settings.Default.parity3.ToString();
            materialComboBoxstopbit4.Text    = Settings.Default.stopbit3.ToString();
            */


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
                labelsensor1value.Text = mySerialData0;
                chart1.Series["Series1"].Points.AddXY("", yValue: mySerialData0);
            }
            catch { }

            try
            {
                String mySerialData1 = (string)ComPort1.ReadLine();
                labelsensor2value.Text = mySerialData1;
                chart1.Series["Series2"].Points.AddXY("", yValue: mySerialData1);
            }
            catch { }

            try
            {
                String mySerialData2 = (string)ComPort2.ReadLine();
                labelsensor3value.Text = mySerialData2;
                chart1.Series["Series3"].Points.AddXY("", yValue: mySerialData2);
            }
            catch { }

            try
            {
                String mySerialData3 = (string)ComPort3.ReadLine();
                labelsensor4value.Text = mySerialData3;
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


        private void materialButtongraphplaypause_Click(object sender, EventArgs e)
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

        private void materialButtonsensor1_Click(object sender, EventArgs e)
        {
            if (ComPort0.IsOpen)
            {
                try
                {
                    ComPort0.Close();
                    materialButtonsensor1.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort0.Open();
                    materialButtonsensor1.Text = "Connect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialButtonsensor2_Click(object sender, EventArgs e)
        {
            if (ComPort1.IsOpen)
            {
                try
                {
                    ComPort1.Close();
                    materialButtonsensor1.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort1.Open();
                    materialButtonsensor1.Text = "Connect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialComboBoxsensor1baud_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("selected baudrate : " + materialComboBoxsensor1baud.SelectedItem + " : " + materialComboBoxsensor1baud.SelectedIndex);

        }

        private void materialButtonsensor3_Click(object sender, EventArgs e)
        {
            if (ComPort2.IsOpen)
            {
                try
                {
                    ComPort2.Close();
                    materialButtonsensor1.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort2.Open();
                    materialButtonsensor2.Text = "Connect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialButtonsensor4_Click(object sender, EventArgs e)
        {
            if (ComPort3.IsOpen)
            {
                try
                {
                    ComPort3.Close();
                    materialButtonsensor3.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort3.Open();
                    materialButtonsensor4.Text = "Connect";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            // Set settings from form
            Settings.Default.comport0  = ComPort0.PortName;
            
            Settings.Default.baudrate0 = materialComboBoxsensor1baud.SelectedIndex;
            Settings.Default.databit0  = materialComboBoxdatabit1.SelectedIndex;
            Settings.Default.parity0   = (Parity)materialComboBoxparity1.SelectedIndex;
            Settings.Default.stopbit0 = (StopBits)materialComboBoxstopbit1.SelectedIndex;

            Settings.Default.comport1  = ComPort1.PortName;
            Settings.Default.baudrate1 = ComPort1.BaudRate;
            Settings.Default.databit1  = ComPort1.DataBits;
            Settings.Default.parity1   = ComPort1.Parity;
            Settings.Default.stopbit1  = ComPort1.StopBits;

            Settings.Default.comport2  = ComPort2.PortName;
            Settings.Default.baudrate2 = ComPort2.BaudRate;
            Settings.Default.databit2  = ComPort2.DataBits;
            Settings.Default.parity2   = ComPort2.Parity;
            Settings.Default.stopbit2  = ComPort2.StopBits;

            Settings.Default.comport3  = ComPort3.PortName;
            Settings.Default.baudrate3 = ComPort3.BaudRate;
            Settings.Default.databit3  = ComPort3.DataBits;
            Settings.Default.parity3   = ComPort3.Parity;
            Settings.Default.stopbit3  = ComPort3.StopBits;

            Settings.Default.Save();
        }
    }
}
