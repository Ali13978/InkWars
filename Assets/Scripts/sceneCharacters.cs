using UnityEngine;
public class sceneCharacters : MonoBehaviour
{
    // Fields
    public static sceneCharacters instance;
    public TMPro.TextMeshProUGUI defaultName;
    public UnityEngine.UI.Image defaultCharacters;
    public UnityEngine.UI.Image defaultPower;
    public UnityEngine.UI.Text pearlCount;
    public UnityEngine.GameObject buyButton;
    public PearlBuyButton pearlBuyButton;
    public CharacterNameController nameController;
    public UnityEngine.UI.GridLayoutGroup gridHolder;
    public UnityEngine.GameObject ikaPanel;
    public UnityEngine.GameObject takoPanel;
    public UnityEngine.GameObject specialPanel;
    public UnityEngine.UI.Image takoButtonImage;
    public UnityEngine.UI.Image ikaButtonImage;
    public UnityEngine.UI.Image specialButtonImage;
    public static CharacterNameID DirectCharacterLink;
    public UnityEngine.GameObject normalPanel;
    public CharacterStore_CelebInfoPanel celebInfoPanel;
    public UnityEngine.GameObject celebInfoButton;
    private UnityEngine.GameObject PearButton;
    private UnityEngine.GameObject ShellButton;
    private UnityEngine.GameObject ggpButton;
    public CharacterStore_Controller currentCharacterController;
    public System.Collections.Generic.List<CharacterStore_Controller> specialControllerList;
    public CharacterStore_Controller firstTako;
    public CharacterStore_Controller firstSpecial;
    public CharacterStore_Controller firstIka;
    private UnityEngine.AudioClip bgm;
    
    // Methods
    private void Awake()
    {
        null = null;
        sceneCharacters.instance = this;
        this.defaultCharacters.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.defaultPower.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        this.defaultName.text = "";
        GameAudio.SwitchMusic(clip:  this.bgm, customLoopStartTime:  0f, customLoopEndTime:  0f, forcePlay:  false);
        MainThreadDispatcher.Init();
        IAPCharacterPromoGift.CheckPromoGift(showLoadingWhenProc:  false);
        GGPPurchasingManager.instance.UpdateProducts();
    }
    private void Start()
    {
        UnityEngine.GameObject val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_23 = this;
        UnityEngine.Color val_1 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.takoButtonImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        TMPro.TextMeshProUGUI val_4 = this.takoButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_5 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.ikaButtonImage.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        TMPro.TextMeshProUGUI val_9 = this.ikaButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_10 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_11 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.specialButtonImage.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        TMPro.TextMeshProUGUI val_14 = this.specialButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_15 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.celebInfoPanel.gameObject.SetActive(value:  false);
        val_24 = null;
        val_24 = null;
        if(0 == (CharacterDataManager.Get(id:  sceneCharacters.DirectCharacterLink)))
        {
            goto label_24;
        }
        
        val_25 = null;
        if(val_17.realPersonCharacter == false)
        {
            goto label_26;
        }
        
        val_26 = null;
        this.SpecialButtonClickWithSelection(defaultSelect:  sceneCharacters.DirectCharacterLink);
        return;
        label_24:
        this.PearButton.gameObject.SetActive(value:  false);
        this.ShellButton.gameObject.SetActive(value:  true);
        this.ggpButton.gameObject.SetActive(value:  true);
        val_23 = this.takoPanel;
        val_23.SetActive(value:  true);
        return;
        label_26:
        val_27 = null;
        CharacterClan val_22 = Character_GlobalInfo.GetClan(characterId:  sceneCharacters.DirectCharacterLink);
        if((val_22 != 1) && (val_22 == 0))
        {
                this.IkaButtonClick();
            return;
        }
        
        this.TakoButtonClick();
    }
    public void TakoButtonClick()
    {
        this.celebInfoButton.SetActive(value:  false);
        this.takoPanel.SetActive(value:  true);
        this.ikaPanel.SetActive(value:  false);
        this.specialPanel.SetActive(value:  false);
        this.normalPanel.SetActive(value:  true);
        this.celebInfoPanel.gameObject.SetActive(value:  false);
        this.defaultName.gameObject.SetActive(value:  true);
        this.PearButton.gameObject.SetActive(value:  false);
        this.ShellButton.gameObject.SetActive(value:  true);
        this.ggpButton.gameObject.SetActive(value:  false);
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.takoButtonImage.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        TMPro.TextMeshProUGUI val_9 = this.takoButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_10 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_11 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.ikaButtonImage.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        TMPro.TextMeshProUGUI val_14 = this.ikaButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_15 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_16 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.specialButtonImage.color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
        TMPro.TextMeshProUGUI val_19 = this.specialButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        if((UnityEngine.Object.op_Implicit(exists:  this.firstTako)) == false)
        {
                return;
        }
        
        this = this.firstTako;
        this.SelectCharacterStart();
    }
    public void IkaButtonClick()
    {
        this.celebInfoButton.SetActive(value:  false);
        this.takoPanel.SetActive(value:  false);
        this.ikaPanel.SetActive(value:  true);
        this.specialPanel.SetActive(value:  false);
        this.normalPanel.SetActive(value:  true);
        this.celebInfoPanel.gameObject.SetActive(value:  false);
        this.defaultName.gameObject.SetActive(value:  true);
        this.PearButton.gameObject.SetActive(value:  false);
        this.ShellButton.gameObject.SetActive(value:  true);
        this.ggpButton.gameObject.SetActive(value:  false);
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.takoButtonImage.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        TMPro.TextMeshProUGUI val_9 = this.takoButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_10 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_11 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.ikaButtonImage.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        TMPro.TextMeshProUGUI val_14 = this.ikaButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_15 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_16 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.specialButtonImage.color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
        TMPro.TextMeshProUGUI val_19 = this.specialButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        if((UnityEngine.Object.op_Implicit(exists:  this.firstIka)) == false)
        {
                return;
        }
        
        this = this.firstIka;
        this.SelectCharacterStart();
    }
    public void SpecialButtonClick()
    {
        this.SpecialButtonClickWithSelection(defaultSelect:  42);
    }
    public void SpecialButtonClickWithSelection(CharacterNameID defaultSelect = 999999)
    {
        .defaultSelect = defaultSelect;
        this.celebInfoButton.SetActive(value:  false);
        this.takoPanel.SetActive(value:  false);
        this.ikaPanel.SetActive(value:  false);
        this.specialPanel.SetActive(value:  true);
        this.normalPanel.SetActive(value:  true);
        this.celebInfoPanel.gameObject.SetActive(value:  false);
        this.PearButton.gameObject.SetActive(value:  true);
        this.ShellButton.gameObject.SetActive(value:  true);
        this.ggpButton.gameObject.SetActive(value:  true);
        UnityEngine.Color val_6 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.takoButtonImage.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
        TMPro.TextMeshProUGUI val_9 = this.takoButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_10 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_11 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.ikaButtonImage.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
        TMPro.TextMeshProUGUI val_14 = this.ikaButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_15 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Color val_16 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this.specialButtonImage.color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
        TMPro.TextMeshProUGUI val_19 = this.specialButtonImage.transform.GetChild(index:  0).GetComponent<TMPro.TextMeshProUGUI>();
        UnityEngine.Color val_20 = UnityEngine.Color.op_Implicit(v:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        CharacterStore_Controller val_22 = this.specialControllerList.Find(match:  new System.Predicate<CharacterStore_Controller>(object:  new sceneCharacters.<>c__DisplayClass33_0(), method:  System.Boolean sceneCharacters.<>c__DisplayClass33_0::<SpecialButtonClickWithSelection>b__0(CharacterStore_Controller x)));
        if(0 == val_22)
        {
                this = this.firstSpecial;
            if(this != null)
        {
            goto label_35;
        }
        
        }
        
        label_35:
        val_22.SelectCharacterStart();
    }
    public void InfoButtonClick()
    {
        GameAudio.PlayButtonSound();
        this.celebInfoPanel.gameObject.SetActive(value:  true);
        this.normalPanel.SetActive(value:  false);
    }
    public void InfoBackButtonClick()
    {
        GameAudio.PlayButtonSound();
        this.normalPanel.SetActive(value:  true);
        this.celebInfoPanel.gameObject.SetActive(value:  false);
    }
    public void PurchaseButtonClicked()
    {
        GameAudio.PlayButtonSound();
    }
    private void Update()
    {
        string val_2 = PlayerPrefsManager.Pearls.ToString();
        if(this.pearlCount != null)
        {
                return;
        }
    
    }
    public void backtoShop()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Shop_Scene");
    }
    public void buttonInapp()
    {
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  val_1.m_Handle.name);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetPearl");
    }
    public sceneCharacters()
    {
        this.specialControllerList = new System.Collections.Generic.List<CharacterStore_Controller>();
    }
    private static sceneCharacters()
    {
        sceneCharacters.DirectCharacterLink = 42;
    }

}
