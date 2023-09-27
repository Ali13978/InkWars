using UnityEngine;
private sealed class SwipeSceneSelect.<CharacterStatus>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SwipeSceneSelect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SwipeSceneSelect.<CharacterStatus>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_10;
        int val_11;
        val_10 = this;
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
        val_11 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        var val_12 = 4;
        do
        {
            SelectStageController val_3 = UnityEngine.GameObject.FindWithTag(tag:  "ikaLeftRight").GetComponent<SelectStageController>();
            var val_4 = val_12 - 4;
            UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            val_3.testimages[0].GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            val_12 = val_12 + 1;
        }
        while(val_12 != 16);
        
        this.<>4__this.ikaSelection.GetComponent<SelectStageController>().DarkenAtStart();
        val_10 = this.<>4__this.iconsHolder;
        val_10.SetActive(value:  true);
        val_11 = 0;
        SwipeSceneSelect.touchBoolIka = true;
        return (bool)val_11;
        label_2:
        this.<>1__state = 0;
        UnityEngine.GameObject.FindWithTag(tag:  "ikaLeftRight").GetComponent<SelectStageController>().leftSwipe();
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        this.<>1__state = 2;
        val_11 = 1;
        return (bool)val_11;
        label_3:
        val_11 = 0;
        return (bool)val_11;
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
