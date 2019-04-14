using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class NetModel
{
    private static NetModel _instance = null;

    private NetModel()
    {
        
    }

    public static NetModel GetInstance()
    {
        if (_instance == null)
        {
            _instance = new NetModel();
        }
        return _instance;
    }

    public static bool StartConnect()
    {
        bool isConnect = false;
        try
        {
            Socket clientSocket;
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect("47.102.207.240", 6060);
            isConnect = true;
            Debug.Log("连接服务器成功");
        }
        catch (System.Exception ex)
        {
            Debug.Log("连接服务器失败！");
            Debug.Log(ex.Message);
        }
        return isConnect;
    }
}