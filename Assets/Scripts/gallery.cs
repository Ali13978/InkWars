using UnityEngine;
public class gallery : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image defaultCharchterImage;
    public UnityEngine.UI.Image defaultstatImage;
    public UnityEngine.UI.Image defalultLevelImge;
    public UnityEngine.GameObject galleryScene;
    public UnityEngine.GameObject infoScene;
    public LanguageTextResponser descriptionTxtResp;
    public LanguageTextResponser levelNameTxtResp;
    public UnityEngine.GameObject infoPanel;
    public UnityEngine.GameObject infolevelName;
    public LanguageTextResponser likeTxtResp;
    public LanguageTextResponser dislikeTxtResp;
    public UnityEngine.UI.Image puzzleFill;
    public UnityEngine.UI.Image battleFill;
    public UnityEngine.UI.Image exBattleFill;
    public UnityEngine.UI.Button backButton;
    public CharacterNameController nameController;
    public UnityEngine.UI.Text stars;
    public UnityEngine.UI.GridLayoutGroup gridHolder1;
    public UnityEngine.UI.GridLayoutGroup gridHolder2;
    public UnityEngine.Sprite takoFlag;
    public UnityEngine.Sprite ikaFlag;
    private static bool forceAds;
    
    // Methods
    private void OnEnable()
    {
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void gallery::bacKClick()));
    }
    private void OnDisable()
    {
        this.backButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void gallery::bacKClick()));
    }
    private void Start()
    {
        null = null;
        gallery.forceAds = false;
        GameAudio.SwitchMusic(musicId:  128, forcePlay:  false);
        this.InitCharacterStatus();
    }
    private void InitCharacterStatus()
    {
        var val_11;
        T val_12;
        var val_13;
        CharacterAvatarController val_14;
        val_11 = 0;
        goto label_3;
        label_20:
        .<>4__this = this;
        val_12 = UnityEngine.Object.FindObjectsOfType<CharacterAvatarController>()[0];
        .avatar = val_12;
        val_13 = null;
        val_13 = null;
        val_12 = (gallery.<>c__DisplayClass25_0)[1152921528273159568].avatar;
        bool val_3 = DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  (gallery.<>c__DisplayClass25_0)[1152921528273159568].avatar.characterID);
        UnityEngine.Color val_4 = UnityEngine.Color.black;
        (gallery.<>c__DisplayClass25_0)[1152921528273159568].avatar.SetBorderColor(color:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        val_14 = (gallery.<>c__DisplayClass25_0)[1152921528273159568].avatar;
        if(val_3 != false)
        {
                UnityEngine.Color val_5 = UnityEngine.Color.black;
        }
        else
        {
                UnityEngine.Color val_6 = UnityEngine.Color.white;
        }
        
        val_14.SetAvatarColor(color:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        if(val_3 != true)
        {
                UnityEngine.Events.UnityAction val_10 = null;
            val_14 = val_10;
            val_10 = new UnityEngine.Events.UnityAction(object:  new gallery.<>c__DisplayClass25_0(), method:  System.Void gallery.<>c__DisplayClass25_0::<InitCharacterStatus>b__0());
            (gallery.<>c__DisplayClass25_0)[1152921528273159568].avatar.gameObject.AddComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  val_10);
        }
        
        val_11 = 1;
        label_3:
        if(val_11 < val_1.Length)
        {
            goto label_20;
        }
    
    }
    public void bacKClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Menu_Title_Screen");
        GameAudio.PlayButtonSound();
    }
    public void backClickFromInfo()
    {
        GameAudio.PlayButtonSound();
        this.infoScene.SetActive(value:  false);
        this.galleryScene.SetActive(value:  true);
        this.backButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void gallery::backClickFromInfo()));
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void gallery::bacKClick()));
    }
    public void buttonCharacter(CharacterNameID cid)
    {
        var val_21;
        string val_22;
        UnityEngine.Sprite val_24;
        var val_25;
        GameAudio.PlayButtonSound();
        val_21 = null;
        val_21 = null;
        DataStructs.UserDataDictionary.GameSave.UnlockAchievement(id:  27);
        CharacterData val_1 = CharacterDataManager.Get(id:  cid);
        this.infolevelName.SetActive(value:  (val_1.type != 4) ? 1 : 0);
        this.infoPanel.SetActive(value:  (val_1.type != 4) ? 1 : 0);
        this.SetupAdventureProgressData(data:  DataStructs.UserDataDictionary.GameSave.GetAdventureProgressByID(cid:  cid));
        this.dislikeTxtResp.textKey = CharacterLocalization.GetTxtKey(cid:  cid, key:  "dislike");
        val_22 = CharacterLocalization.GetTxtKey(cid:  cid, key:  "like");
        this.likeTxtResp.textKey = val_22;
        CharacterAssetLoader.Get(id:  cid, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void gallery::<buttonCharacter>b__28_0(CharacterAssetLoader loader)));
        this.levelNameTxtResp.textKey = "";
        if(cid == 7)
        {
            goto label_15;
        }
        
        if(cid != 20)
        {
            goto label_16;
        }
        
        UnityEngine.UI.Image val_8 = this.defalultLevelImge.GetComponent<UnityEngine.UI.Image>();
        val_24 = this.takoFlag;
        goto label_18;
        label_15:
        val_24 = this.ikaFlag;
        label_18:
        this.defalultLevelImge.GetComponent<UnityEngine.UI.Image>().sprite = val_24;
        goto label_21;
        label_16:
        val_25 = null;
        val_25 = null;
        StageData val_10 = GameInfo.stage.GetItemDataById(uniqueId:  val_1.relatedStage);
        val_22 = val_10.LoadStageSprite();
        this.defalultLevelImge.GetComponent<UnityEngine.UI.Image>().sprite = val_22;
        this.levelNameTxtResp.textKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  val_10);
        label_21:
        this.defaultstatImage.GetComponent<UnityEngine.UI.Image>().sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  cid, left:  true);
        this.descriptionTxtResp.textKey = CharacterLocalization.GetTxtKey(cid:  cid, key:  "characterDescription");
        this.nameController.characterId = cid;
        this.galleryScene.SetActive(value:  false);
        this.infoScene.SetActive(value:  true);
        this.backButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void gallery::bacKClick()));
        this.backButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void gallery::backClickFromInfo()));
    }
    private void SetupAdventureProgressData(DataStructs.AdventureProgress data)
    {
        string val_2 = data.TotalStars.ToString();
        this.puzzleFill.fillAmount = data.GetPassedLevelProgress(mode:  1);
        this.battleFill.fillAmount = data.GetPassedLevelProgress(mode:  0);
        this.exBattleFill.fillAmount = data.GetPassedLevelProgress(mode:  2);
    }
    public gallery()
    {
    
    }
    private static gallery()
    {
        gallery.forceAds = true;
    }
    private void <buttonCharacter>b__28_0(CharacterAssetLoader loader)
    {
        this.defaultCharchterImage.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPose_Dynamic();
    }

}
