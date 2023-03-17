using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static KronReader.KronListener;

// Socket Listener acts as a server and listens to the incoming
// messages on the specified port and protocol.
public class SocketListener
{
    public static int Main(String[] args)
    {
        StartServer(5656);
        return 0;
    }
}