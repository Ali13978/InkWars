using UnityEngine;
public class DisableSelection : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup m_canvasGroup;
    
    // Methods
    private void Update()
    {
        if((this.GetComponent<UnityEngine.UI.Toggle>().isOn) == false)
        {
                return;
        }
        
        this.m_canvasGroup.alpha = 0.2f;
    }
    private void OnEnable()
    {
        UnityEngine.UI.Toggle val_1 = this.GetComponent<UnityEngine.UI.Toggle>();
        val_1.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void DisableSelection::<OnEnable>b__2_0(bool <p0>)));
    }
    private void OnDisable()
    {
        if(0 == (this.GetComponent<UnityEngine.UI.Toggle>()))
        {
                return;
        }
        
        val_1.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void DisableSelection::<OnDisable>b__3_0(bool <p0>)));
    }
    private void OnToggleValueChanged()
    {
        UnityEngine.CanvasGroup val_5;
        if((this.GetComponent<UnityEngine.UI.Toggle>().isOn) != false)
        {
                this.GetComponent<UnityEngine.UI.Toggle>().interactable = false;
            val_5 = this.m_canvasGroup;
        }
        else
        {
                val_5 = this.m_canvasGroup;
        }
        
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_5, endValue:  1f, duration:  0.5f);
    }
    public DisableSelection()
    {
    
    }
    private void <OnEnable>b__2_0(bool <p0>)
    {
        this.OnToggleValueChanged();
    }
    private void <OnDisable>b__3_0(bool <p0>)
    {
        this.OnToggleValueChanged();
    }

}
