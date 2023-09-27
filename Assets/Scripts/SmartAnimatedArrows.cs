using UnityEngine;
public class SmartAnimatedArrows : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject m_downArrow;
    private UnityEngine.GameObject m_upArrow;
    private UnityEngine.UI.ScrollRect m_scrollRect;
    private float m_upperLimit;
    private float m_LowerLimit;
    private int maxItemsCount;
    
    // Methods
    public void ResetAnimator(UnityEngine.Animator animator)
    {
        var val_13;
        UnityEngine.AnimatorControllerParameter val_14;
        string val_15;
        string val_16;
        string val_17;
        val_13 = 0;
        goto label_2;
        label_20:
        val_14 = animator.parameters[0];
        UnityEngine.AnimatorControllerParameterType val_2 = val_14.type;
        if(val_2 == 1)
        {
            goto label_5;
        }
        
        if(val_2 == 4)
        {
            goto label_6;
        }
        
        if(val_2 != 3)
        {
            goto label_17;
        }
        
        if(val_14 == null)
        {
            goto label_8;
        }
        
        val_15 = val_14.name;
        goto label_9;
        label_5:
        if(val_14 == null)
        {
            goto label_10;
        }
        
        val_16 = val_14.name;
        goto label_11;
        label_6:
        if(val_14 == null)
        {
            goto label_12;
        }
        
        val_17 = val_14.name;
        goto label_13;
        label_10:
        val_16 = 0.name;
        label_11:
        animator.SetFloat(name:  val_16, value:  val_14.defaultFloat);
        goto label_17;
        label_12:
        val_17 = 0.name;
        label_13:
        val_14 = val_14.defaultBool;
        animator.SetBool(name:  val_17, value:  val_14);
        goto label_17;
        label_8:
        val_15 = 0.name;
        label_9:
        val_14 = val_14.defaultInt;
        animator.SetInteger(name:  val_15, value:  val_14);
        label_17:
        val_13 = 1;
        label_2:
        if(val_13 < val_1.Length)
        {
            goto label_20;
        }
        
        animator.SetTrigger(name:  "Reset");
    }
    private void OnScrolled(UnityEngine.Vector2 pos)
    {
        this.m_downArrow.gameObject.SetActive(value:  false);
        this.m_upArrow.gameObject.SetActive(value:  false);
        if((this.m_scrollRect.content.GetComponent<UnityEngine.RectTransform>().childCount) <= this.maxItemsCount)
        {
                return;
        }
        
        this.m_downArrow.gameObject.SetActive(value:  (pos.x > this.m_LowerLimit) ? 1 : 0);
        this.m_upArrow.gameObject.SetActive(value:  (pos.x < 0) ? 1 : 0);
    }
    private void OnEnable()
    {
        this.m_scrollRect.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  System.Void SmartAnimatedArrows::OnScrolled(UnityEngine.Vector2 pos)));
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  1f);
        this.OnScrolled(pos:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
    }
    private void OnDisable()
    {
        this.m_scrollRect.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  System.Void SmartAnimatedArrows::OnScrolled(UnityEngine.Vector2 pos)));
    }
    public SmartAnimatedArrows()
    {
        this.m_upperLimit = 0.9f;
        this.m_LowerLimit = 7.346868E-41f;
        this.maxItemsCount = 21;
    }

}
