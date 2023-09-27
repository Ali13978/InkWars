using UnityEngine;
public class CryptoCurrency : MonoBehaviour
{
    // Fields
    public static UnityEngine.Events.UnityEvent OnCryptoCurrencyChanged;
    private static decimal cryptoCurrency;
    
    // Properties
    public static decimal CryptoCurency { get; set; }
    
    // Methods
    public static decimal get_CryptoCurency()
    {
        null = null;
        return new System.Decimal() {flags = CryptoCurrency.cryptoCurrency, hi = CryptoCurrency.cryptoCurrency, lo = CryptoCurrency.OnCryptoCurrencyChanged.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = CryptoCurrency.OnCryptoCurrencyChanged.__il2cppRuntimeField_10>>32&0x0};
    }
    public static void set_CryptoCurency(decimal value)
    {
        null = null;
        CryptoCurrency.cryptoCurrency = value.flags;
        CryptoCurrency.OnCryptoCurrencyChanged.__il2cppRuntimeField_C = value.hi;
        CryptoCurrency.OnCryptoCurrencyChanged.__il2cppRuntimeField_10 = value.lo;
        CryptoCurrency.OnCryptoCurrencyChanged.__il2cppRuntimeField_14 = value.mid;
        CryptoCurrency.OnCryptoCurrencyChanged.Invoke();
    }
    public static void RemoveUserCurrencyChangeEvent()
    {
        MMOCUser.current.OnEvents.RemoveListener(call:  new UnityEngine.Events.UnityAction<MMOCEvents>(object:  0, method:  static System.Void CryptoCurrency::OnMMOCUserStatsChanged(MMOCEvents events)));
    }
    public static void ListenToUserCurrencyChangeEvent()
    {
        MMOCUser.current.OnEvents.RemoveListener(call:  new UnityEngine.Events.UnityAction<MMOCEvents>(object:  0, method:  static System.Void CryptoCurrency::OnMMOCUserStatsChanged(MMOCEvents events)));
        MMOCUser.current.OnEvents.AddListener(call:  new UnityEngine.Events.UnityAction<MMOCEvents>(object:  0, method:  static System.Void CryptoCurrency::OnMMOCUserStatsChanged(MMOCEvents events)));
        CryptoCurrency.OnMMOCUserStatsChanged(events:  1);
    }
    private static void OnMMOCUserStatsChanged(MMOCEvents events)
    {
        var val_8;
        decimal val_9;
        var val_10;
        var val_11;
        val_8 = events;
        if(val_8 != 1)
        {
                return;
        }
        
        if(MMOCUser.current.userProfile != null)
        {
                val_9 = val_4.gems;
            val_10 = MMOCUser.current.userProfile + 40;
        }
        else
        {
                val_11 = null;
            val_11 = null;
            val_9 = 1152921504618352648;
            val_10 = 1152921504618352656;
        }
        
        CryptoCurrency.CryptoCurency = new System.Decimal() {flags = val_9, hi = val_9, lo = mem[1152921504618352656], mid = mem[1152921504618352656]};
        decimal val_5 = CryptoCurrency.CryptoCurency;
        string val_6 = val_5.flags.ToString();
    }
    public CryptoCurrency()
    {
    
    }
    private static CryptoCurrency()
    {
        CryptoCurrency.OnCryptoCurrencyChanged = new UnityEngine.Events.UnityEvent();
        CryptoCurrency.cryptoCurrency = 0m;
        CryptoCurrency.OnCryptoCurrencyChanged.__il2cppRuntimeField_10 = 0;
    }

}
