using UnityEngine;
public class CustomTitle : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image bg;
    private TMPro.TextMeshProUGUI titleText;
    private CharacterAvatarController avatarController;
    private UnityEngine.UI.Image avatarCover;
    private TitleBGCollection bgSource;
    private UnityEngine.Vector2 offsetMin;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector2 val_2 = this.titleText.GetComponent<UnityEngine.RectTransform>().offsetMin;
        this.offsetMin = val_2;
        mem[1152921528853006820] = val_2.y;
    }
    public void Setup(ProfileUnlockables_Title title)
    {
        this.bg.sprite = this.bgSource.GetSpriteByType(type:  title.BGType);
        this.titleText.text = title.Title;
        if((title & 1) != 0)
        {
            
        }
        
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  70f, y:  19.5f);
        this.titleText.GetComponent<UnityEngine.RectTransform>().offsetMin = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  -10f, y:  -0.5f);
        this.titleText.GetComponent<UnityEngine.RectTransform>().offsetMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        this.titleText.fontSizeMin = 8f;
        this.titleText.overflowMode = 0;
        this.avatarController.gameObject.SetActive(value:  (1152921525069039472 != 999999) ? 1 : 0);
        this.avatarController.Init(cid:  1152921525069039472, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  false);
        UnityEngine.Color val_8 = this.bgSource.GetColorByType(type:  title.BGType);
        this.avatarCover.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
    }
    public CustomTitle()
    {
    
    }

}
