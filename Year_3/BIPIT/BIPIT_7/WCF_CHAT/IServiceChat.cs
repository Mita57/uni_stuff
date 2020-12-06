using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CHAT
{ 
    [ServiceContract(CallbackContract = typeof(IServerChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay =true)]
        void SendMsg(string msg, int id);

        [OperationContract]
        List<string> ShowMsg(string name);

    }

    public interface IServerChatCallback
    {
        [OperationContract(IsOneWay =true)]
        void MsgCallback(string msg);
    }
}
