using UnityEngine;
private sealed class LoadingPanelPoseLoader.<LoadImages>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.List<CharacterStatType> typeList;
    public LoadingPanel_Type target;
    public LoadingPanelPoseLoader <>4__this;
    private System.Collections.Generic.List<CharacterData> <characterList>5__2;
    private int <count>5__3;
    private System.Collections.Generic.List<UnityEngine.Sprite> <imageList>5__4;
    private int <i>5__5;
    private CharacterAssetLoader <assetLoader>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingPanelPoseLoader.<LoadImages>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterStatType val_7;
        object val_27;
        int val_28;
        CharacterAssetLoader val_29;
        var val_30;
        System.Collections.Generic.List<UnityEngine.UI.Image> val_31;
        var val_32;
        int val_33;
        int val_34;
        CharacterAssetLoader val_35;
        val_27 = this;
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
        val_28 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.<>1__state = val_28;
        return (bool)val_28;
        label_1:
        val_29 = this.<assetLoader>5__6;
        this.<>1__state = 0;
        goto label_5;
        label_2:
        this.<>1__state = 0;
        UnityEngine.Debug.Log(message:  "==== Preload "("==== Preload ") + this.typeList.Item[0]);
        System.Collections.Generic.List<CharacterData> val_4 = new System.Collections.Generic.List<CharacterData>();
        this.<characterList>5__2 = val_4;
        List.Enumerator<T> val_5 = this.typeList.GetEnumerator();
        label_17:
        if(((-1407425264) & 1) == 0)
        {
            goto label_10;
        }
        
        new LoadingPanelPoseLoader.<>c__DisplayClass2_0() = new System.Object();
        .type = val_7.GetHashCode();
        System.Predicate<CharacterData> val_10 = new System.Predicate<CharacterData>(object:  new LoadingPanelPoseLoader.<>c__DisplayClass2_0(), method:  System.Boolean LoadingPanelPoseLoader.<>c__DisplayClass2_0::<LoadImages>b__0(CharacterData x));
        System.Collections.Generic.List<CharacterData> val_11 = CharacterDataManager.FindAll(match:  null);
        if((val_11 == null) || (val_11.Count == 0))
        {
            goto label_17;
        }
        
        this.<characterList>5__2.AddRange(collection:  val_11.ToArray());
        goto label_17;
        label_10:
        val_7.Add(driver:  public System.Void List.Enumerator<CharacterStatType>::Dispose(), rectTransform:  0, drivenProperties:  null);
        val_30 = 1152921528176510128;
        if((this.<characterList>5__2.Count) > this.target.characterImageList.Count)
        {
                val_31 = this.target.characterImageList;
            val_32 = public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::get_Count();
        }
        else
        {
                val_31 = this.<characterList>5__2;
            val_32 = public System.Int32 System.Collections.Generic.List<CharacterData>::get_Count();
        }
        
        val_33 = val_27;
        this.<count>5__3 = val_31.Count;
        val_34 = 0;
        mem[1152921528969237688] = new System.Collections.Generic.List<UnityEngine.Sprite>();
        mem[1152921528969237696] = 0;
        goto label_36;
        label_49:
        CharacterAssetLoader val_19 = this.<>4__this.gameObject.AddComponent<CharacterAssetLoader>();
        val_29 = val_27;
        this.<assetLoader>5__6 = val_19;
        val_30 = mem[1152921528969237696];
        CharacterData val_20 = val_4.Item[0];
        UnityEngine.Coroutine val_22 = this.<>4__this.StartCoroutine(routine:  val_19.RetrieveBundle(inputCharID:  val_20.characterId, callback:  0));
        label_5:
        val_35 = this.<assetLoader>5__6;
        if(val_19.ready == false)
        {
            goto label_44;
        }
        
        this.<imageList>5__4.Add(item:  this.<assetLoader>5__6.LoadPose_Dynamic());
        UnityEngine.Object.Destroy(obj:  this.<assetLoader>5__6);
        val_33 = this.<count>5__3;
        this.<assetLoader>5__6 = 0;
        val_34 = (this.<i>5__5) + 1;
        this.<i>5__5 = val_34;
        label_36:
        if(val_34 < val_33)
        {
            goto label_49;
        }
        
        val_35 = this.target.currentData;
        this.target.currentData.characterImageList = this.<imageList>5__4;
        val_7 = this.typeList.Item[0];
        val_27 = "==== Preload Done "("==== Preload Done ") + val_7;
        UnityEngine.Debug.Log(message:  val_27);
        label_3:
        val_28 = 0;
        return (bool)val_28;
        label_44:
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_28 = 1;
        return (bool)val_28;
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
