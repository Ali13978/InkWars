using UnityEngine;
public class UnlockableCollection : MonoBehaviour
{
    // Fields
    private static UnlockableCollection m_Instance;
    private UnlockController m_UnlockController;
    public static bool IsProcessing;
    public static int AmountOfUnlockables;
    private System.Collections.Generic.List<ProfileUnlockables_Title> UnlockedTitleList;
    private System.Collections.Generic.List<ProfileUnlockables_Avatar> UnlockedAvatarList;
    private System.Collections.Generic.List<ProfileUnlockables_Base> UnlockedBaseList;
    private CharacterNameID CharID_Unlocked;
    
    // Properties
    private static UnlockableCollection Instance { get; }
    
    // Methods
    private static UnlockableCollection get_Instance()
    {
        var val_5;
        UnlockableCollection val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = UnlockableCollection.m_Instance;
        if(0 == val_6)
        {
                val_7 = null;
            val_7 = null;
            UnlockableCollection.m_Instance = UnityEngine.Object.Instantiate<UnlockableCollection>(original:  UnityEngine.Resources.Load<UnlockableCollection>(path:  "DynamicUI/UnlockAvatar_TitleCanvas"));
            val_6 = UnlockableCollection.m_Instance;
            DialogManager.ShowCustomDialog(dialog:  val_6.GetComponent<UnityEngine.RectTransform>());
        }
        
        val_8 = null;
        val_8 = null;
        return (UnlockableCollection)UnlockableCollection.m_Instance;
    }
    private void FakeDataInitialize()
    {
        this.InitializeLists();
        this.SetupFakeData();
        this.GenerateBaseList();
        this.ProcessUnlockables();
    }
    private void InitializeLists()
    {
        var val_4;
        System.Collections.Generic.List<ProfileUnlockables_Title> val_1 = new System.Collections.Generic.List<ProfileUnlockables_Title>();
        this.UnlockedTitleList = val_1;
        val_1.Clear();
        System.Collections.Generic.List<ProfileUnlockables_Avatar> val_2 = new System.Collections.Generic.List<ProfileUnlockables_Avatar>();
        this.UnlockedAvatarList = val_2;
        val_2.Clear();
        System.Collections.Generic.List<ProfileUnlockables_Base> val_3 = new System.Collections.Generic.List<ProfileUnlockables_Base>();
        this.UnlockedBaseList = val_3;
        val_3.Clear();
        val_4 = null;
        val_4 = null;
        UnlockableCollection.AmountOfUnlockables = 0;
    }
    public static void DisplayNewUnlocksOneByOne()
    {
        CharacterNameID val_2;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        UnlockableCollection.Setup(charID:  val_2);
    }
    public static void Setup(CharacterNameID charID)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = null;
        val_10 = null;
        if(Character_GlobalInfo.gameMode == 6)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        if(DebugUserSettingPanel.UnlockCollectionBehaviour == 1)
        {
                UnlockableCollection.Instance.FakeDataInitialize();
            return;
        }
        
        UnlockableCollection val_2 = UnlockableCollection.Instance;
        val_2.CharID_Unlocked = charID;
        val_12 = null;
        val_12 = null;
        if(NewUnlocks.NewUnlocksThisCheck != null)
        {
                UnlockableCollection.Instance.InitializeLists();
            UnlockableCollection.Instance.GenerateKeys();
            UnlockableCollection.Instance.GenerateBaseList();
            UnlockableCollection.Instance.ProcessUnlockables();
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  "Setup could not be done properly: UserProfileUnlockables.NewUnlocksThisCheck is NULL");
        if(0 == UnlockableCollection.Instance)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        UnityEngine.Object.Destroy(obj:  UnlockableCollection.m_Instance.gameObject);
    }
    public void ProcessUnlockables()
    {
        var val_22;
        UnlockController val_23;
        var val_24;
        ProfileUnlockables_Avatar val_25;
        ProfileUnlockables_Avatar val_26;
        var val_27;
        var val_28;
        UnlockableCollection val_29;
        ProfileUnlockables_Title val_30;
        System.Collections.Generic.List<ProfileUnlockables_Base> val_31;
        var val_32;
        val_22 = this;
        if((this.UnlockedBaseList == null) || (this.UnlockedBaseList.Count == 0))
        {
            goto label_2;
        }
        
        if(0 == this.m_UnlockController)
        {
                return;
        }
        
        System.Collections.Generic.List<ProfileUnlockables_Base> val_22 = this.UnlockedBaseList;
        val_22 = val_22.Count - 1;
        object[] val_4 = new object[1];
        val_4[0] = this.UnlockedBaseList.Item[val_22].GetType();
        UnityEngine.Debug.LogFormat(format:  "Type of base list item: {0}", args:  val_4);
        bool val_10 = System.Type.op_Equality(left:  this.UnlockedBaseList.Item[val_22].GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_23 = this.m_UnlockController;
        val_24 = this.UnlockedBaseList.Item[val_22];
        if(val_23 == null)
        {
            goto label_20;
        }
        
        if(val_10 == false)
        {
            goto label_21;
        }
        
        label_40:
        if(val_24 != null)
        {
                val_25 = 0;
        }
        
        val_26 = val_25;
        val_23.SetupAvatar(_avatar:  val_26);
        goto label_25;
        label_2:
        val_27 = null;
        val_27 = null;
        UnlockableCollection.IsProcessing = false;
        val_23 = 1152921504858337280;
        if(0 == UnlockableCollection.m_Instance)
        {
            goto label_30;
        }
        
        val_28 = null;
        val_28 = null;
        val_29 = UnlockableCollection.m_Instance;
        if(val_29 != null)
        {
            goto label_34;
        }
        
        goto label_34;
        label_30:
        if(0 == this.gameObject)
        {
                return;
        }
        
        label_34:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        return;
        label_20:
        if(val_10 == true)
        {
            goto label_40;
        }
        
        label_21:
        if(val_24 != null)
        {
                val_30 = 0;
        }
        
        val_26 = val_30;
        val_23.SetupTitle(_title:  val_26);
        label_25:
        val_31 = this.UnlockedBaseList;
        if(val_31 != null)
        {
                val_32 = val_31.Count;
        }
        else
        {
                val_32 = 0.Count;
        }
        
        val_31.RemoveAt(index:  val_32 - 1);
    }
    private void GenerateKeys()
    {
        var val_3;
        var val_21;
        UnityEngine.RectTransform val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        System.Collections.Generic.List<Avatars_Common_Key> val_28;
        val_21 = null;
        val_21 = null;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_12:
        if(((-1905797552) & 1) == 0)
        {
            goto label_5;
        }
        
        UnlockableCollection val_6 = UnlockableCollection.Instance;
        val_6.UnlockedTitleList.Add(item:  TitleCollection.GetSpecificTitleByKey(cid:  this.CharID_Unlocked, key:  val_3.GetHashCode()));
        goto label_12;
        label_5:
        val_3.Add(driver:  public System.Void List.Enumerator<Titles_Specific_Key>::Dispose(), rectTransform:  null, drivenProperties:  null);
        val_23 = null;
        val_23 = null;
        List.Enumerator<T> val_7 = GetEnumerator();
        label_31:
        if(((-1905797584) & 1) == 0)
        {
            goto label_24;
        }
        
        UnlockableCollection val_10 = UnlockableCollection.Instance;
        val_10.UnlockedTitleList.Add(item:  TitleCollection.GetCommonTitleByKey(key:  val_3.GetHashCode()));
        goto label_31;
        label_24:
        val_3.Add(driver:  public System.Void List.Enumerator<Titles_Common_Key>::Dispose(), rectTransform:  val_22 = 0, drivenProperties:  null);
        val_24 = null;
        val_24 = null;
        List.Enumerator<T> val_11 = GetEnumerator();
        label_50:
        if(((-1905797616) & 1) == 0)
        {
            goto label_43;
        }
        
        UnlockableCollection val_14 = UnlockableCollection.Instance;
        val_14.UnlockedAvatarList.Add(item:  AvatarCollection.GetSpecificAvatarByKey(cid:  this.CharID_Unlocked, key:  val_3.GetHashCode()));
        goto label_50;
        label_43:
        val_3.Add(driver:  public System.Void List.Enumerator<Avatars_Specific_Key>::Dispose(), rectTransform:  val_22 = 0, drivenProperties:  null);
        val_25 = 0;
        if( != 1)
        {
                var val_15 = (239 == 239) ? 1 : 0;
            val_15 = (( >= 0) ? 1 : 0) & val_15;
             =  - val_15;
             =  + 1;
            val_26 = (long);
        }
        else
        {
                val_26 = 0;
        }
        
        val_27 = null;
        val_27 = null;
        val_28 = mem[NewUnlocks.NewUnlocksThisCheck + 24];
        val_28 = NewUnlocks.NewUnlocksThisCheck.AvatarCommons;
        List.Enumerator<T> val_17 = GetEnumerator();
        label_71:
        if(((-1905797640) & 1) == 0)
        {
            goto label_64;
        }
        
        UnlockableCollection val_20 = UnlockableCollection.Instance;
        val_20.UnlockedAvatarList.Add(item:  AvatarCollection.GetCommonAvatarByKey(key:  0.GetHashCode()));
        goto label_71;
        label_64:
        0.Add(driver:  public System.Void List.Enumerator<Avatars_Common_Key>::Dispose(), rectTransform:  val_22 = 0, drivenProperties:  null);
    }
    private void GenerateBaseList()
    {
        var val_3;
        var val_8;
        List.Enumerator<T> val_1 = this.UnlockedAvatarList.GetEnumerator();
        label_4:
        if(((-1905590288) & 1) == 0)
        {
            goto label_2;
        }
        
        this.UnlockedBaseList.Add(item:  val_3.InitialType);
        goto label_4;
        label_2:
        val_3.Add(driver:  public System.Void List.Enumerator<ProfileUnlockables_Avatar>::Dispose(), rectTransform:  null, drivenProperties:  null);
        List.Enumerator<T> val_5 = this.UnlockedTitleList.GetEnumerator();
        label_12:
        if(((-1905590312) & 1) == 0)
        {
            goto label_10;
        }
        
        this.UnlockedBaseList.Add(item:  0.InitialType);
        goto label_12;
        label_10:
        0.Add(driver:  public System.Void List.Enumerator<ProfileUnlockables_Title>::Dispose(), rectTransform:  0, drivenProperties:  null);
        val_8 = null;
        val_8 = null;
        UnlockableCollection.AmountOfUnlockables = this.UnlockedBaseList.Count;
    }
    private void SetupFakeData()
    {
        this.UnlockedTitleList.Add(item:  TitleCollection.GetRandom());
        this.UnlockedTitleList.Add(item:  TitleCollection.GetRandom());
        this.UnlockedAvatarList.Add(item:  AvatarCollection.GetRandom());
        this.UnlockedAvatarList.Add(item:  AvatarCollection.GetRandom());
    }
    public UnlockableCollection()
    {
    
    }
    private static UnlockableCollection()
    {
        UnlockableCollection.IsProcessing = true;
        UnlockableCollection.AmountOfUnlockables = 0;
    }

}
