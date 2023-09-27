using UnityEngine;
public class NetworkUtils : MonoBehaviour
{
    // Methods
    public static UnityEngine.Sprite GetCountry(DataStructs.Flag _flag)
    {
        _flag.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        return (UnityEngine.Sprite)UnityEngine.Resources.Load<UnityEngine.Sprite>(path:  "Countryflags/"("Countryflags/") + _flag.ToString());
    }
    public static string InsertSpacesInCamelCasingNaming(string _string)
    {
        return System.Text.RegularExpressions.Regex.Replace(input:  _string, pattern:  "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", replacement:  "$1 ");
    }
    public static void SetImageSpriteWithSpriteSize(UnityEngine.UI.Image _i, UnityEngine.Sprite _s)
    {
        float val_3;
        UnityEngine.Bounds val_1 = _s.bounds;
        UnityEngine.Bounds val_4 = _s.bounds;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_3 * 100f, y:  S1 * 100f);
        _i.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        _i.sprite = _s;
    }
    public NetworkUtils()
    {
    
    }

}
