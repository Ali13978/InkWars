using UnityEngine;
private sealed class NetworkUI_CasualMenu.<AnimateFindingMatchText>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NetworkUI_CasualMenu <>4__this;
    public TMPro.TextMeshProUGUI _text;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkUI_CasualMenu.<AnimateFindingMatchText>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TMPro.TextMeshProUGUI val_8;
        int val_9;
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
            goto label_12;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_11;
        }
        
        goto label_5;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == null)
        {
            goto label_6;
        }
        
        if((this.<>4__this.m_FindingMatchText) != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        string val_3 = this.<>4__this.m_FindingMatchText.Substring(startIndex:  0, length:  (this.<>4__this.m_FindingMatchText.Length) - 3);
        if((this.<>4__this) == null)
        {
            goto label_9;
        }
        
        mem2[0] = val_3;
        val_8 = this._text;
        if(val_8 != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        val_8.text = val_3;
        if((this.<>4__this) != null)
        {
            goto label_11;
        }
        
        label_5:
        label_11:
        if((this.<>4__this.m_IsSearchingForOpponent) == false)
        {
            goto label_12;
        }
        
        this.<i>5__2 = 0;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.m_TypewriterDelay);
        goto label_19;
        label_12:
        val_9 = 0;
        return (bool)val_9;
        label_2:
        this.<>1__state = 0;
        string val_5 = this.<>4__this.m_FindingMatchText(this.<>4__this.m_FindingMatchText) + ".";
        if((this.<>4__this) == null)
        {
            goto label_16;
        }
        
        this.<>4__this.m_FindingMatchText = val_5;
        if(this._text != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        this._text.text = val_5;
        val_8 = (this.<i>5__2) + 1;
        this.<i>5__2 = val_8;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.m_TypewriterDelay);
        if(val_8 >= 3)
        {
                this.<>1__state = 2;
            val_9 = 1;
            return (bool)val_9;
        }
        
        label_19:
        val_9 = 1;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_6:
        if(1 != 0)
        {
            goto label_21;
        }
        
        goto label_22;
        label_9:
        mem2[0] = val_3;
        if(this._text != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_16:
        this.<>4__this.m_FindingMatchText = val_5;
        if(this._text != null)
        {
            goto label_25;
        }
        
        goto label_26;
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
