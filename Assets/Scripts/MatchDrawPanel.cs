using UnityEngine;
public class MatchDrawPanel : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI m_messageBox;
    private PostMatchAnimationSettings m_animationSettings;
    private MotionPanelsControler m_leftCharacter;
    private MotionPanelsControler m_rightCharacter;
    
    // Methods
    public void SetupCharacters()
    {
        CharacterNameID val_2;
        CharacterNameID val_5;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        CharacterAssetLoader.Get(id:  val_2, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void MatchDrawPanel::<SetupCharacters>b__4_0(CharacterAssetLoader loader)));
        CharacterInfo val_4 = Character_GlobalInfo.GetOpponentPlayer();
        CharacterAssetLoader.Get(id:  val_5, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  this, method:  System.Void MatchDrawPanel::<SetupCharacters>b__4_1(CharacterAssetLoader loader)));
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
    public DG.Tweening.Sequence ShowDialog(QuoteData _text)
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.m_messageBox.text = "";
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  TextMeshProUGUIEx.DOText(target:  this.m_messageBox, endValue:  _text.quote, duration:  this.m_animationSettings.AnimSettings.quoteTextAnim.duration, richTextEnabled:  true, scrambleMode:  0, scrambleChars:  0), ease:  this.m_animationSettings.AnimSettings.quoteTextAnim.ease));
        return val_1;
    }
    public DG.Tweening.Sequence HideDialog()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void MatchDrawPanel::<HideDialog>b__7_0()));
        return val_1;
    }
    public void Reset()
    {
        DG.Tweening.Sequence val_1 = this.HideDialog();
    }
    public MatchDrawPanel()
    {
    
    }
    private void <SetupCharacters>b__4_0(CharacterAssetLoader loader)
    {
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        this.m_leftCharacter.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPoseCollection().GetPose(result:  val_3.Model.GameResult, isLocalPlayer:  true, isDraw2KoSame:  true);
    }
    private void <SetupCharacters>b__4_1(CharacterAssetLoader loader)
    {
        InkWars.Model.Model_Manager val_3 = InkWars.Model.Model_Manager.Instance;
        this.m_rightCharacter.GetComponent<UnityEngine.UI.Image>().sprite = loader.LoadPoseCollection().GetPose(result:  val_3.Model.GameResult, isLocalPlayer:  false, isDraw2KoSame:  true);
    }
    private void <HideDialog>b__7_0()
    {
        this.m_messageBox.text = "";
    }

}
