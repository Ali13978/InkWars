using UnityEngine;
public class CharNameIDConverter : MonoBehaviour
{
    // Methods
    public static string ToString_NameOnly(CharacterNameID enumID)
    {
        string val_2 = CharNameIDConverter.ToString(enumID:  enumID).Replace(oldValue:  "Ika_", newValue:  "");
        if(val_2 != null)
        {
                return val_2.Replace(oldValue:  "Tako_", newValue:  "");
        }
        
        return val_2.Replace(oldValue:  "Tako_", newValue:  "");
    }
    public static string ToString(string cid)
    {
        string val_4 = new System.Globalization.CultureInfo(name:  "en-US", useUserOverride:  false).ToTitleCase(str:  cid.ToLower().Replace(oldValue:  "_", newValue:  " "));
        if(val_4 != null)
        {
                return val_4.Replace(oldValue:  " ", newValue:  "_");
        }
        
        return val_4.Replace(oldValue:  " ", newValue:  "_");
    }
    public static string ToString(CharacterNameID enumID)
    {
        enumID.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  0);
        return (string)new System.Globalization.CultureInfo(name:  "en-US", useUserOverride:  false).ToTitleCase(str:  enumID.ToString().ToLower().Replace(oldValue:  "_", newValue:  " ")).Replace(oldValue:  " ", newValue:  "_");
    }
    public static string CharNameIdToJSonId(CharacterNameID charNameID)
    {
        if(charNameID > 41)
        {
                return CharNameIDConverter.ToString(enumID:  charNameID);
        }
        
        var val_5 = 40837112 + (charNameID) << 2;
        val_5 = val_5 + 40837112;
        goto (40837112 + (charNameID) << 2 + 40837112);
    }
    public static CharacterNameID JSonIdToCharNameId(string JsonID)
    {
        var val_42;
        uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  JsonID);
        if(val_1 > 189100134)
        {
            goto label_1;
        }
        
        if(val_1 > 139151184)
        {
            goto label_2;
        }
        
        if(val_1 > 63773692)
        {
            goto label_3;
        }
        
        if(val_1 > 19849241)
        {
            goto label_4;
        }
        
        if(val_1 == 3071622)
        {
            goto label_5;
        }
        
        if((val_1 != 19849241) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_6")) == false))
        {
            goto label_134;
        }
        
        val_42 = 23;
        return 999999;
        label_1:
        if(val_1 > 239816898)
        {
            goto label_9;
        }
        
        if(val_1 > 214772263)
        {
            goto label_10;
        }
        
        if(val_1 > 197994644)
        {
            goto label_11;
        }
        
        if(val_1 == 189484041)
        {
            goto label_12;
        }
        
        if((val_1 != 197994644) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_10")) == false))
        {
            goto label_134;
        }
        
        val_42 = 18;
        return 999999;
        label_2:
        if(val_1 > 170847812)
        {
            goto label_16;
        }
        
        if(val_1 > 155544896)
        {
            goto label_17;
        }
        
        if(val_1 == 147661787)
        {
            goto label_18;
        }
        
        if((val_1 != 155544896) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_1")) == false))
        {
            goto label_134;
        }
        
        val_42 = 4;
        return 999999;
        label_9:
        if(val_1 > 289765848)
        {
            goto label_22;
        }
        
        if(val_1 > 256210610)
        {
            goto label_23;
        }
        
        if(val_1 == 248327501)
        {
            goto label_24;
        }
        
        if((val_1 != 256210610) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_7")) == false))
        {
            goto label_134;
        }
        
        val_42 = 8;
        return 999999;
        label_3:
        if(val_1 > 80551311)
        {
            goto label_28;
        }
        
        if(val_1 == 70182098)
        {
            goto label_29;
        }
        
        if((val_1 != 80551311) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_19")) == false))
        {
            goto label_134;
        }
        
        val_42 = 40;
        return 999999;
        label_10:
        if(val_1 > 223039279)
        {
            goto label_33;
        }
        
        if(val_1 == 222655372)
        {
            goto label_34;
        }
        
        if((val_1 != 223039279) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_15")) == false))
        {
            goto label_134;
        }
        
        val_42 = 32;
        return 999999;
        label_16:
        if(val_1 > 172706422)
        {
            goto label_38;
        }
        
        if(val_1 == 172322515)
        {
            goto label_39;
        }
        
        if((val_1 != 172706422) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_12")) == false))
        {
            goto label_134;
        }
        
        val_42 = 10;
        return 999999;
        label_22:
        if(val_1 > 2111084495)
        {
            goto label_43;
        }
        
        if(val_1 == 306543467)
        {
            goto label_44;
        }
        
        if((val_1 != 2111084495) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_20")) == false))
        {
            goto label_134;
        }
        
        val_42 = 41;
        return 999999;
        label_4:
        if(val_1 == 36626860)
        {
            goto label_48;
        }
        
        if(val_1 == 53404479)
        {
            goto label_49;
        }
        
        if((val_1 != 63773692) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_18")) == false))
        {
            goto label_134;
        }
        
        val_42 = 38;
        return 999999;
        label_11:
        if(val_1 == 205877753)
        {
            goto label_53;
        }
        
        if(val_1 == 206261660)
        {
            goto label_54;
        }
        
        if((val_1 != 214772263) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_11")) == false))
        {
            goto label_134;
        }
        
        val_42 = 24;
        return 999999;
        label_17:
        if(val_1 == 155928803)
        {
            goto label_58;
        }
        
        if(val_1 == 164439406)
        {
            goto label_59;
        }
        
        if((val_1 != 170847812) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_9")) == false))
        {
            goto label_134;
        }
        
        val_42 = 17;
        return 999999;
        label_23:
        if(val_1 == 256594517)
        {
            goto label_63;
        }
        
        if(val_1 == 272988229)
        {
            goto label_64;
        }
        
        if((val_1 != 289765848) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_9")) == false))
        {
            goto label_134;
        }
        
        val_42 = 3;
        return 999999;
        label_28:
        if(val_1 == 86959717)
        {
            goto label_68;
        }
        
        if(val_1 == 130884168)
        {
            goto label_69;
        }
        
        if((val_1 != 139151184) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_10")) == false))
        {
            goto label_134;
        }
        
        val_42 = 12;
        return 999999;
        label_33:
        if(val_1 == 231549882)
        {
            goto label_73;
        }
        
        if(val_1 == 239432991)
        {
            goto label_74;
        }
        
        if((val_1 != 239816898) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_16")) == false))
        {
            goto label_134;
        }
        
        val_42 = 37;
        return 999999;
        label_38:
        if(val_1 == 181217025)
        {
            goto label_78;
        }
        
        if(val_1 == 187625431)
        {
            goto label_79;
        }
        
        if((val_1 != 189100134) || ((System.String.op_Equality(a:  JsonID, b:  "Ika_3")) == false))
        {
            goto label_134;
        }
        
        val_42 = 9;
        return 999999;
        label_43:
        if(val_1 == (-631046915))
        {
            goto label_83;
        }
        
        if(val_1 == (-30483616))
        {
            goto label_84;
        }
        
        if((val_1 != (-13705997)) || ((System.String.op_Equality(a:  JsonID, b:  "Tako_4")) == false))
        {
            goto label_134;
        }
        
        val_42 = 14;
        return 999999;
        label_5:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_7")) == false)
        {
            goto label_134;
        }
        
        val_42 = 25;
        return 999999;
        label_12:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_13")) == false)
        {
            goto label_134;
        }
        
        val_42 = 6;
        return 999999;
        label_18:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_15")) == false)
        {
            goto label_134;
        }
        
        val_42 = 33;
        return 999999;
        label_24:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_13")) == false)
        {
            goto label_134;
        }
        
        val_42 = 29;
        return 999999;
        label_29:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_3")) == false)
        {
            goto label_134;
        }
        
        val_42 = 16;
        return 999999;
        label_34:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_5")) == false)
        {
            goto label_134;
        }
        
        val_42 = 2;
        return 999999;
        label_39:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_0")) == false)
        {
            goto label_134;
        }
        
        val_42 = 7;
        return 999999;
        label_44:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_8")) == false)
        {
            goto label_134;
        }
        
        val_42 = 1;
        return 999999;
        label_48:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_1")) == false)
        {
            goto label_134;
        }
        
        val_42 = 21;
        return 999999;
        label_49:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_0")) == false)
        {
            goto label_134;
        }
        
        val_42 = 20;
        return 999999;
        label_53:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_2")) == false)
        {
            goto label_134;
        }
        
        val_42 = 5;
        return 999999;
        label_54:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_14")) == false)
        {
            goto label_134;
        }
        
        val_42 = 31;
        return 999999;
        label_58:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_11")) == false)
        {
            goto label_134;
        }
        
        val_42 = 11;
        return 999999;
        label_59:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_16")) == false)
        {
            goto label_134;
        }
        
        val_42 = 35;
        return 999999;
        label_63:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_17")) == false)
        {
            goto label_134;
        }
        
        val_42 = 39;
        return 999999;
        label_64:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_6")) == false)
        {
            goto label_134;
        }
        
        val_42 = 0;
        return 999999;
        label_68:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_2")) == false)
        {
            goto label_134;
        }
        
        val_42 = 19;
        return 999999;
        label_69:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_14")) == false)
        {
            goto label_134;
        }
        
        val_42 = 30;
        return 999999;
        label_73:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_12")) == false)
        {
            goto label_134;
        }
        
        val_42 = 22;
        return 999999;
        label_74:
        if((System.String.op_Equality(a:  JsonID, b:  "Ika_4")) == false)
        {
            goto label_134;
        }
        
        val_42 = 13;
        return 999999;
        label_78:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_17")) == false)
        {
            goto label_134;
        }
        
        val_42 = 36;
        return 999999;
        label_79:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_8")) == false)
        {
            goto label_134;
        }
        
        val_42 = 26;
        return 999999;
        label_83:
        if((System.String.op_Equality(a:  JsonID, b:  "Special_2")) == false)
        {
            goto label_134;
        }
        
        val_42 = 34;
        return 999999;
        label_84:
        if((System.String.op_Equality(a:  JsonID, b:  "Tako_5")) != false)
        {
                val_42 = 15;
            return 999999;
        }
        
        label_134:
        val_42 = 983040;
        val_42 = 15;
        return 999999;
    }
    public static int StageOrder(CharacterNameID charNameID)
    {
        if(charNameID > 41)
        {
                return 100;
        }
        
        return (int)40837920 + (charNameID) << 2;
    }
    public static CharacterClan GetClan(CharacterNameID nameID)
    {
        var val_8;
        var val_9;
        char[] val_2 = new char[1];
        val_8 = "_";
        if("_" == null)
        {
                val_8 = "_";
        }
        
        val_2[0] = Chars[0];
        string val_8 = CharNameIDConverter.ToString(enumID:  nameID).Split(separator:  val_2)[0];
        if((System.String.op_Equality(a:  val_8, b:  "Ika")) != false)
        {
                val_9 = 0;
            return (CharacterClan)(nameID == 42) ? (2 + 1) : 2;
        }
        
        if((System.String.op_Equality(a:  val_8, b:  "Tako")) == false)
        {
                return (CharacterClan)(nameID == 42) ? (2 + 1) : 2;
        }
        
        val_9 = 1;
        return (CharacterClan)(nameID == 42) ? (2 + 1) : 2;
    }
    public CharNameIDConverter()
    {
    
    }

}
