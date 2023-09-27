using UnityEngine;
private sealed class NetworkUIController.<>c__DisplayClass25_0
{
    // Fields
    public NetworkUIController.MenuType _menuType;
    public NetworkUIController <>4__this;
    
    // Methods
    public NetworkUIController.<>c__DisplayClass25_0()
    {
    
    }
    internal void <ShowMenu>b__0()
    {
        var val_11;
        NetworkUIController val_12;
        object[] val_1 = new object[1];
        val_1[0] = this._menuType;
        UnityEngine.Debug.LogFormat(format:  "Menu Type: {0}", args:  val_1);
        val_11 = 0;
        goto label_7;
        label_32:
        NetworkUIMenu val_2 = X22 + 72.Item[0];
        NetworkUIMenu val_3 = this.<>4__this.m_MenuList.Item[0];
        if(val_2.m_MenuType != this._menuType)
        {
            goto label_13;
        }
        
        val_3.Show();
        this.<>4__this.m_MenuList.Item[0].ApplyGradientToMaterial(_material:  this.<>4__this.m_GradientMaterial);
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  -30f, y:  0f);
        this.<>4__this.m_MenuDescriptionText.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        if((this.<>4__this.canRefreshDescText) == false)
        {
            goto label_28;
        }
        
        val_12 = this.<>4__this;
        if((this.<>4__this) != null)
        {
            goto label_23;
        }
        
        val_12 = this.<>4__this;
        if(val_12 == null)
        {
            goto label_24;
        }
        
        label_23:
        NetworkUIMenu val_7 = this.<>4__this.m_MenuList.Item[0];
        this.<>4__this.m_MenuDescriptionText.text = val_7.m_MenuDescription;
        goto label_28;
        label_13:
        val_3.Hide();
        label_28:
        val_11 = 1;
        label_7:
        if(val_11 < (this.<>4__this.m_MenuList.Count))
        {
            goto label_32;
        }
        
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.m_TransitionImage, endValue:  0f, duration:  0.15f), delay:  0.25f);
        return;
        label_24:
    }

}
