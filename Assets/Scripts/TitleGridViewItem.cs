using UnityEngine;
public class TitleGridViewItem : UnlockableGridViewItem<ProfileUnlockables_Title, TitleGridView>
{
    // Fields
    private CustomTitle title;
    
    // Methods
    public override void OnClick()
    {
        if(0 != static_value_03330000)
        {
                if(X21 != 0)
        {
            goto label_5;
        }
        
        }
        else
        {
                this = 1152921528856236504;
        }
        
        label_5:
        UnityEngine.Debug.Log(message:  TitleGridViewItem.__il2cppRuntimeField_name);
    }
    protected override void OnSetup(ProfileUnlockables_Title aNewData, TitleGridView aNewParent)
    {
        UnityEngine.Object val_6;
        UnityEngine.Object val_7;
        this.title.Setup(title:  aNewData);
        val_6 = this.GetComponent<UnityEngine.CanvasGroup>();
        val_7 = val_6;
        if(0 == val_7)
        {
                val_7 = public UnityEngine.CanvasGroup UnityEngine.GameObject::AddComponent<UnityEngine.CanvasGroup>();
            val_6 = this.gameObject.AddComponent<UnityEngine.CanvasGroup>();
        }
        
        val_6.alpha = (aNewData != 1) ? 1f : 0.5f;
    }
    public TitleGridViewItem()
    {
    
    }

}
