using UnityEngine;
public class UnlockButtonShare : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Slider progressBar;
    public UnityEngine.UI.Text countTxt;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.UI.Slider val_15;
        var val_16;
        int val_17;
        var val_18;
        val_15 = this;
        if(0 != this.countTxt)
        {
                val_16 = null;
            val_16 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_2 = DataStructs.UserDataDictionary.Stats.ShareScreenCount;
            val_17 = System.String.Format(format:  "{0}/{1}", arg0:  UnityEngine.Mathf.Min(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_2.currentCryptoKey, hiddenValue = val_2.hiddenValue, fakeValue = val_2.fakeValue, inited = val_2.inited}), b:  ShareScreenButton.SHARE_UNLOCK_COUNT), arg1:  ShareScreenButton.SHARE_UNLOCK_COUNT);
        }
        
        if(0 == this.progressBar)
        {
                return;
        }
        
        val_15 = this.progressBar;
        val_18 = null;
        val_18 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Stats.ShareScreenCount;
        val_17 = ShareScreenButton.SHARE_UNLOCK_COUNT;
        float val_15 = (float)UnityEngine.Mathf.Min(a:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_9.currentCryptoKey, hiddenValue = val_9.hiddenValue, fakeValue = val_9.fakeValue, inited = val_9.inited}), b:  val_17);
        val_15 = val_15 / (float)ShareScreenButton.SHARE_UNLOCK_COUNT;
        float val_14 = UnityEngine.Mathf.Clamp01(value:  val_15);
    }
    public UnlockButtonShare()
    {
    
    }

}
