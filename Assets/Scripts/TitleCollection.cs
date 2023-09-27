using UnityEngine;
public class TitleCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<ProfileUnlockables_Title> titles;
    private static TitleCollection _inst;
    
    // Properties
    private static TitleCollection instance { get; }
    
    // Methods
    private static TitleCollection get_instance()
    {
        var val_3;
        TitleCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = TitleCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<TitleCollection>(path:  "NetworkDataCollection/TitleCollection.g");
            val_5 = null;
            TitleCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (TitleCollection)TitleCollection._inst;
    }
    public static ProfileUnlockables_Title GetRandom()
    {
        TitleCollection val_1 = TitleCollection.instance;
        TitleCollection val_2 = TitleCollection.instance;
        if(val_1.titles != null)
        {
                return val_1.titles.Item[UnityEngine.Random.Range(min:  0, max:  val_2.titles.Count)];
        }
        
        return val_1.titles.Item[UnityEngine.Random.Range(min:  0, max:  val_2.titles.Count)];
    }
    public static System.Collections.Generic.List<ProfileUnlockables_Title> GetCommon()
    {
        var val_8;
        var val_10;
        System.Func<ProfileUnlockables_Title, Titles_Common_Order> val_12;
        var val_13;
        TitleCollection val_1 = TitleCollection.instance;
        val_8 = null;
        val_8 = null;
        if((TitleCollection.<>c.<>9__5_0) == null)
        {
            goto label_6;
        }
        
        label_18:
        System.Collections.Generic.List<T> val_2 = val_1.titles.FindAll(match:  TitleCollection.<>c.<>9__5_0);
        if(val_2 == null)
        {
            goto label_8;
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = TitleCollection.<>c.<>9__5_1;
        if(val_12 == null)
        {
                System.Func<ProfileUnlockables_Title, Titles_Common_Order> val_3 = null;
            val_12 = val_3;
            val_3 = new System.Func<ProfileUnlockables_Title, Titles_Common_Order>(object:  TitleCollection.<>c.__il2cppRuntimeField_static_fields, method:  Titles_Common_Order TitleCollection.<>c::<GetCommon>b__5_1(ProfileUnlockables_Title x));
            TitleCollection.<>c.<>9__5_1 = val_12;
        }
        
        val_13 = System.Linq.Enumerable.ToList<ProfileUnlockables_Title>(source:  System.Linq.Enumerable.OrderBy<ProfileUnlockables_Title, Titles_Common_Order>(source:  val_2, keySelector:  val_3));
        return (System.Collections.Generic.List<ProfileUnlockables_Title>)val_13;
        label_6:
        TitleCollection.<>c.<>9__5_0 = new System.Predicate<ProfileUnlockables_Title>(object:  TitleCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean TitleCollection.<>c::<GetCommon>b__5_0(ProfileUnlockables_Title x));
        if(val_1.titles != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_8:
        System.Collections.Generic.List<ProfileUnlockables_Title> val_7 = null;
        val_13 = val_7;
        val_7 = new System.Collections.Generic.List<ProfileUnlockables_Title>();
        return (System.Collections.Generic.List<ProfileUnlockables_Title>)val_13;
    }
    public static System.Collections.Generic.List<ProfileUnlockables_Title> GetSpecific(CharacterNameID cid)
    {
        System.Predicate<T> val_9;
        var val_10;
        System.Func<ProfileUnlockables_Title, Titles_Specific_Order> val_12;
        var val_13;
        .cid = cid;
        TitleCollection val_2 = TitleCollection.instance;
        System.Predicate<ProfileUnlockables_Title> val_3 = null;
        val_9 = val_3;
        val_3 = new System.Predicate<ProfileUnlockables_Title>(object:  new TitleCollection.<>c__DisplayClass6_0(), method:  System.Boolean TitleCollection.<>c__DisplayClass6_0::<GetSpecific>b__0(ProfileUnlockables_Title x));
        System.Collections.Generic.List<T> val_4 = val_2.titles.FindAll(match:  val_3);
        if(val_4 != null)
        {
                val_10 = null;
            val_10 = null;
            val_12 = TitleCollection.<>c.<>9__6_1;
            if(val_12 == null)
        {
                System.Func<ProfileUnlockables_Title, Titles_Specific_Order> val_5 = null;
            val_12 = val_5;
            val_5 = new System.Func<ProfileUnlockables_Title, Titles_Specific_Order>(object:  TitleCollection.<>c.__il2cppRuntimeField_static_fields, method:  Titles_Specific_Order TitleCollection.<>c::<GetSpecific>b__6_1(ProfileUnlockables_Title x));
            TitleCollection.<>c.<>9__6_1 = val_12;
        }
        
            val_13 = System.Linq.Enumerable.ToList<ProfileUnlockables_Title>(source:  System.Linq.Enumerable.OrderBy<ProfileUnlockables_Title, Titles_Specific_Order>(source:  val_4, keySelector:  val_5));
            return (System.Collections.Generic.List<ProfileUnlockables_Title>)val_13;
        }
        
        System.Collections.Generic.List<ProfileUnlockables_Title> val_8 = null;
        val_13 = val_8;
        val_8 = new System.Collections.Generic.List<ProfileUnlockables_Title>();
        return (System.Collections.Generic.List<ProfileUnlockables_Title>)val_13;
    }
    public static ProfileUnlockables_Title GetCommonTitleByKey(Titles_Common_Key key)
    {
        .key = key;
        TitleCollection val_2 = TitleCollection.instance;
        if(val_2.titles != null)
        {
                return val_2.titles.Find(match:  new System.Predicate<ProfileUnlockables_Title>(object:  new TitleCollection.<>c__DisplayClass7_0(), method:  System.Boolean TitleCollection.<>c__DisplayClass7_0::<GetCommonTitleByKey>b__0(ProfileUnlockables_Title x)));
        }
        
        return val_2.titles.Find(match:  new System.Predicate<ProfileUnlockables_Title>(object:  new TitleCollection.<>c__DisplayClass7_0(), method:  System.Boolean TitleCollection.<>c__DisplayClass7_0::<GetCommonTitleByKey>b__0(ProfileUnlockables_Title x)));
    }
    public static ProfileUnlockables_Title GetSpecificTitleByKey(CharacterNameID cid, Titles_Specific_Key key)
    {
        TitleCollection.<>c__DisplayClass8_0 val_1 = new TitleCollection.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                .cid = cid;
        }
        else
        {
                mem[16] = cid;
        }
        
        .key = key;
        TitleCollection val_2 = TitleCollection.instance;
        if(val_2.titles != null)
        {
                return val_2.titles.Find(match:  new System.Predicate<ProfileUnlockables_Title>(object:  val_1, method:  System.Boolean TitleCollection.<>c__DisplayClass8_0::<GetSpecificTitleByKey>b__0(ProfileUnlockables_Title x)));
        }
        
        return val_2.titles.Find(match:  new System.Predicate<ProfileUnlockables_Title>(object:  val_1, method:  System.Boolean TitleCollection.<>c__DisplayClass8_0::<GetSpecificTitleByKey>b__0(ProfileUnlockables_Title x)));
    }
    public static ProfileUnlockables_Title GetTitleFromIntId(int id)
    {
        CharacterNameID val_5;
        System.Collections.Generic.List<ProfileUnlockables_Title> val_6;
        IntPtr val_8;
        TitleCollection.<>c__DisplayClass9_0 val_1 = new TitleCollection.<>c__DisplayClass9_0();
        val_5 = 0;
        if(val_1 != null)
        {
                .keyNum = 0;
            .cid = val_5;
        }
        else
        {
                var val_2 = 0 + 0;
            val_2 = id - (val_2 * 1000);
            mem[16] = val_2;
            .cid = val_5;
            val_5 = (TitleCollection.<>c__DisplayClass9_0)[1152921528324365968].cid;
        }
        
        if(val_5 == 999999)
        {
                TitleCollection val_3 = TitleCollection.instance;
            val_6 = val_3.titles;
            val_8 = 1152921528324295632;
        }
        else
        {
                TitleCollection val_4 = TitleCollection.instance;
            val_6 = val_4.titles;
            System.Predicate<ProfileUnlockables_Title> val_5 = null;
            val_8 = 1152921528324308944;
        }
        
        val_5 = new System.Predicate<ProfileUnlockables_Title>(object:  val_1, method:  val_8);
        if(val_6 != null)
        {
                return val_6.Find(match:  val_5);
        }
        
        return val_6.Find(match:  val_5);
    }
    public static int GetTitleIntId(Titles_Common_Key key, CharacterNameID cid)
    {
        return (int)key + (cid * 1000);
    }
    public static int GetTitleIntId(Titles_Specific_Key key, CharacterNameID cid)
    {
        return (int)key + (cid * 1000);
    }
    private static int GetIntId(int key, int cid)
    {
        key = key + (cid * 1000);
        return (int)key;
    }
    public TitleCollection()
    {
        this.titles = new System.Collections.Generic.List<ProfileUnlockables_Title>();
    }
    private static TitleCollection()
    {
    
    }

}
