<<<<<<< HEAD
using System;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.TestRunner.TestLaunchers;

namespace UnityEditor.TestTools.TestRunner
{
    [Serializable]
    internal class RemoteTestResultReciever
    {
        public void RunStarted(MessageEventArgs messageEventArgs)
        {
        }

        public void RunFinished(MessageEventArgs messageEventArgs)
        {
            EditorConnection.instance.Send(PlayerConnectionMessageIds.quitPlayerMessageId, null, messageEventArgs.playerId);
            EditorConnection.instance.DisconnectAll();
        }
    }
}
=======
using System;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.TestRunner.TestLaunchers;

namespace UnityEditor.TestTools.TestRunner
{
    [Serializable]
    internal class RemoteTestResultReciever
    {
        public void RunStarted(MessageEventArgs messageEventArgs)
        {
        }

        public void RunFinished(MessageEventArgs messageEventArgs)
        {
            EditorConnection.instance.Send(PlayerConnectionMessageIds.quitPlayerMessageId, null, messageEventArgs.playerId);
            EditorConnection.instance.DisconnectAll();
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
