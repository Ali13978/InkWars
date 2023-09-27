using UnityEngine;
public class UnlockButtonInvite : MonoBehaviour
{
    // Fields
    public const int INVITE_UNLOCK_COUNT = 8;
    public UnityEngine.UI.Slider progressBar;
    public UnityEngine.UI.Text countTxt;
    
    // Methods
    private void Awake()
    {
        bool val_2 = UnityEngine.Object.op_Inequality(x:  0, y:  this.GetComponent<UnityEngine.UI.Button>());
    }
    private void OnEnable()
    {
        this.UpdateButtonState(success:  false, info:  null);
    }
    private void OnDisable()
    {
    
    }
    private void UpdateButtonState(bool success, string info)
    {
        UnityEngine.UI.Slider val_11;
        var val_12;
        int val_13;
        var val_14;
        val_11 = this;
        if(0 != this.countTxt)
        {
                val_12 = null;
            val_12 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.InviteCount;
            val_13 = System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Mathf.Min(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}), b:  8), arg1:  8);
        }
        
        if(0 == this.progressBar)
        {
                return;
        }
        
        val_11 = this.progressBar;
        val_14 = null;
        val_14 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_7 = DataStructs.UserDataDictionary.Stats.InviteCount;
        val_13 = val_7.fakeValue;
        float val_11 = (float)UnityEngine.Mathf.Min(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_7.currentCryptoKey, hiddenValue = val_7.hiddenValue, fakeValue = val_13, inited = val_7.inited}), b:  8);
        val_11 = val_11 * 0.125f;
        float val_10 = UnityEngine.Mathf.Clamp01(value:  val_11);
    }
    public UnlockButtonInvite()
    {
    
    }

}
