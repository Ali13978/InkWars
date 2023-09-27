using UnityEngine;
public class OnMouseOverPurchaseBubble : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
    // Fields
    private UnityEngine.UI.Image purchaseBubble;
    private UnityEngine.Transform parent;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
    {
        bool val_3 = UnityEngine.Object.op_Equality(x:  eventData.pointerEnter, y:  this.gameObject);
        UnityEngine.GameObject val_4 = this.purchaseBubble.gameObject;
        if(val_4 == null)
        {
            goto label_5;
        }
        
        if(val_3 == false)
        {
            goto label_6;
        }
        
        label_12:
        val_4.SetActive(value:  true);
        UnityEngine.Vector2 val_6 = eventData.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        this.purchaseBubble.GetComponent<UnityEngine.RectTransform>().position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        return;
        label_5:
        if(val_3 == true)
        {
            goto label_12;
        }
        
        label_6:
        val_4.SetActive(value:  false);
    }
    private void OnMouseOver()
    {
        this.purchaseBubble.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_3 = this.purchaseBubble.GetComponent<UnityEngine.Transform>().localPosition;
        this.purchaseBubble.GetComponent<UnityEngine.Transform>().position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    private void OnMouseEnter()
    {
        this.purchaseBubble.gameObject.SetActive(value:  true);
        UnityEngine.Vector3 val_3 = this.purchaseBubble.GetComponent<UnityEngine.Transform>().localPosition;
        this.purchaseBubble.GetComponent<UnityEngine.Transform>().position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    private void OnMouseExit()
    {
        this.purchaseBubble.gameObject.SetActive(value:  false);
    }
    public OnMouseOverPurchaseBubble()
    {
    
    }

}
