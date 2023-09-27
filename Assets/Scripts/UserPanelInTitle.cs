using UnityEngine;
public class UserPanelInTitle : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image avatar;
    private UnityEngine.UI.Text nameTxt;
    private TMPro.TextMeshProUGUI ppTxt;
    private TMPro.TextMeshProUGUI highScoreTxt;
    private TMPro.TextMeshProUGUI winCount;
    private TMPro.TextMeshProUGUI loseCount;
    private TMPro.TextMeshProUGUI drawCount;
    private CustomTitle title;
    private UnityEngine.UI.Button logoutButton;
    private TMPro.TextMeshProUGUI savingText;
    private CloudLoginFlowController loginController;
    
    // Methods
    private void Setup()
    {
        this.RefreshAvatarAndTitle();
        this.RefreshData();
        this.EnableLogout(enable:  false);
    }
    private void RefreshData()
    {
        var val_16;
        string val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_16 = null;
        val_16 = null;
        string val_2 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  DataStructs.UserDataDictionary.Settings.UserName);
        Utility.SetBoldTextWithBlackOutline(txtObj:  this.nameTxt);
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_3 = DataStructs.UserDataDictionary.Stats.PlayerPoints;
        val_17 = val_3.currentCryptoKey.ToString();
        this.ppTxt.text = val_17;
        if(0 != this.winCount)
        {
                val_18 = null;
            val_18 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_6 = DataStructs.UserDataDictionary.Stats.NetworkWins;
            val_17 = val_6.currentCryptoKey.ToString();
            this.winCount.text = val_17;
        }
        
        if(0 != this.loseCount)
        {
                val_19 = null;
            val_19 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_9 = DataStructs.UserDataDictionary.Stats.NetworkLoses;
            val_17 = val_9.currentCryptoKey.ToString();
            this.loseCount.text = val_17;
        }
        
        if(0 != this.drawCount)
        {
                val_20 = null;
            val_20 = null;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_12 = DataStructs.UserDataDictionary.Stats.NetworkDraws;
            val_17 = val_12.currentCryptoKey.ToString();
            this.drawCount.text = val_17;
        }
        
        val_21 = null;
        val_21 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_14 = DataStructs.UserDataDictionary.Stats.AllTimeHighScore;
        this.highScoreTxt.text = val_14.currentCryptoKey.ToString();
    }
    private void RefreshAvatarAndTitle()
    {
        var val_8;
        DataStructs.Settings val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        val_9 = DataStructs.UserDataDictionary.Settings;
        if(val_9 == null)
        {
                return;
        }
        
        val_9 = DataStructs.UserDataDictionary.Settings;
        if(val_9 == null)
        {
                val_9 = 0;
        }
        
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = val_9.SelectedAvatar;
        this.avatar.sprite = AvatarCollection.GetAvatarSpriteFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited}));
        if(0 == this.title)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_5 = DataStructs.UserDataDictionary.Settings.SelectedTitle;
        this.title.Setup(title:  TitleCollection.GetTitleFromIntId(id:  CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_5.currentCryptoKey, hiddenValue = val_5.hiddenValue, fakeValue = val_5.fakeValue, inited = val_5.inited})));
    }
    private void OnAvatarAndTitleChange()
    {
        this.RefreshAvatarAndTitle();
    }
    private void OnEnable()
    {
        var val_7;
        UnityEngine.Events.UnityAction val_8;
        val_7 = null;
        val_7 = null;
        UnityEngine.Events.UnityAction val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UserPanelInTitle::OnAvatarAndTitleChange());
        AvatarAndTitleUpdater.OnAvatarAndTitleChangedEvent.AddListener(call:  val_1);
        this.Setup();
        if(0 != this.logoutButton)
        {
                UnityEngine.Events.UnityAction val_4 = null;
            val_8 = val_4;
            val_4 = new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void UserPanelInTitle::Logout());
            this.logoutButton.onClick.AddListener(call:  val_4);
        }
        
        this.InvokeRepeating(methodName:  "CheckLogoutEnable", time:  0.5f, repeatRate:  2f);
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.RefreshLayout());
        this.InvokeRepeating(methodName:  "RefreshData", time:  1f, repeatRate:  0.5f);
    }
    private System.Collections.IEnumerator RefreshLayout()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new UserPanelInTitle.<RefreshLayout>d__16();
    }
    private void OnDisable()
    {
        var val_5;
        this.CancelInvoke(methodName:  "CheckLogoutEnable");
        this.CancelInvoke(methodName:  "RefreshData");
        val_5 = null;
        val_5 = null;
        AvatarAndTitleUpdater.OnAvatarAndTitleChangedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UserPanelInTitle::OnAvatarAndTitleChange()));
        if(0 == this.logoutButton)
        {
                return;
        }
        
        this.logoutButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  public System.Void UserPanelInTitle::Logout()));
    }
    public void Logout()
    {
        var val_9;
        object[] val_1 = new object[3];
        val_1[0] = "<br>";
        val_9 = null;
        val_9 = null;
        val_1[1] = DataStructs.UserDataDictionary.Settings.UserName;
        val_1[2] = "<br>";
        DialogPanel val_8 = DialogManager.ShowConfirmDialog(title:  LanguageManager.GetText(key:  "LK.MenuTitle.Logout.Title"), message:  LanguageManager.GetTextFormat(key:  "LK.MenuTitle.Logout.Body", list:  val_1), confirmButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Logout.Logout"), cancelButtonTitle:  LanguageManager.GetText(key:  "LK.MenuTitle.Logout.Cancel"), onConfirmCallback:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UserPanelInTitle::LogoutUser()), onCancelCallback:  0);
    }
    private void LogoutUser()
    {
        var val_2;
        System.Action<System.Boolean, System.String> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = UserPanelInTitle.<>c.<>9__19_0;
        if(val_4 == null)
        {
                System.Action<System.Boolean, System.String> val_1 = null;
            val_4 = val_1;
            val_1 = new System.Action<System.Boolean, System.String>(object:  UserPanelInTitle.<>c.__il2cppRuntimeField_static_fields, method:  System.Void UserPanelInTitle.<>c::<LogoutUser>b__19_0(bool done, string msg));
            UserPanelInTitle.<>c.<>9__19_0 = val_4;
        }
        
        IWServerDB_Cache.SaveCache(onResult:  val_1);
    }
    public void EnableLogout(bool enable)
    {
        if(0 != this.logoutButton)
        {
                this.logoutButton.gameObject.SetActive(value:  enable);
        }
        
        this.savingText.gameObject.SetActive(value:  (~enable) & 1);
    }
    private void CheckLogoutEnable()
    {
        this.EnableLogout(enable:  true);
    }
    public UserPanelInTitle()
    {
    
    }

}
