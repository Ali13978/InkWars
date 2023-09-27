using UnityEngine;
private sealed class PlayerToScene.<Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PlayerToScene <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerToScene.<Start>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_4;
        int val_5;
        val_4 = this;
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
        if((this.<>4__this.player.isPlaying) == false)
        {
            goto label_10;
        }
        
        goto label_9;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_9;
        }
        
        goto label_9;
        label_2:
        this.<>1__state = 0;
        label_10:
        if((this.<>4__this.player.isPlaying) == false)
        {
            goto label_12;
        }
        
        label_9:
        if((this.<>4__this.player.isPlaying) != false)
        {
                this.<>2__current = 0;
            this.<>1__state = 2;
            val_5 = 1;
            return (bool)val_5;
        }
        
        val_4 = this.<>4__this.nextScene;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_4);
        label_3:
        val_5 = 0;
        return (bool)val_5;
        label_12:
        val_5 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_5;
        return (bool)val_5;
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
