using UnityEngine;
public class CharacterAvatarController : MonoBehaviour
{
    // Fields
    public CharacterNameID characterID;
    private CharacterAvatarController.CharacterAvatarMaskType maskType;
    private int borderWidthPer256Pixel;
    private bool faceLeft;
    private bool refreshAtAwake;
    private UnityEngine.UI.Image border;
    private UnityEngine.UI.Image bg;
    private UnityEngine.UI.Image avatar;
    private CharacterAvatarImageCollection bgCollection;
    private CharacterAssetLoader linkedLoader;
    private UnityEngine.Vector3 originScale;
    
    // Methods
    private void Awake()
    {
        if(this.refreshAtAwake != false)
        {
                this.Setup(cid:  this.characterID, reloadAvatar:  true);
        }
        
        UnityEngine.Vector3 val_2 = this.transform.localScale;
        this.originScale = val_2;
        mem[1152921528886403060] = val_2.y;
        mem[1152921528886403064] = val_2.z;
    }
    public void Init(CharacterNameID cid, CharacterAvatarController.CharacterAvatarMaskType aNewMaskType, bool reloadAvatar = True, bool isFaceLeft = True)
    {
        this.faceLeft = isFaceLeft;
        this.maskType = aNewMaskType;
        this.Setup(cid:  cid, reloadAvatar:  reloadAvatar);
    }
    private void Setup(CharacterNameID cid, bool reloadAvatar = True)
    {
        this.characterID = cid;
        cid.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  reloadAvatar, drivenProperties:  null);
        this.gameObject.name = "AVATAR_" + cid.ToString();
        this.SetBorderWidth(widthInPixelPre256Pixels:  this.borderWidthPer256Pixel);
        this.SetFaceLeft(isFaceLeft:  this.faceLeft);
        this.SetMask(aNewBgType:  this.maskType, updateAvatarMask:  true);
        this.AutoSetBg();
        if(reloadAvatar == false)
        {
                return;
        }
        
        this.LoadAvatar(isInked:  false);
    }
    public void SetBorderWidth(int widthInPixelPre256Pixels)
    {
        this.borderWidthPer256Pixel = widthInPixelPre256Pixels;
        this.SetImageOffset(img:  this.avatar, offset:  (float)widthInPixelPre256Pixels);
        this.SetImageOffset(img:  this.bg, offset:  (float)this.borderWidthPer256Pixel);
    }
    public void SetBorderColor(UnityEngine.Color color)
    {
        this.border.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
    }
    public void SetAvatarColor(UnityEngine.Color color)
    {
        this.avatar.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
    }
    public void Refresh()
    {
        this.Setup(cid:  this.characterID, reloadAvatar:  true);
    }
    public void SetScale(float scale)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.originScale, y = V10.16B, z = V9.16B}, d:  scale);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public void SetRoundAvatarScale()
    {
        this.SetScale(scale:  1.35f);
    }
    public void SetShopAvatarScale()
    {
        this.SetScale(scale:  1.2f);
    }
    public void SetFaceLeft(bool isFaceLeft)
    {
        UnityEngine.RectTransform val_1 = this.avatar.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_2 = val_1.localScale;
        float val_5 = val_2.x;
        val_5 = ((isFaceLeft != true) ? -1f : 1f) * System.Math.Abs(val_5);
        val_1.localScale = new UnityEngine.Vector3() {x = val_5, y = val_2.y, z = val_2.z};
    }
    public void SetMask(CharacterAvatarController.CharacterAvatarMaskType aNewBgType, bool updateAvatarMask = True)
    {
        UnityEngine.Material val_1;
        UnityEngine.Sprite val_2;
        UnityEngine.Material val_3;
        if(this.characterID == 999999)
        {
                val_1 = 0;
            val_2 = 0;
        }
        else
        {
                if(aNewBgType == 1)
        {
                val_2 = this.bgCollection.MaskSpriteRoundedRect;
            val_3 = this.bgCollection.MaskMaterialRoundedRect;
        }
        else
        {
                val_2 = this.bgCollection.MaskSpriteRound;
            val_3 = this.bgCollection.MaskMaterialRound;
        }
        
            val_1 = mem[this.bgCollection.MaskMaterialRound];
        }
        
        this.SetImageSprite(img:  this.border, sp:  val_2);
        if(updateAvatarMask != false)
        {
                this.SetImageMaterial(img:  this.avatar, maskSprite:  val_1);
        }
        
        this.SetImageMaterial(img:  this.bg, maskSprite:  val_1);
    }
    public void SetBg(UnityEngine.Sprite sp)
    {
        this.SetImageSprite(img:  this.bg, sp:  sp);
    }
    public void AutoSetBg()
    {
        UnityEngine.Sprite val_3;
        if(this.characterID != 999999)
        {
            goto label_1;
        }
        
        val_3 = 0;
        goto label_17;
        label_1:
        CharacterData val_1 = CharacterDataManager.Get(id:  this.characterID);
        if(val_1.realPersonCharacter == false)
        {
            goto label_6;
        }
        
        if(this.maskType != 1)
        {
            goto label_8;
        }
        
        label_19:
        val_3 = this.bgCollection.BGOrange;
        goto label_17;
        label_6:
        CharacterClan val_2 = Character_GlobalInfo.GetClan(characterId:  this.characterID);
        if(val_2 == 2)
        {
            goto label_12;
        }
        
        if(val_2 == 1)
        {
            goto label_13;
        }
        
        val_3 = 0;
        if(val_2 != 0)
        {
            goto label_17;
        }
        
        val_3 = this.bgCollection.BGRed;
        goto label_17;
        label_8:
        val_3 = this.bgCollection.BGPurple;
        goto label_17;
        label_12:
        if(this.bgCollection != null)
        {
            goto label_19;
        }
        
        goto label_19;
        label_13:
        val_3 = this.bgCollection.BGBlue;
        label_17:
        this.SetImageSprite(img:  this.bg, sp:  val_3);
    }
    public void SetAvatar(UnityEngine.Sprite sp)
    {
        this.SetImageSprite(img:  this.avatar, sp:  sp);
    }
    public void LoadAvatar(bool isInked = False)
    {
        CharacterAvatarController.<>c__DisplayClass27_0 val_1 = new CharacterAvatarController.<>c__DisplayClass27_0();
        if(val_1 != null)
        {
                .isInked = isInked;
        }
        else
        {
                mem[16] = isInked;
        }
        
        .<>4__this = this;
        if(this.characterID == 999999)
        {
                return;
        }
        
        CharacterAssetLoader.Get(id:  this.characterID, callback:  new UnityEngine.Events.UnityAction<CharacterAssetLoader>(object:  val_1, method:  System.Void CharacterAvatarController.<>c__DisplayClass27_0::<LoadAvatar>b__0(CharacterAssetLoader loader)));
    }
    private void SetImageSprite(UnityEngine.UI.Image img, UnityEngine.Sprite sp)
    {
        if(0 == img)
        {
                return;
        }
        
        if(img != null)
        {
                img.sprite = sp;
        }
        else
        {
                0.sprite = sp;
        }
        
        UnityEngine.Color val_2 = img.color;
        img.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = (0 != sp) ? 0f : 1f};
    }
    private void SetImageMaterial(UnityEngine.UI.Image img, UnityEngine.Material maskSprite)
    {
        if(0 == img)
        {
                return;
        }
        
        if(0 == maskSprite)
        {
                UnityEngine.Color val_3 = UnityEngine.Color.clear;
        }
        else
        {
                UnityEngine.Color val_4 = UnityEngine.Color.white;
        }
        
        img.color = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
    }
    private void SetImageOffset(UnityEngine.UI.Image img, float offset)
    {
        UnityEngine.RectTransform val_1 = img.GetComponent<UnityEngine.RectTransform>();
        if(0 == val_1)
        {
                return;
        }
        
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  -offset, y:  -offset);
        val_1.offsetMax = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  offset, y:  offset);
        val_1.offsetMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
    }
    public CharacterAvatarController()
    {
        this.characterID = 999999;
        this.borderWidthPer256Pixel = 7;
        this.faceLeft = true;
        this.refreshAtAwake = true;
    }

}
