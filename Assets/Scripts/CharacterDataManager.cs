using UnityEngine;
public class CharacterDataManager : ScriptableObject
{
    // Fields
    private System.Collections.Generic.List<CharacterData> items;
    private static CharacterDataManager _inst;
    
    // Properties
    private static CharacterDataManager instance { get; }
    
    // Methods
    private static CharacterDataManager get_instance()
    {
        var val_3;
        CharacterDataManager val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = CharacterDataManager._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<CharacterDataManager>(path:  "NetworkDataCollection/CharacterDataCollecion");
            val_5 = null;
            CharacterDataManager._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (CharacterDataManager)CharacterDataManager._inst;
    }
    public static CharacterData Get(CharacterNameID id)
    {
        .id = id;
        CharacterDataManager val_2 = CharacterDataManager.instance;
        CharacterData val_4 = val_2.items.Find(match:  new System.Predicate<CharacterData>(object:  new CharacterDataManager.<>c__DisplayClass4_0(), method:  System.Boolean CharacterDataManager.<>c__DisplayClass4_0::<Get>b__0(CharacterData x)));
        if(0 != val_4)
        {
                return val_4;
        }
        
        if(((CharacterDataManager.<>c__DisplayClass4_0)[1152921526039197888].id) == 999999)
        {
                return val_4;
        }
        
        object[] val_6 = new object[1];
        val_6[0] = (CharacterDataManager.<>c__DisplayClass4_0)[1152921526039197888].id;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find character data by id {0}", args:  val_6);
        return val_4;
    }
    public static CharacterData Find(System.Predicate<CharacterData> match)
    {
        CharacterDataManager val_1 = CharacterDataManager.instance;
        CharacterData val_2 = val_1.items.Find(match:  match);
        if(0 != val_2)
        {
                return val_2;
        }
        
        object[] val_4 = new object[1];
        val_4[0] = match;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find character data by Predicate {0}", args:  val_4);
        return val_2;
    }
    public static System.Collections.Generic.List<CharacterData> FindAll(System.Predicate<CharacterData> match)
    {
        CharacterDataManager val_1 = CharacterDataManager.instance;
        System.Collections.Generic.List<T> val_2 = val_1.items.FindAll(match:  match);
        if(val_2 != null)
        {
                if(val_2.Count != 0)
        {
                return (System.Collections.Generic.List<CharacterData>)val_2;
        }
        
        }
        
        object[] val_4 = new object[1];
        val_4[0] = match;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find any character data by Predicate {0}", args:  val_4);
        return (System.Collections.Generic.List<CharacterData>)val_2;
    }
    public static int GetCharacterCount()
    {
        var val_3;
        System.Predicate<CharacterData> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = CharacterDataManager.<>c.<>9__7_0;
        if(val_5 == null)
        {
                System.Predicate<CharacterData> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Predicate<CharacterData>(object:  CharacterDataManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterDataManager.<>c::<GetCharacterCount>b__7_0(CharacterData x));
            CharacterDataManager.<>c.<>9__7_0 = val_5;
        }
        
        System.Collections.Generic.List<CharacterData> val_2 = CharacterDataManager.FindAll(match:  val_1);
        if(val_2 == null)
        {
                return (int)val_2;
        }
        
        return val_2.Count;
    }
    public CharacterDataManager()
    {
        this.items = new System.Collections.Generic.List<CharacterData>();
    }
    private static CharacterDataManager()
    {
    
    }

}
