using UnityEngine;
public class AnimationPreviewer : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Dropdown DD_Animation;
    public UnityEngine.UI.Dropdown DD_CharID;
    public CharAnimationController_Physical animController;
    public UnityEngine.UI.Image imagePreview;
    public UnityEngine.UI.Text phoneDebugText;
    private int indexIdle;
    
    // Methods
    private void Start()
    {
        int val_12;
        var val_13;
        this.DD_Animation.ClearOptions();
        this.DD_CharID.ClearOptions();
        this.indexIdle = 0;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_12 = 0;
        goto label_7;
        label_13:
        val_1.Add(item:  System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))[0]);
        if((System.String.op_Equality(a:  val_3[0x0] + 32, b:  "IDLE")) != false)
        {
                this.indexIdle = val_12;
        }
        
        val_12 = 1;
        label_7:
        if(val_12 < val_3.Length)
        {
            goto label_13;
        }
        
        this.DD_Animation.AddOptions(options:  val_1);
        System.Collections.Generic.List<System.String> val_5 = new System.Collections.Generic.List<System.String>();
        val_13 = 0;
        goto label_19;
        label_23:
        val_5.Add(item:  System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = 1152921525169714464}))[0]);
        val_13 = 1;
        label_19:
        if(val_13 < val_7.Length)
        {
            goto label_23;
        }
        
        this.DD_CharID.AddOptions(options:  val_5);
        this.DD_CharID.value = val_7.Length - 2;
        this.animController.RetrieveCharacterBundle(charNameID:  this.DD_CharID.value);
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.animController.LoadAnimations_Gameplay());
        this.DD_Animation.value = this.indexIdle;
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  114)) != false)
        {
                this.Button_PlayFromStart();
        }
        
        string val_3 = CharBundleManager.GetInstance().GetBundlePath(charID:  0);
        if(this.phoneDebugText == null)
        {
            
        }
    
    }
    public void Change_Animation()
    {
        this.animController.PlayAnimation(newAnimName:  this.DD_Animation.value, forceOverride:  true);
    }
    public void Change_Character()
    {
        this.animController.RetrieveCharacterBundle(charNameID:  this.DD_CharID.value);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.animController.LoadAnimations_Gameplay());
        this.DD_Animation.value = this.indexIdle;
    }
    public void Button_PlayFromStart()
    {
        this.animController.PlayAnimation(newAnimName:  this.DD_Animation.value, forceOverride:  true);
    }
    public void Button_ReloadCharacter()
    {
        this.animController.RetrieveCharacterBundle(charNameID:  this.DD_CharID.value);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.animController.LoadAnimations_Gameplay());
        this.DD_Animation.value = this.indexIdle;
    }
    public AnimationPreviewer()
    {
    
    }

}
