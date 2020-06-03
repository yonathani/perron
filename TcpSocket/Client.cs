using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TcpSocket
{
    public class Client
    {
        private ClientForm clientForm;
        private TcpClient client;
        private Thread thread;
        private NetworkStream networkStream;
        private byte[] bytes;
        private string receivedData;
        private string path;
        private string fileName;

        public Client(ClientForm clientForm)
        {
            this.clientForm = clientForm;
        }

        public void Start(string host, int port)
        {
            try
            {
                clientForm.SetMessage("Conectado..."); 

                client = new TcpClient();                
                client.Connect(host, port);
            }
            catch { }
            
            thread = new Thread(new ThreadStart(ClientStartThread));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
        }

        private void ClientStartThread()
        {
            try
            {
                do
                {
                    networkStream = client.GetStream();

                    bytes = new byte[client.ReceiveBufferSize];
                    networkStream.Read(bytes, 0, client.ReceiveBufferSize);
                    receivedData = Encoding.ASCII.GetString(bytes);

                    if (receivedData.Replace("\0", "") == "Cerrando conexion...")
                    {
                        clientForm.SetMessage(receivedData); //servidor se esta ejecutando
                        clientForm.Disconnect();
                    }
                    else
                    {
                        path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);//carpeta del usuario
                        File.WriteAllBytes(path + "\\Downloads\\" + fileName + ".txt", bytes); //Guardado archivo

                        clientForm.SetMessage("Archivo descargado correctamente..."); 
                    }
                } while (client.Connected);
            }
            catch (IOException)
            {
                clientForm.Disconnect();

                clientForm.SetMessage("Cliente desconectado...");
            }
            catch (InvalidOperationException)
            {                
                clientForm.Disconnect();

                clientForm.SetMessage("Servidor desconectado...");
            }
        }

        public void SearchFile(string fileName)
        {
            this.fileName = Path.GetFileName(fileName);

            if (networkStream.CanWrite)
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(fileName); 
                networkStream.Write(sendBytes, 0, sendBytes.Length);

                clientForm.SetMessage("Buscando archivo...");
            }
        }

        public void Disconnect()
        {
            if (thread != null)
                if (thread.ThreadState == ThreadState.Running)
                    thread.Abort();

            client.Close();
        }

        public void SendMessage(string message)
        {
            if (networkStream.CanWrite)
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                clientForm.SetMessage(message);
            }
        }
    }
}
