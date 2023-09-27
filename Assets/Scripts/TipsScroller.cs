using UnityEngine;
public class TipsScroller : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI m_title;
    private System.Collections.Generic.List<string> m_titleList;
    private System.Collections.Generic.List<UnityEngine.UI.Image> m_tipsList;
    private UnityEngine.UI.Button m_close;
    private UnityEngine.UI.Button m_right;
    private UnityEngine.UI.Button m_left;
    private UnityEngine.GameObject parentPanel;
    public int m_index;
    
    // Properties
    public int Index { get; set; }
    
    // Methods
    public int get_Index()
    {
        return (int)this.m_index;
    }
    public void set_Index(int value)
    {
        this.m_index = value;
        this.EnableTip(ind:  value);
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_9;
        UnityEngine.Events.UnityAction val_2 = null;
        val_9 = val_2;
        val_2 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TipsScroller::Close());
        this.m_close.onClick.AddListener(call:  val_2);
        if(0 != this.m_right)
        {
                UnityEngine.Events.UnityAction val_5 = null;
            val_9 = val_5;
            val_5 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TipsScroller::OnClickRight());
            this.m_right.onClick.AddListener(call:  val_5);
        }
        
        if(0 != this.m_left)
        {
                UnityEngine.Events.UnityAction val_8 = null;
            val_9 = val_8;
            val_8 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TipsScroller::OnClickLeft());
            this.m_left.onClick.AddListener(call:  val_8);
        }
        
        this.EnableTip(ind:  this.m_index);
    }
    private void OnDisable()
    {
        UnityEngine.Events.UnityAction val_9;
        UnityEngine.Events.UnityAction val_2 = null;
        val_9 = val_2;
        val_2 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TipsScroller::Close());
        this.m_close.onClick.RemoveListener(call:  val_2);
        if(0 != this.m_right)
        {
                UnityEngine.Events.UnityAction val_5 = null;
            val_9 = val_5;
            val_5 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TipsScroller::OnClickRight());
            this.m_right.onClick.RemoveListener(call:  val_5);
        }
        
        if(0 == this.m_left)
        {
                return;
        }
        
        this.m_left.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TipsScroller::OnClickLeft()));
    }
    private void Close()
    {
        this.m_index = 0;
    }
    private void EnableTip(int ind)
    {
        var val_6 = null;
        if((TipsScroller.<>c.<>9__14_0) == null)
        {
            goto label_3;
        }
        
        label_13:
        this.m_tipsList.ForEach(action:  TipsScroller.<>c.<>9__14_0);
        this.m_tipsList.Item[ind].gameObject.SetActive(value:  true);
        this.m_title.text = LanguageManager.GetText(key:  this.m_titleList.Item[ind]);
        LanguageManager.InvokeLanguageChage();
        return;
        label_3:
        TipsScroller.<>c.<>9__14_0 = new System.Action<UnityEngine.UI.Image>(object:  TipsScroller.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TipsScroller.<>c::<EnableTip>b__14_0(UnityEngine.UI.Image x));
        if(this.m_tipsList != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    private void OnClickRight()
    {
        int val_3 = this.m_index;
        val_3 = val_3 + 1;
        this.m_index = val_3;
        this.m_left.interactable = true;
        if(this.m_index > (this.m_titleList.Count - 2))
        {
                this.m_right.interactable = false;
        }
        
        this.EnableTip(ind:  this.m_index);
    }
    private void OnClickLeft()
    {
        int val_1;
        int val_1 = this.m_index;
        val_1 = val_1 - 1;
        this.m_index = val_1;
        this.m_right.interactable = true;
        val_1 = this.m_index;
        if(val_1 <= 0)
        {
                this.m_left.interactable = false;
            val_1 = this.m_index;
        }
        
        this.EnableTip(ind:  val_1);
    }
    public TipsScroller()
    {
    
    }

}
