using UnityEngine;
public class InstructionCollection : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.Sprite> items;
    private static InstructionCollection _inst;
    
    // Properties
    private static InstructionCollection instance { get; }
    
    // Methods
    private static InstructionCollection get_instance()
    {
        var val_3;
        InstructionCollection val_4;
        var val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        val_4 = InstructionCollection._inst;
        if(0 == val_4)
        {
                val_5 = null;
            val_4 = UnityEngine.Resources.Load<InstructionCollection>(path:  "NetworkDataCollection/InstructionCollection");
            val_5 = null;
            InstructionCollection._inst = val_4;
        }
        
        val_6 = null;
        val_6 = null;
        return (InstructionCollection)InstructionCollection._inst;
    }
    public static UnityEngine.Sprite GetByName(string name)
    {
        object val_7;
        InstructionCollection.<>c__DisplayClass4_0 val_1 = null;
        val_7 = val_1;
        val_1 = new InstructionCollection.<>c__DisplayClass4_0();
        .name = name;
        InstructionCollection val_2 = InstructionCollection.instance;
        UnityEngine.Sprite val_4 = val_2.items.Find(match:  new System.Predicate<UnityEngine.Sprite>(object:  val_1, method:  System.Boolean InstructionCollection.<>c__DisplayClass4_0::<GetByName>b__0(UnityEngine.Sprite x)));
        if(0 != val_4)
        {
                return val_4;
        }
        
        object[] val_6 = new object[1];
        val_7 = val_6;
        val_7[0] = (InstructionCollection.<>c__DisplayClass4_0)[1152921528953003936].name;
        UnityEngine.Debug.LogErrorFormat(format:  "Cannot find item by name {0} in Instruction Collection", args:  val_6);
        return val_4;
    }
    public static UnityEngine.Sprite GetById(int id)
    {
        InstructionCollection val_1 = InstructionCollection.instance;
        return (UnityEngine.Sprite)val_1.items.Item[id];
    }
    public InstructionCollection()
    {
        this.items = new System.Collections.Generic.List<UnityEngine.Sprite>();
    }
    private static InstructionCollection()
    {
    
    }

}
