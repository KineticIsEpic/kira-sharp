using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace KiraSharp {
    /// <summary>
    /// Simple class for interfacing with Project Kira serial devices. 
    /// </summary>
    public class KiraSerial {
        SerialPort serial;
        /// <summary>
        /// Name of Project Kira device
        /// </summary>
        public string devname;
        /// <summary>
        /// If the serial port is ready
        /// </summary>
        public bool isopen;

        private int[] servopos = new int[10];

        int rate = 9600;
        public string slport = "COM1";

        /// <summary>
        /// Gets the port name
        /// </summary>
        public string serialport {
            get {
                try { return serial.PortName; }
                catch (Exception) { return null; }
            }
        }

        /// <summary>
        /// Gets the serial baud rate
        /// </summary>
        public int serialrate {
            get {
                try { return serial.BaudRate; }
                catch (Exception) { return 0; }
            }
        }

        /// <summary>
        /// Gets a string with the timeouts
        /// </summary>
        public string timeouts {
            get {
                try {
                    return serial.ReadTimeout.ToString() + "/" + 
                        serial.WriteTimeout.ToString();
                }
                catch (Exception) { return null; }
            }
        }

        /// <summary>
        /// Make a new KiraSerial and open the commmunication port
        /// with the specified parameters.
        /// </summary>
        public KiraSerial(string port, int bdrate) {
            Open(port, bdrate);
        }

        /// <summary>
        /// Make a new KiraSerial without opening a communication port.
        /// </summary>
        public KiraSerial() { }

        /// <summary>
        /// Opens the communication port.
        /// </summary>
        public void Open() {
            serial = new SerialPort(slport, rate);
            serial.ReadTimeout = 1500;
            serial.WriteTimeout = 1500;
            serial.Open();
            isopen = serial.IsOpen;

            try {
                serial.Write("n");
                devname = serial.ReadTo("\n");
            }
            catch (Exception) {
                Logger.WriteLine("Serial connection failed. Trying again...");

                serial = new SerialPort(slport, rate);
                serial.ReadTimeout = 1500;
                serial.WriteTimeout = 1500;
                serial.Open();
                isopen = serial.IsOpen;
            }

            Logger.Write("Connection established \r\nDevice Name: \""
                + devname + "\"\r\nPort: " + serial.PortName + "\r\nTimeout(R): "
                + serial.ReadTimeout + "\r\nTimeout(W): " + serial.WriteTimeout
                + "\r\nBaud Rate: " + serial.BaudRate);
        }

        /// <summary>
        /// Opens the communication port.
        /// </summary>
        /// <param name="port">Port COM name</param>
        /// <param name="bdrate">Baud rate</param>
        public void Open(string port, int bdrate) {
            slport = port;
            if (bdrate != 0) rate = bdrate;

            Open();
        }

        /// <summary>
        /// Disconnect any connected device.
        /// </summary>
        public void Disconnect() {
            serial.Close();
            devname = "";
            isopen = false;

            Logger.Write("Serial disconnected.");
        }

        public string[] Getservos() {
            serial.Write("gs");

            string servostr = serial.ReadTo("$");
            string[] servolst = servostr.Split(',');

            Logger.WriteLine("Asked for servos, got: " 
                + servostr);
            foreach (string svol in servolst)
                Logger.WriteLine("List item: " + svol, true);

            return servolst;
        }
        
        /// <summary>
        /// Adds servo position data to the queue. 
        /// </summary>
        /// <param name="servo">Servo index</param>
        /// <param name="loc">Servo position</param>
        /// <param name="time">Time to reach position</param>
        public void Setservo(int servo, int loc, int time) {
            servopos[servo * 2] = loc;
            servopos[servo * 2 + 1] = time;
        }

        /// <summary>
        /// Sends commands to the device. 
        /// </summary>
        public void Run() {
            string svs = "";
            foreach (int i in servopos) svs += i.ToString() + ",";
            svs = svs.Substring(0, svs.Length - 1);
            
            serial.Write(svs);

            Logger.Write("Wrote: " + svs);
        }
    }
}