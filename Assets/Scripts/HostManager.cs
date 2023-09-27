using UnityEngine;
public class HostManager : MonoBehaviour
{
    // Fields
    private static float expireTime;
    private static HostManager _instance;
    public HostTemplate OriginalHostTemplate;
    public UnityEngine.Transform ContentHolder;
    private System.Collections.Generic.Dictionary<string, HostData> Hosts;
    private System.Collections.Generic.List<HostTemplate> HostTemplates;
    private bool isDirty;
    
    // Properties
    public static HostManager instance { get; }
    
    // Methods
    public static HostManager get_instance()
    {
        var val_3;
        HostManager val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = HostManager._instance;
        if(val_4 == 0)
        {
                val_5 = null;
            val_4 = UnityEngine.Object.FindObjectOfType<HostManager>();
            val_5 = null;
            HostManager._instance = val_4;
        }
        else
        {
                val_5 = null;
        }
        
        val_5 = null;
        return (HostManager)HostManager._instance;
    }
    private void Awake()
    {
        this.OriginalHostTemplate.gameObject.SetActive(value:  false);
    }
    public void HostRefreshed(HostData host)
    {
        this.Hosts.set_Item(key:  host.IPAddress, value:  host);
        this.isDirty = true;
    }
    internal void MatchHostRefreshed(UnityEngine.Networking.Match.MatchInfoSnapshot response)
    {
        this.Hosts.Clear();
        UnityEngine.Networking.Types.NetworkID val_1 = response.networkId;
        val_1.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        .PlayerName = response.name.Replace(oldValue:  "INKWARS_", newValue:  "");
        .NetworkID = response.networkId;
        this.Hosts.set_Item(key:  val_1.ToString(), value:  new HostData());
        this.isDirty = true;
    }
    private void FixedUpdate()
    {
        float val_3;
        var val_23;
        bool val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, HostData>, System.String> val_31;
        val_23 = this;
        if(NetworkLobby_Network_Select_Screen.instance.TEST_ONLINE_MODE == false)
        {
            goto label_2;
        }
        
        val_24 = this.isDirty;
        goto label_3;
        label_2:
        List.Enumerator<T> val_2 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<System.String, HostData>>(source:  this.Hosts).GetEnumerator();
        val_25 = 1152921528223556848;
        val_26 = 1152921505087090688;
        val_27 = 1152921528223558896;
        label_12:
        if((2141959040 & 1) == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Playables.PlayableHandle val_5 = val_3.GetHandle();
        float val_6 = UnityEngine.Time.fixedDeltaTime;
        val_6 = val_3 + val_6;
        val_28 = null;
        val_28 = null;
        if(val_6 <= HostManager.expireTime)
        {
            goto label_12;
        }
        
        this.isDirty = true;
        bool val_8 = this.Hosts.Remove(key:  val_5.m_Handle.ToInt64());
        goto label_12;
        label_5:
        val_3.Add(driver:  public System.Void List.Enumerator<System.Collections.Generic.KeyValuePair<System.String, HostData>>::Dispose(), rectTransform:  null, drivenProperties:  null);
        val_24 = this.isDirty;
        label_3:
        if(val_24 == false)
        {
                return;
        }
        
        List.Enumerator<T> val_10 = System.Linq.Enumerable.ToList<HostTemplate>(source:  this.HostTemplates).GetEnumerator();
        label_31:
        if((2141958992 & 1) == 0)
        {
            goto label_26;
        }
        
        System.Type val_11 = val_3.InitialType;
        UnityEngine.Object.Destroy(obj:  val_11.gameObject);
        bool val_13 = this.HostTemplates.Remove(item:  val_11);
        goto label_31;
        label_26:
        val_3.Add(driver:  public System.Void List.Enumerator<HostTemplate>::Dispose(), rectTransform:  0, drivenProperties:  null);
        val_29 = null;
        val_29 = null;
        val_31 = HostManager.<>c.<>9__12_0;
        if(val_31 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, HostData>, System.String> val_14 = null;
            val_31 = val_14;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, HostData>, System.String>(object:  HostManager.<>c.__il2cppRuntimeField_static_fields, method:  System.String HostManager.<>c::<FixedUpdate>b__12_0(System.Collections.Generic.KeyValuePair<string, HostData> p));
            HostManager.<>c.<>9__12_0 = val_31;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        System.Collections.Generic.IEnumerator<T> val_17 = System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.String, HostData>, System.String>(source:  this.Hosts, keySelector:  val_14).GetEnumerator();
        val_27 = 1152921504691990528;
        val_25 = 1152921528223557872;
        val_26 = 1;
        goto label_48;
        label_65:
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_31 = UnityEngine.Object.Instantiate<HostTemplate>(original:  this.OriginalHostTemplate, parent:  this.ContentHolder, worldPositionStays:  false);
        val_31.SetData(value:  val_17.Current, isEvenRow:  true);
        val_31.gameObject.SetActive(value:  true);
        this.HostTemplates.Add(item:  val_31);
        val_26 = 0;
        label_48:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_17.MoveNext() == true)
        {
            goto label_65;
        }
        
        val_23 = 0;
        if(val_17 == null)
        {
            
        }
        else
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_17.Dispose();
        }
        
        mem2[0] = 0;
    }
    public HostManager()
    {
        this.Hosts = new System.Collections.Generic.Dictionary<System.String, HostData>();
        this.HostTemplates = new System.Collections.Generic.List<HostTemplate>();
        this.isDirty = true;
    }
    private static HostManager()
    {
        HostManager.expireTime = 5f;
    }

}
