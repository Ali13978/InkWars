using UnityEngine;
public class CanvasSwitcher : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Canvas> m_ToBeEnabled;
    private System.Collections.Generic.List<UnityEngine.Canvas> m_ToBeDisabled;
    private bool m_isAnimationOn;
    private UnityEngine.UI.Button m_controlButton;
    private UnityEngine.UI.Toggle m_controlToggleButton;
    private DG.Tweening.Tweener fadeAnim;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_8;
        if(0 != this.m_controlButton)
        {
                UnityEngine.Events.UnityAction val_3 = null;
            val_8 = val_3;
            val_3 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CanvasSwitcher::OnControlButtonCliked());
            this.m_controlButton.onClick.AddListener(call:  val_3);
        }
        
        if(0 == this.m_controlToggleButton)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction<System.Boolean> val_5 = null;
        val_8 = val_5;
        val_5 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void CanvasSwitcher::<OnEnable>b__6_0(bool <p0>));
        this.m_controlToggleButton.onValueChanged.AddListener(call:  val_5);
        if(this.m_controlToggleButton.isOn == false)
        {
                return;
        }
        
        MainThreadDispatcher.Invoke(action:  new System.Action(object:  this, method:  System.Void CanvasSwitcher::OnControlButtonCliked()), delay:  0.1f);
    }
    private void OnDisable()
    {
        if(0 != this.m_controlButton)
        {
                this.m_controlButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void CanvasSwitcher::OnControlButtonCliked()));
        }
        
        if(0 == this.m_controlToggleButton)
        {
                return;
        }
        
        this.m_controlToggleButton.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  System.Void CanvasSwitcher::<OnDisable>b__7_0(bool <p0>)));
    }
    private void OnControlButtonCliked()
    {
        this.EnableCanvas();
        this.DisableCanvas();
        GameAudio.PlayButtonSound();
    }
    private void DisableCanvas()
    {
        var val_6;
        System.Collections.Generic.List<UnityEngine.Canvas> val_8;
        val_6 = null;
        val_6 = null;
        if((CanvasSwitcher.<>c.<>9__9_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        int val_1 = this.m_ToBeDisabled.RemoveAll(match:  CanvasSwitcher.<>c.<>9__9_0);
        val_8 = this.m_ToBeDisabled;
        List.Enumerator<T> val_2 = val_8.GetEnumerator();
        label_9:
        if(((-1676998984) & 1) == 0)
        {
            goto label_6;
        }
        
        0.InitialType.gameObject.SetActive(value:  false);
        goto label_9;
        label_3:
        CanvasSwitcher.<>c.<>9__9_0 = new System.Predicate<UnityEngine.Canvas>(object:  CanvasSwitcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CanvasSwitcher.<>c::<DisableCanvas>b__9_0(UnityEngine.Canvas x));
        if(this.m_ToBeDisabled != null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_6:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.Canvas>::Dispose(), rectTransform:  public System.Int32 System.Collections.Generic.List<UnityEngine.Canvas>::RemoveAll(System.Predicate<T> match), drivenProperties:  null);
    }
    private void EnableCanvas()
    {
        var val_4;
        System.Collections.Generic.List<UnityEngine.Canvas> val_16;
        var val_17;
        System.Predicate<UnityEngine.Canvas> val_19;
        UnityEngine.RectTransform val_20;
        var val_22;
        var val_23;
        val_16 = this;
        if(this.m_isAnimationOn == false)
        {
            goto label_27;
        }
        
        val_17 = null;
        val_17 = null;
        val_19 = CanvasSwitcher.<>c.<>9__10_0;
        if(val_19 == null)
        {
            goto label_4;
        }
        
        label_20:
        val_20 = public System.Int32 System.Collections.Generic.List<UnityEngine.Canvas>::RemoveAll(System.Predicate<T> match);
        int val_1 = this.m_ToBeEnabled.RemoveAll(match:  val_19);
        List.Enumerator<T> val_2 = this.m_ToBeEnabled.GetEnumerator();
        val_22 = 1152921528699623472;
        goto label_13;
        label_15:
        System.Type val_5 = val_4.InitialType;
        val_19 = val_5.gameObject;
        val_19.SetActive(value:  true);
        UnityEngine.CanvasGroup val_7 = val_5.GetComponentInChildren<UnityEngine.CanvasGroup>();
        val_20 = 0;
        if(0 != val_7)
        {
                val_7.alpha = 0f;
            this.fadeAnim = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_7, endValue:  1f, duration:  1f);
        }
        
        label_13:
        if(((-1676814304) & 1) != 0)
        {
            goto label_15;
        }
        
        goto label_33;
        label_4:
        CanvasSwitcher.<>c.<>9__10_0 = new System.Predicate<UnityEngine.Canvas>(object:  CanvasSwitcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CanvasSwitcher.<>c::<EnableCanvas>b__10_0(UnityEngine.Canvas x));
        if(this.m_ToBeEnabled != null)
        {
            goto label_20;
        }
        
        goto label_20;
        label_27:
        val_22 = 1152921505120743424;
        val_23 = null;
        val_23 = null;
        if((CanvasSwitcher.<>c.<>9__10_1) == null)
        {
            goto label_30;
        }
        
        label_40:
        val_20 = public System.Int32 System.Collections.Generic.List<UnityEngine.Canvas>::RemoveAll(System.Predicate<T> match);
        int val_11 = this.m_ToBeEnabled.RemoveAll(match:  CanvasSwitcher.<>c.<>9__10_1);
        val_16 = this.m_ToBeEnabled;
        List.Enumerator<T> val_12 = val_16.GetEnumerator();
        val_19 = 1152921528699623472;
        label_36:
        if(((-1676814304) & 1) == 0)
        {
            goto label_33;
        }
        
        val_4.InitialType.gameObject.SetActive(value:  true);
        goto label_36;
        label_30:
        CanvasSwitcher.<>c.<>9__10_1 = new System.Predicate<UnityEngine.Canvas>(object:  CanvasSwitcher.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CanvasSwitcher.<>c::<EnableCanvas>b__10_1(UnityEngine.Canvas x));
        if(this.m_ToBeEnabled != null)
        {
            goto label_40;
        }
        
        goto label_40;
        label_33:
        val_4.Add(driver:  public System.Void List.Enumerator<UnityEngine.Canvas>::Dispose(), rectTransform:  val_20, drivenProperties:  null);
    }
    public CanvasSwitcher()
    {
    
    }
    private void <OnEnable>b__6_0(bool <p0>)
    {
        this.OnControlButtonCliked();
    }
    private void <OnDisable>b__7_0(bool <p0>)
    {
        this.OnControlButtonCliked();
    }

}
