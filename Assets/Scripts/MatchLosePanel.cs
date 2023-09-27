using UnityEngine;
public class MatchLosePanel : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI m_tips;
    private TMPro.TextMeshProUGUI m_neverGiveUpText;
    private UnityEngine.UI.Image m_dialog;
    private UnityEngine.UI.Image m_tag;
    private TMPro.TextMeshProUGUI m_dialogText;
    private MotionPanelsControler m_hereAreTipsText;
    private MotionPanelsControler m_leftCharacter;
    private MotionPanelsControler m_rightCharacter;
    private MotionPanelsControler m_tipsPanel;
    private MotionPanelsControler m_leftCharacterAnim;
    private MotionPanelsControler m_rightCharacterAnim;
    private PostMatchAnimationSettings m_animationSettings;
    public System.Collections.Generic.List<LoadingPanelTypeData> typeDataList;
    private UnityEngine.GameObject bottomText;
    private PostMatchEnhancerData enhancerData;
    
    // Methods
    public void SetupCharacters()
    {
        CharacterNameID val_2;
        CharacterNameID val_5;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        CharacterAssetLoader.Get(id:  val_2, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void MatchLosePanel::<SetupCharacters>b__15_0(CharacterAssetLoader loader)));
        CharacterInfo val_4 = Character_GlobalInfo.GetOpponentPlayer();
        CharacterAssetLoader.Get(id:  val_5, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void MatchLosePanel::<SetupCharacters>b__15_1(CharacterAssetLoader loader)));
    }
    private void SetupTypeInfo(LoadingPanelTypeData data)
    {
        CharacterNameID val_2;
        UnityEngine.UI.Image val_21;
        UnityEngine.UI.Image val_22;
        string val_23;
        int val_24;
        System.Object[] val_25;
        float val_26;
        float val_27;
        val_22 = this;
        if(data == null)
        {
            goto label_1;
        }
        
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        CharacterStatType val_3 = Character_GlobalInfo.GetStatType(charNameID:  val_2);
        val_3.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        val_23 = val_3.ToString().ToLower();
        if((val_23.Contains(value:  "_")) == false)
        {
            goto label_8;
        }
        
        if(val_23 == null)
        {
            goto label_9;
        }
        
        val_24 = val_23.IndexOf(value:  '_');
        goto label_10;
        label_1:
        UnityEngine.Debug.LogError(message:  "Data is null");
        return;
        label_9:
        val_24 = 0.IndexOf(value:  '_');
        label_10:
        val_23 = val_23.Substring(startIndex:  0, length:  val_24);
        label_8:
        if((System.String.op_Equality(a:  val_23, b:  "hero")) != false)
        {
                val_25 = new object[4];
            val_25[0] = "<b>";
            val_25[1] = "</b>";
            val_25[2] = "<b>";
            val_25[3] = "</b>";
        }
        else
        {
                object[] val_13 = new object[2];
            val_25 = val_13;
            val_25[0] = "<b>";
            val_25[1] = "</b>";
        }
        
        this.m_tips.text = LanguageManager.GetTextFormat(key:  "LK.TipsData." + val_23 + ".strategy", list:  val_13);
        UnityEngine.Debug.Log(message:  "Reset Panel Images");
        val_21 = this.m_tag;
        UnityEngine.Color val_15 = UnityEngine.Color.clear;
        val_26 = val_15.r;
        val_27 = val_15.b;
        val_21.color = new UnityEngine.Color() {r = val_26, g = val_15.g, b = val_27, a = val_15.a};
        if(data.typeTagList == null)
        {
                return;
        }
        
        if(data.typeTagList.Count < 1)
        {
                return;
        }
        
        val_21 = data.typeTagList.Item[UnityEngine.Random.Range(min:  0, max:  data.typeTagList.Count)];
        this.m_tag.sprite = val_21;
        val_22 = this.m_tag;
        UnityEngine.Color val_20 = UnityEngine.Color.white;
        val_26 = val_20.r;
        val_27 = val_20.b;
        val_22.color = new UnityEngine.Color() {r = val_26, g = val_20.g, b = val_27, a = val_20.a};
    }
    public DG.Tweening.Sequence ShowCharacters(bool showIn)
    {
        this.SetupCharacters();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        if(this.m_leftCharacter == null)
        {
            goto label_3;
        }
        
        if(showIn == false)
        {
            goto label_4;
        }
        
        label_6:
        DG.Tweening.Sequence val_2 = this.m_leftCharacter.MovetoEnd();
        goto label_5;
        label_3:
        if(showIn == true)
        {
            goto label_6;
        }
        
        label_4:
        label_5:
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.m_leftCharacter.MovetoStart());
        if(this.m_rightCharacter == null)
        {
            goto label_7;
        }
        
        if(showIn == false)
        {
            goto label_8;
        }
        
        label_10:
        DG.Tweening.Sequence val_5 = this.m_rightCharacter.MovetoEnd();
        goto label_9;
        label_7:
        if(showIn == true)
        {
            goto label_10;
        }
        
        label_8:
        label_9:
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_rightCharacter.MovetoStart());
        return val_1;
    }
    public void SetLoseTips(CharacterNameID tag, string tips)
    {
        this.m_tips.text = tips;
        this.m_tag.sprite = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  tag, left:  false);
    }
    public DG.Tweening.Sequence ShowDialog(QuoteData _text)
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.m_dialog.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_dialog.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  this.m_animationSettings.AnimSettings.winnerTextAnim.duration), ease:  this.m_animationSettings.AnimSettings.winnerTextAnim.ease));
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  TextMeshProUGUIEx.DOText(target:  this.m_dialogText, endValue:  _text.quote, duration:  this.m_animationSettings.AnimSettings.quoteTextAnim.duration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0), ease:  this.m_animationSettings.AnimSettings.quoteTextAnim.ease));
        return val_1;
    }
    public DG.Tweening.Sequence HideDialog()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_dialog.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  26));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_leftCharacterAnim.MovetoStart());
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_rightCharacterAnim.MovetoStart());
        return val_1;
    }
    public DG.Tweening.Sequence ShowTips()
    {
        CharacterNameID val_3;
        int val_29;
        MatchLosePanel.<>c__DisplayClass21_0 val_1 = new MatchLosePanel.<>c__DisplayClass21_0();
        .<>4__this = this;
        CharacterInfo val_2 = Character_GlobalInfo.GetMainPlayer();
        CharacterStatType val_4 = Character_GlobalInfo.GetStatType(charNameID:  val_3);
        this.bottomText.gameObject.SetActive(value:  false);
        val_4.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  null);
        string val_7 = val_4.ToString().ToLower();
        .typeStr = val_7;
        if((val_7.Contains(value:  "_")) != false)
        {
                if(((MatchLosePanel.<>c__DisplayClass21_0)[1152921528657622688].typeStr) != null)
        {
                val_29 = (MatchLosePanel.<>c__DisplayClass21_0)[1152921528657622688].typeStr.IndexOf(value:  '_');
        }
        else
        {
                val_29 = (MatchLosePanel.<>c__DisplayClass21_0)[1152921528657622688].typeStr.IndexOf(value:  '_');
        }
        
            .typeStr = (MatchLosePanel.<>c__DisplayClass21_0)[1152921528657622688].typeStr.Substring(startIndex:  0, length:  val_29);
        }
        
        this.SetupTypeInfo(data:  this.typeDataList.Find(match:  new System.Predicate<LoadingPanelTypeData>(object:  val_1, method:  System.Boolean MatchLosePanel.<>c__DisplayClass21_0::<ShowTips>b__0(LoadingPanelTypeData x))));
        DG.Tweening.Sequence val_14 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        this.m_neverGiveUpText.GetComponent<UnityEngine.RectTransform>().localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_14, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_neverGiveUpText.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_14, t:  this.m_hereAreTipsText.MovetoEnd());
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_14, t:  this.m_tipsPanel.MovetoEnd());
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_14, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void MatchLosePanel.<>c__DisplayClass21_0::<ShowTips>b__1()));
        return val_14;
    }
    public DG.Tweening.Sequence HideTips()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_neverGiveUpText.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  26));
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_hereAreTipsText.MovetoStart());
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_tipsPanel.MovetoStart());
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MatchLosePanel::<HideTips>b__22_0()));
        return val_1;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public MatchLosePanel()
    {
        this.typeDataList = new System.Collections.Generic.List<LoadingPanelTypeData>();
    }
    private void <SetupCharacters>b__15_0(CharacterAssetLoader loader)
    {
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        this.m_leftCharacter.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPoseCollection().GetPose(result:  val_3.Model.GameResult, isLocalPlayer:  true, isDraw2KoSame:  false);
    }
    private void <SetupCharacters>b__15_1(CharacterAssetLoader loader)
    {
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        this.m_rightCharacter.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPoseCollection().GetPose(result:  val_3.Model.GameResult, isLocalPlayer:  false, isDraw2KoSame:  false);
    }
    private void <HideTips>b__22_0()
    {
        this.bottomText.gameObject.SetActive(value:  false);
    }

}
