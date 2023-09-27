using UnityEngine;
public class AvatarCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<ProfileUnlockables_Avatar> avatars;
    private static AvatarCollection _inst;
    
    // Properties
    private static AvatarCollection instance { get; }
    
    // Methods
    private static AvatarCollection get_instance()
    {
        var val_3;
        AvatarCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = AvatarCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<AvatarCollection>(path:  "NetworkDataCollection/AvatarCollection.g");
            val_5 = null;
            AvatarCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (AvatarCollection)AvatarCollection._inst;
    }
    public static ProfileUnlockables_Avatar GetRandom()
    {
        AvatarCollection val_1 = AvatarCollection.instance;
        AvatarCollection val_2 = AvatarCollection.instance;
        if(val_1.avatars != null)
        {
                return val_1.avatars.Item[UnityEngine.Random.Range(min:  0, max:  val_2.avatars.Count)];
        }
        
        return val_1.avatars.Item[UnityEngine.Random.Range(min:  0, max:  val_2.avatars.Count)];
    }
    public static System.Collections.Generic.List<ProfileUnlockables_Avatar> GetCommonAvatars()
    {
        var val_8;
        var val_10;
        System.Func<ProfileUnlockables_Avatar, Avatars_Common_Order> val_12;
        var val_13;
        AvatarCollection val_1 = AvatarCollection.instance;
        val_8 = null;
        val_8 = null;
        if((AvatarCollection.<>c.<>9__5_0) == null)
        {
            goto label_6;
        }
        
        label_18:
        System.Collections.Generic.List<T> val_2 = val_1.avatars.FindAll(match:  AvatarCollection.<>c.<>9__5_0);
        if(val_2 == null)
        {
            goto label_8;
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = AvatarCollection.<>c.<>9__5_1;
        if(val_12 == null)
        {
                System.Func<ProfileUnlockables_Avatar, Avatars_Common_Order> val_3 = null;
            val_12 = val_3;
            val_3 = new System.Func<ProfileUnlockables_Avatar, Avatars_Common_Order>(object:  AvatarCollection.<>c.__il2cppRuntimeField_static_fields, method:  Avatars_Common_Order AvatarCollection.<>c::<GetCommonAvatars>b__5_1(ProfileUnlockables_Avatar x));
            AvatarCollection.<>c.<>9__5_1 = val_12;
        }
        
        val_13 = System.Linq.Enumerable.ToList<ProfileUnlockables_Avatar>(source:  System.Linq.Enumerable.OrderBy<ProfileUnlockables_Avatar, Avatars_Common_Order>(source:  val_2, keySelector:  val_3));
        return (System.Collections.Generic.List<ProfileUnlockables_Avatar>)val_13;
        label_6:
        AvatarCollection.<>c.<>9__5_0 = new System.Predicate<ProfileUnlockables_Avatar>(object:  AvatarCollection.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AvatarCollection.<>c::<GetCommonAvatars>b__5_0(ProfileUnlockables_Avatar x));
        if(val_1.avatars != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_8:
        System.Collections.Generic.List<ProfileUnlockables_Avatar> val_7 = null;
        val_13 = val_7;
        val_7 = new System.Collections.Generic.List<ProfileUnlockables_Avatar>();
        return (System.Collections.Generic.List<ProfileUnlockables_Avatar>)val_13;
    }
    public static System.Collections.Generic.List<ProfileUnlockables_Avatar> GetAvatars(CharacterNameID cid)
    {
        System.Predicate<T> val_9;
        var val_10;
        System.Func<ProfileUnlockables_Avatar, Avatars_Specific_Order> val_12;
        var val_13;
        .cid = cid;
        AvatarCollection val_2 = AvatarCollection.instance;
        System.Predicate<ProfileUnlockables_Avatar> val_3 = null;
        val_9 = val_3;
        val_3 = new System.Predicate<ProfileUnlockables_Avatar>(object:  new AvatarCollection.<>c__DisplayClass6_0(), method:  System.Boolean AvatarCollection.<>c__DisplayClass6_0::<GetAvatars>b__0(ProfileUnlockables_Avatar x));
        System.Collections.Generic.List<T> val_4 = val_2.avatars.FindAll(match:  val_3);
        if(val_4 != null)
        {
                val_10 = null;
            val_10 = null;
            val_12 = AvatarCollection.<>c.<>9__6_1;
            if(val_12 == null)
        {
                System.Func<ProfileUnlockables_Avatar, Avatars_Specific_Order> val_5 = null;
            val_12 = val_5;
            val_5 = new System.Func<ProfileUnlockables_Avatar, Avatars_Specific_Order>(object:  AvatarCollection.<>c.__il2cppRuntimeField_static_fields, method:  Avatars_Specific_Order AvatarCollection.<>c::<GetAvatars>b__6_1(ProfileUnlockables_Avatar x));
            AvatarCollection.<>c.<>9__6_1 = val_12;
        }
        
            val_13 = System.Linq.Enumerable.ToList<ProfileUnlockables_Avatar>(source:  System.Linq.Enumerable.OrderBy<ProfileUnlockables_Avatar, Avatars_Specific_Order>(source:  val_4, keySelector:  val_5));
            return (System.Collections.Generic.List<ProfileUnlockables_Avatar>)val_13;
        }
        
        System.Collections.Generic.List<ProfileUnlockables_Avatar> val_8 = null;
        val_13 = val_8;
        val_8 = new System.Collections.Generic.List<ProfileUnlockables_Avatar>();
        return (System.Collections.Generic.List<ProfileUnlockables_Avatar>)val_13;
    }
    public static ProfileUnlockables_Avatar GetCommonAvatarByKey(Avatars_Common_Key key)
    {
        .key = key;
        AvatarCollection val_2 = AvatarCollection.instance;
        if(val_2.avatars != null)
        {
                return val_2.avatars.Find(match:  new System.Predicate<ProfileUnlockables_Avatar>(object:  new AvatarCollection.<>c__DisplayClass7_0(), method:  System.Boolean AvatarCollection.<>c__DisplayClass7_0::<GetCommonAvatarByKey>b__0(ProfileUnlockables_Avatar x)));
        }
        
        return val_2.avatars.Find(match:  new System.Predicate<ProfileUnlockables_Avatar>(object:  new AvatarCollection.<>c__DisplayClass7_0(), method:  System.Boolean AvatarCollection.<>c__DisplayClass7_0::<GetCommonAvatarByKey>b__0(ProfileUnlockables_Avatar x)));
    }
    public static ProfileUnlockables_Avatar GetSpecificAvatarByKey(CharacterNameID cid, Avatars_Specific_Key key)
    {
        AvatarCollection.<>c__DisplayClass8_0 val_1 = new AvatarCollection.<>c__DisplayClass8_0();
        if(val_1 != null)
        {
                .cid = cid;
        }
        else
        {
                mem[16] = cid;
        }
        
        .key = key;
        AvatarCollection val_2 = AvatarCollection.instance;
        if(val_2.avatars != null)
        {
                return val_2.avatars.Find(match:  new System.Predicate<ProfileUnlockables_Avatar>(object:  val_1, method:  System.Boolean AvatarCollection.<>c__DisplayClass8_0::<GetSpecificAvatarByKey>b__0(ProfileUnlockables_Avatar x)));
        }
        
        return val_2.avatars.Find(match:  new System.Predicate<ProfileUnlockables_Avatar>(object:  val_1, method:  System.Boolean AvatarCollection.<>c__DisplayClass8_0::<GetSpecificAvatarByKey>b__0(ProfileUnlockables_Avatar x)));
    }
    public static ProfileUnlockables_Avatar GetAvatarFromIntId(int id)
    {
        CharacterNameID val_5;
        System.Collections.Generic.List<ProfileUnlockables_Avatar> val_6;
        IntPtr val_8;
        AvatarCollection.<>c__DisplayClass9_0 val_1 = new AvatarCollection.<>c__DisplayClass9_0();
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
            val_5 = (AvatarCollection.<>c__DisplayClass9_0)[1152921528311073248].cid;
        }
        
        if(val_5 == 999999)
        {
                AvatarCollection val_3 = AvatarCollection.instance;
            val_6 = val_3.avatars;
            val_8 = 1152921528311002912;
        }
        else
        {
                AvatarCollection val_4 = AvatarCollection.instance;
            val_6 = val_4.avatars;
            System.Predicate<ProfileUnlockables_Avatar> val_5 = null;
            val_8 = 1152921528311016224;
        }
        
        val_5 = new System.Predicate<ProfileUnlockables_Avatar>(object:  val_1, method:  val_8);
        if(val_6 != null)
        {
                return val_6.Find(match:  val_5);
        }
        
        return val_6.Find(match:  val_5);
    }
    public static UnityEngine.Sprite GetAvatarSpriteFromIntId(int id)
    {
        int val_4;
        UnityEngine.Sprite val_5;
        val_4 = id;
        if((AvatarCollection.GetAvatarFromIntId(id:  val_4)) != null)
        {
                val_5 = val_1.Sprite_Avatar;
            return (UnityEngine.Sprite)val_5;
        }
        
        val_4 = "Cannot find avatar with id " + val_4.ToString();
        UnityEngine.Debug.LogError(message:  val_4);
        val_5 = 0;
        return (UnityEngine.Sprite)val_5;
    }
    public static int GetAvatarIntId(Avatars_Common_Key key, CharacterNameID cid)
    {
        return (int)key + (cid * 1000);
    }
    public static int GetAvatarIntId(Avatars_Specific_Key key, CharacterNameID cid)
    {
        return (int)key + (cid * 1000);
    }
    private static int GetIntId(int key, int cid)
    {
        key = key + (cid * 1000);
        return (int)key;
    }
    public AvatarCollection()
    {
        this.avatars = new System.Collections.Generic.List<ProfileUnlockables_Avatar>();
    }
    private static AvatarCollection()
    {
    
    }

}
