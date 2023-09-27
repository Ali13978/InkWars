using UnityEngine;
public class FirstTimeJumpingButton : MonoBehaviour
{
    // Fields
    private DG.Tweening.Tweener anim;
    private FirstTimeJumpingButton.JumpingButtonKey key;
    private UnityEngine.UI.Button button;
    private float time;
    private UnityEngine.Vector3 originalScale;
    
    // Properties
    private string flagKey { get; }
    
    // Methods
    private string get_flagKey()
    {
        this.key.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        mem2[0] = null;
        return "IS_" + this.key.ToString() + "_CLICKED";
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_2 = this.transform.localScale;
        this.originalScale = val_2;
        mem[1152921528942340264] = val_2.y;
        mem[1152921528942340268] = val_2.z;
    }
    private void OnEnable()
    {
        string val_16;
        var val_17;
        DataStructs.GameSave val_18;
        if(this.anim != null)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.anim, complete:  false);
        }
        
        if(this.key == 0)
        {
                return;
        }
        
        val_16 = 1152921505151520768;
        val_17 = null;
        val_17 = null;
        val_18 = DataStructs.UserDataDictionary.GameSave;
        if(val_18 == null)
        {
                return;
        }
        
        val_18 = DataStructs.UserDataDictionary.GameSave;
        val_16 = this.flagKey;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_4 = val_18.GetGameSaveFlags(key:  val_16, defaultValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        val_4.fakeValue = val_4.fakeValue & 4294967295;
        if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_4.currentCryptoKey, hiddenValue = val_4.hiddenValue, fakeValue = val_4.fakeValue, fakeValueChanged = val_4.fakeValue, inited = val_4.fakeValue})) != false)
        {
                if(this.key != 4)
        {
                return;
        }
        
        }
        
        if(0 != this.button)
        {
                UnityEngine.Events.UnityAction val_8 = null;
            val_16 = val_8;
            val_8 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FirstTimeJumpingButton::OnButtonClick());
            this.button.onClick.AddListener(call:  val_8);
        }
        
        this.transform.localScale = new UnityEngine.Vector3() {x = this.originalScale, y = V9.16B, z = V10.16B};
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  0.2f);
        this.anim = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.transform, punch:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  this.time, vibrato:  1, elasticity:  1f), loops:  0, loopType:  1), ease:  27);
    }
    private void OnDisable()
    {
        if(0 != this.button)
        {
                this.button.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FirstTimeJumpingButton::OnButtonClick()));
        }
        
        if(this.anim == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.anim, complete:  false);
    }
    private void OnButtonClick()
    {
        var val_5;
        if(this.key != 4)
        {
                val_5 = null;
            val_5 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  true);
            DataStructs.UserDataDictionary.GameSave.SetGameSaveFlags(key:  this.flagKey, aNewValue:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue & 4294967295, fakeValueChanged = val_2.fakeValue & 4294967295, inited = val_2.fakeValue & 4294967295});
        }
        
        this.transform.localScale = new UnityEngine.Vector3() {x = this.originalScale, y = V9.16B, z = V10.16B};
        if(this.anim == null)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.anim, complete:  false);
    }
    public FirstTimeJumpingButton()
    {
        this.time = 1f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.originalScale = val_1;
        mem[1152921528942973608] = val_1.y;
        mem[1152921528942973612] = val_1.z;
    }

}
