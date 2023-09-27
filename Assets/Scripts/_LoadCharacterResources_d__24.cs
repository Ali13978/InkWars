using UnityEngine;
private sealed class BattleVSGates.<LoadCharacterResources>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BattleVSGates <>4__this;
    public CharacterNameID nameID;
    public CharacterNameController nameController;
    public UnityEngine.UI.Image backGround;
    public UnityEngine.UI.Image clanSymbol;
    public UnityEngine.UI.Image statsImage;
    public bool leftSide;
    public UnityEngine.UI.Image poseImage;
    public UnityEngine.Vector3 originScale;
    private CharacterAssetLoader <assetLoader>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BattleVSGates.<LoadCharacterResources>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterAssetLoader val_27;
        UnityEngine.Sprite val_28;
        UnityEngine.UI.Image val_29;
        UnityEngine.Sprite val_30;
        var val_31;
        UnityEngine.Sprite val_32;
        UnityEngine.Sprite val_33;
        CharacterAssetLoader val_34;
        int val_35;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_57;
        }
        
        this.<>1__state = 0;
        CharacterAssetLoader val_2 = this.<>4__this.gameObject.AddComponent<CharacterAssetLoader>();
        val_27 = this;
        this.<assetLoader>5__2 = val_2;
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  val_2.RetrieveBundle(inputCharID:  this.nameID, callback:  0));
        this.nameController.characterId = this.nameID;
        CharacterClan val_5 = CharNameIDConverter.GetClan(nameID:  this.nameID);
        if(val_5 == 2)
        {
            goto label_8;
        }
        
        if(val_5 == 1)
        {
            goto label_9;
        }
        
        if(val_5 != 0)
        {
            goto label_10;
        }
        
        val_28 = UnityEngine.Resources.Load(path:  "PvPVs/BG_Ika", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_28 != null) && (null != null))
        {
                val_28 = 0;
        }
        
        this.backGround.sprite = val_28;
        val_29 = this.clanSymbol;
        val_30 = UnityEngine.Resources.Load(path:  "PvPVs/BG_Ika_Icon", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_30 == null) || (null == null))
        {
            goto label_37;
        }
        
        val_31 = 0;
        goto label_29;
        label_1:
        val_27 = this.<assetLoader>5__2;
        this.<>1__state = 0;
        goto label_20;
        label_9:
        val_32 = UnityEngine.Resources.Load(path:  "PvPVs/BG_Tako", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_32 != null) && (null != null))
        {
                val_32 = 0;
        }
        
        this.backGround.sprite = val_32;
        val_29 = this.clanSymbol;
        val_30 = UnityEngine.Resources.Load(path:  "PvPVs/BG_Tako_Icon", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_30 == null) || (null == null))
        {
            goto label_37;
        }
        
        val_31 = 0;
        goto label_29;
        label_8:
        val_33 = UnityEngine.Resources.Load(path:  "PvPVs/BG_Mermaid", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_33 != null) && (null != null))
        {
                val_33 = 0;
        }
        
        this.backGround.sprite = val_33;
        val_29 = this.clanSymbol;
        val_30 = UnityEngine.Resources.Load(path:  "PvPVs/BG_Mermaid_Icon", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_30 == null) || (null == null))
        {
            goto label_37;
        }
        
        val_31 = 0;
        label_29:
        val_30 = 0;
        label_37:
        val_29.sprite = val_30;
        label_10:
        this.statsImage.sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  this.nameID, left:  this.leftSide);
        this.nameController.characterId = this.nameID;
        label_20:
        val_34 = this.<assetLoader>5__2;
        if(val_2.ready == false)
        {
            goto label_41;
        }
        
        this.poseImage.sprite = this.<assetLoader>5__2.LoadPose_VS();
        val_34 = this.<assetLoader>5__2.LoadCharacterData();
        if(0 != val_34)
        {
                val_34 = this.poseImage.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Mathf.Max(a:  1f, b:  val_21.scale), a:  new UnityEngine.Vector3() {x = this.originScale, y = V10.16B, z = V9.16B});
            val_34.localScale = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
        }
        
        var val_26 = (this.leftSide == true) ? this.<>4__this.left : this.<>4__this.right;
        mem2[0] = 1;
        if((val_26 != 0) && (val_26 != 0))
        {
                val_35 = 0;
            this.<>4__this.BattleGatesLoaded = true;
            return (bool)val_35;
        }
        
        label_57:
        val_35 = 0;
        return (bool)val_35;
        label_41:
        val_35 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_35;
        return (bool)val_35;
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
