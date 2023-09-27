using UnityEngine;
internal class DecimalConverter : JsonConverter
{
    // Methods
    public override bool CanConvert(System.Type objectType)
    {
        if((System.Type.op_Equality(left:  objectType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
                return System.Type.op_Equality(left:  objectType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        
        return true;
    }
    public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
    {
        Newtonsoft.Json.Linq.JToken val_1 = Newtonsoft.Json.Linq.JToken.Load(reader:  reader);
        if(val_1 != 7)
        {
                if(val_1 != 6)
        {
            goto label_5;
        }
        
        }
        
        decimal val_2 = val_1.ToObject<System.Decimal>();
        label_11:
        return (object)val_2;
        label_5:
        if(val_1 != 8)
        {
            goto label_6;
        }
        
        decimal val_4 = System.Decimal.Parse(s:  val_1, provider:  System.Globalization.CultureInfo.GetCultureInfo(name:  "es-ES"));
        goto label_11;
        label_6:
        if(val_1 == 10)
        {
                if((System.Type.op_Equality(left:  objectType, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
        {
                return (object)val_2;
        }
        
        }
        
        Newtonsoft.Json.JsonSerializationException val_9 = new Newtonsoft.Json.JsonSerializationException(message:  "Unexpected token type: "("Unexpected token type: ") + val_1.ToString());
    }
    public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    public DecimalConverter()
    {
    
    }

}
