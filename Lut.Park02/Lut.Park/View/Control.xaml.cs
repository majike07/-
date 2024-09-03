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

namespace Lut.Park.View
{
    /// <summary>
    /// Control.xaml 的交互逻辑
    /// </summary>
    public partial class Control : UserControl
        
    {
        public static SerialPort serialPort;
        public static string[] serialPorts;
        public Control()
        {
            InitializeComponent();
            InitializeSerialPorts();
        }
        public void InitializeSerialPorts()
        {
            serialPorts = SerialPort.GetPortNames();
            if (serialPorts.Count() != 0)
            {
                foreach (string serial in serialPorts)
                {
                    var serialItems = SerialPortNamesCmbBox.Items;
                    if (!serialItems.Contains(serial)) // if the serial is not yet inside the combobox 
                    {
                        SerialPortNamesCmbBox.Items.Add(serial);  // add a serial port name to combo box
                    }
                }
                SerialPortNamesCmbBox.SelectedItem = serialPorts[0];// combobox as default selected item 
            }
        }

        #region WPF to Arduino connection
        bool isConnectedToArduino = false;
       public  void ConnectToArduino()
        {
            try
            {
                string selectedSerialPort = SerialPortNamesCmbBox.SelectedItem.ToString(); // gets the selected port
                serialPort = new SerialPort(selectedSerialPort, 9600);
                serialPort.Open();
                SerialPortConnectBtn.Content = "Disconnect";
                LedControlPanel.IsEnabled = true;
                isConnectedToArduino = true;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("The selected serial port is busy!", "Busy", MessageBoxButton.OK, MessageBoxImage.Stop);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("There is no serial port!", "Empty Serial Port", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void DisconnectFromArduino()
        {
            SerialPortConnectBtn.Content = "Connect";
            LedControlPanel.IsEnabled = false;
            isConnectedToArduino = false;
            ResetControl();
            serialPort.Close();
        }

        public void ResetControl()
        {
            LedOffBtn.Background = Brushes.DarkGray;
            LedOnBtn.Background = Brushes.DarkGray;
            SliderBrightness.Value = 0;
            LblSliderBrightness.Content = "0";
        }

        public void SerialPortConnectBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isConnectedToArduino)
            {
                ConnectToArduino();
                
            }
            else
            {
                DisconnectFromArduino();
                
            }
        }
        #endregion


        #region LED Switch
        private void LedOffBtn_Click(object sender, RoutedEventArgs e)
        {
           
            serialPort.Write("256");
            LedOnBtn.Background = Brushes.DarkGray;
            LedOffBtn.Background = Brushes.LightPink;
       
           
        }

        private void LedOnBtn_Click(object sender, RoutedEventArgs e)
        {
            serialPort.Write("257");
            LedOnBtn.Background = Brushes.LightPink;
            LedOffBtn.Background = Brushes.DarkGray;
        }
        #endregion

        #region Control brightness LED
        private void SliderBrightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int sliderValue = (int)SliderBrightness.Value;
            serialPort.Write(sliderValue.ToString()); // send the value of a slider to arduino
            serialPort.Write("-"); // negative as no data to send
            LblSliderBrightness.Content = sliderValue.ToString();
        }
        #endregion

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            InitializeSerialPorts();
        }

    }
}
