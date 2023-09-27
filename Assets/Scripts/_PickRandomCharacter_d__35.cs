using UnityEngine;
private sealed class CharacterSelectPanel.<PickRandomCharacter>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharacterSelectPanel <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterSelectPanel.<PickRandomCharacter>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        int val_8;
        MVC_Bot_Base val_9;
        val_7 = this;
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
        val_8 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = val_8;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        val_7 = this.<>4__this.confirmButton.onClick;
        val_7.Invoke();
        label_3:
        val_8 = 0;
        return (bool)val_8;
        label_2:
        this.<>1__state = 0;
        val_9 = MVC_Bot_Base.P1Bot;
        if(MVC_Bot_Base.P1Bot != null)
        {
            goto label_9;
        }
        
        val_9 = MVC_Bot_Base.P1Bot;
        if(val_9 == null)
        {
            goto label_10;
        }
        
        label_9:
        this.<>4__this.OnCharacterChanged.Invoke(arg0:  Item[UnityEngine.Random.Range(min:  0, max:  Count)]);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = 2;
        val_8 = 1;
        return (bool)val_8;
        label_10:
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
