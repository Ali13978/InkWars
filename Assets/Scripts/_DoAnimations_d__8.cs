using UnityEngine;
private sealed class LobbyHint.<DoAnimations>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LobbyHint <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyHint.<DoAnimations>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_15;
        int val_16;
        var val_17;
        int val_19;
        var val_20;
        int val_21;
        val_15 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_16 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  (float)this.<>4__this.m_waitingTime);
        this.<>1__state = val_16;
        return (bool)val_16;
        label_1:
        this.<>1__state = 0;
        val_15 = UnityEngine.Mathf.CeilToInt(f:  (float)UnityEngine.Random.Range(min:  0, max:  100));
        val_17 = null;
        val_17 = null;
        if((LobbyHint.<>c.<>9__8_0) == null)
        {
            goto label_10;
        }
        
        label_29:
        this.<>4__this.m_hints.ForEach(action:  LobbyHint.<>c.<>9__8_0);
        val_19 = this.<>4__this.m_precentage;
        if(val_15 > val_19)
        {
                val_20 = 0;
        }
        else
        {
                this.<>4__this.speachBubble.gameObject.SetActive(value:  true);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.speachBubble.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = this.<>4__this.actualSize}, duration:  0.2f);
            val_19 = 1152921528539958320;
            val_21 = UnityEngine.Mathf.CeilToInt(f:  (float)UnityEngine.Random.Range(min:  0, max:  this.<>4__this.m_hints.Count));
            if(val_21 >= (this.<>4__this.m_hints.Count))
        {
                val_21 = (this.<>4__this.m_hints.Count) - 1;
        }
        
            val_15 = this.<>4__this.m_hints.Item[val_21].gameObject;
            val_20 = 1;
        }
        
        val_15.SetActive(value:  true);
        label_2:
        val_16 = 0;
        return (bool)val_16;
        label_10:
        LobbyHint.<>c.<>9__8_0 = new System.Action<UnityEngine.GameObject>(object:  LobbyHint.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LobbyHint.<>c::<DoAnimations>b__8_0(UnityEngine.GameObject x));
        if((this.<>4__this.m_hints) != null)
        {
            goto label_29;
        }
        
        goto label_29;
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
