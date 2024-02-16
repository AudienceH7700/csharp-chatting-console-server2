using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChattingServiceConsoleServer
{
    class ClientData
    {
        public TcpClient tcpClient { get; set; }
        public Byte[] readBuffer { get; set; }
        public StringBuilder currentMsg { get; set; }
        public string clientName {  get; set; }
        public int clientNumber {  get; set; }

        public ClientData(TcpClient client) { 
            currentMsg = new StringBuilder();
            readBuffer = new byte[1024];

            this.tcpClient = client;

            char[] splitDivision = new char[2];
            splitDivision[0] = '.';
            splitDivision[1] = ':';

            string[] temp = null;
            temp = tcpClient.Client.LocalEndPoint.ToString().Split(splitDivision);

            this.clientNumber = int.Parse(temp[3]);
        }
    }
}
