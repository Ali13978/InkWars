using UnityEngine;
private sealed class JSONClass.<>c__DisplayClass12_0
{
    // Fields
    public SimpleJSON.JSONNode aNode;
    
    // Methods
    public JSONClass.<>c__DisplayClass12_0()
    {
    
    }
    internal bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> k)
    {
        return (bool)SimpleJSON.JSONNode.op_Equality(a:  k.Value, b:  this.aNode);
    }

}
