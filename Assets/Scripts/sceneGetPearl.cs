using UnityEngine;
public class sceneGetPearl : MonoBehaviour
{
    // Fields
    public static bool showShellPanelAsDefault;
    public TMPro.TextMeshProUGUI pearlCount;
    public TMPro.TextMeshProUGUI shellsCount;
    public UnityEngine.GameObject pearlBar;
    public UnityEngine.GameObject shellBar;
    public UnityEngine.GameObject pearlsPanel;
    public UnityEngine.GameObject shellsPanel;
    public UnityEngine.UI.Toggle shellToggle;
    public UnityEngine.UI.Toggle pearlToggle;
    private bool muteFirstButtonSoundForInit;
    
    // Methods
    private void Start()
    {
        var val_7;
        this.pearlCount.text = PlayerPrefsManager.Pearls.ToString();
        this.shellsCount.text = PlayerPrefsManager.GetShellString(shells:  PlayerPrefsManager.Shells);
        val_7 = null;
        val_7 = null;
        this.shellToggle.isOn = (sceneGetPearl.showShellPanelAsDefault == true) ? 1 : 0;
        this.pearlToggle.isOn = (sceneGetPearl.showShellPanelAsDefault == false) ? 1 : 0;
        sceneGetPearl.showShellPanelAsDefault = false;
    }
    public void onPearlsButtonClicked()
    {
        if(this.muteFirstButtonSoundForInit != false)
        {
                this.muteFirstButtonSoundForInit = false;
        }
        else
        {
                GameAudio.PlayButtonSound();
        }
        
        this.pearlsPanel.SetActive(value:  true);
        this.shellsPanel.SetActive(value:  false);
        this.pearlBar.SetActive(value:  true);
        this.shellBar.SetActive(value:  false);
    }
    public void onShellsButtonClicked()
    {
        GameAudio.PlayButtonSound();
        this.pearlsPanel.SetActive(value:  false);
        this.shellsPanel.SetActive(value:  true);
        this.pearlBar.SetActive(value:  false);
        this.shellBar.SetActive(value:  true);
    }
    private void Update()
    {
        this.pearlCount.text = PlayerPrefsManager.Pearls.ToString();
        this.shellsCount.text = PlayerPrefsManager.GetShellString(shells:  PlayerPrefsManager.Shells);
    }
    public void backButton()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  "LastLevel")) != true)
        {
                UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  "Menu_Title_Screen");
        }
        
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  UnityEngine.PlayerPrefs.GetString(key:  "LastLevel"));
    }
    public void onPurchaseButtonClick(int index)
    {
        GGPPurchasingManager.instance.BuyProductID(skuIndex:  index);
    }
    public sceneGetPearl()
    {
        this.muteFirstButtonSoundForInit = true;
    }
    private static sceneGetPearl()
    {
    
    }

}
