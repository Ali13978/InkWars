using UnityEngine;
private sealed class MVC_GameScene_Activator.<LoadCharacterResources>d__46 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MVC_GameScene_Activator <>4__this;
    public CharacterNameID nameID;
    public View_BattleGates_Side battleGate;
    public bool leftSide;
    private CharacterAssetLoader <assetLoader>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MVC_GameScene_Activator.<LoadCharacterResources>d__46(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharacterAssetLoader val_9;
        UnityEngine.Sprite val_11;
        CharacterAssetLoader val_12;
        var val_13;
        GameMode val_14;
        int val_15;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_36;
        }
        
        this.<>1__state = 0;
        CharacterAssetLoader val_2 = this.<>4__this.gameObject.AddComponent<CharacterAssetLoader>();
        val_9 = this;
        this.<assetLoader>5__2 = val_2;
        System.Collections.IEnumerator val_3 = val_2.RetrieveBundle(inputCharID:  this.nameID, callback:  0);
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  val_3);
        CharacterClan val_5 = CharNameIDConverter.GetClan(nameID:  this.nameID);
        if(val_5 == 2)
        {
            goto label_7;
        }
        
        if(val_5 == 1)
        {
            goto label_8;
        }
        
        if(val_5 != 0)
        {
            goto label_9;
        }
        
        val_3.sprite = this.<>4__this.background_Ika;
        val_11 = this.<>4__this.clanSymbol_Ika;
        if(val_3 != null)
        {
            goto label_41;
        }
        
        goto label_42;
        label_1:
        val_9 = this.<assetLoader>5__2;
        this.<>1__state = 0;
        goto label_18;
        label_7:
        val_3.sprite = this.<>4__this.background_Special;
        val_11 = this.<>4__this.clanSymbol_Special;
        if(val_3 != null)
        {
            goto label_41;
        }
        
        label_42:
        label_41:
        val_3.sprite = val_11;
        label_9:
        if(this.nameID == 42)
        {
                val_3.sprite = this.<>4__this.background_IronShark;
            val_3.sprite = this.<>4__this.clanSymbol_IronShark;
        }
        
        label_18:
        val_12 = this.<assetLoader>5__2;
        if(val_2.ready == false)
        {
            goto label_23;
        }
        
        val_12.sprite = this.<assetLoader>5__2.LoadPose_VS();
        val_12.characterId = this.nameID;
        val_12 = 1152921505064992768;
        val_13 = null;
        val_13 = null;
        val_14 = Character_GlobalInfo.gameMode;
        if(val_14 != 6)
        {
                val_14 = Character_GlobalInfo.gameMode;
            if(val_14 != 10)
        {
                sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  this.nameID, left:  this.leftSide);
        }
        
        }
        
        var val_8 = (this.leftSide == true) ? this.<>4__this.left : this.<>4__this.right;
        mem2[0] = 1;
        if((val_8 != 0) && (val_8 != 0))
        {
                val_15 = 0;
            this.<>4__this.BattleGatesLoaded = true;
            return (bool)val_15;
        }
        
        label_36:
        val_15 = 0;
        return (bool)val_15;
        label_23:
        val_15 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_15;
        return (bool)val_15;
        label_8:
        val_3.sprite = this.<>4__this.background_Tako;
        if(val_3 != null)
        {
            goto label_41;
        }
        
        goto label_42;
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
