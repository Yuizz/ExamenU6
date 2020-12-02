using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU6
{
    /// <summary>
    /// Proporciona herramientas, de momento solo proporciona el objeto capaz de leer una linea proveniente del puerto serial
    /// </summary>
    class Tools
    {
        string cadena;
        System.IO.Ports.SerialPort Port;
        bool request = false;
        public void OpenPort(string name, int baudRate)
        {
            Port = new System.IO.Ports.SerialPort();
            Port.PortName = name;
            Port.BaudRate = baudRate;
            Port.ReadTimeout = 500;
            try
            {
                Port.Open();
            }
            catch { }
        }
        public string ReadSerial()
        {
            cadena = "";
            if (Port.IsOpen)
            {
                if (!this.request)
                {
                    System.Threading.Thread.Sleep(500);
                    Port.WriteLine("2");
                    this.request = true;
                }
                else
                {
                    try
                    {
                        cadena = Port.ReadLine();
                    }
                    catch { }
                    cadena = cadena.Replace("\n", string.Empty);
                }
            }
            else
            {
                try
                {
                    Port.Open();
                }
                catch
                {
                    cadena = "Arduino desconectado!!";
                }
                this.request = false;
            }
            return cadena;
        }
        public void closePort()
        {
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }
    }
}
