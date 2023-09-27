using UnityEngine;
private sealed class VSSHARE.<>c__DisplayClass95_0
{
    // Fields
    public System.Action OnUpdate;
    public UnityEngine.UI.Image im;
    public float _to;
    public System.Action OnCompleted;
    
    // Methods
    public VSSHARE.<>c__DisplayClass95_0()
    {
    
    }
    internal void <DOFade>b__0()
    {
        if(this.OnUpdate == null)
        {
                return;
        }
        
        this.OnUpdate.Invoke();
    }
    internal void <DOFade>b__1()
    {
        UnityEngine.Color val_1 = this.im.color;
        this.im.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = this._to};
        if(this._to == 0f)
        {
                this.im.gameObject.SetActive(value:  false);
        }
        
        if(this.OnCompleted == null)
        {
                return;
        }
        
        this.OnCompleted.Invoke();
    }

}
