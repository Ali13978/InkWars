using UnityEngine;
public class Scene_CharacterSelection_Adventure : MonoBehaviour
{
    // Fields
    public static bool ready;
    public UnityEngine.UI.Image rollTargetLeft;
    public UnityEngine.UI.Image rollTargetRight;
    public UnityEngine.GameObject nextButton;
    public UnityEngine.GameObject imageName;
    public UnityEngine.GameObject imageStats;
    public UnityEngine.GameObject iconHolder;
    public UnityEngine.Transform imageNameSource;
    public UnityEngine.Transform imageStatsSource;
    public UnityEngine.Transform iconHolderSource;
    public UnityEngine.Transform imageNameTarget;
    public UnityEngine.Transform imageStatsTarget;
    public UnityEngine.Transform iconHolderTarget;
    public UnityEngine.GameObject lockedImage;
    public UnityEngine.GameObject buyButtons;
    public UnityEngine.GameObject[] swipeButtons;
    public UnityEngine.GameObject backButton;
    private UnityEngine.Vector3 imagePos_Left;
    private UnityEngine.Vector3 imagePos_Middle;
    private UnityEngine.Vector3 imagePos_Right;
    private CharacterNameID[] allClanCharactersInOrder;
    private UnityEngine.Sprite[] characterDynamicPoses;
    private UnityEngine.Sprite[] characterStats;
    public System.Collections.Generic.List<UnityEngine.UI.Image> displayImages;
    private int charCenterIndex;
    private UnityEngine.Vector3 scaleSide;
    private UnityEngine.Vector3 scaleCenter;
    private UnityEngine.Vector4 fade_Locked;
    private UnityEngine.Vector4 fadeCenter_Unlocked;
    private UnityEngine.Vector4 fadeSide_Unlocked;
    public UnityEngine.UI.Image image_Stats;
    public UnityEngine.GameObject imageNew;
    public UnityEngine.UI.Image puzzleFill;
    public UnityEngine.UI.Image battleFill;
    public UnityEngine.UI.Image exBattleFill;
    public UnityEngine.GameObject iconsHolder;
    public UnityEngine.GameObject instructionalPanel;
    public CharacterNameController CharNameController;
    
    // Methods
    private void OnEnable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.AddListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void Scene_CharacterSelection_Adventure::OnItemPurchased(IAPItemIds id)));
    }
    private void OnDisable()
    {
        null = null;
        GGPPurchasingManager.OnPurchaseSuccess.RemoveListener(call:  new UnityEngine.Events.UnityAction<IAPItemIds>(object:  this, method:  System.Void Scene_CharacterSelection_Adventure::OnItemPurchased(IAPItemIds id)));
    }
    private void OnItemPurchased(IAPItemIds id)
    {
        this.UnlockCharacter();
    }
    private System.Collections.IEnumerator LoadCharacterLockStatuses()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Scene_CharacterSelection_Adventure.<LoadCharacterLockStatuses>d__41();
    }
    private System.Collections.IEnumerator LoadStoryPanels()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new Scene_CharacterSelection_Adventure.<LoadStoryPanels>d__42();
    }
    private System.Collections.IEnumerator LoadStageSelect()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new Scene_CharacterSelection_Adventure.<LoadStageSelect>d__43();
    }
    public void ButtonPress_Back()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_PlayerChoose");
    }
    public void ButtonPress_Next()
    {
        var val_2;
        string val_9;
        string val_10;
        var val_11;
        var val_12;
        var val_13;
        string val_14;
        var val_15;
        var val_16;
        Character_GlobalInfo.SetMainPlayer(nameID:  this.allClanCharactersInOrder[(this.charCenterIndex) << 2]);
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 != 1)
        {
            goto label_5;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "ika", value:  "no");
        val_9 = "tako";
        val_10 = "yes";
        goto label_6;
        label_5:
        CharacterInfo val_3 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 != 0)
        {
            goto label_9;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  "ika", value:  "yes");
        val_9 = "tako";
        val_10 = "no";
        label_6:
        UnityEngine.PlayerPrefs.SetString(key:  val_9, value:  val_10);
        label_9:
        val_11 = null;
        val_11 = null;
        DataStructs.UserDataDictionary.GameSave.SetCurrentCharacterUsed(used:  true);
        GameAudio.PlayButtonSound();
        if(this.charCenterIndex == 0)
        {
            goto label_15;
        }
        
        label_35:
        label_41:
        UnityEngine.Coroutine val_4 = this.StartCoroutine(methodName:  "LoadStageSelect");
        return;
        label_15:
        CharacterInfo val_5 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 == 0)
        {
            goto label_18;
        }
        
        CharacterInfo val_6 = Character_GlobalInfo.GetMainPlayer();
        if(val_2 != 1)
        {
            goto label_35;
        }
        
        val_12 = null;
        val_12 = null;
        if(DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed == true)
        {
            goto label_35;
        }
        
        val_13 = null;
        val_13 = null;
        DataStructs.UserDataDictionary.GameSave.isTakoStoryStartPlayed = true;
        val_14 = "Tako_Start";
        goto label_31;
        label_18:
        val_15 = null;
        val_15 = null;
        if(DataStructs.UserDataDictionary.GameSave.isIkaStoryStartPlayed == true)
        {
            goto label_35;
        }
        
        val_16 = null;
        val_16 = null;
        DataStructs.UserDataDictionary.GameSave.isIkaStoryStartPlayed = true;
        val_14 = "Ika_Start";
        label_31:
        StoryPanelScript.keyForStory = val_14;
        goto label_41;
    }
    private System.Collections.IEnumerator Start()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Scene_CharacterSelection_Adventure.<Start>d__46();
    }
    public void DarkenAtStart()
    {
        this.swipeButtons[0].SetActive(value:  true);
        this.swipeButtons[1].SetActive(value:  true);
        this.backButton.SetActive(value:  true);
        UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.fadeCenter_Unlocked});
        this.displayImages.Item[1].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
    }
    private void Update()
    {
    
    }
    private int IncrementIndex(int index)
    {
        int val_1 = index + 1;
        return (int)(val_1 >= this.characterDynamicPoses.Length) ? 0 : (val_1);
    }
    private int DecrementIndex(int index)
    {
        var val_2 = index - 1;
        if((val_2 & 2147483648) == 0)
        {
                return (int)val_2;
        }
        
        val_2 = this.characterDynamicPoses.Length - 1;
        return (int)val_2;
    }
    private void TweenInfoImages_Out()
    {
        object[] val_1 = new object[4];
        val_1[0] = "position";
        UnityEngine.Vector3 val_2 = this.imageNameTarget.position;
        val_1[1] = val_2;
        val_1[2] = "time";
        val_1[3] = 0.2f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_1));
        object[] val_4 = new object[4];
        val_4[0] = "position";
        UnityEngine.Vector3 val_5 = this.imageStatsTarget.position;
        val_4[1] = val_5;
        val_4[2] = "time";
        val_4[3] = 0.2f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_4));
        object[] val_7 = new object[4];
        val_7[0] = "position";
        UnityEngine.Vector3 val_8 = this.iconHolderTarget.position;
        val_7[1] = val_8;
        val_7[2] = "time";
        val_7[3] = 0.2f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_7));
        object[] val_10 = new object[6];
        val_10[0] = "x";
        val_10[1] = 0f;
        val_10[2] = "y";
        val_10[3] = 0f;
        val_10[4] = "time";
        val_10[5] = 0.05f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_10));
    }
    private void TweenInfoImages_In()
    {
        object[] val_1 = new object[8];
        val_1[0] = "position";
        UnityEngine.Vector3 val_2 = this.imageNameSource.position;
        val_1[1] = val_2;
        val_1[2] = "easeType";
        val_1[3] = 24;
        val_1[4] = "delay";
        val_1[5] = 0.3f;
        val_1[6] = "time";
        val_1[7] = 0.3f;
        iTween.MoveTo(target:  this.imageName, args:  iTween.Hash(args:  val_1));
        object[] val_4 = new object[8];
        val_4[0] = "position";
        UnityEngine.Vector3 val_5 = this.imageStatsSource.position;
        val_4[1] = val_5;
        val_4[2] = "easeType";
        val_4[3] = 24;
        val_4[4] = "delay";
        val_4[5] = 0.3f;
        val_4[6] = "time";
        val_4[7] = 0.3f;
        iTween.MoveTo(target:  this.imageStats, args:  iTween.Hash(args:  val_4));
        object[] val_7 = new object[8];
        val_7[0] = "position";
        UnityEngine.Vector3 val_8 = this.iconHolderSource.position;
        val_7[1] = val_8;
        val_7[2] = "easeType";
        val_7[3] = 24;
        val_7[4] = "delay";
        val_7[5] = 0.3f;
        val_7[6] = "time";
        val_7[7] = 0.3f;
        iTween.MoveTo(target:  this.iconHolder, args:  iTween.Hash(args:  val_7));
        object[] val_10 = new object[10];
        val_10[0] = "x";
        val_10[1] = 1f;
        val_10[2] = "y";
        val_10[3] = 1f;
        val_10[4] = "easeType";
        val_10[5] = 24;
        val_10[6] = "delay";
        val_10[7] = 0.4f;
        val_10[8] = "time";
        val_10[9] = 0.2f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_10));
    }
    public void swipe(bool left)
    {
        int val_98;
        float val_99;
        System.Object[] val_100;
        UnityEngine.GameObject val_101;
        var val_102;
        var val_103;
        var val_104;
        var val_105;
        if(left != false)
        {
                int val_1 = this.charCenterIndex + 1;
            var val_2 = (val_1 >= this.characterDynamicPoses.Length) ? 0 : (val_1);
        }
        else
        {
                if(((this.charCenterIndex - 1) & 2147483648) != 0)
        {
                int val_4 = this.characterDynamicPoses.Length - 1;
        }
        
        }
        
        if((this.GetUnlockStatus(id:  this.charCenterIndex)) == false)
        {
            goto label_6;
        }
        
        object[] val_6 = new object[6];
        val_6[0] = "x";
        val_6[1] = 0f;
        val_6[2] = "y";
        val_6[3] = 0f;
        val_6[4] = "time";
        val_6[5] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_6));
        this.buyButtons.transform.GetChild(index:  this.charCenterIndex).gameObject.SetActive(value:  false);
        if((this.GetUnlockStatus(id:  val_4)) == false)
        {
            goto label_32;
        }
        
        this.lockedImage.transform.SetAsLastSibling();
        object[] val_13 = new object[10];
        val_13[0] = "x";
        val_13[1] = 1f;
        val_13[2] = "y";
        val_13[3] = 1f;
        val_13[4] = "easeType";
        val_13[5] = 24;
        val_13[6] = "delay";
        val_13[7] = 0.4f;
        if("time" != null)
        {
            goto label_62;
        }
        
        goto label_62;
        label_6:
        this.TweenInfoImages_Out();
        if((this.GetUnlockStatus(id:  val_4)) == false)
        {
            goto label_63;
        }
        
        this.lockedImage.transform.SetAsLastSibling();
        object[] val_16 = new object[10];
        val_16[0] = "x";
        val_16[1] = 1f;
        val_16[2] = "y";
        val_16[3] = 1f;
        val_16[4] = "easeType";
        val_16[5] = 24;
        val_16[6] = "delay";
        val_16[7] = 0.4f;
        label_62:
        val_16[8] = "time";
        val_16[9] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_16));
        this.buyButtons.transform.GetChild(index:  val_4).gameObject.SetActive(value:  true);
        goto label_104;
        label_32:
        this.TweenInfoImages_In();
        goto label_104;
        label_63:
        this.TweenInfoImages_In();
        object[] val_21 = new object[6];
        val_21[0] = "x";
        val_21[1] = 0f;
        val_21[2] = "y";
        val_21[3] = 0f;
        val_21[4] = "time";
        val_21[5] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_21));
        label_104:
        if(left == false)
        {
            goto label_126;
        }
        
        int val_23 = this.charCenterIndex + 1;
        val_98 = this;
        int val_24 = (val_23 >= this.characterDynamicPoses.Length) ? 0 : (val_23);
        var val_26 = val_24 + 1;
        if(this.characterDynamicPoses == null)
        {
            goto label_129;
        }
        
        var val_27 = (val_26 >= this.characterDynamicPoses.Length) ? 0 : (val_26);
        goto label_130;
        label_126:
        if(((this.charCenterIndex - 1) & 2147483648) != 0)
        {
                int val_29 = this.characterDynamicPoses.Length - 1;
        }
        
        val_98 = this;
        if(((val_29 - 1) & 2147483648) != 0)
        {
            goto label_134;
        }
        
        if(this.characterDynamicPoses != null)
        {
            goto label_136;
        }
        
        goto label_136;
        label_129:
        label_130:
        this.displayImages.Item[0].sprite = this.characterDynamicPoses[(long)(val_26 >= this.characterDynamicPoses.Length) ? 0 : (val_26)];
        this.charCenterIndex = val_24;
        this.displayImages.RemoveAt(index:  0);
        this.displayImages.Add(item:  this.displayImages.Item[0]);
        goto label_142;
        label_134:
        label_136:
        this.displayImages.Item[2].sprite = this.characterDynamicPoses[(long)this.characterDynamicPoses.Length - 1];
        this.charCenterIndex = val_29;
        this.displayImages.RemoveAt(index:  2);
        this.displayImages.Insert(index:  0, item:  this.displayImages.Item[2]);
        label_142:
        if((this.GetUnlockStatus(id:  this.characterDynamicPoses.Length - 1)) != false)
        {
            
        }
        
        UnityEngine.Color val_42 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.fadeSide_Unlocked.x, y = 2.113612E-20f, z = 2.113612E-20f, w = 2.113612E-20f});
        this.displayImages.Item[0].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_42.r, g = val_42.g, b = val_42.b, a = val_42.a};
        if((this.GetUnlockStatus(id:  this.charCenterIndex)) != false)
        {
            
        }
        
        UnityEngine.Color val_47 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.fadeCenter_Unlocked.x, y = 2.113612E-20f, z = 2.113612E-20f, w = 2.113612E-20f});
        this.displayImages.Item[1].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_47.r, g = val_47.g, b = val_47.b, a = val_47.a};
        int val_51 = this.charCenterIndex + 1;
        if((this.GetUnlockStatus(id:  (val_51 >= this.characterDynamicPoses.Length) ? 0 : (val_51))) != false)
        {
            
        }
        
        UnityEngine.Color val_54 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.fadeSide_Unlocked.x, y = 2.113612E-20f, z = 2.113612E-20f, w = 2.113612E-20f});
        val_99 = val_54.r;
        this.displayImages.Item[2].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_99, g = val_54.g, b = val_54.b, a = val_54.a};
        object[] val_57 = new object[6];
        val_57[0] = "x";
        val_57[1] = this.imagePos_Left;
        val_57[2] = "y";
        val_57[3] = val_57.Length;
        val_57[4] = "time";
        val_57[5] = 0.4f;
        iTween.MoveTo(target:  this.displayImages.Item[0].gameObject, args:  iTween.Hash(args:  val_57));
        object[] val_61 = new object[6];
        val_61[0] = "x";
        val_61[1] = this.imagePos_Middle;
        val_61[2] = "y";
        val_61[3] = val_61.Length;
        val_61[4] = "time";
        val_61[5] = 0.4f;
        iTween.MoveTo(target:  this.displayImages.Item[1].gameObject, args:  iTween.Hash(args:  val_61));
        object[] val_65 = new object[6];
        val_65[0] = "x";
        val_65[1] = this.imagePos_Right;
        val_65[2] = "y";
        val_65[3] = val_65.Length;
        val_65[4] = "time";
        val_65[5] = 0.4f;
        iTween.MoveTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_65));
        object[] val_69 = new object[8];
        val_69[0] = "x";
        val_69[1] = 0.19f;
        val_69[2] = "y";
        val_69[3] = 0.19f;
        val_69[4] = "easeType";
        val_69[5] = 21;
        val_69[6] = "time";
        val_69[7] = 0.3f;
        iTween.ScaleTo(target:  this.displayImages.Item[0].gameObject, args:  iTween.Hash(args:  val_69));
        object[] val_73 = new object[10];
        val_73[0] = "x";
        val_73[1] = 0.15f;
        val_73[2] = "y";
        val_73[3] = 0.15f;
        val_73[4] = "easeType";
        val_73[5] = 24;
        val_73[6] = "delay";
        val_73[7] = 0.3f;
        val_73[8] = "time";
        val_73[9] = 0.4f;
        iTween.ScaleTo(target:  this.displayImages.Item[0].gameObject, args:  iTween.Hash(args:  val_73));
        object[] val_77 = new object[8];
        val_77[0] = "x";
        val_77[1] = 0.23f;
        val_77[2] = "y";
        val_77[3] = 0.23f;
        val_77[4] = "easeType";
        val_77[5] = 21;
        val_77[6] = "time";
        val_77[7] = 0.3f;
        iTween.ScaleTo(target:  this.displayImages.Item[1].gameObject, args:  iTween.Hash(args:  val_77));
        object[] val_81 = new object[10];
        val_81[0] = "x";
        val_81[1] = 0.3f;
        val_81[2] = "y";
        val_81[3] = 0.3f;
        val_81[4] = "easeType";
        val_81[5] = 24;
        val_81[6] = "delay";
        val_81[7] = 0.3f;
        val_81[8] = "time";
        val_81[9] = 0.4f;
        iTween.ScaleTo(target:  this.displayImages.Item[1].gameObject, args:  iTween.Hash(args:  val_81));
        object[] val_85 = new object[8];
        val_85[0] = "x";
        val_85[1] = 0.19f;
        val_85[2] = "y";
        val_85[3] = 0.19f;
        val_85[4] = "easeType";
        val_85[5] = 21;
        val_85[6] = "time";
        val_85[7] = 0.3f;
        iTween.ScaleTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_85));
        object[] val_89 = new object[10];
        val_100 = val_89;
        val_100[0] = "x";
        val_100[1] = 0.15f;
        val_100[2] = "y";
        val_100[3] = 0.15f;
        val_100[4] = "easeType";
        val_100[5] = 24;
        val_100[6] = "delay";
        val_100[7] = 0.3f;
        val_100[8] = "time";
        val_100[9] = 0.4f;
        iTween.ScaleTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_89));
        if((this.GetUnlockStatus(id:  this.charCenterIndex)) == false)
        {
            goto label_415;
        }
        
        this.imageNew.SetActive(value:  false);
        val_101 = this.lockedImage;
        val_102 = 1;
        goto label_418;
        label_415:
        val_103 = null;
        val_103 = null;
        val_98 = this.charCenterIndex;
        bool val_92 = DataStructs.UserDataDictionary.GameSave.GetCharacterUsed(cid:  this.allClanCharactersInOrder[(this.charCenterIndex) << 2]);
        if(this.imageNew == null)
        {
            goto label_424;
        }
        
        if(val_92 == false)
        {
            goto label_425;
        }
        
        label_427:
        val_104 = 0;
        goto label_426;
        label_424:
        if(val_92 == true)
        {
            goto label_427;
        }
        
        label_425:
        val_104 = 1;
        label_426:
        this.imageNew.SetActive(value:  true);
        val_105 = null;
        val_105 = null;
        DataStructs.AdventureProgress val_93 = DataStructs.UserDataDictionary.GameSave.GetAdventureProgressByID(cid:  this.allClanCharactersInOrder[(this.charCenterIndex) << 2]);
        this.puzzleFill.fillAmount = val_93.GetPassedLevelProgress(mode:  1);
        this.battleFill.fillAmount = val_93.GetPassedLevelProgress(mode:  0);
        val_99 = val_93.GetPassedLevelProgress(mode:  2);
        this.exBattleFill.fillAmount = val_99;
        this.SetNameImage();
        val_100 = this.characterStats[this.charCenterIndex];
        this.image_Stats.GetComponent<UnityEngine.UI.Image>().sprite = val_100;
        val_101 = this.lockedImage;
        val_102 = 0;
        label_418:
        val_101.SetActive(value:  false);
    }
    public void leftSwipe()
    {
        this.swipe(left:  true);
    }
    public void rightSwipe()
    {
        this.swipe(left:  false);
    }
    public void UnlockCharacter()
    {
        UnityEngine.Color val_4 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = this.fadeCenter_Unlocked});
        this.displayImages.Item[1].gameObject.GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
        object[] val_5 = new object[6];
        val_5[0] = "x";
        val_5[1] = 0f;
        val_5[2] = "y";
        val_5[3] = 0f;
        val_5[4] = "time";
        val_5[5] = 0.2f;
        iTween.ScaleTo(target:  this.lockedImage, args:  iTween.Hash(args:  val_5));
        this.buyButtons.transform.GetChild(index:  this.charCenterIndex).gameObject.SetActive(value:  false);
        object[] val_10 = new object[10];
        val_10[0] = "x";
        val_10[1] = 1f;
        val_10[2] = "y";
        val_10[3] = 1f;
        val_10[4] = "easeType";
        val_10[5] = 24;
        val_10[6] = "delay";
        val_10[7] = 0.4f;
        val_10[8] = "time";
        val_10[9] = 0.2f;
        iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_10));
    }
    private void rollTemp()
    {
    
    }
    private System.Collections.IEnumerator AnimationAtStart()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Scene_CharacterSelection_Adventure.<AnimationAtStart>d__58();
    }
    private System.Collections.IEnumerator PlayRollAnimation()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Scene_CharacterSelection_Adventure.<PlayRollAnimation>d__59();
    }
    public void StartRoll(float rollTime)
    {
        float val_85;
        UnityEngine.GameObject val_86;
        var val_87;
        var val_88;
        System.Object[] val_89;
        val_85 = rollTime;
        val_86 = this;
        int val_85 = this.charCenterIndex;
        val_85 = ((val_85 + 1) < this.characterDynamicPoses.Length) ? (val_85 + 2) : (0 + 1);
        if(this.characterDynamicPoses != null)
        {
                var val_4 = (val_85 >= this.characterDynamicPoses.Length) ? 0 : (val_85);
        }
        
        this.displayImages.Item[0].sprite = this.characterDynamicPoses[(long)(val_85 >= this.characterDynamicPoses.Length) ? 0 : (val_85)];
        this.displayImages.Item[2].transform.SetAsLastSibling();
        int val_87 = this.allClanCharactersInOrder.Length;
        UnityEngine.GameObject val_9 = this.displayImages.Item[0].gameObject;
        object[] val_10 = new object[8];
        val_87 = val_87 - 1;
        val_10[0] = "x";
        if(this.charCenterIndex == val_87)
        {
                val_10[1] = this.imagePos_Right;
            val_10[2] = "y";
            val_10[3] = val_10.Length;
            val_10[4] = "easeType";
            val_10[5] = 21;
            val_87 = "time";
            val_10[6] = "time";
            val_10[7] = val_85;
            iTween.MoveTo(target:  val_9, args:  iTween.Hash(args:  val_10));
            object[] val_14 = new object[8];
            val_14[0] = "x";
            val_14[1] = this.imagePos_Left;
            val_14[2] = "y";
            val_14[3] = val_14.Length;
            val_14[4] = "easeType";
            val_14[5] = 21;
            val_14[6] = "time";
            val_14[7] = val_85;
            iTween.MoveTo(target:  this.displayImages.Item[1].gameObject, args:  iTween.Hash(args:  val_14));
            object[] val_18 = new object[8];
            val_18[0] = "x";
            val_18[1] = this.imagePos_Middle;
            val_18[2] = "y";
            val_18[3] = val_18.Length;
            val_18[4] = "easeType";
            val_18[5] = 21;
            val_18[6] = "time";
            val_18[7] = val_85;
            iTween.MoveTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_18));
            this.displayImages.RemoveAt(index:  0);
            this.displayImages.Add(item:  this.displayImages.Item[0]);
            object[] val_23 = new object[8];
            val_23[0] = "x";
            val_23[1] = 0.1f;
            val_23[2] = "y";
            val_23[3] = 0.1f;
            val_23[4] = "easeType";
            val_23[5] = 21;
            val_23[6] = "time";
            float val_24 = val_85 * 0.5f;
            val_23[7] = val_24;
            iTween.ScaleTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_23));
            object[] val_28 = new object[10];
            val_28[0] = "x";
            val_28[1] = 0.18f;
            val_28[2] = "y";
            val_28[3] = 0.18f;
            val_28[4] = "easeType";
            val_28[5] = 21;
            val_88 = "delay";
            val_28[6] = "delay";
            val_28[7] = val_24;
            val_28[8] = "time";
            val_28[9] = val_24;
            iTween.ScaleTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_28));
            object[] val_32 = new object[8];
            val_32[0] = "x";
            val_32[1] = 0.18f;
            val_32[2] = "y";
            val_32[3] = 0.18f;
            val_32[4] = "easeType";
            val_32[5] = 21;
            val_32[6] = "time";
            val_32[7] = val_85;
            iTween.ScaleTo(target:  this.displayImages.Item[0].gameObject, args:  iTween.Hash(args:  val_32));
            object[] val_36 = new object[8];
            val_36[0] = "x";
            val_36[1] = 0.22f;
            val_36[2] = "y";
            val_36[3] = 0.22f;
            val_36[4] = "easeType";
            val_36[5] = 21;
            val_36[6] = "time";
            val_36[7] = val_85;
            iTween.ScaleTo(target:  this.displayImages.Item[1].gameObject, args:  iTween.Hash(args:  val_36));
            object[] val_40 = new object[10];
            val_40[0] = "x";
            val_40[1] = this.scaleSide;
            val_40[2] = "y";
            val_40[3] = val_40.Length;
            val_40[4] = "easeType";
            val_40[5] = 21;
            val_40[6] = "delay";
            val_85 = val_85 + 0.2f;
            val_40[7] = val_85;
            val_40[8] = "time";
            val_40[9] = 0.2f;
            iTween.ScaleTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_40));
            object[] val_44 = new object[10];
            val_44[0] = "x";
            val_44[1] = this.scaleSide;
            val_44[2] = "y";
            val_44[3] = val_44.Length;
            val_44[4] = "easeType";
            val_44[5] = 21;
            val_44[6] = "delay";
            val_44[7] = val_85;
            val_44[8] = "time";
            val_44[9] = 0.2f;
            iTween.ScaleTo(target:  this.displayImages.Item[0].gameObject, args:  iTween.Hash(args:  val_44));
            object[] val_48 = new object[10];
            val_48[0] = "x";
            val_48[1] = this.scaleCenter;
            val_48[2] = "y";
            val_48[3] = val_48.Length;
            val_48[4] = "easeType";
            val_48[5] = 21;
            val_48[6] = "delay";
            val_48[7] = val_85;
            val_48[8] = "time";
            val_48[9] = 0.2f;
            iTween.ScaleTo(target:  this.displayImages.Item[1].gameObject, args:  iTween.Hash(args:  val_48));
            object[] val_50 = new object[10];
            val_89 = val_50;
            val_89[0] = "x";
            val_89[1] = 1f;
            val_89[2] = "y";
            val_89[3] = 1f;
            val_89[4] = "easeType";
            val_89[5] = 21;
            val_89[6] = "delay";
            val_89[7] = val_85;
            val_89[8] = "time";
            val_89[9] = 0.2f;
            iTween.ScaleTo(target:  this.nextButton, args:  iTween.Hash(args:  val_50));
            UnityEngine.Coroutine val_53 = this.StartCoroutine(routine:  this.ActivateForRoll());
            return;
        }
        
        UnityEngine.Vector3 val_55 = this.rollTargetRight.transform.position;
        val_10[1] = val_55.x;
        val_88 = "y";
        val_10[2] = "y";
        val_10[3] = val_10.Length;
        val_10[4] = "easeType";
        val_10[5] = 21;
        val_87 = "time";
        val_10[6] = "time";
        val_10[7] = val_85;
        iTween.MoveTo(target:  val_9, args:  iTween.Hash(args:  val_10));
        object[] val_59 = new object[8];
        val_59[0] = "x";
        UnityEngine.Vector3 val_61 = this.rollTargetLeft.transform.position;
        val_59[1] = val_61.x;
        val_59[2] = "y";
        val_59[3] = val_59.Length;
        val_59[4] = "easeType";
        val_59[5] = 21;
        val_59[6] = "time";
        val_59[7] = val_85;
        iTween.MoveTo(target:  this.displayImages.Item[1].gameObject, args:  iTween.Hash(args:  val_59));
        object[] val_65 = new object[8];
        val_65[0] = "x";
        val_65[1] = this.imagePos_Middle;
        val_65[2] = "y";
        val_65[3] = val_65.Length;
        val_65[4] = "easeType";
        val_65[5] = 21;
        val_65[6] = "time";
        val_65[7] = val_85;
        iTween.MoveTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_65));
        this.displayImages.RemoveAt(index:  0);
        this.displayImages.Add(item:  this.displayImages.Item[0]);
        object[] val_70 = new object[8];
        val_70[0] = "x";
        val_70[1] = 0.08f;
        val_70[2] = "y";
        val_70[3] = 0.08f;
        val_70[4] = "easeType";
        val_70[5] = 21;
        val_70[6] = "time";
        float val_71 = val_85 * 0.5f;
        val_70[7] = val_71;
        iTween.ScaleTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_70));
        object[] val_75 = new object[10];
        val_75[0] = "x";
        val_75[1] = 0.14f;
        val_75[2] = "y";
        val_75[3] = 0.14f;
        val_75[4] = "easeType";
        val_75[5] = 21;
        val_75[6] = "delay";
        val_75[7] = val_71;
        val_75[8] = "time";
        val_75[9] = val_71;
        iTween.ScaleTo(target:  this.displayImages.Item[2].gameObject, args:  iTween.Hash(args:  val_75));
        object[] val_79 = new object[8];
        val_79[0] = "x";
        val_79[1] = 0.14f;
        val_79[2] = "y";
        val_79[3] = 0.14f;
        val_79[4] = "easeType";
        val_79[5] = 21;
        val_79[6] = "time";
        val_79[7] = val_85;
        iTween.ScaleTo(target:  this.displayImages.Item[0].gameObject, args:  iTween.Hash(args:  val_79));
        val_86 = this.displayImages.Item[1].gameObject;
        object[] val_83 = new object[8];
        val_83[0] = "x";
        val_83[1] = 0.22f;
        val_83[2] = "y";
        val_83[3] = 0.22f;
        val_83[4] = "easeType";
        val_83[5] = 21;
        val_83[6] = "time";
        val_89 = val_85;
        val_83[7] = val_89;
        iTween.ScaleTo(target:  val_86, args:  iTween.Hash(args:  val_83));
    }
    private System.Collections.IEnumerator ActivateForRoll()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Scene_CharacterSelection_Adventure.<ActivateForRoll>d__61();
    }
    public void ActiveNameTag()
    {
        this.iconHolder.SetActive(value:  true);
        this.imageStats.SetActive(value:  true);
        this.imageName.SetActive(value:  true);
    }
    public void BuyButtonClick(int index)
    {
        GGPPurchasingManager.instance.BuyProductID(skuIndex:  index);
    }
    public void OnFacebookLikeButtonClick()
    {
    
    }
    private void SetNameImage()
    {
        this.CharNameController.characterId = this.allClanCharactersInOrder[(this.charCenterIndex) << 2];
    }
    private bool GetUnlockStatus(int id)
    {
        null = null;
        if(DataStructs.UserDataDictionary.Items != null)
        {
                return DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.allClanCharactersInOrder[((long)(int)(id)) << 2]);
        }
        
        return DataStructs.UserDataDictionary.Items.IsCharacterLocked(id:  this.allClanCharactersInOrder[((long)(int)(id)) << 2]);
    }
    public Scene_CharacterSelection_Adventure()
    {
        this.scaleSide = 0;
        mem[1152921528752629260] = 0;
        this.scaleCenter = 0;
        mem[1152921528752629272] = 0;
        this.fade_Locked = 0;
        mem[1152921528752629280] = 0;
        mem[1152921528752629288] = 0;
        this.fadeCenter_Unlocked = 0;
        mem[1152921528752629296] = 0;
        mem[1152921528752629304] = 0;
        this.fadeSide_Unlocked = 0;
        mem[1152921528752629312] = 0;
        mem[1152921528752629320] = 0;
    }
    private static Scene_CharacterSelection_Adventure()
    {
    
    }

}
