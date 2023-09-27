using UnityEngine;
private sealed class NetworkBehaviour_CharacterSelect.<Start>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NetworkBehaviour_CharacterSelect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkBehaviour_CharacterSelect.<Start>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_1;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_2;
        }
        
        this.<>4__this.localPlayerReady = false;
        this.<>4__this.otherPlayerReady = false;
        this.<>4__this.localPlayerSceneReady = false;
        this.<>4__this.otherPlayerSceneReady = false;
        goto label_3;
        label_0:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_2:
        mem[72] = 0;
        mem[73] = 0;
        mem[75] = 0;
        mem[76] = 0;
        label_3:
        this.<>4__this.thisPlayerState = 1;
        if((this.<>4__this) != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if((this.<>4__this.otherPlayerState) < 1)
        {
            goto label_7;
        }
        
        label_1:
        val_1 = 0;
        return (bool)val_1;
        label_7:
        val_1 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_1;
        return (bool)val_1;
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
