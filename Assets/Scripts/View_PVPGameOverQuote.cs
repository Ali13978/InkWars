using UnityEngine;
public class View_PVPGameOverQuote : MonoBehaviour
{
    // Fields
    public UnityEngine.Color quoteColor_Bubbles20;
    public UnityEngine.Color quoteColor_Bubbles19;
    public UnityEngine.Color quoteColor_Bubbles5;
    public UnityEngine.Color quoteColor_SameCharacter;
    public UnityEngine.Color quoteColor_Draw;
    public UnityEngine.Color quoteColor_SpecialOpponent;
    private string drawQuote;
    
    // Methods
    public QuoteData GetQuoteData()
    {
        var val_42;
        var val_43;
        UnityEngine.Object val_44;
        UnityEngine.Object val_45;
        UnityEngine.Object val_46;
        var val_47;
        UnityEngine.Object val_48;
        var val_49;
        var val_50;
        string val_52;
        var val_53;
        QuoteData val_0;
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        InkWars.Model.GameResult val_2 = val_1.Model.GameResult;
        if(val_2 != 6)
        {
                if(val_2 != 3)
        {
            goto label_4;
        }
        
        }
        
        label_53:
        label_50:
        val_0.color.r = this.quoteColor_Draw;
        val_0.color.g = ;
        val_0.color.b = ;
        val_0.color.a = ;
        val_0.quote = LanguageManager.GetText(key:  static_value_0332F190);
        return val_0;
        label_4:
        InkWars.Model.Model_Manager val_4 = InkWars.Model.Model_Manager.Instance;
        if(val_4.Model != null)
        {
                val_42 = val_4.Model.GetPlayer(PlayerNumber:  0);
        }
        else
        {
                val_42 = 0.GetPlayer(PlayerNumber:  0);
        }
        
        InkWars.Model.Model_Player val_7 = val_4.Model.GetPlayer(PlayerNumber:  1);
        if(val_2 != 4)
        {
                if(val_2 != 1)
        {
            goto label_11;
        }
        
        }
        
        val_43 = CharacterDataManager.Get(id:  val_6.Name);
        if(val_6.Name == 0)
        {
            goto label_14;
        }
        
        val_44 = public System.String System.Enum::ToString();
        string val_9 = val_6.Name.ToString();
        goto label_15;
        label_11:
        val_43 = CharacterDataManager.Get(id:  val_7.Name);
        if(val_7.Name == 0)
        {
            goto label_18;
        }
        
        val_45 = public System.String System.Enum::ToString();
        string val_11 = val_7.Name.ToString();
        goto label_19;
        label_14:
        val_44 = public System.String System.Enum::ToString();
        string val_12 = val_6.Name.ToString();
        label_15:
        val_6.Name.Add(driver:  val_44, rectTransform:  0, drivenProperties:  null);
        if(val_7.Name != 0)
        {
                val_46 = public System.String System.Enum::ToString();
            string val_13 = val_7.Name.ToString();
        }
        else
        {
                val_46 = public System.String System.Enum::ToString();
            string val_14 = val_7.Name.ToString();
        }
        
        val_7.Name.Add(driver:  val_46, rectTransform:  0, drivenProperties:  null);
        val_47 = val_7;
        goto label_22;
        label_18:
        val_45 = public System.String System.Enum::ToString();
        string val_15 = val_7.Name.ToString();
        label_19:
        val_7.Name.Add(driver:  val_45, rectTransform:  0, drivenProperties:  null);
        if(null != 0)
        {
                val_48 = public System.String System.Enum::ToString();
            string val_16 = null.ToString();
        }
        else
        {
                val_48 = public System.String System.Enum::ToString();
            string val_17 = null.ToString();
        }
        
        null.Add(driver:  val_48, rectTransform:  0, drivenProperties:  null);
        val_47 = val_42;
        val_42 = val_7;
        label_22:
        if(val_7.BubblesRemainingOnMatchConclusion >= (CharacterHelper.GetMinBubbleCountForInkSequence(winnerId:  val_7.Name)))
        {
            goto label_27;
        }
        
        if(val_7.BubblesRemainingOnMatchConclusion >= 6)
        {
            goto label_28;
        }
        
        string val_20 = val_43.localizedText.winQuote5Balls;
        goto label_34;
        label_27:
        string val_22 = val_43.localizedText.winQuote20Balls;
        goto label_34;
        label_28:
        label_34:
        val_52 = val_43.localizedText.winQuote19Balls;
        if((val_2 & 4294967294) == 4)
        {
                val_52 = val_43.localizedText.winQuoteTimeOut;
            UnityEngine.Color val_28 = UnityEngine.Color.blue;
            val_49 = val_28.g;
            val_50 = val_28.a;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_43.localizedText.GetSpecialOpponentQuote(opponentId:  val_6.Name))) != true)
        {
                val_52 = val_43.localizedText.GetSpecialOpponentQuote(opponentId:  val_6.Name);
        }
        
        if((System.String.IsNullOrEmpty(value:  val_52)) == true)
        {
            goto label_50;
        }
        
        if((val_52.StartsWith(value:  "\"")) != false)
        {
                val_52 = val_52.Substring(startIndex:  1);
        }
        
        if((val_52.EndsWith(value:  "\"")) == false)
        {
            goto label_50;
        }
        
        if(val_52 != null)
        {
                val_53 = val_52.Length;
        }
        else
        {
                val_53 = 0.Length;
        }
        
        string val_41 = val_52.Substring(startIndex:  0, length:  val_53 - 1);
        goto label_53;
    }
    public View_PVPGameOverQuote()
    {
        this.drawQuote = static_value_0332F198;
    }

}
