using UnityEngine;
private sealed class InteractiveTutorialManager.<ReloadPlayer>d__90 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.UI.Image activeIcon;
    public TutorialDataManager.PlayerData PlayerData;
    private float <startTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InteractiveTutorialManager.<ReloadPlayer>d__90(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        PlayerData val_9;
        float val_10;
        float val_11;
        int val_12;
        val_8 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.activeIcon.GetComponent<UnityEngine.UI.Outline>().enabled = false;
        val_9 = val_8;
        val_10 = 1152921526145414456;
        mem[1152921526145414464] = 0;
        this.PlayerData.isReloading = true;
        goto label_6;
        label_1:
        val_10 = this.<startTime>5__2;
        val_9 = this.PlayerData;
        this.<>1__state = 0;
        label_6:
        val_11 = 1f;
        UnityEngine.UI.Image val_3 = this.activeIcon.GetComponent<UnityEngine.UI.Image>();
        if(val_10 <= ((mem[this.PlayerData] + 20) + val_11))
        {
            goto label_9;
        }
        
        val_3.fillAmount = 1f;
        mem2[0] = 0;
        val_8 = this.activeIcon.GetComponent<UnityEngine.UI.Outline>();
        val_8.enabled = true;
        label_2:
        val_12 = 0;
        return (bool)val_12;
        label_9:
        float val_5 = (mem[this.PlayerData] + 20) + val_11;
        val_5 = val_10 / val_5;
        val_3.fillAmount = val_5;
        if((mem[this.PlayerData] + 53) == 0)
        {
                val_11 = mem[this.<startTime>5__2];
            val_11 = val_10;
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = val_11 + val_6;
            mem2[0] = val_6;
        }
        
        val_12 = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
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
