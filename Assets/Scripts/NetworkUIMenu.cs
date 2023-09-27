using UnityEngine;
public class NetworkUIMenu : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform m_RectTransform;
    private NetworkUIController.MenuType m_MenuType;
    private NetworkUICharacterAnimation m_CharacterAnimation;
    private float m_CharacterAnimationAnimationDelay;
    private string m_MenuDescription;
    private UnityEngine.AudioClip bgm;
    protected GradientInformation m_BackgroundGradient;
    private System.Collections.IEnumerator m_AnimationWithDelayCoroutine;
    private bool <IsShowing>k__BackingField;
    
    // Properties
    public bool IsShowing { get; set; }
    public NetworkUIController.MenuType Type { get; }
    public string Description { get; }
    
    // Methods
    public bool get_IsShowing()
    {
        return (bool)this.<IsShowing>k__BackingField;
    }
    protected void set_IsShowing(bool value)
    {
        this.<IsShowing>k__BackingField = value;
    }
    private void Awake()
    {
        var val_5;
        if(0 == this.m_RectTransform)
        {
                this.m_RectTransform = this.GetComponent<UnityEngine.RectTransform>();
        }
        
        if(LoadingScreenController.isShowing == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        LoadingScreenController.OnFlyOutDone.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void NetworkUIMenu::AnimateCharacters()));
    }
    public void Show()
    {
        UnityEngine.Object val_5;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.m_RectTransform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        if(this.m_MenuType != 2)
        {
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.AnimateWithDelay(_delay:  val_1.x));
        }
        
        val_5 = this.bgm;
        if(0 != val_5)
        {
                val_5 = 0;
            GameAudio.SwitchMusic(clip:  this.bgm, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        }
        
        this.<IsShowing>k__BackingField = true;
        goto typeof(NetworkUIMenu).__il2cppRuntimeField_168;
    }
    protected virtual void OnShow()
    {
    
    }
    private void AnimateCharacters()
    {
        if(0 == this.m_CharacterAnimation)
        {
                return;
        }
        
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_2 = this.AnimateWithDelay(_delay:  null);
        this.m_AnimationWithDelayCoroutine = val_2;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_2);
    }
    private System.Collections.IEnumerator AnimateWithDelay(float _delay)
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new NetworkUIMenu.<AnimateWithDelay>d__16();
    }
    public void Hide()
    {
        this.<IsShowing>k__BackingField = false;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.m_RectTransform.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        goto typeof(NetworkUIMenu).__il2cppRuntimeField_178;
    }
    protected virtual void OnHide()
    {
    
    }
    public NetworkUIController.MenuType get_Type()
    {
        return (MenuType)this.m_MenuType;
    }
    public string get_Description()
    {
        return (string)this.m_MenuDescription;
    }
    public void ApplyGradientToMaterial(UnityEngine.Material _material)
    {
        this.m_BackgroundGradient.ApplyPropertiesToMaterial(_material:  _material);
    }
    private void OnValidate()
    {
        if(this.m_BackgroundGradient.Brightness >= 0)
        {
                return;
        }
        
        this = this.m_BackgroundGradient;
        this.m_BackgroundGradient.Brightness = 1f;
    }
    public NetworkUIMenu()
    {
    
    }

}
