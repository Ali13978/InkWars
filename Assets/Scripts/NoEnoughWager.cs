using UnityEngine;
public class NoEnoughWager : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private TMPro.TextMeshProUGUI message;
    
    // Methods
    public static NoEnoughWager Show(string msg1)
    {
        NoEnoughWager val_2 = UnityEngine.Object.Instantiate<NoEnoughWager>(original:  UnityEngine.Resources.Load<NoEnoughWager>(path:  "DynamicUI/NoEnoughWager"));
        if(val_2 != null)
        {
                val_2.Setup(msg1:  msg1);
        }
        else
        {
                val_2.Setup(msg1:  msg1);
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  val_2.GetComponent<UnityEngine.RectTransform>(), scale:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        GameAudio.PlayButtonSound();
        return val_2;
    }
    public void Setup(string msg1)
    {
        this.message.text = msg1;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  27);
        this.closeButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void NoEnoughWager::Close()));
    }
    private void OnDisable()
    {
        this.closeButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void NoEnoughWager::Close()));
    }
    public void Close()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void NoEnoughWager::<Close>b__6_0()));
    }
    public NoEnoughWager()
    {
    
    }
    private void <Close>b__6_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
