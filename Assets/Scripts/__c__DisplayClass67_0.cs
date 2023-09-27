using UnityEngine;
private sealed class MVC_Multiplayer_Manager_Base.<>c__DisplayClass67_0
{
    // Fields
    public int rounds;
    public InkWars.Model.MVC_Multiplayer_Manager_Base <>4__this;
    
    // Methods
    public MVC_Multiplayer_Manager_Base.<>c__DisplayClass67_0()
    {
    
    }
    internal void <ReloadNetworkLobbyScene>b__0(MMOCClientUser.MMOCUserProfile profile)
    {
        MVC_GameScene_Activator val_11;
        var val_12;
        InkWars.Model.MVC_Multiplayer_Manager_Base val_13;
        val_11 = this;
        string val_1 = profile.gems.ToString();
        val_12 = null;
        val_12 = null;
        string val_2 = ToString();
        if(((profile.gems & 1) == 0) && (this.rounds < 21))
        {
                val_13 = this.<>4__this;
            int val_3 = this.rounds + 1;
            this.rounds = val_3;
            val_13.ReloadNetworkLobbyScene(rounds:  val_3);
            return;
        }
        
        CryptoCurrency.ListenToUserCurrencyChangeEvent();
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Equality(a:  val_4.m_Handle.name, b:  "NetworkLobbyNew")) != false)
        {
                UnityEngine.Debug.Log(message:  "++++++++++++++++ reload NetworkLobbyNew.");
            UnityEngine.SceneManagement.Scene val_7 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            AsyncSceneLoader.Load(sceneName:  val_7.m_Handle.name, minimumDelayInSeconds:  0f, showLoadingScreen:  false, autoHideLoadingScreen:  true);
        }
        
        val_13 = 1152921505092362240;
        val_11 = MVC_GameScene_Activator.instance;
        if(0 == val_11)
        {
                return;
        }
        
        val_11 = MVC_GameScene_Activator.instance.gameObject;
        UnityEngine.Object.Destroy(obj:  val_11);
    }

}
