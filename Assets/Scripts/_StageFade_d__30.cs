using UnityEngine;
private sealed class SelectStageController.<StageFade>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SelectStageController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SelectStageController.<StageFade>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SelectStageController val_40;
        int val_41;
        UnityEngine.GameObject[] val_42;
        float val_43;
        float val_44;
        int val_45;
        var val_46;
        UnityEngine.GameObject[] val_47;
        val_40 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.ConfirmMapButton.interactable = false;
        this.<>4__this.StageNameText.SetActive(value:  false);
        UnityEngine.Coroutine val_2 = val_40.StartCoroutine(routine:  val_40.UnlockButton());
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.testimages[this.<>4__this.leftCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
        val_41 = this.<>4__this.middleCounter;
        UnityEngine.Color val_8 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.<>4__this.testimages[val_41].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
        val_42 = this.<>4__this.testimages;
        UnityEngine.Color val_11 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_43 = val_11.r;
        val_44 = val_11.b;
        val_42[this.<>4__this.rightCounter].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_43, g = val_11.g, b = val_44, a = val_11.a};
        UnityEngine.WaitForSeconds val_12 = null;
        val_40 = val_12;
        val_12 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        val_45 = 1;
        this.<>2__current = val_40;
        this.<>1__state = val_45;
        return (bool)val_45;
        label_1:
        this.<>1__state = 0;
        if(val_40 != null)
        {
                val_46 = val_40;
            val_47 = this.<>4__this.testimages;
        }
        else
        {
                val_46 = 32;
            val_47 = 64;
        }
        
        var val_13 = val_47 + ((this.<>4__this.leftCounter) << 3);
        var val_15 = val_46 + ((this.<>4__this.leftCounter) << 3);
        UnityEngine.Color val_18 = (val_46 + (this.<>4__this.leftCounter) << 3) + 32.gameObject.GetComponent<UnityEngine.UI.Image>().color;
        UnityEngine.Color val_19 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Coroutine val_21 = val_40.StartCoroutine(routine:  0.Fade(mat:  (val_47 + (this.<>4__this.leftCounter) << 3) + 32.GetComponent<UnityEngine.UI.Image>(), duration:  0.25f, startColor:  new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a}, endColor:  new UnityEngine.Color() {r = val_19.r, g = val_19.b, b = 0f, a = 0f}));
        var val_22 = 64 + ((this.<>4__this.rightCounter) << 3);
        var val_24 = 64 + ((this.<>4__this.rightCounter) << 3);
        UnityEngine.Color val_27 = (64 + (this.<>4__this.rightCounter) << 3) + 32.gameObject.GetComponent<UnityEngine.UI.Image>().color;
        UnityEngine.Color val_28 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Coroutine val_30 = val_40.StartCoroutine(routine:  0.Fade(mat:  (64 + (this.<>4__this.rightCounter) << 3) + 32.GetComponent<UnityEngine.UI.Image>(), duration:  0.25f, startColor:  new UnityEngine.Color() {r = val_27.r, g = val_27.g, b = val_27.b, a = val_27.a}, endColor:  new UnityEngine.Color() {r = val_28.r, g = val_28.b, b = 0f, a = 0f}));
        var val_31 = 64 + ((this.<>4__this.middleCounter) << 3);
        val_41 = this.<>4__this.middleCounter;
        var val_33 = 64 + ((this.<>4__this.middleCounter) << 3);
        val_42 = (64 + (this.<>4__this.middleCounter) << 3) + 32.gameObject.GetComponent<UnityEngine.UI.Image>();
        UnityEngine.Color val_36 = val_42.color;
        val_43 = val_36.r;
        val_44 = val_36.b;
        UnityEngine.Color val_37 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Coroutine val_39 = val_40.StartCoroutine(routine:  0.Fade(mat:  (64 + (this.<>4__this.middleCounter) << 3) + 32.GetComponent<UnityEngine.UI.Image>(), duration:  0.01f, startColor:  new UnityEngine.Color() {r = val_43, g = val_36.g, b = val_44, a = val_36.a}, endColor:  new UnityEngine.Color() {r = val_37.r, g = val_37.b, b = 0f, a = 0f}));
        label_2:
        val_45 = 0;
        return (bool)val_45;
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
