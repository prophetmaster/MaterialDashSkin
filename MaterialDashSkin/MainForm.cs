﻿using LiveCharts;
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
        System.IFormatProvider cultureUS = new System.Globalization.CultureInfo("en-US");

        //int pointCounter0, pointCounter1, pointCounter2, pointCounter3 = 0;

        // Define serial port object
        //SerialPort ComPort0, ComPort1, ComPort2, ComPort3;
        private bool myDebug = true;

        String mySerialData0 = "";
        String mySerialData1 = "";
        String mySerialData2 = "";
        String mySerialData3 = "";

        int mySeries = 0;

        string constr;

        int GridlinesOffset = 0;
        int[] MyBaudrate = { 150, 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200, 230400 };
        int[] MyDataBits = { 5, 6, 7, 8 };

        ArrayList mySensorData1 = new ArrayList();
        ArrayList mySensorData2 = new ArrayList();
        ArrayList mySensorData3 = new ArrayList();
        ArrayList mySensorData4 = new ArrayList();

        //bool mySensorPort0, mySensorPort1, mySensorPort2, mySensorPort3 = false;

        bool myRecording = false;
        SqlConnection conn;


        List<SerialPort> mySerialPorts = new List<SerialPort>();
        



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
            /*
            Debug.WriteLineIf(myDebug, "get baudrate0 :" + Settings.Default.baudrate0);
            Debug.WriteLineIf(myDebug, "get comport0 :" + Settings.Default.comport0.ToString());
            Debug.WriteLineIf(myDebug, "get databit0 :" + Settings.Default.databit0.ToString() + " value : " + materialComboBoxdatabit1.FindString(Settings.Default.databit0.ToString()));
            Debug.WriteLineIf(myDebug, "get parity0 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity0.ToString()));
            Debug.WriteLineIf(myDebug, "get stopbit0 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit0.ToString()));

            Debug.WriteLineIf(myDebug, "get baudrate1 :" + Settings.Default.baudrate1);
            Debug.WriteLineIf(myDebug, "get comport1 :" + Settings.Default.comport1.ToString());
            Debug.WriteLineIf(myDebug, "get databit1 :" + Settings.Default.databit1.ToString() + " value : " + materialComboBoxdatabit2.FindString(Settings.Default.databit1.ToString()));
            Debug.WriteLineIf(myDebug, "get parity1 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity1.ToString()));
            Debug.WriteLineIf(myDebug, "get stopbit1 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit1.ToString()));

            Debug.WriteLineIf(myDebug, "get baudrate2 :" + Settings.Default.baudrate2);
            Debug.WriteLineIf(myDebug, "get comport2 :" + Settings.Default.comport2.ToString());
            Debug.WriteLineIf(myDebug, "get databit2 :" + Settings.Default.databit2.ToString() + " value : " + materialComboBoxdatabit3.FindString(Settings.Default.databit2.ToString()));
            Debug.WriteLineIf(myDebug, "get parity2 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity2.ToString()));
            Debug.WriteLineIf(myDebug, "get stopbit2 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit2.ToString()));

            Debug.WriteLineIf(myDebug, "get baudrate3 :" + Settings.Default.baudrate3);
            Debug.WriteLineIf(myDebug, "get comport3 :" + Settings.Default.comport3.ToString());
            Debug.WriteLineIf(myDebug, "get databit3 :" + Settings.Default.databit3.ToString() + " value : " + materialComboBoxdatabit4.FindString(Settings.Default.databit3.ToString()));
            Debug.WriteLineIf(myDebug, "get parity3 :" + (Parity)Enum.Parse(typeof(Parity), Settings.Default.parity3.ToString()));
            Debug.WriteLineIf(myDebug, "get stopbit3 :" + (StopBits)Enum.Parse(typeof(StopBits), Settings.Default.stopbit3.ToString()));
            */

            // Re apply saved settings
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

            // Setting com port
            if (!SettingComPorts())
            {
                MessageBox.Show("Serial port are not setup correctly !", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Re apply sql server settings
            constr = @"Data Source=";
            constr += Settings.Default.databaseUrl;
            constr += ",";
            constr += Settings.Default.databasePort;
            constr += ";Network Library=DBMSSOCN;Initial Catalog=serialdata;User ID=";
            constr += Settings.Default.databaseLogin;
            constr += ";Password=";
            constr += Settings.Default.databasePassword;
            constr += ";";

            conn = new SqlConnection(constr);

            // to open the connection
            conn.Open();

            Debug.WriteLineIf(myDebug, "Connection Open!");


            SqlCommand cmd;

            SqlDataReader dreader;

            string sql, output = "";

            sql = "Select id, sensor1, sensor2, sensor3, sensor4, datetime, serie from myTable";

            cmd = new SqlCommand(sql, conn);

            dreader = cmd.ExecuteReader();

            int x = 0;
            int myLimit = 100;

            while (dreader.Read() && x <= myLimit)
            {

                output = output + "ID : " + dreader.GetValue(0) + " - " +
                                  "SENSOR1 : " + dreader.GetValue(1) + " - " +
                                  "SENSOR2 : " + dreader.GetValue(2) + " - " +
                                  "SENSOR3 : " + dreader.GetValue(3) + " - " +
                                  "SENSOR4 : " + dreader.GetValue(4) + " - " +
                                  "TIME : " + dreader.GetValue(5) + " - " +
                                  "SERIE : " + dreader.GetValue(6) +
                                  "\n";
                x++;
            }

            // to display the output
            //Debug.WriteLineIf(myDebug, output);

            // to close all the objects
            dreader.Close();
            cmd.Dispose();

            // to close the connection
            //conn.Close();


        }

        private bool SettingComPorts()
        {
            mySerialPorts.Add(new SerialPort());
            mySerialPorts.Add(new SerialPort());
            mySerialPorts.Add(new SerialPort());
            mySerialPorts.Add(new SerialPort());

            Debug.WriteLineIf(myDebug, "serialPort : " + (mySerialPorts.Count - 1));

            try
            {
                Debug.WriteLineIf(myDebug, "mySerialPorts[0].PortName :" + Settings.Default.comport0);
                Debug.WriteLineIf(myDebug, "mySerialPorts[0].BaudRate :" + MyBaudrate[Settings.Default.baudrate0]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[0].Parity :" + Settings.Default.parity0);
                Debug.WriteLineIf(myDebug, "mySerialPorts[0].DataBits :" + MyDataBits[Settings.Default.databit0]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[0].StopBits :" + Settings.Default.stopbit0);


                mySerialPorts[0].PortName = Settings.Default.comport0;      // Name of your COM port 
                mySerialPorts[0].BaudRate = MyBaudrate[Settings.Default.baudrate0];     // Baudrate
                mySerialPorts[0].Parity = Settings.Default.parity0;       // Parity bits = none  
                mySerialPorts[0].DataBits = MyDataBits[Settings.Default.databit0];      // No of Data bits = 8
                mySerialPorts[0].StopBits = Settings.Default.stopbit0;      // No of Stop bits = 1

                // Set the read/write timeouts
                mySerialPorts[0].ReadTimeout = 1500;
                mySerialPorts[0].WriteTimeout = 1500;

                mySerialPorts[0].DataReceived += new SerialDataReceivedEventHandler(ComPort0_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Setting serial 1
            try
            {
                Debug.WriteLineIf(myDebug, "mySerialPorts[1].PortName :" + Settings.Default.comport1);
                Debug.WriteLineIf(myDebug, "mySerialPorts[1].BaudRate :" + MyBaudrate[Settings.Default.baudrate1]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[1].Parity :" + Settings.Default.parity1);
                Debug.WriteLineIf(myDebug, "mySerialPorts[1].DataBits :" + MyDataBits[Settings.Default.databit1]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[1].StopBits :" + Settings.Default.stopbit1);


                mySerialPorts[1].PortName = Settings.Default.comport1;      // Name of your COM port 
                mySerialPorts[1].BaudRate = MyBaudrate[Settings.Default.baudrate1];     // Baudrate
                mySerialPorts[1].Parity = Settings.Default.parity1;       // Parity bits = none  
                mySerialPorts[1].DataBits = MyDataBits[Settings.Default.databit1];      // No of Data bits = 8
                mySerialPorts[1].StopBits = Settings.Default.stopbit1;      // No of Stop bits = 1

                // Set the read/write timeouts
                mySerialPorts[1].ReadTimeout = 1500;
                mySerialPorts[1].WriteTimeout = 1500;

                mySerialPorts[1].DataReceived += new SerialDataReceivedEventHandler(ComPort1_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Setting serial 1
            try
            {
                Debug.WriteLineIf(myDebug, "mySerialPorts[2].PortName :" + Settings.Default.comport2);
                Debug.WriteLineIf(myDebug, "mySerialPorts[2].BaudRate :" + MyBaudrate[Settings.Default.baudrate2]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[2].Parity :" + Settings.Default.parity2);
                Debug.WriteLineIf(myDebug, "mySerialPorts[2].DataBits :" + MyDataBits[Settings.Default.databit2]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[2].StopBits :" + Settings.Default.stopbit2);


                mySerialPorts[2].PortName = Settings.Default.comport2;      // Name of your COM port 
                mySerialPorts[2].BaudRate = MyBaudrate[Settings.Default.baudrate2];     // Baudrate
                mySerialPorts[2].Parity = Settings.Default.parity2;       // Parity bits = none  
                mySerialPorts[2].DataBits = MyDataBits[Settings.Default.databit2];      // No of Data bits = 8
                mySerialPorts[2].StopBits = Settings.Default.stopbit2;      // No of Stop bits = 1

                // Set the read/write timeouts
                mySerialPorts[2].ReadTimeout = 1500;
                mySerialPorts[2].WriteTimeout = 1500;

                mySerialPorts[2].DataReceived += new SerialDataReceivedEventHandler(ComPort2_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Setting serial 1
            try
            {
                Debug.WriteLineIf(myDebug, "mySerialPorts[3].PortName :" + Settings.Default.comport3);
                Debug.WriteLineIf(myDebug, "mySerialPorts[3].BaudRate :" + MyBaudrate[Settings.Default.baudrate3]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[3].Parity :" + Settings.Default.parity3);
                Debug.WriteLineIf(myDebug, "mySerialPorts[3].DataBits :" + MyDataBits[Settings.Default.databit3]);
                Debug.WriteLineIf(myDebug, "mySerialPorts[3].StopBits :" + Settings.Default.stopbit3);


                mySerialPorts[3].PortName = Settings.Default.comport3;      // Name of your COM port 
                mySerialPorts[3].BaudRate = MyBaudrate[Settings.Default.baudrate3];     // Baudrate
                mySerialPorts[3].Parity = Settings.Default.parity3;       // Parity bits = none  
                mySerialPorts[3].DataBits = MyDataBits[Settings.Default.databit3];      // No of Data bits = 8
                mySerialPorts[3].StopBits = Settings.Default.stopbit3;      // No of Stop bits = 1

                // Set the read/write timeouts
                mySerialPorts[3].ReadTimeout = 1500;
                mySerialPorts[3].WriteTimeout = 1500;

                mySerialPorts[3].DataReceived += new SerialDataReceivedEventHandler(ComPort3_DataReceived);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return true;
        }
        /*
        private void SetttingComPorts()
        {
            // Setting serial 0
            try
            {
                ComPort0 = new SerialPort();

                Debug.WriteLineIf(myDebug, "ComPort0.PortName :" + Settings.Default.comport0);
                Debug.WriteLineIf(myDebug, "ComPort0.BaudRate :" + MyBaudrate[Settings.Default.baudrate0]);
                Debug.WriteLineIf(myDebug, "ComPort0.Parity :" + Settings.Default.parity0);
                Debug.WriteLineIf(myDebug, "ComPort0.DataBits :" + MyDataBits[Settings.Default.databit0]);
                Debug.WriteLineIf(myDebug, "ComPort0.StopBits :" + Settings.Default.stopbit0);


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

            // Setting serial 1
            try
            {
                ComPort1 = new SerialPort();

                Debug.WriteLineIf(myDebug, "ComPort1.PortName :" + Settings.Default.comport1);
                Debug.WriteLineIf(myDebug, "ComPort1.BaudRate :" + MyBaudrate[Settings.Default.baudrate1]);
                Debug.WriteLineIf(myDebug, "ComPort1.Parity :" + Settings.Default.parity1);
                Debug.WriteLineIf(myDebug, "ComPort1.DataBits :" + MyDataBits[Settings.Default.databit1]);
                Debug.WriteLineIf(myDebug, "ComPort1.StopBits :" + Settings.Default.stopbit1);


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

            // Setting serial 1
            try
            {
                ComPort2 = new SerialPort();

                Debug.WriteLineIf(myDebug, "ComPort2.PortName :" + Settings.Default.comport2);
                Debug.WriteLineIf(myDebug, "ComPort2.BaudRate :" + MyBaudrate[Settings.Default.baudrate2]);
                Debug.WriteLineIf(myDebug, "ComPort2.Parity :" + Settings.Default.parity2);
                Debug.WriteLineIf(myDebug, "ComPort2.DataBits :" + MyDataBits[Settings.Default.databit2]);
                Debug.WriteLineIf(myDebug, "ComPort2.StopBits :" + Settings.Default.stopbit2);


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

            // Setting serial 1
            try
            {
                ComPort3 = new SerialPort();

                Debug.WriteLineIf(myDebug, "ComPort3.PortName :" + Settings.Default.comport3);
                Debug.WriteLineIf(myDebug, "ComPort3.BaudRate :" + MyBaudrate[Settings.Default.baudrate3]);
                Debug.WriteLineIf(myDebug, "ComPort3.Parity :" + Settings.Default.parity3);
                Debug.WriteLineIf(myDebug, "ComPort3.DataBits :" + MyDataBits[Settings.Default.databit3]);
                Debug.WriteLineIf(myDebug, "ComPort3.StopBits :" + Settings.Default.stopbit3);


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
        */

        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            // close SQL connection
            if (conn.State == ConnectionState.Closed)
            {
                conn.Close();
            }

            // Close all com port
            for (int i = 0; i< mySerialPorts.Count-1; i++)
            {
                if (mySerialPorts[i].IsOpen) { mySerialPorts[i].Close(); }
            }
            

        }

        // Executed when data is received in com port n°1
        private void ComPort0_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString1 = mySerialPorts[0].ReadLine().ToString();
            //Debug.WriteLineIf(myDebug,"mySenrodataString1 :" + mySenrodataString1);
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

        // Executed when data is received in com port n°2
        private void ComPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString2 = mySerialPorts[1].ReadLine().ToString();
            //Debug.WriteLineIf(myDebug,"mySenrodataString2 :" + mySenrodataString2);
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

        // Executed when data is received in com port n°3
        private void ComPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString3 = mySerialPorts[2].ReadLine().ToString();

            //Debug.WriteLineIf(myDebug,"mySenrodataString3 :" + mySenrodataString3);
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

        // Executed when data is received in com port n°4
        private void ComPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String mySenrodataString4 = mySerialPorts[3].ReadLine().ToString();

            //Debug.WriteLineIf(myDebug,"mySenrodataString4 :" + mySenrodataString4);
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

        // Form load
        private void Form2_Load(object sender, EventArgs e)
        {
            // Populate listbox with serial port name
            string[] ports = SerialPort.GetPortNames();

            // Clear serial port 0 name
            materialComboBoxsensor1port.Items.Clear();

            // Populate serial port combobox
            foreach (string comport in ports)
            {
                materialComboBoxsensor1port.Items.Add(comport);
            }

            // If com port > 0 find serial port com in saved setting and re apply
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

            // If com port > 0 find serial port com in saved setting and re apply
            if (materialComboBoxsensor2port.Items.Count > 0)
            {
                int index = materialComboBoxsensor2port.FindString(Settings.Default.comport1);
                materialComboBoxsensor2port.SelectedIndex = index;
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

            // If com port > 0 find serial port com in saved setting and re apply
            if (materialComboBoxsensor3port.Items.Count > 0)
            {
                int index = materialComboBoxsensor3port.FindString(Settings.Default.comport2);
                materialComboBoxsensor3port.SelectedIndex = index;
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

            // If com port > 0 find serial port com in saved setting and re apply
            if (materialComboBoxsensor4port.Items.Count > 0)
            {
                int index = materialComboBoxsensor4port.FindString(Settings.Default.comport3);
                materialComboBoxsensor4port.SelectedIndex = index;
            }
            else
            {
                materialComboBoxsensor1port.Text = " "; //if there are no com ports ,write Empty
            }

            // Setting chart config

            int myMajorGridInterval = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 500;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = myMajorGridInterval;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "ss.fff";
            chart1.Series[0].XValueType = ChartValueType.DateTime;      // this sets the type of the X-Axis values

            // Special tricks to initialise graph

            for (int i = 0; i < myMajorGridInterval; i++)
            {
                // Get actual date and time
                DateTime now = DateTime.Now;

                // Populate graph with data
                chart1.Series["Series1"].Points.AddXY("", "");
                chart1.Series["Series2"].Points.AddXY("", "");
                chart1.Series["Series3"].Points.AddXY("", "");
                chart1.Series["Series4"].Points.AddXY("", "");
            }

            // Paint graph
            chart1.Update();


        }

        /*
        // Start / pause graph live view
        private void materialButton1_Click(object sender, EventArgs e)
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
        */

        // Timer1 used to update graph
        private void timer1_Tick(object sender, EventArgs e)
        {

            // Get time and date
            DateTime now = DateTime.Now;

            if (mySerialPorts[0].IsOpen)
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

            if (mySerialPorts[1].IsOpen)
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

            if (mySerialPorts[2].IsOpen)
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

            if (mySerialPorts[3].IsOpen)
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
            /*
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
            */

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
            

            
            if (mySerialPorts[0].IsOpen)
            {
                try
                {
                    //backgroundWorker1.CancelAsync();
                    mySerialPorts[0].Close();
                    materialButtonsensor1.Text = "OPEN";
                    //mySensorPort0 = false;
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
                    mySerialPorts[0].Open();
                    //backgroundWorker1.RunWorkerAsync();
                    materialButtonsensor1.Text = "CLOSE";
                    //mySensorPort0 = true;
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
            if (mySerialPorts[1].IsOpen)
            {
                try
                {
                    mySerialPorts[1].Close();
                    materialButtonsensor2.Text = "OPEN";
                    //mySensorPort1 = false;
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
                    mySerialPorts[1].Open();
                    materialButtonsensor2.Text = "CLOSE";
                    //mySensorPort1 = true;
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
            if (mySerialPorts[2].IsOpen)
            {
                try
                {
                    mySerialPorts[2].Close();
                    materialButtonsensor3.Text = "OPEN";
                    //mySensorPort3 = false;
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
                    mySerialPorts[2].Open();
                    materialButtonsensor3.Text = "CLOSE";
                    //mySensorPort3 = true;
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
            if (mySerialPorts[3].IsOpen)
            {
                try
                {
                    mySerialPorts[3].Close();
                    materialButtonsensor4.Text = "OPEN";
                    //mySensorPort3 = false;
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
                    mySerialPorts[3].Open();
                    materialButtonsensor4.Text = "CLOSE";
                    //mySensorPort3 = true;
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

                for (int i = 0; i < mySerialPorts.Count-1; i++)
                {
                    mySerialPorts[i].Close();
                }

                //ComPort0.Close();
                //ComPort1.Close();
                //ComPort2.Close();
                //ComPort3.Close();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                int minArrayLength = Math.Min(mySensorData1.Count, Math.Min(mySensorData2.Count, Math.Min(mySensorData3.Count, mySensorData4.Count)));

                Debug.WriteLineIf(myDebug, minArrayLength);

                for (int i = 0; i < minArrayLength - 1; i++)
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
                    /*
                    Debug.WriteLineIf(myDebug,"mySensorData1 : " 
                        + mySensorData1[i].ToString().Replace(",", ".") 
                        + " mySensorData2 : " + mySensorData2[i].ToString().Replace(",", ".")
                        + " mySensorData3 : " + mySensorData3[i].ToString().Replace(",", ".")
                        + " mySensorData4 : " + mySensorData4[i].ToString().Replace(",", ".")
                        );
                    */
                    sql = "INSERT INTO myTable (sensor1, sensor2, sensor3, sensor4, datetime, serie) values("
                        + mySensorData1[i].ToString().Replace(",", ".")
                        + ","
                        + mySensorData2[i].ToString().Replace(",", ".")
                        + ","
                        + mySensorData3[i].ToString().Replace(",", ".")
                        + ","
                        + mySensorData4[i].ToString().Replace(",", ".")
                        + ",'"
                        + sqlFormattedDate
                        + "',"
                        + mySeries.ToString()
                        + ")";

                    Debug.WriteLineIf(myDebug, "sql : " + sql);

                    cmd = new SqlCommand(sql, conn);

                    adap.InsertCommand = new SqlCommand(sql, conn);
                    adap.InsertCommand.ExecuteNonQuery();

                    cmd.Dispose();
                    conn.Close();






                }
                /*
                var myList1 = mySensorData1;
                myList1.RemoveRange(0, minArrayLength);
                mySensorData1 = myList1;

                var myList2 = mySensorData2;
                myList2.RemoveRange(0, minArrayLength);
                mySensorData1 = myList2;

                var myList3 = mySensorData3;
                myList3.RemoveRange(0, minArrayLength);
                mySensorData1 = myList3;

                var myList4 = mySensorData4;
                myList4.RemoveRange(0, minArrayLength);
                mySensorData1 = myList4;

                int countArrayAfter = Math.Min(mySensorData1.Count, Math.Min(mySensorData2.Count, Math.Min(mySensorData3.Count, mySensorData4.Count)));

                Debug.WriteLineIf(myDebug, countArrayAfter);
                */

                mySeries++;

                for (int i = 0; i < mySerialPorts.Count - 1; i++)
                {
                    mySerialPorts[i].Open();
                }
                /*
                ComPort0.Open();
                ComPort1.Open();
                ComPort2.Open();
                ComPort3.Open();
                */
            }


        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            constr = @"Data Source=";
            constr += Settings.Default.databaseUrl;
            constr += ",";
            constr += Settings.Default.databasePort;
            constr += ";Network Library=DBMSSOCN;Initial Catalog=serialdata;User ID=";
            constr += Settings.Default.databaseLogin;
            constr += ";Password=";
            constr += Settings.Default.databasePassword;
            constr += ";";

            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constr);

            conn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM myTable", conn);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            // populate table with sql data 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dtbl;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker1.CancellationPending)
            {
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



        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            // Set settings from form
            Settings.Default.comport0 = materialComboBoxsensor1port.Text.ToString();
            Settings.Default.baudrate0 = materialComboBoxsensor1baud.SelectedIndex;
            Settings.Default.databit0 = materialComboBoxdatabit1.SelectedIndex;
            Settings.Default.parity0 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity1.SelectedItem.ToString());
            Settings.Default.stopbit0 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit1.SelectedItem.ToString());

            Settings.Default.comport1 = materialComboBoxsensor2port.Text.ToString();
            Settings.Default.baudrate1 = materialComboBoxsensor2baud.SelectedIndex;
            Settings.Default.databit1 = materialComboBoxdatabit2.SelectedIndex;
            Settings.Default.parity1 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity2.SelectedItem.ToString());
            Settings.Default.stopbit1 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit2.SelectedItem.ToString());

            Settings.Default.comport2 = materialComboBoxsensor3port.Text.ToString();
            Settings.Default.baudrate2 = materialComboBoxsensor3baud.SelectedIndex;
            Settings.Default.databit2 = materialComboBoxdatabit3.SelectedIndex;
            Settings.Default.parity2 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity3.SelectedItem.ToString());
            Settings.Default.stopbit2 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit3.SelectedItem.ToString());

            Settings.Default.comport3 = materialComboBoxsensor4port.Text.ToString();
            Settings.Default.baudrate3 = materialComboBoxsensor4baud.SelectedIndex;
            Settings.Default.databit3 = materialComboBoxdatabit4.SelectedIndex;
            Settings.Default.parity3 = (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity4.SelectedItem.ToString());
            Settings.Default.stopbit3 = (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit4.SelectedItem.ToString());

            Settings.Default.databaseUrl = materialTextBoxDatabaseUrl.Text;
            Settings.Default.databasePort = materialTextBoxDatabasePort.Text;
            Settings.Default.databaseLogin = materialTextBoxDatabaseLogin.Text;
            Settings.Default.databasePassword = materialTextBoxDatabasePassword.Text;

            if (myDebug)
            {
                // Debug sensor 1 settings
                Debug.WriteLineIf(myDebug, "set port1 :" + materialComboBoxsensor1port.Text);
                Debug.WriteLineIf(myDebug, "set databit1 :" + materialComboBoxdatabit1.SelectedIndex + " value : " + materialComboBoxdatabit1.Text);
                Debug.WriteLineIf(myDebug, "set baudrate1 :" + materialComboBoxsensor1baud.SelectedIndex + " value : " + materialComboBoxsensor1baud.Text);
                Debug.WriteLineIf(myDebug, "set Parity1 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity1.SelectedItem.ToString()));
                Debug.WriteLineIf(myDebug, "set StopBits1 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit1.SelectedItem.ToString()));

                // Debug sensor 2 settings
                Debug.WriteLineIf(myDebug, "set port2 :" + materialComboBoxsensor2port.Text);
                Debug.WriteLineIf(myDebug, "set databit2 :" + materialComboBoxdatabit2.SelectedIndex + " value : " + materialComboBoxdatabit2.Text);
                Debug.WriteLineIf(myDebug, "set baudrate2 :" + materialComboBoxsensor2baud.SelectedIndex + " value : " + materialComboBoxsensor2baud.Text);
                Debug.WriteLineIf(myDebug, "set Parity2 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity2.SelectedItem.ToString()));
                Debug.WriteLineIf(myDebug, "set StopBits2 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit2.SelectedItem.ToString()));

                // Debug sensor 3 settings
                Debug.WriteLineIf(myDebug, "set port3 :" + materialComboBoxsensor3port.Text);
                Debug.WriteLineIf(myDebug, "set databit3 :" + materialComboBoxdatabit3.SelectedIndex + " value : " + materialComboBoxdatabit3.Text);
                Debug.WriteLineIf(myDebug, "set baudrate3 :" + materialComboBoxsensor3baud.SelectedIndex + " value : " + materialComboBoxsensor3baud.Text);
                Debug.WriteLineIf(myDebug, "set Parity3 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity3.SelectedItem.ToString()));
                Debug.WriteLineIf(myDebug, "set StopBits3 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit3.SelectedItem.ToString()));

                // Debug sensor 4 settings
                Debug.WriteLineIf(myDebug, "set port4 :" + materialComboBoxsensor4port.Text);
                Debug.WriteLineIf(myDebug, "set databit4 :" + materialComboBoxdatabit4.SelectedIndex + " value : " + materialComboBoxdatabit4.Text);
                Debug.WriteLineIf(myDebug, "set baudrate4 :" + materialComboBoxsensor4baud.SelectedIndex + " value : " + materialComboBoxsensor4baud.Text);
                Debug.WriteLineIf(myDebug, "set Parity4 :" + (Parity)Enum.Parse(typeof(Parity), materialComboBoxparity4.SelectedItem.ToString()));
                Debug.WriteLineIf(myDebug, "set StopBits4 :" + (StopBits)Enum.Parse(typeof(StopBits), materialComboBoxstopbit4.SelectedItem.ToString()));

                // Debug database
                Debug.WriteLineIf(myDebug, "set databaseUrl :" + materialTextBoxDatabaseUrl.Text);
                Debug.WriteLineIf(myDebug, "set databasePort :" + materialTextBoxDatabasePort.Text);
                Debug.WriteLineIf(myDebug, "set databaseLogin :" + materialTextBoxDatabaseLogin.Text);
                Debug.WriteLineIf(myDebug, "set databasePassword :" + materialTextBoxDatabasePassword.Text);

            }

            Settings.Default.Save();

            SettingComPorts();
        }
    }
}
