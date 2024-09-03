using LiveCharts;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Lut.Park;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Security.Cryptography.Xml;

namespace Lut.Park.View
{
    /// <summary>
    /// RealtimeData.xaml 的交互逻辑
    /// </summary>
    public partial class RealtimeData : UserControl
    {
        //SerialPort serialPort = new SerialPort();
        //DispatcherTimer TimerPoll = new DispatcherTimer();
        public event MessageEventHandler Message;

        public delegate void MessageEventHandler(RealtimeData sender, string Data);

        //Server Control
        public IPAddress ServerIP = IPAddress.Parse("192.168.203.112");
        public int ServerPort = 3000;
        public TcpListener myserver;

        public Thread Comthread;
        public bool IsLiserning = true;

        //Clients
        private TcpClient client;
        private StreamReader clientdata;
        sbyte indexOfA, indexOfB, indexOfC;
        string sensorData1, sensorData2, sensorData3;
        string serialDataIn = "";
        DispatcherTimer TimerPoll = new DispatcherTimer();

        private void gauge2_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public RealtimeData()
        {
            InitializeComponent();

            //serialPort.PortName = "COM3";//Set your board COM
            //serialPort.BaudRate = 115200;
            //serialPort.Open();

            //TimerPoll.Interval = TimeSpan.FromSeconds(1);
            //TimerPoll.Tick += TimerPoll_Tick;
            //TimerPoll.Start();
            chart1.Values = new ChartValues<Int16> { };
            chart2.Values = new ChartValues<Int16> { };
            chart3.Values = new ChartValues<Int16> { };
            //Control.serialPort.DataReceived += SerialPort_DataReceived;
            myserver = new TcpListener(ServerIP, ServerPort);
            myserver.Start();

            Comthread = new Thread(new ThreadStart(Hearing));
            Comthread.Start();

        }
        private void Hearing()
        {
            while (!IsLiserning == false)
            {
                //if (myserver.Pending() == true)
                //{
                    client = myserver.AcceptTcpClient();
                    clientdata = new StreamReader(client.GetStream());


                //}

                try
                {
                    Message?.Invoke(this, clientdata.ReadLine());
                    Message += RecInfo;
                }

                catch (Exception ex)
                {

                }
                Thread.Sleep(1000);

            }
        }

        //private void TimerPoll_Tick(object? sender, EventArgs e)
        //{
        //    serialDataIn = Control.serialPort.ReadLine();
        //    this.Dispatcher.Invoke(new Action(ProcessData));
        //}
        //private void RecInfo(object sender, SerialDataReceivedEventArgs e)
        //{
        //    serialDataIn = Control.serialPort.ReadLine(); //We read the serial port

        //    this.Dispatcher.Invoke(new Action(ProcessData)); //execute the delegate (ProcessingData)
        //}
        private void RecInfo(object sender, string data)
        {
            serialDataIn = data; //We read the serial port

            this.Dispatcher.Invoke(new Action(ProcessData)); //execute the delegate (ProcessingData)
        }

        private void ProcessData()
        {
            try
            { if (serialDataIn != null )
                {
                    indexOfA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                    indexOfB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                    indexOfC = Convert.ToSByte(serialDataIn.IndexOf("C"));
                    sensorData1 = serialDataIn.Substring(0, indexOfA);
                    sensorData2 = serialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                    sensorData3 = serialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                    TemperatureBox.Text += sensorData1 + Environment.NewLine;
                    HumidityBox.Text += sensorData2 + Environment.NewLine;
                    AirBox.Text += sensorData3 + Environment.NewLine;
                    chart1.Values.Add(Convert.ToInt16(sensorData1));

                    if (chart1.Values.Count > 20)
                    {
                        chart1.Values.RemoveAt(0);
                    }
                    chart2.Values.Add(Convert.ToInt16(sensorData2));
                    if (chart2.Values.Count > 20)
                    {
                        chart2.Values.RemoveAt(0);
                    }
                    chart3.Values.Add(Convert.ToInt16(sensorData3));
                    if (chart3.Values.Count > 20)
                    {
                        chart3.Values.RemoveAt(0);
                    }
                    gauge1.Value = Convert.ToDouble(sensorData1);
                    gauge2.Value = Convert.ToDouble(sensorData2);
                    gauge3.Value = Convert.ToDouble(sensorData3);

                }
                
                //chart1.Values.Add(Convert.ToInt16(sensorData1));

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }

        }
    }
}
