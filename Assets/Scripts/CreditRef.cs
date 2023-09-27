using UnityEngine;
public class Credits.CreditRef
{
    // Fields
    public string Text;
    public Credits.CreditStyle Style;
    
    // Methods
    public Credits.CreditRef(string text)
    {
        this.Text = text;
        this.Style = 1;
    }
    public Credits.CreditRef(string text, Credits.CreditStyle style)
    {
        this.Text = text;
        this.Style = style;
    }

}
