using UnityEngine;
private sealed class View_PostMatch.<LoseSequence>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public View_PostMatch <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public View_PostMatch.<LoseSequence>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        this.<>1__state = 0;
        View_Core val_1 = View_Core.Instance;
        if(View_Core.Instance == null)
        {
            goto label_6;
        }
        
        if(val_1.LeftPlayer.m_PlayerModel.ID == 0)
        {
            goto label_7;
        }
        
        label_16:
        if(val_2.RightPlayer != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        this.<>4__this.LosePose.sprite = val_2.RightPlayer.PlayerAnimator.transform.Find(n:  "Animator_Body").GetComponent<UnityEngine.SpriteRenderer>().sprite;
        this = this.<>4__this.LosePanel.gameObject;
        this.SetActive(value:  true);
        return false;
        label_6:
        if(val_1.LeftPlayer.m_PlayerModel.ID != 0)
        {
            goto label_16;
        }
        
        label_7:
        if(val_2.LeftPlayer != null)
        {
            goto label_17;
        }
        
        goto label_18;
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
