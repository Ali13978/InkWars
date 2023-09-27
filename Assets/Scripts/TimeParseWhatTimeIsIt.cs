using UnityEngine;
public class TimeParseWhatTimeIsIt : IOnlineTimeParser
{
    // Methods
    public string GetUrl()
    {
        return "http://www.whattimeisit.com/";
    }
    public string GetTimeStringFromWWWText(string WWWText)
    {
        string val_2 = WWWText.Substring(startIndex:  0, length:  WWWText.IndexOf(value:  "UTC"));
        string val_4 = val_2.Substring(startIndex:  val_2.LastIndexOf(value:  "<B>"));
        return (string)val_4.Substring(startIndex:  0, length:  val_4.IndexOf(value:  "<BR>")).Replace(oldValue:  "<B>", newValue:  "");
    }
    public TimeParseWhatTimeIsIt()
    {
    
    }

}
