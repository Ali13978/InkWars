using UnityEngine;
private sealed class NetworkBehaviour_CharacterSelect.<startPlayScene>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NetworkBehaviour_CharacterSelect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkBehaviour_CharacterSelect.<startPlayScene>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BattleVSGates val_2;
        var val_3;
        int val_4;
        val_2 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        this.<>4__this.thisPlayerState = 99;
        if((this.<>4__this) != null)
        {
            goto label_11;
        }
        
        goto label_6;
        label_1:
        this.<>1__state = 0;
        BattleVSGates.instance.LoadCharacterSprites();
        val_3 = null;
        if(BattleVSGates.instance == null)
        {
                val_3 = null;
        }
        
        BattleVSGates.instance.nextSceneName = "PlaySceneVS";
        val_2 = BattleVSGates.instance;
        val_2.Trigger(doNotShowGates:  false);
        label_3:
        val_4 = 0;
        return (bool)val_4;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_11;
        }
        
        label_6:
        label_11:
        if((this.<>4__this.otherPlayerState) >= 99)
        {
                this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  3f);
            this.<>1__state = 2;
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_4;
        return (bool)val_4;
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
