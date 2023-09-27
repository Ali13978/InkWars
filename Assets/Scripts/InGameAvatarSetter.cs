using UnityEngine;
public class InGameAvatarSetter : MonoBehaviour
{
    // Fields
    private static InGameAvatarSetter <instance>k__BackingField;
    public CharacterAvatarController VS_char_Image_CPU;
    public CharacterAvatarController VS_char_Image_Player;
    public UnityEngine.UI.Image playerChar_TypeIcon;
    public UnityEngine.UI.Image opponentChar_TypeIcon;
    private UnityEngine.Sprite inkedOpponentAvatar;
    
    // Properties
    public static InGameAvatarSetter instance { get; set; }
    
    // Methods
    public static InGameAvatarSetter get_instance()
    {
        return (InGameAvatarSetter)InGameAvatarSetter.<instance>k__BackingField;
    }
    private static void set_instance(InGameAvatarSetter value)
    {
        InGameAvatarSetter.<instance>k__BackingField = value;
    }
    private void Awake()
    {
        InGameAvatarSetter.<instance>k__BackingField = this;
        this.SetupAvatar();
    }
    private void OnDestroy()
    {
        UnityEngine.Object val_2 = this;
        if((InGameAvatarSetter.<instance>k__BackingField) != this)
        {
                return;
        }
        
        InGameAvatarSetter.<instance>k__BackingField = 0;
    }
    public void SetOpponentAsInked()
    {
        this.VS_char_Image_CPU.SetAvatar(sp:  this.inkedOpponentAvatar);
    }
    private System.Collections.IEnumerator LoadFromBundle(CharacterAvatarController avatar, CharacterNameID charNameID, bool inked)
    {
        InGameAvatarSetter.<LoadFromBundle>d__12 val_1 = new InGameAvatarSetter.<LoadFromBundle>d__12();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
            .avatar = avatar;
            .charNameID = charNameID;
        }
        else
        {
                mem[32] = this;
            mem[48] = avatar;
            mem[40] = charNameID;
        }
        
        .inked = inked;
        return (System.Collections.IEnumerator)val_1;
    }
    private void SetupAvatar()
    {
        CharacterNameID val_10;
        CharacterNameID val_14;
        CharacterNameID val_18;
        CharacterNameID val_30;
        UnityEngine.UI.Image val_33;
        var val_34;
        UnityEngine.Sprite val_35;
        CharacterNameID val_36;
        var val_37;
        val_33 = this;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_1.m_Handle.name, b:  "PlayScene")) == false)
        {
            goto label_3;
        }
        
        val_34 = null;
        val_34 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressForCurrentCharacter().GetCurrentLevelData().InkPercentage;
        CharacterInfo val_9 = Character_GlobalInfo.GetOpponentPlayer();
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this.LoadFromBundle(avatar:  this.VS_char_Image_CPU, charNameID:  val_10, inked:  ((CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_6.currentCryptoKey, hiddenValue = val_6.hiddenValue, fakeValue = val_6.fakeValue, inited = val_6.inited})) > 99) ? 1 : 0));
        CharacterInfo val_13 = Character_GlobalInfo.GetMainPlayer();
        UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  this.LoadFromBundle(avatar:  this.VS_char_Image_Player, charNameID:  val_14, inked:  false));
        CharacterInfo val_17 = Character_GlobalInfo.GetMainPlayer();
        val_35 = CharacterAssetLoader.LoadResource_CharacterStatTypeIcon(charNameID:  val_18);
        this.playerChar_TypeIcon.sprite = val_35;
        if((Character_GlobalInfo.gameMode == 1) || (Character_GlobalInfo.gameMode == 3))
        {
            goto label_15;
        }
        
        if(Character_GlobalInfo.gameMode != 4)
        {
                return;
        }
        
        val_33 = this.opponentChar_TypeIcon;
        CharacterInfo val_20 = Character_GlobalInfo.GetOpponentPlayer();
        val_36 = val_10;
        goto label_19;
        label_3:
        val_37 = null;
        val_37 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
                return;
        }
        
        CharacterInfo val_21 = Character_GlobalInfo.GetLeftPlayer();
        UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  this.LoadFromBundle(avatar:  this.VS_char_Image_Player, charNameID:  val_10, inked:  false));
        CharacterInfo val_24 = Character_GlobalInfo.GetRightPlayer();
        UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  this.LoadFromBundle(avatar:  this.VS_char_Image_CPU, charNameID:  val_14, inked:  false));
        CharacterInfo val_27 = Character_GlobalInfo.GetLeftPlayer();
        val_35 = CharacterAssetLoader.LoadResource_CharacterStatTypeIcon(charNameID:  val_18);
        this.playerChar_TypeIcon.sprite = val_35;
        val_33 = this.opponentChar_TypeIcon;
        CharacterInfo val_29 = Character_GlobalInfo.GetRightPlayer();
        val_36 = val_30;
        label_19:
        val_33.sprite = CharacterAssetLoader.LoadResource_CharacterStatTypeIcon(charNameID:  val_36);
        return;
        label_15:
        val_33 = this.opponentChar_TypeIcon.gameObject;
        val_33.SetActive(value:  false);
    }
    public InGameAvatarSetter()
    {
    
    }

}
