using UnityEngine;

namespace DataStructs.Dictionalizer
{
    public class DictionalizeNodeKeyType : Attribute
    {
        // Fields
        public System.Type keyType;
        
        // Methods
        public DictionalizeNodeKeyType(System.Type aNewKeyType)
        {
            this.keyType = aNewKeyType;
        }
    
    }

}
