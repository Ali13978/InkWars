using UnityEngine;
public class MatchWinPanel : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_dialog;
    private TMPro.TextMeshProUGUI m_dialogText;
    private PostMatchAnimationSettings m_animationSettings;
    private MotionPanelsControler m_leftCharacterAnim;
    private MotionPanelsControler m_rightCharacterAnim;
    
    // Methods
    public void SetupCharacters()
    {
        CharacterNameID val_2;
        CharacterNameID val_5;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        CharacterAssetLoader.Get(id:  val_2, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void MatchWinPanel::<SetupCharacters>b__5_0(CharacterAssetLoader loader)));
        CharacterInfo val_4 = Character_GlobalInfo.GetOpponentPlayer();
        CharacterAssetLoader.Get(id:  val_5, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void MatchWinPanel::<SetupCharacters>b__5_1(CharacterAssetLoader loader)));
    }
    public DG.Tweening.Sequence ShowCharacters(bool showIn)
    {
        this.SetupCharacters();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        if(this.m_leftCharacterAnim == null)
        {
            goto label_3;
        }
        
        if(showIn == false)
        {
            goto label_4;
        }
        
        label_6:
        DG.Tweening.Sequence val_2 = this.m_leftCharacterAnim.MovetoEnd();
        goto label_5;
        label_3:
        if(showIn == true)
        {
            goto label_6;
        }
        
        label_4:
        label_5:
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.m_leftCharacterAnim.MovetoStart());
        if(this.m_rightCharacterAnim == null)
        {
            goto label_7;
        }
        
        if(showIn == false)
        {
            goto label_8;
        }
        
        label_10:
        DG.Tweening.Sequence val_5 = this.m_rightCharacterAnim.MovetoEnd();
        goto label_9;
        label_7:
        if(showIn == true)
        {
            goto label_10;
        }
        
        label_8:
        label_9:
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  this.m_rightCharacterAnim.MovetoStart());
        return val_1;
    }
    public DG.Tweening.Sequence ShowDialog(QuoteData _text)
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.m_dialog.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_dialog.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  this.m_animationSettings.AnimSettings.winnerTextAnim.duration), ease:  this.m_animationSettings.AnimSettings.winnerTextAnim.ease));
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  TextMeshProUGUIEx.DOText(target:  this.m_dialogText, endValue:  _text.quote, duration:  this.m_animationSettings.AnimSettings.quoteTextAnim.duration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0), ease:  this.m_animationSettings.AnimSettings.quoteTextAnim.ease));
        return val_1;
    }
    public DG.Tweening.Sequence HideDialog()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.m_dialog.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  this.m_animationSettings.AnimSettings.winnerTextAnim.duration), ease:  26));
        this.m_dialogText.text = "";
        return val_1;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public MatchWinPanel()
    {
    
    }
    private void <SetupCharacters>b__5_0(CharacterAssetLoader loader)
    {
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        this.m_leftCharacterAnim.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPoseCollection().GetPose(result:  val_3.Model.GameResult, isLocalPlayer:  true, isDraw2KoSame:  false);
    }
    private void <SetupCharacters>b__5_1(CharacterAssetLoader loader)
    {
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        this.m_rightCharacterAnim.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPoseCollection().GetPose(result:  val_3.Model.GameResult, isLocalPlayer:  false, isDraw2KoSame:  false);
    }

}
