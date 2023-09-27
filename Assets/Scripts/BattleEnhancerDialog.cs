using UnityEngine;
public class BattleEnhancerDialog : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI titleTxt;
    private TMPro.TextMeshProUGUI itemNameTxt;
    private TMPro.TextMeshProUGUI messageTxt;
    private TMPro.TextMeshProUGUI yellowButtonTitleTxt;
    private TMPro.TextMeshProUGUI grayButtonTitleTxt;
    private UnityEngine.UI.Button yellowButton;
    private UnityEngine.UI.Button grayButton;
    
    // Methods
    public static void Show(string title, string name, string message, string yellowButtonTitle, string grayButtonTitle, UnityEngine.Events.UnityAction onYellowButton, UnityEngine.Events.UnityAction onGrayButton)
    {
        BattleEnhancerDialog val_2 = UnityEngine.Object.Instantiate<BattleEnhancerDialog>(original:  UnityEngine.Resources.Load<BattleEnhancerDialog>(path:  "DynamicUI/BattleEnhancerDialog"));
        if(val_2 != null)
        {
                val_2.Setup(title:  title, name:  name, message:  message, yellowButtonTitle:  yellowButtonTitle, grayButtonTitle:  grayButtonTitle, onYellowButton:  onYellowButton, onGrayButton:  onGrayButton);
        }
        else
        {
                val_2.Setup(title:  title, name:  name, message:  message, yellowButtonTitle:  yellowButtonTitle, grayButtonTitle:  grayButtonTitle, onYellowButton:  onYellowButton, onGrayButton:  onGrayButton);
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  val_2.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    public void Setup(string title, string name, string message, string yellowButtonTitle, string grayButtonTitle, UnityEngine.Events.UnityAction onYellowButton, UnityEngine.Events.UnityAction onGrayButton)
    {
        this.titleTxt.text = title;
        this.itemNameTxt.text = name;
        this.messageTxt.text = message;
        this.yellowButtonTitleTxt.text = yellowButtonTitle;
        this.grayButtonTitleTxt.text = grayButtonTitle;
        this.yellowButton.onClick.RemoveAllListeners();
        this.grayButton.onClick.RemoveAllListeners();
        this.yellowButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerDialog::OnClose()));
        this.grayButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BattleEnhancerDialog::OnClose()));
        this.yellowButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void GameAudio::PlayButtonSound()));
        this.grayButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  0, method:  public static System.Void GameAudio::PlayButtonSound()));
        if(onYellowButton != null)
        {
                this.yellowButton.onClick.AddListener(call:  onYellowButton);
        }
        
        if(onGrayButton == null)
        {
                return;
        }
        
        this.grayButton.onClick.AddListener(call:  onGrayButton);
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  27);
    }
    private void OnClose()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void BattleEnhancerDialog::<OnClose>b__10_0()));
    }
    public BattleEnhancerDialog()
    {
    
    }
    private void <OnClose>b__10_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
