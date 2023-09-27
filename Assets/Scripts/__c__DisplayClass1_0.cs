using UnityEngine;
private sealed class UnityIAPHandler.<>c__DisplayClass1_0
{
    // Fields
    public IAPItemIds id;
    public System.Action onDone;
    
    // Methods
    public UnityIAPHandler.<>c__DisplayClass1_0()
    {
    
    }
    internal void <OnPurchaseComplete>b__0()
    {
        VIP.BuyVIPFull(vipIAPIds:  this.id);
        DialogManager.HideLoading();
        MainThreadDispatcher.Invoke(action:  this.onDone, delay:  0f);
    }
    internal void <OnPurchaseComplete>b__1()
    {
        VIP.BuyVIPUpgrade(vipIAPIds:  this.id);
        DialogManager.HideLoading();
        MainThreadDispatcher.Invoke(action:  this.onDone, delay:  0f);
    }

}
