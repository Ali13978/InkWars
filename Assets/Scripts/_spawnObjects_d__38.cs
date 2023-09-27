using UnityEngine;
private sealed class NetworkManager_Custom.<spawnObjects>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkManager_Custom.<spawnObjects>d__38(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        short val_11;
        int val_12;
        val_11 = this;
        if((this.<>1__state) > 1)
        {
            goto label_18;
        }
        
        this.<>1__state = 0;
        if(UnityEngine.Networking.NetworkServer.SpawnObjects() == false)
        {
            goto label_4;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  NetworkBehaviour_CharacterSelect.instance)) != false)
        {
                if(NetworkBehaviour_CharacterSelect.instance.gameObject.activeSelf != true)
        {
                UnityEngine.MonoBehaviour.print(message:  "Forcing active");
            NetworkBehaviour_CharacterSelect.instance.gameObject.SetActive(value:  true);
        }
        
        }
        
        val_11 = NetworkBehaviour_PlayScene.syncMessageId;
        if((UnityEngine.Object.op_Implicit(exists:  val_11)) != false)
        {
                val_11 = NetworkBehaviour_PlayScene.syncMessageId.gameObject;
            if(val_11.activeSelf != true)
        {
                UnityEngine.MonoBehaviour.print(message:  "Forcing active");
            val_11 = NetworkBehaviour_PlayScene.syncMessageId.gameObject;
            val_11.SetActive(value:  true);
        }
        
        }
        
        label_18:
        val_12 = 0;
        return (bool)val_12;
        label_4:
        UnityEngine.Debug.LogWarning(message:  "Failed to spawn objects");
        val_12 = 1;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        this.<>1__state = val_12;
        return (bool)val_12;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
