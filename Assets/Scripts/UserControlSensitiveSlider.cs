using UnityEngine;
public class UserControlSensitiveSlider : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip sound;
    private UnityEngine.UI.Slider targetSlider;
    private float startValue;
    
    // Methods
    private void Awake()
    {
        float val_3;
        int val_4;
        var val_6;
        UnityEngine.UI.Slider val_1 = this.GetComponent<UnityEngine.UI.Slider>();
        this.targetSlider = val_1;
        val_1.maxValue = 1f;
        this.targetSlider.minValue = -0.5f;
        this.targetSlider.direction = 1;
        val_6 = null;
        val_6 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_2 = DataStructs.UserDataDictionary.Settings.ControllerSensitivity;
        float val_5 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = val_4, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_4, b2 = val_4, b3 = val_4, b4 = val_4}, hiddenValueOld = val_4, fakeValue = val_3, inited = val_3});
        this.InitEventTrigger();
    }
    private void InitEventTrigger()
    {
        UnityEngine.EventSystems.EventTrigger val_8 = this.GetComponent<UnityEngine.EventSystems.EventTrigger>();
        if(0 == val_8)
        {
                val_8 = this.gameObject.AddComponent<UnityEngine.EventSystems.EventTrigger>();
        }
        
        EventTrigger.Entry val_5 = new EventTrigger.Entry();
        if(val_5 != null)
        {
                .eventID = 3;
        }
        else
        {
                mem[16] = 3;
        }
        
        UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData> val_6 = 39779392;
        val_6 = new UnityEngine.Events.UnityAction<UnityEngine.EventSystems.BaseEventData>(object:  this, method:  System.Void UserControlSensitiveSlider::<InitEventTrigger>b__4_0(UnityEngine.EventSystems.BaseEventData data));
        (EventTrigger.Entry)[1152921529073112000].callback.AddListener(call:  val_6);
        val_8.triggers.Add(item:  val_5);
    }
    public UserControlSensitiveSlider()
    {
    
    }
    private void <InitEventTrigger>b__4_0(UnityEngine.EventSystems.BaseEventData data)
    {
        float val_2;
        int val_3;
        UnityEngine.AudioClip val_7;
        var val_8;
        val_7 = this;
        val_8 = null;
        val_8 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  V0.16B);
        DataStructs.UserDataDictionary.Settings.ControllerSensitivity = new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {currentCryptoKey = val_3, hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4() {b1 = val_3, b2 = val_3, b3 = val_3, b4 = val_3}, hiddenValueOld = val_3, fakeValue = val_2, inited = val_2};
        if(0 == this.sound)
        {
                return;
        }
        
        val_7 = this.sound;
        UnityEngine.AudioSource val_6 = GameAudio.sound.PlayOneShot(clip:  val_7, volume:  1f);
    }

}
