using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using MaterialDashSkin.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private bool myDebug = true;

        String mySerialData0 = "";
        String mySerialData1 = "";
        String mySerialData2 = "";
        String mySerialData3 = "";

        int GridlinesOffset = 0;
        int[] MyBaudrate = { 150, 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200, 230400 };
        int[] MyDataBits = { 5, 6, 7, 8 };

        ArrayList mySensorData1 = new ArrayList();
        ArrayList mySensorData2 = new ArrayList();
        ArrayList mySensorData3 = new ArrayList();
        ArrayList mySensorData4 = new ArrayList();

        bool mySensorPort0, mySensorPort1, mySensorPort2, mySensorPort3 = false;

        bool myRecording = false;
        SqlConnection conn;

        public MainForm()
        {
            InitializeComponent();

            this.FormClosed += MainForm_FormClosed;

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
            materialSkinManager.EnforceBackcolorOnAllComponents = false;

            // Set text from settings
            if (myDebug)
            {
                Debug.WriteLine("get baudrate0 :" + Settings.Default.baudrate0);
                Debug.WriteLine("get comport0 :" + Settings.Default.comport0.ToString());
                Debug.WriteLine("get databit0 :" + Settings.Default.databit0.ToString() + " value : " + materialComboBoxdatabit1.FindString(Settings.Default.databit0.ToString()));
                Debug.WriteLine("get parity0 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity0.ToString()));
                Debug.WriteLine("get stopbit0 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit0.ToString()));

                Debug.WriteLine("get baudrate1 :" + Settings.Default.baudrate1);
                Debug.WriteLine("get comport1 :" + Settings.Default.comport1.ToString());
                Debug.WriteLine("get databit1 :" + Settings.Default.databit1.ToString() + " value : " + materialComboBoxdatabit2.FindString(Settings.Default.databit0.ToString()));
                Debug.WriteLine("get parity1 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity1.ToString()));
                Debug.WriteLine("get stopbit1 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit1.ToString()));

                Debug.WriteLine("get baudrate2 :" + Settings.Default.baudrate2);
                Debug.WriteLine("get comport2 :" + Settings.Default.comport2.ToString());
                Debug.WriteLine("get databit2 :" + Settings.Default.databit2.ToString() + " value : " + materialComboBoxdatabit3.FindString(Settings.Default.databit0.ToString()));
                Debug.WriteLine("get parity2 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity2.ToString()));
                Debug.WriteLine("get stopbit2 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit2.ToString()));

                Debug.WriteLine("get baudrate3 :" + Settings.Default.baudrate3);
                Debug.WriteLine("get comport3 :" + Settings.Default.comport3.ToString());
                Debug.WriteLine("get databit3 :" + Settings.Default.databit3.ToString() + " value : " + materialComboBoxdatabit4.FindString(Settings.Default.databit0.ToString()));
                Debug.WriteLine("get parity3 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity3.ToString()));
                Debug.WriteLine("get stopbit3 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit3.ToString()));
            }

            materialComboBoxsensor1baud.SelectedIndex = Settings.Default.baudrate0;
            materialComboBoxsensor1port.Text = Settings.Default.comport0.ToString();
            materialComboBoxdatabit1.SelectedIndex = Settings.Default.databit0;
            materialComboBoxparity1.SelectedIndex = (int)(Parity)Enum.Parse(typeof(Parity), Settings.Default.parity0.ToString());
            materialComboBoxstopbit1.SelectedIndex = (int)(StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit0.ToString());

            materialComboBoxsensor2baud.SelectedIndex = Settings.Default.baudrate1;
            materialComboBoxsensor2port.Text = Settings.Default.comport1.ToString();
            materialComboBoxdatabit2.SelectedIndex = Settings.Default.databit1;
            materialComboBoxparity2.SelectedIndex = (int)(Parity)Enum.Parse(typeof(Parity), Settings.Default.parity1.ToString());
            materialComboBoxstopbit2.SelectedIndex = (int)(StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit1.ToString());

            materialComboBoxsensor3baud.SelectedIndex = Settings.Default.baudrate2;
            materialComboBoxsensor3port.Text = Settings.Default.comport2.ToString();
            materialComboBoxdatabit3.SelectedIndex = Settings.Default.databit2;
            materialComboBoxparity3.SelectedIndex = (int)(Parity)Enum.Parse(typeof(Parity), Settings.Default.parity2.ToString());
            materialComboBoxstopbit3.SelectedIndex = (int)(StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit2.ToString());

            materialComboBoxsensor4baud.SelectedIndex = Settings.Default.baudrate3;
            materialComboBoxsensor4port.Text = Settings.Default.comport3.ToString();
            materialComboBoxdatabit4.SelectedIndex = Settings.Default.databit3;
            materialComboBoxparity4.SelectedIndex = (int)(Parity)Enum.Parse(typeof(Parity), Settings.Default.parity3.ToString());
            materialComboBoxstopbit4.SelectedIndex = (int)(StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit3.ToString());

            SetttingComPorts();





            string constr;

            // for the connection to
            // sql server database


            // Data Source is the name of the
            // server on which the database is stored.
            // The Initial Catalog is used to specify
            // the name of the database
            // The UserID and Password are the credentials
            // required to connect to the database.
            constr = @"Data Source=ASUS-SULLIVAN\SQLEXPRESS;Initial Catalog=serialdata;User ID=test;Password=test";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            if (myDebug)
            {
                Debug.WriteLine("Connection Open!");


                SqlCommand cmd;

                SqlDataReader dreader;

                string sql, output = "";

                sql = "Select id, sensor1, sensor2, sensor3, sensor4, datetime from myTable";

                cmd = new SqlCommand(sql, conn);

                dreader = cmd.ExecuteReader();

                while (dreader.Read())
                {
                    output = output + "ID : " + dreader.GetValue(0) + " - " +
                                      "SENSOR1 : " + dreader.GetValue(1) + " - " +
                                      "SENSOR2 : " + dreader.GetValue(2) + " - " +
                                      "SENSOR3 : " + dreader.GetValue(3) + " - " +
                                      "SENSOR4 : " + dreader.GetValue(4) + " - " +
                                      "TIME : " + dreader.GetValue(5) + " - " +
                                      "\n";
                }

                // to display the output
                Debug.Write(output);

                // to close all the objects
                dreader.Close();
                cmd.Dispose();

                // to close the connection
                //conn.Close();
            }

        }

        private void SetttingComPorts()
        {
            // Open serial 0
            try
            {
                ComPort0 = new SerialPort();

                if (myDebug)
                {
                    Debug.WriteLine("ComPort0.PortName :" + Settings.Default.comport0);
                    Debug.WriteLine("ComPort0.BaudRate :" + MyBaudrate[Settings.Default.baudrate0]);
                    Debug.WriteLine("ComPort0.Parity :" + Settings.Default.parity0);
                    Debug.WriteLine("ComPort0.DataBits :" + MyDataBits[Settings.Default.databit0]);
                    Debug.WriteLine("ComPort0.StopBits :" + Settings.Default.stopbit0);
                }

                ComPort0.PortName = Settings.Default.comport0;      // Name of your COM port 
                ComPort0.BaudRate = MyBaudrate[Settings.Default.baudrate0];     // Baudrate
                ComPort0.Parity = Settings.Default.parity0;       // Parity bits = none  
                ComPort0.DataBits = MyDataBits[Settings.Default.databit0];      // No of Data bits = 8
                ComPort0.StopBits = Settings.Default.stopbit0;      // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort0.ReadTimeout = 1500;
                ComPort0.WriteTimeout = 1500;

                ComPort0.DataReceived += new SerialDataReceivedEventHandler(ComPort0_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Open serial 1
            try
            {
                ComPort1 = new SerialPort();

                ComPort1.PortName = Settings.Default.comport1;      // Name of your COM port 
                ComPort1.BaudRate = MyBaudrate[Settings.Default.baudrate1];     // Baudrate
                ComPort1.Parity = Settings.Default.parity1;       // Parity bits = none  
                ComPort1.DataBits = MyDataBits[Settings.Default.databit1];      // No of Data bits = 8
                ComPort1.StopBits = Settings.Default.stopbit1;      // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort1.ReadTimeout = 1500;
                ComPort1.WriteTimeout = 1500;

                ComPort1.DataReceived += new SerialDataReceivedEventHandler(ComPort1_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Open serial 1
            try
            {
                ComPort2 = new SerialPort();

                ComPort2.PortName = Settings.Default.comport2;      // Name of your COM port 
                ComPort2.BaudRate = MyBaudrate[Settings.Default.baudrate2];     // Baudrate
                ComPort2.Parity = Settings.Default.parity2;       // Parity bits = none  
                ComPort2.DataBits = MyDataBits[Settings.Default.databit2];      // No of Data bits = 8
                ComPort2.StopBits = Settings.Default.stopbit2;      // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort2.ReadTimeout = 1500;
                ComPort2.WriteTimeout = 1500;

                ComPort2.DataReceived += new SerialDataReceivedEventHandler(ComPort2_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Open serial 1
            try
            {
                ComPort3 = new SerialPort();

                ComPort3.PortName = Settings.Default.comport3;      // Name of your COM port 
                ComPort3.BaudRate = MyBaudrate[Settings.Default.baudrate3];     // Baudrate
                ComPort3.Parity = Settings.Default.parity3;       // Parity bits = none  
                ComPort3.DataBits = MyDataBits[Settings.Default.databit3];      // No of Data bits = 8
                ComPort3.StopBits = Settings.Default.stopbit3;      // No of Stop bits = 1

                // Set the read/write timeouts
                ComPort3.ReadTimeout = 1500;
                ComPort3.WriteTimeout = 1500;

                ComPort3.DataReceived += new SerialDataReceivedEventHandler(ComPort3_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private void ComPort0_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString1 = ComPort0.ReadLine().ToString();
            //Debug.WriteLine("mySenrodataString1 :" + mySenrodataString1);
            try
            {
                mySensorData1.Add((float)Convert.ToDouble(mySenrodataString1));
                mySerialData0 = mySenrodataString1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString2 = ComPort1.ReadLine().ToString();
            //Debug.WriteLine("mySenrodataString2 :" + mySenrodataString2);
            try
            {
                mySensorData2.Add((float)Convert.ToDouble(mySenrodataString2));
                mySerialData1 = mySenrodataString2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString3 = ComPort2.ReadLine().ToString();

            //Debug.WriteLine("mySenrodataString3 :" + mySenrodataString3);
            try
            {
                mySensorData3.Add((float)Convert.ToDouble(mySenrodataString3));
                mySerialData2 = mySenrodataString3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString4 = ComPort3.ReadLine().ToString();

            //Debug.WriteLine("mySenrodataString4 :" + mySenrodataString4);
            try
            {
                mySensorData4.Add((float)Convert.ToDouble(mySenrodataString4));
                mySerialData3 = mySenrodataString4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 500;



            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 100;

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "ss.fff";
            // this sets the type of the X-Axis values
            chart1.Series[0].XValueType = ChartValueType.DateTime;

            // Special tricks to initialise graph

            for (int i = 0; i < 100; i++)
            {
                DateTime now = DateTime.Now;

                chart1.Series["Series1"].Points.AddXY("", "");
                chart1.Series["Series2"].Points.AddXY("", "");
                chart1.Series["Series3"].Points.AddXY("", "");
                chart1.Series["Series4"].Points.AddXY("", "");
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Get time and date
            DateTime now = DateTime.Now;

            if (ComPort0.IsOpen)
            {
                try
                {
                    labelsensor1value.Text = mySerialData0;
                    chart1.Series["Series1"].Points.RemoveAt(0);
                    chart1.Series["Series1"].Points.AddXY(now, yValue: mySerialData0.Replace(",", "."));
                    chart1.Series["Series1"].IsXValueIndexed = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                chart1.Series["Series1"].Points.RemoveAt(0);
                chart1.Series["Series1"].Points.AddXY(now, "");
                chart1.Series["Series1"].IsXValueIndexed = true;
                if (myRecording) { }
            }

            if (ComPort1.IsOpen)
            {
                try
                {
                    labelsensor2value.Text = mySerialData1;
                    chart1.Series["Series2"].Points.RemoveAt(0);
                    chart1.Series["Series2"].Points.AddXY(now, yValue: mySerialData1.Replace(",", "."));
                    chart1.Series["Series2"].IsXValueIndexed = true;
                    if (myRecording) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                chart1.Series["Series2"].Points.RemoveAt(0);
                chart1.Series["Series2"].Points.AddXY(now, "");
                chart1.Series["Series2"].IsXValueIndexed = true;
            }

            if (ComPort2.IsOpen)
            {

                try
                {
                    labelsensor3value.Text = mySerialData2;
                    chart1.Series["Series3"].Points.RemoveAt(0);
                    chart1.Series["Series3"].Points.AddXY(now, yValue: mySerialData2.Replace(",", "."));
                    chart1.Series["Series3"].IsXValueIndexed = true;
                    if (myRecording) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                chart1.Series["Series3"].Points.RemoveAt(0);
                chart1.Series["Series3"].Points.AddXY(now, "");
                chart1.Series["Series3"].IsXValueIndexed = true;
            }

            if (ComPort3.IsOpen)
            {

                try
                {
                    labelsensor4value.Text = mySerialData3;
                    chart1.Series["Series4"].Points.RemoveAt(0);
                    chart1.Series["Series4"].Points.AddXY(now, yValue: mySerialData3.Replace(",", "."));
                    chart1.Series["Series4"].IsXValueIndexed = true;
                    if (myRecording) { }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                chart1.Series["Series4"].Points.RemoveAt(0);
                chart1.Series["Series4"].Points.AddXY(now, "");
                chart1.Series["Series4"].IsXValueIndexed = true;
            }


            chart1.ResetAutoValues();


            // Make gridlines move.
            chart1.ChartAreas[0].AxisX.MajorGrid.IntervalOffset = -GridlinesOffset;

            // Calculate next offset.
            GridlinesOffset++;
            GridlinesOffset %= (int)chart1.ChartAreas[0].AxisX.MajorGrid.Interval;

            // Redraw the graph
            //chart1.Update();


        }


        private void materialButtongraphplaypause_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                materialButtongraphplaypause.Text = "PLAY";
                timer1.Stop();
            }
            else
            {
                materialButtongraphplaypause.Text = "PAUSE";
                timer1.Start();
            }
        }

        private void materialButtonsensor1_Click(object sender, EventArgs e)
        {

            if (ComPort0.IsOpen)
            {
                try
                {
                    //backgroundWorker1.CancelAsync();
                    ComPort0.Close();
                    materialButtonsensor1.Text = "OPEN";
                    mySensorPort0 = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort0.Open();
                    //backgroundWorker1.RunWorkerAsync();
                    materialButtonsensor1.Text = "CLOSE";
                    mySensorPort0 = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
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
                    materialButtonsensor2.Text = "OPEN";
                    mySensorPort1 = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort1.Open();
                    materialButtonsensor2.Text = "CLOSE";
                    mySensorPort1 = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialButtonsensor3_Click(object sender, EventArgs e)
        {
            if (ComPort2.IsOpen)
            {
                try
                {
                    ComPort2.Close();
                    materialButtonsensor3.Text = "OPEN";
                    mySensorPort3 = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort2.Open();
                    materialButtonsensor3.Text = "CLOSE";
                    mySensorPort3 = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
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
                    materialButtonsensor4.Text = "OPEN";
                    mySensorPort3 = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    ComPort3.Open();
                    materialButtonsensor4.Text = "CLOSE";
                    mySensorPort3 = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == true)
            {
                myRecording = true;
            }
            else
            {
                myRecording = false;
                ComPort0.Close();

                foreach (var item in mySensorData1)
                {
                    Debug.WriteLine("test : " + item);
                }
                ComPort0.Open();

                ComPort1.Close();

                foreach (var item in mySensorData2)
                {
                    Debug.WriteLine("test2 : " + item);
                }
                ComPort1.Open();

                ComPort2.Close();

                foreach (var item in mySensorData3)
                {
                    Debug.WriteLine("test3 : " + item);
                }
                ComPort2.Open();

                ComPort3.Close();

                foreach (var item in mySensorData4)
                {
                    Debug.WriteLine("test4 : " + item);
                }
                ComPort3.Open();

                /*
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }



                SqlCommand cmd;

                SqlDataAdapter adap = new SqlDataAdapter();

                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                string sql = "";

                sql = "INSERT INTO myTable (sensor1, sensor2, sensor3, sensor4, datetime) values('" + (float)Convert.ToDouble(mySensorData1[item]) + "','" + (float)Convert.ToDouble(mySensorData2[item]) + "','" + (float)Convert.ToDouble(mySensorData3[item]) + "','" + (float)Convert.ToDouble(mySensorData4[item]) + "','" + sqlFormattedDate + "')";
                if (myDebug) { Debug.WriteLine("sql : " + sql); }

                cmd = new SqlCommand(sql, conn);

                adap.InsertCommand = new SqlCommand(sql, conn);
                adap.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
                */


                //ComPort0.Open();
            }


        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            ComPort0.Close();
            ComPort1.Close();
            ComPort2.Close();
            ComPort3.Close();

            Debug.WriteLine("mySensorData1 length : " + mySensorData1.Count);
            Debug.WriteLine("mySensorData2 length : " + mySensorData2.Count);
            Debug.WriteLine("mySensorData3 length : " + mySensorData3.Count);
            Debug.WriteLine("mySensorData4 length : " + mySensorData4.Count);

            foreach (var item in mySensorData1)
            {
                Debug.WriteLine("mySensorData1 : " + item);
            }
            foreach (var item in mySensorData2)
            {
                Debug.WriteLine("mySensorData2 : " + item);
            }
            foreach (var item in mySensorData3)
            {
                Debug.WriteLine("mySensorData3 : " + item);
            }
            foreach (var item in mySensorData4)
            {
                Debug.WriteLine("mySensorData4 : " + item);
            }

            int aaa = Math.Min(mySensorData1.Count, Math.Min(mySensorData2.Count, Math.Min(mySensorData3.Count, mySensorData4.Count)));

            Debug.WriteLine("aaa : " + aaa);

            for (int i = 0; i < aaa - 1; i++)
            {
                Debug.WriteLine("mySensorData1 : " + mySensorData1[i] + " mySensorData2 : " + mySensorData2[i] + " mySensorData3 : " + mySensorData3[i] + " mySensorData4 : " + mySensorData4[i]);

            }



            /*
            foreach (var item in mySensorData1)
            {
                Debug.WriteLine("mySensorData1 : " + item);
            }
            foreach (var item in mySensorData2)
            {
                Debug.WriteLine("mySensorData2 : " + item);
            }
            foreach (var item in mySensorData3)
            {
                Debug.WriteLine("mySensorData3 : " + item);
            }
            foreach (var item in mySensorData4)
            {
                Debug.WriteLine("mySensorData4 : " + item);
            }
            */

            ComPort0.Open();
            ComPort1.Open();
            ComPort2.Open();
            ComPort3.Open();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker1.CancellationPending)
            {

                ComPort0.Close();
                ComPort1.Close();
                ComPort2.Close();
                ComPort3.Close();
                int aaa = Math.Min(mySensorData1.Count, Math.Min(mySensorData2.Count, Math.Min(mySensorData3.Count, mySensorData4.Count)));

                Debug.WriteLine("aaa : " + aaa);

                for (int i = 0; i < aaa - 1; i++)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }



                    SqlCommand cmd;

                    SqlDataAdapter adap = new SqlDataAdapter();

                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                    string sql = "";
                    Debug.WriteLine("mySensorData1 : " + mySensorData1[i] + " mySensorData2 : " + mySensorData2[i] + " mySensorData3 : " + mySensorData3[i] + " mySensorData4 : " + mySensorData4[i]);

                    sql = "INSERT INTO myTable (sensor1, sensor2, sensor3, sensor4, datetime) values('" + (float)Convert.ToDouble(mySensorData1[i].ToString()) + "','" + (float)Convert.ToDouble(mySensorData2[i].ToString()) + "','" + (float)Convert.ToDouble(mySensorData3[i].ToString()) + "','" + (float)Convert.ToDouble(mySensorData4[i].ToString()) + "','" + sqlFormattedDate + "')";

                    if (myDebug) { Debug.WriteLine("sql : " + sql); }

                    cmd = new SqlCommand(sql, conn);

                    adap.InsertCommand = new SqlCommand(sql, conn);
                    adap.InsertCommand.ExecuteNonQuery();

                    cmd.Dispose();
                    conn.Close();

                    ComPort0.Open();
                    ComPort1.Open();
                    ComPort2.Open();
                    ComPort3.Open();
                }
            }
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker2.CancellationPending)
            {
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker3.CancellationPending)
            {
            }
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker4.CancellationPending)
            {
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            // Set settings from form
            Settings.Default.comport0 = materialComboBoxsensor1port.Text;
            Settings.Default.baudrate0 = materialComboBoxsensor1baud.SelectedIndex;
            Settings.Default.databit0 = materialComboBoxdatabit1.SelectedIndex;
            Settings.Default.parity0 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity1.SelectedItem.ToString());
            Settings.Default.stopbit0 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit1.SelectedItem.ToString());

            Settings.Default.comport1 = materialComboBoxsensor2port.Text;
            Settings.Default.baudrate1 = materialComboBoxsensor2baud.SelectedIndex;
            Settings.Default.databit1 = materialComboBoxdatabit2.SelectedIndex;
            Settings.Default.parity1 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity2.SelectedItem.ToString());
            Settings.Default.stopbit1 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit2.SelectedItem.ToString());

            Settings.Default.comport2 = materialComboBoxsensor3port.Text;
            Settings.Default.baudrate2 = materialComboBoxsensor3baud.SelectedIndex;
            Settings.Default.databit2 = materialComboBoxdatabit3.SelectedIndex;
            Settings.Default.parity2 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity3.SelectedItem.ToString());
            Settings.Default.stopbit2 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit3.SelectedItem.ToString());

            Settings.Default.comport3 = materialComboBoxsensor4port.Text;
            Settings.Default.baudrate3 = materialComboBoxsensor4baud.SelectedIndex;
            Settings.Default.databit3 = materialComboBoxdatabit4.SelectedIndex;
            Settings.Default.parity3 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity4.SelectedItem.ToString());
            Settings.Default.stopbit3 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit4.SelectedItem.ToString());

            if (myDebug)
            {
                // Debug sensor 1 settings
                Debug.WriteLine("set port1 :" + materialComboBoxsensor1port.Text);
                Debug.WriteLine("set databit1 :" + materialComboBoxdatabit1.SelectedIndex + " value : " + materialComboBoxdatabit1.Text);
                Debug.WriteLine("set baudrate1 :" + materialComboBoxsensor1baud.SelectedIndex + " value : " + materialComboBoxsensor1baud.Text);
                Debug.WriteLine("set Parity1 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity1.SelectedItem.ToString()));
                Debug.WriteLine("set StopBits1 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit1.SelectedItem.ToString()));

                // Debug sensor 2 settings
                Debug.WriteLine("set port2 :" + materialComboBoxsensor2port.Text);
                Debug.WriteLine("set databit2 :" + materialComboBoxdatabit2.SelectedIndex + " value : " + materialComboBoxdatabit2.Text);
                Debug.WriteLine("set baudrate2 :" + materialComboBoxsensor2baud.SelectedIndex + " value : " + materialComboBoxsensor2baud.Text);
                Debug.WriteLine("set Parity2 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity2.SelectedItem.ToString()));
                Debug.WriteLine("set StopBits2 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit2.SelectedItem.ToString()));

                // Debug sensor 3 settings
                Debug.WriteLine("set port3 :" + materialComboBoxsensor3port.Text);
                Debug.WriteLine("set databit3 :" + materialComboBoxdatabit3.SelectedIndex + " value : " + materialComboBoxdatabit3.Text);
                Debug.WriteLine("set baudrate3 :" + materialComboBoxsensor3baud.SelectedIndex + " value : " + materialComboBoxsensor3baud.Text);
                Debug.WriteLine("set Parity3 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity3.SelectedItem.ToString()));
                Debug.WriteLine("set StopBits3 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit3.SelectedItem.ToString()));

                // Debug sensor 4 settings
                Debug.WriteLine("set port4 :" + materialComboBoxsensor4port.Text);
                Debug.WriteLine("set databit4 :" + materialComboBoxdatabit4.SelectedIndex + " value : " + materialComboBoxdatabit4.Text);
                Debug.WriteLine("set baudrate4 :" + materialComboBoxsensor4baud.SelectedIndex + " value : " + materialComboBoxsensor4baud.Text);
                Debug.WriteLine("set Parity4 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity4.SelectedItem.ToString()));
                Debug.WriteLine("set StopBits4 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit4.SelectedItem.ToString()));

            }

            Settings.Default.Save();
        }
    }
}
