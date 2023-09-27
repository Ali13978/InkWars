using UnityEngine;
private sealed class PlayerCharacterUIController.<LoadPlayerAvatar>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public CharacterAssetLoader _cl;
    public CharacterNameID _ID;
    public PlayerCharacterUIController <>4__this;
    public bool forceLoadInked;
    public UnityEngine.UI.Image _image;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerCharacterUIController.<LoadPlayerAvatar>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.UI.Image val_13;
        CharacterAssetLoader val_14;
        CharacterNameID val_15;
        CharacterAssetLoader val_16;
        var val_17;
        GameMode val_18;
        var val_19;
        UnityEngine.Sprite val_21;
        int val_22;
        val_13 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        val_14 = val_13;
        this.<>1__state = 0;
        this._cl.charID = this._ID;
        if(this._cl == null)
        {
            goto label_4;
        }
        
        val_15 = this._cl.charID;
        goto label_5;
        label_1:
        val_14 = this._cl;
        this.<>1__state = 0;
        goto label_6;
        label_4:
        val_15 = 0;
        label_5:
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(routine:  this._cl.RetrieveBundle(inputCharID:  val_15, callback:  0));
        label_6:
        val_16 = this._cl;
        if(this._cl.ready == false)
        {
            goto label_9;
        }
        
        InkWars.Model.Model_Player val_3 = this.<>4__this.PlayerModel;
        if(val_3.ID != 1)
        {
            goto label_18;
        }
        
        val_17 = null;
        val_17 = null;
        val_18 = Character_GlobalInfo.gameMode;
        if(val_18 == 1)
        {
            goto label_15;
        }
        
        val_18 = Character_GlobalInfo.gameMode;
        if(val_18 != 2)
        {
            goto label_18;
        }
        
        label_15:
        val_19 = null;
        val_19 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage;
        val_16 = (((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited})) > 99) ? 1 : 0) | ((this.forceLoadInked == true) ? 1 : 0);
        if(this._cl == null)
        {
            goto label_26;
        }
        
        if(val_16 == 0)
        {
            goto label_27;
        }
        
        label_33:
        UnityEngine.Sprite val_10 = this._cl.LoadAvatar_MainInked();
        goto label_28;
        label_18:
        val_13 = this._image;
        val_21 = this._cl.LoadAvatar_Main();
        goto label_31;
        label_9:
        val_22 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_22;
        return (bool)val_22;
        label_26:
        if(val_16 != 0)
        {
            goto label_33;
        }
        
        label_27:
        label_28:
        val_13 = this._cl.LoadAvatar_Main();
        val_21 = val_13;
        label_31:
        this._image.sprite = val_21;
        label_2:
        val_22 = 0;
        return (bool)val_22;
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
