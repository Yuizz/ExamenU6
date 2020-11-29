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
        bool isClosed=false;
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
            if (isClosed)
            {
                try 
                { 
                    Port.Open(); 
                    isClosed = false;
                    return "";
                } 
                catch { }
            }
            try
            {
                Port.WriteLine("2");
            }
            catch 
            {
                isClosed = true;
                return "Arduino desconectado!!"; 
            }
            while (cadena.Length<1)
            {
                try
                {
                    cadena = Port.ReadLine();
                }
                catch { }
            }
            cadena = cadena.Replace("\n", string.Empty);
            return cadena;
        }
        public void closePort()
        {
            isClosed = true;
            if (Port.IsOpen)
            {
                Port.Close();
            }
        }
    }
}
