using UnityEngine;
public static class PostMatchHelper
{
    // Methods
    public static string GetQuoteByBallRemain(CharacterData data, int remainBallCount)
    {
        if(remainBallCount >= 20)
        {
                CharacterLocalization val_1 = data.localizedText;
            if(val_1 != null)
        {
                return val_1.winQuote20Balls;
        }
        
            return val_1.winQuote20Balls;
        }
        
        CharacterLocalization val_2 = data.localizedText;
        if(remainBallCount < 6)
        {
                return val_2.winQuote5Balls;
        }
        
        return val_2.winQuote19Balls;
    }

}
