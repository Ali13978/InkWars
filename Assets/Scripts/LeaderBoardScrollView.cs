using UnityEngine;
public class LeaderBoardScrollView : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.ScrollRect scrollView;
    private UnityEngine.RectTransform content;
    private LeaderBoardScrollViewItem template;
    private System.Collections.Generic.List<LeaderBoardScrollViewItem> items;
    private System.Collections.Generic.List<ILeaderBoardResponse> dataList;
    private int lastId;
    
    // Methods
    private void Awake()
    {
        this.template.gameObject.SetActive(value:  false);
        do
        {
            LeaderBoardScrollViewItem val_4 = UnityEngine.Object.Instantiate<LeaderBoardScrollViewItem>(original:  this.template, parent:  this.template.transform.parent);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            val_4.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            val_4.gameObject.SetActive(value:  true);
            val_4.Setup(data:  0, place:  0);
            this.items.Add(item:  val_4);
        }
        while((100 - 1) != 0);
        
        this.scrollView.vertical = true;
    }
    private void OnEnable()
    {
    
    }
    private void OnDisable()
    {
    
    }
    public void Reposition()
    {
        this.scrollView.verticalNormalizedPosition = 1f;
    }
    public void Init(System.Collections.Generic.List<ILeaderBoardResponse> source)
    {
        var val_3;
        System.Collections.Generic.List<LeaderBoardScrollViewItem> val_10;
        var val_11;
        val_10 = this.items;
        List.Enumerator<T> val_1 = val_10.GetEnumerator();
        val_11 = 1152921528961029232;
        label_4:
        if(((-1415579936) & 1) == 0)
        {
            goto label_2;
        }
        
        val_3.InitialType.Setup(data:  0, place:  0);
        goto label_4;
        label_2:
        val_3.Add(driver:  public System.Void List.Enumerator<LeaderBoardScrollViewItem>::Dispose(), rectTransform:  null, drivenProperties:  null);
        if(source == null)
        {
                return;
        }
        
        if(source.Count == 0)
        {
                return;
        }
        
        this.dataList = source;
        List.Enumerator<T> val_6 = source.GetEnumerator();
        val_11 = 1152921528961037424;
        int val_10 = 0;
        label_19:
        if(((-1415579960) & 1) == 0)
        {
            goto label_16;
        }
        
        val_10 = 0.InitialType;
        if((-1415579960) < 1)
        {
            goto label_19;
        }
        
        if(val_10 >= this.items.Count)
        {
            goto label_16;
        }
        
        val_10 = val_10 + 1;
        this.items.Item[0].Setup(data:  val_10, place:  val_10);
        goto label_19;
        label_16:
        0.Add(driver:  public System.Void List.Enumerator<ILeaderBoardResponse>::Dispose(), rectTransform:  0, drivenProperties:  null);
        this.Reposition();
    }
    private void OnValueChange(UnityEngine.Vector2 value)
    {
        UnityEngine.Rect val_2 = this.template.GetComponent<UnityEngine.RectTransform>().rect;
        UnityEngine.Vector2 val_3 = this.content.anchoredPosition;
        UnityEngine.Debug.Log(message:  (int)val_3.y / val_2.m_XMin);
    }
    public LeaderBoardScrollView()
    {
        this.items = new System.Collections.Generic.List<LeaderBoardScrollViewItem>();
        this.dataList = new System.Collections.Generic.List<ILeaderBoardResponse>();
    }

}
