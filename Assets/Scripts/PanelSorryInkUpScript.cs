using UnityEngine;
public class PanelSorryInkUpScript : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject image;
    public UnityEngine.GameObject inkMeter;
    public UnityEngine.GameObject wrongCross;
    private UnityEngine.GameObject cross;
    public UnityEngine.UI.Text messageText;
    public string messageFormat;
    
    // Methods
    public void OnEnable()
    {
        CharacterNameID val_2;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        if(0 == this.messageText)
        {
                return;
        }
        
        val_2 = CharacterHelper.GetMinBubbleCountForInkSequence(winnerId:  val_2);
        this = System.String.Format(format:  this.messageFormat, arg0:  val_2);
    }
    public void onStartWrongArrow()
    {
        UnityEngine.Vector3 val_2 = this.inkMeter.transform.localPosition;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.wrongCross, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        this.cross = val_4;
        val_4.transform.SetParent(parent:  this.image.transform, worldPositionStays:  false);
    }
    public void onTickButtonDown()
    {
        UnityEngine.Time.timeScale = 1f;
        this.gameObject.SetActive(value:  false);
    }
    public PanelSorryInkUpScript()
    {
        this.messageFormat = "you need at least {0} bubbles to ink your opponent";
    }

}
