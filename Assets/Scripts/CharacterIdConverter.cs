using UnityEngine;
public static class CharacterIdConverter
{
    // Fields
    private static string[] ikaNames;
    private static string[] takoNames;
    private static string[] allNames;
    
    // Methods
    public static string GetCharacterNameFromId_0to13(int id, CharacterClan clan)
    {
        var val_2;
        var val_3;
        System.String[] val_4;
        var val_5;
        var val_6;
        val_2 = id;
        if(clan == 1)
        {
            goto label_1;
        }
        
        if(clan != 0)
        {
            goto label_2;
        }
        
        val_3 = null;
        val_3 = null;
        val_4 = CharacterIdConverter.ikaNames;
        if(val_4 != null)
        {
            goto label_9;
        }
        
        goto label_6;
        label_1:
        val_5 = null;
        val_5 = null;
        val_4 = CharacterIdConverter.takoNames;
        if(val_4 != null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_2 = (long)val_2;
        System.String[] val_1 = val_4 + (((long)(int)(id)) << 3);
        val_6 = mem[(CharacterIdConverter.takoNames + ((long)(int)(id)) << 3) + 32];
        val_6 = (CharacterIdConverter.takoNames + ((long)(int)(id)) << 3) + 32;
        return (string)val_6;
        label_2:
        val_6 = 0;
        return (string)val_6;
    }
    public static string GetCharacterNameWithRaceFromId_0to13(int id, CharacterClan clan)
    {
        var val_2;
        System.String[] val_3;
        string val_4;
        var val_5;
        if(clan != 1)
        {
                if(clan != 0)
        {
                return 0;
        }
        
            val_2 = null;
            val_2 = null;
            val_3 = CharacterIdConverter.ikaNames;
            val_4 = "Ika_";
        }
        else
        {
                val_5 = null;
            val_5 = null;
            val_3 = CharacterIdConverter.takoNames;
            val_4 = "Tako_";
        }
        
        System.String[] val_1 = val_3 + (((long)(int)(id)) << 3);
        return val_4 + (CharacterIdConverter.takoNames + ((long)(int)(id)) << 3) + 32((CharacterIdConverter.takoNames + ((long)(int)(id)) << 3) + 32);
    }
    public static string GetTakoNameFromId_0to13(int id)
    {
        null = null;
        System.String[] val_1 = CharacterIdConverter.takoNames + (((long)(int)(id)) << 3);
        return (string)(CharacterIdConverter.takoNames + ((long)(int)(id)) << 3) + 32;
    }
    public static string GetIkaNameFromId_0to13(int id)
    {
        null = null;
        System.String[] val_1 = CharacterIdConverter.ikaNames + (((long)(int)(id)) << 3);
        return (string)(CharacterIdConverter.ikaNames + ((long)(int)(id)) << 3) + 32;
    }
    public static string GetNameFromId_0to27(int id)
    {
        null = null;
        System.String[] val_1 = CharacterIdConverter.allNames + (((long)(int)(id)) << 3);
        return (string)(CharacterIdConverter.allNames + ((long)(int)(id)) << 3) + 32;
    }
    public static string GetNameWithRace_0to27(int id)
    {
        null = null;
        System.String[] val_2 = CharacterIdConverter.allNames + (((long)(int)(id)) << 3);
        return (id < 26) ? "Ika_" : "Tako_"((id < 26) ? "Ika_" : "Tako_") + (CharacterIdConverter.allNames + ((long)(int)(id)) << 3) + 32((CharacterIdConverter.allNames + ((long)(int)(id)) << 3) + 32);
    }
    public static CharacterClan GetRaceFromId_0to27(int id)
    {
        if(id < 13)
        {
                return 0;
        }
        
        return (CharacterClan)(id != 26) ? 1 : 0;
    }
    private static CharacterIdConverter()
    {
        string[] val_1 = new string[14];
        val_1[0] = "Princess";
        val_1[1] = "Cowboy";
        val_1[2] = "Hobo";
        val_1[3] = "Salesman";
        val_1[4] = "Waitress";
        val_1[5] = "Butcher";
        val_1[6] = "Artist";
        val_1[7] = "Punk";
        val_1[8] = "Boxer";
        val_1[9] = "Commando";
        val_1[10] = "Senator";
        val_1[11] = "SecretAgent";
        val_1[12] = "Scientist";
        val_1[13] = "Lorii";
        CharacterIdConverter.ikaNames = val_1;
        string[] val_2 = new string[14];
        val_2[0] = "Hero";
        val_2[1] = "Hippie";
        val_2[2] = "Gypsy";
        val_2[3] = "Clown";
        val_2[4] = "Biker";
        val_2[5] = "Chef";
        val_2[6] = "Nerd";
        val_2[7] = "Rockstar";
        val_2[8] = "Wrestler";
        val_2[9] = "Cop";
        val_2[10] = "Godfather";
        val_2[11] = "Ninja";
        val_2[12] = "King";
        val_2[13] = "Jamie";
        CharacterIdConverter.takoNames = val_2;
        string[] val_3 = new string[28];
        val_3[0] = "Princess";
        val_3[1] = "Cowboy";
        val_3[2] = "Hobo";
        val_3[3] = "Salesman";
        val_3[4] = "Waitress";
        val_3[5] = "Butcher";
        val_3[6] = "Artist";
        val_3[7] = "Punk";
        val_3[8] = "Boxer";
        val_3[9] = "Commando";
        val_3[10] = "Senator";
        val_3[11] = "Secret Agent";
        val_3[12] = "Scientist";
        val_3[13] = "Hero";
        val_3[14] = "Hippie";
        val_3[15] = "Gypsy";
        val_3[16] = "Clown";
        val_3[17] = "Biker";
        val_3[18] = "Chef";
        val_3[19] = "Nerd";
        val_3[20] = "Rockstar";
        val_3[21] = "Wrestler";
        val_3[22] = "Cop";
        val_3[23] = "Godfather";
        val_3[24] = "Ninja";
        val_3[25] = "King";
        val_3[26] = "Lorii";
        val_3[27] = "Jamie";
        CharacterIdConverter.allNames = val_3;
    }

}
