using UnityEngine;
private sealed class LoadingPanel_Type.<Init>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LoadingPanel_Type <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingPanel_Type.<Init>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        LoadingPanel_Type val_17;
        System.Collections.Generic.List<UnityEngine.UI.Image> val_18;
        var val_19;
        int val_21;
        var val_22;
        LoadingPanelPoseLoader val_24;
        val_17 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_18 = this.<>4__this.characterImageList;
        val_19 = null;
        val_19 = null;
        if((LoadingPanel_Type.<>c.<>9__19_0) == null)
        {
            goto label_6;
        }
        
        label_25:
        int val_1 = val_18.RemoveAll(match:  LoadingPanel_Type.<>c.<>9__19_0);
        this.<>4__this.currentData = val_17.GetNextData();
        UnityEngine.WaitForEndOfFrame val_3 = null;
        val_17 = val_3;
        val_3 = new UnityEngine.WaitForEndOfFrame();
        val_21 = 1;
        this.<>2__current = val_17;
        this.<>1__state = val_21;
        return (bool)val_21;
        label_1:
        this.<>1__state = 0;
        val_22 = null;
        val_22 = null;
        if((LoadingPanel_Type.<>c.<>9__19_1) == null)
        {
            goto label_12;
        }
        
        label_29:
        int val_4 = this.<>4__this.characterImageList.RemoveAll(match:  LoadingPanel_Type.<>c.<>9__19_1);
        List.Enumerator<T> val_5 = this.<>4__this.characterImageList.GetEnumerator();
        label_20:
        if(((-1409124784) & 1) == 0)
        {
            goto label_15;
        }
        
        UnityEngine.RectTransform val_9 = val_7.InitialType.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_10 = val_9.rect;
        UnityEngine.Vector2 val_11 = val_9.sizeDelta;
        val_9.sizeDelta = new UnityEngine.Vector2() {x = val_10.m_XMin, y = val_11.y};
        goto label_20;
        label_2:
        val_21 = 0;
        return (bool)val_21;
        label_6:
        LoadingPanel_Type.<>c.<>9__19_0 = new System.Predicate<UnityEngine.UI.Image>(object:  LoadingPanel_Type.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LoadingPanel_Type.<>c::<Init>b__19_0(UnityEngine.UI.Image x));
        if(val_18 != null)
        {
            goto label_25;
        }
        
        goto label_25;
        label_12:
        LoadingPanel_Type.<>c.<>9__19_1 = new System.Predicate<UnityEngine.UI.Image>(object:  LoadingPanel_Type.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean LoadingPanel_Type.<>c::<Init>b__19_1(UnityEngine.UI.Image x));
        if((this.<>4__this.characterImageList) != null)
        {
            goto label_29;
        }
        
        goto label_29;
        label_15:
        val_7.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
        if(val_17 != null)
        {
            goto label_30;
        }
        
        goto label_39;
        label_30:
        val_24 = this.<>4__this.poseLoader;
        goto label_40;
        label_39:
        val_24 = 0;
        label_40:
        val_18 = this.<>4__this.currentData.typeList;
        UnityEngine.Coroutine val_15 = val_24.StartCoroutine(routine:  val_24.LoadImages(typeList:  val_18, target:  val_17));
        val_21 = 0;
        this.<>4__this.init = true;
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
