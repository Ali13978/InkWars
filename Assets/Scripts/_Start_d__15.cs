using UnityEngine;
private sealed class MVC_Multiplayer_Manager.<Start>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InkWars.Model.MVC_Multiplayer_Manager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVC_Multiplayer_Manager.<Start>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        var val_8;
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
            goto label_18;
        }
        
        this.<>1__state = 0;
        this.<>2__current = 0.Start();
        val_7 = 1;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        0.StartAutoPlayGame(SecondAttempt:  true);
        InkWars.Model.MVC_Multiplayer_Manager_Base.ForceAutoStart = false;
        goto label_18;
        label_2:
        this.<>1__state = 0;
        if(MVC_Bot_Base.NetworkControlMode != 0)
        {
                UnityEngine.GameObject.Find(name:  "Ranked_Menu").GetComponent<UnityEngine.UI.Button>().onClick.Invoke();
            InkWars.Model.MVC_Multiplayer_Manager_Base.ForceAutoStart = true;
        }
        
        val_8 = null;
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.ForceAutoStart != false)
        {
                this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
            this.<>1__state = 2;
            val_7 = 1;
            return (bool)val_7;
        }
        
        label_18:
        val_7 = 0;
        return (bool)val_7;
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
