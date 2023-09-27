using UnityEngine;
private sealed class Credits.<Scroll>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Credits <>4__this;
    public float PanelHeight;
    private float <waitTime>5__2;
    private float <MusicTimeLength>5__3;
    private float <ScrollRate>5__4;
    private UnityEngine.RectTransform <RectTrans_Panel>5__5;
    private UnityEngine.RectTransform <RectTrans_InkWars>5__6;
    private float <ElapsedTime>5__7;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Credits.<Scroll>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_21;
        float val_22;
        float val_23;
        UnityEngine.UI.Image val_24;
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
        this.<waitTime>5__2 = 1f;
        val_21 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  1f);
        this.<>1__state = val_21;
        return (bool)val_21;
        label_1:
        val_22 = this.<ElapsedTime>5__7;
        val_23 = this.<MusicTimeLength>5__3;
        this.<>1__state = 0;
        goto label_5;
        label_2:
        this.<>1__state = 0;
        float val_2 = this.<>4__this.Audio_BGM.length;
        float val_21 = this.<waitTime>5__2;
        val_23 = this.<MusicTimeLength>5__3;
        val_2 = val_2 - val_21;
        val_21 = this.PanelHeight / val_2;
        this.<MusicTimeLength>5__3 = val_2;
        this.<ScrollRate>5__4 = val_21;
        this.<RectTrans_Panel>5__5 = this.<>4__this.GetComponent<UnityEngine.RectTransform>();
        val_24 = this.<>4__this.Image_InkWars;
        this.<RectTrans_InkWars>5__6 = val_24.GetComponent<UnityEngine.RectTransform>();
        this.<ElapsedTime>5__7 = 0f;
        val_22 = 0f;
        label_5:
        if(val_22 < 0)
        {
            goto label_9;
        }
        
        0.Button_ReturnToMainMenu();
        label_3:
        val_21 = 0;
        return (bool)val_21;
        label_9:
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_22 + val_5;
        this.<ElapsedTime>5__7 = val_5;
        UnityEngine.Vector2 val_8 = this.<RectTrans_Panel>5__5.anchoredPosition;
        val_8.y = ((this.<ScrollRate>5__4) * UnityEngine.Time.deltaTime) + val_8.y;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0f, y:  val_8.y);
        this.<RectTrans_Panel>5__5.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        UnityEngine.Vector2 val_10 = this.<RectTrans_InkWars>5__6.anchoredPosition;
        val_22 = val_10.y;
        UnityEngine.Rect val_11 = this.<RectTrans_InkWars>5__6.rect;
        UnityEngine.Vector2 val_12 = this.<RectTrans_Panel>5__5.anchoredPosition;
        val_24 = this.<>4__this.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_14 = val_24.rect;
        float val_22 = -2f;
        val_22 = val_11.m_XMin * val_22;
        val_22 = val_22 + val_22;
        val_14.m_XMin = val_12.y - val_14.m_XMin;
        if(val_22 < 0)
        {
                val_24 = this.<RectTrans_InkWars>5__6;
            UnityEngine.Rect val_15 = val_24.rect;
            val_22 = val_15.m_XMin;
            UnityEngine.Vector2 val_16 = this.<RectTrans_Panel>5__5.anchoredPosition;
            UnityEngine.Rect val_18 = this.<>4__this.GetComponent<UnityEngine.RectTransform>().rect;
            float val_19 = val_22 + val_22;
            val_19 = val_19 + val_16.y;
            val_19 = val_19 - val_18.m_XMin;
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  0f, y:  val_19);
            val_24.anchoredPosition = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
        }
        
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_21 = 1;
        return (bool)val_21;
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
