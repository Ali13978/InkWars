using UnityEngine;
public class BPIndicater : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI BP_count;
    private CharacterAvatarController avatarController;
    
    // Methods
    private void OnEnable()
    {
        CharacterNameID val_4;
        null = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = DataStructs.UserDataDictionary.Stats.CurrentCharacterBP;
        this.BP_count.text = val_1.currentCryptoKey.ToString();
        CharacterInfo val_3 = Character_GlobalInfo.GetLeftPlayer();
        this.avatarController.Init(cid:  val_4, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  false);
    }
    public BPIndicater()
    {
    
    }

}
