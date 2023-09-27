using UnityEngine;
public class PopupCanvas<T> : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    protected static T _inst;
    
    // Properties
    protected static T instance { get; }
    
    // Methods
    protected static T get_instance()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_5 & 1) == 0)
        {
                val_5 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if(0 == (__RuntimeMethodHiddenParam + 24 + 192 + 184))
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_6 = __RuntimeMethodHiddenParam + 24 + 294;
            val_7 = __RuntimeMethodHiddenParam + 24;
            if((val_6 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24];
            val_7 = __RuntimeMethodHiddenParam + 24;
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_6 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_8 = __RuntimeMethodHiddenParam + 24 + 294;
            val_9 = __RuntimeMethodHiddenParam + 24;
            if((val_8 & 1) == 0)
        {
                val_9 = mem[__RuntimeMethodHiddenParam + 24];
            val_9 = __RuntimeMethodHiddenParam + 24;
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_8 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
            val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
            if((val_10 & 1) == 0)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_10 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
            mem2[0] = "DynamicUI/"("DynamicUI/") + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 16}));
            __RuntimeMethodHiddenParam + 24 + 192 + 184.gameObject.SetActive(value:  false);
        }
        
        val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_11 & 1) == 0)
        {
                val_11 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_11 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 294) & 1) != 0)
        {
                return (InfoCanvas)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        
        return (InfoCanvas)__RuntimeMethodHiddenParam + 24 + 192 + 184;
    }
    public static void Show()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_2 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_3 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_3 = __RuntimeMethodHiddenParam + 24 + 294;
        val_4 = __RuntimeMethodHiddenParam + 24;
        if((val_3 & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24];
            val_4 = __RuntimeMethodHiddenParam + 24;
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_3 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        DialogManager.ShowCustomDialog(dialog:  __RuntimeMethodHiddenParam + 24 + 192 + 40.GetComponent<UnityEngine.RectTransform>());
    }
    protected virtual void OnEnable()
    {
        var val_14;
        DG.Tweening.TweenCallback val_15;
        var val_16;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        val_14 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 48 + 294];
        val_14 = __RuntimeMethodHiddenParam + 24 + 192 + 48 + 294;
        if((val_14 & 1) == 0)
        {
                val_14 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 48 + 294];
            val_14 = __RuntimeMethodHiddenParam + 24 + 192 + 48 + 294;
        }
        
        val_15 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 48 + 184 + 8];
        val_15 = __RuntimeMethodHiddenParam + 24 + 192 + 48 + 184 + 8;
        if(val_15 == 0)
        {
                val_16 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 48 + 294];
            val_16 = __RuntimeMethodHiddenParam + 24 + 192 + 48 + 294;
            if((val_16 & 1) == 0)
        {
                val_16 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 48 + 294];
            val_16 = __RuntimeMethodHiddenParam + 24 + 192 + 48 + 294;
        }
        
            DG.Tweening.TweenCallback val_4 = null;
            val_15 = val_4;
            val_4 = new DG.Tweening.TweenCallback(object:  __RuntimeMethodHiddenParam + 24 + 192 + 48 + 184, method:  __RuntimeMethodHiddenParam + 24 + 192 + 56);
            mem2[0] = val_15;
        }
        
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_3, callback:  val_4);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  val_3, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  0.5f), ease:  27)), isIndependentUpdate:  true);
        val_3.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 64));
    }
    protected virtual void OnDisable()
    {
        onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 64));
    }
    public void ClosePopup()
    {
        if(this == null)
        {
            
        }
    
    }
    public DG.Tweening.Sequence Close()
    {
        GameAudio.PlayButtonSound();
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.5f), ease:  26)), isIndependentUpdate:  true);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_1, action:  new DG.Tweening.TweenCallback(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 80));
        return val_1;
    }
    public PopupCanvas<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    private static PopupCanvas<T>()
    {
    
    }
    private void <Close>b__8_0()
    {
        UnityEngine.Time.timeScale = 1f;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
