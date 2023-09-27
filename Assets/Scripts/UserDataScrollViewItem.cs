using UnityEngine;
public class UserDataScrollViewItem : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI titleText;
    private TMPro.TextMeshProUGUI valueText;
    private UnityEngine.UI.Image valueImage;
    private CharacterAvatarController avatarValue;
    private UnityEngine.UI.Image bottomLine;
    
    // Methods
    public UserDataScrollViewItem Setup(string title, string value)
    {
        this.valueImage.gameObject.SetActive(value:  false);
        this.valueText.gameObject.SetActive(value:  true);
        this.avatarValue.gameObject.SetActive(value:  false);
        this.titleText.text = title;
        this.valueText.text = value;
        return (UserDataScrollViewItem)this;
    }
    public UserDataScrollViewItem SetupImage(string title, UnityEngine.Sprite sprite)
    {
        this.valueImage.gameObject.SetActive(value:  true);
        this.valueText.gameObject.SetActive(value:  false);
        this.avatarValue.gameObject.SetActive(value:  false);
        this.titleText.text = title;
        this.valueImage.sprite = sprite;
        return (UserDataScrollViewItem)this;
    }
    public UserDataScrollViewItem SetupAvatar(string title, CharacterNameID cid)
    {
        if((CharacterHelper.IsHidden(cid:  cid)) != false)
        {
                return this.Setup(title:  title, value:  "???");
        }
        
        this.valueImage.gameObject.SetActive(value:  false);
        this.valueText.gameObject.SetActive(value:  false);
        this.avatarValue.gameObject.SetActive(value:  true);
        this.titleText.text = title;
        this.avatarValue.Init(cid:  cid, aNewMaskType:  0, reloadAvatar:  true, isFaceLeft:  true);
        return (UserDataScrollViewItem)this;
    }
    public void ShowBottomLine(bool show)
    {
        this.bottomLine.gameObject.SetActive(value:  show);
    }
    public UserDataScrollViewItem()
    {
    
    }

}
