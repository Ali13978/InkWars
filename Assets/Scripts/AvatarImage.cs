using UnityEngine;
public class AvatarImage : MonoBehaviour
{
    // Fields
    private CustomTitle title;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnEnable()
    {
        var val_9;
        var val_10;
        val_9 = null;
        val_9 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Settings.SelectedAvatar;
        this.GetComponent<UnityEngine.UI.Image>().sprite = AvatarCollection.GetAvatarSpriteFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}));
        if(0 == this.title)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
        this.title.Setup(title:  TitleCollection.GetTitleFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited})));
    }
    public AvatarImage()
    {
    
    }

}
