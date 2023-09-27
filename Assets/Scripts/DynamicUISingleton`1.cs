using UnityEngine;
public class DynamicUISingleton<T> : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Button closeButton;
    private bool canPlayEnterAnim;
    private static DynamicUISingleton<T> _inst;
    
    // Properties
    protected static DynamicUISingleton<T> instance { get; }
    
    // Methods
    protected static DynamicUISingleton<T> get_instance()
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
        
            mem2[0] = "DynamicUI/"("DynamicUI/") + System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8})(System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 8}));
            __RuntimeMethodHiddenParam + 24 + 192 + 184.gameObject.SetActive(value:  false);
            mem2[0] = 1;
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
                return (DynamicUISingleton<T>)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        
        return (DynamicUISingleton<T>)__RuntimeMethodHiddenParam + 24 + 192 + 184;
    }
    public static void Show()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_4 & 1) == 0)
        {
                val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_5 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_5 = __RuntimeMethodHiddenParam + 24 + 294;
        val_6 = __RuntimeMethodHiddenParam + 24;
        if((val_5 & 1) == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24];
            val_6 = __RuntimeMethodHiddenParam + 24;
            val_5 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_5 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        UnityEngine.RectTransform val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 32.GetComponent<UnityEngine.RectTransform>();
        if((DialogManager.HasDialog(dialogRectTransform:  val_1)) != false)
        {
                return;
        }
        
        val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_7 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_7 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
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
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        DialogManager.ShowCustomDialog(dialog:  val_1, scale:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
    }
    public static void Hide()
    {
        var val_1;
        var val_2;
        var val_3;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 294;
        }
        
        val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_2 = __RuntimeMethodHiddenParam + 24 + 294;
        val_3 = __RuntimeMethodHiddenParam + 24;
        if((val_2 & 1) == 0)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 24];
            val_3 = __RuntimeMethodHiddenParam + 24;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_2 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 32) == 0)
        {
            
        }
    
    }
    protected virtual void PlayShowAnim()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  0.5f), ease:  27);
    }
    protected virtual void PlayHideAnim()
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, duration:  0.5f), ease:  26), action:  new DG.Tweening.TweenCallback(object:  this, method:  __RuntimeMethodHiddenParam + 24 + 192 + 56));
    }
    public virtual void Open()
    {
        if(this == null)
        {
            
        }
    
    }
    public virtual void Close()
    {
        GameAudio.PlayButtonSound();
        if(this == null)
        {
            
        }
    
    }
    protected virtual void OnShow()
    {
    
    }
    protected virtual void OnEnable()
    {
        if(0 == static_value_03335000)
        {
                return;
        }
        
        onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(DynamicUISingleton<T>).__il2cppRuntimeField_1A0));
    }
    protected virtual void OnDisable()
    {
        if(0 == static_value_03335000)
        {
                return;
        }
        
        onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  typeof(DynamicUISingleton<T>).__il2cppRuntimeField_1A0));
    }
    public DynamicUISingleton<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    private static DynamicUISingleton<T>()
    {
    
    }
    private void <PlayHideAnim>b__8_0()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }

}
