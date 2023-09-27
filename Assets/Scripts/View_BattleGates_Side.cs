using UnityEngine;
[Serializable]
public struct View_BattleGates_Side
{
    // Fields
    public UnityEngine.GameObject container_PlayerSide;
    public UnityEngine.GameObject container_TopInfo;
    public UnityEngine.GameObject container_BattleEnhancer;
    public UnityEngine.GameObject container_BottomInfo;
    public UnityEngine.GameObject container_TopLAN;
    public UnityEngine.GameObject container_TopNetworked;
    public UnityEngine.GameObject container_BottomNetworked;
    public UnityEngine.UI.Image image_Background;
    public UnityEngine.UI.Image image_ClanSymbol;
    public UnityEngine.UI.Image image_CharacterPose;
    public UnityEngine.UI.Image image_Stats;
    public UnityEngine.UI.Image image_Flag;
    public UnityEngine.UI.Image image_AvatarIcon;
    public CustomTitle title;
    public UnityEngine.UI.Image image_RankTitle;
    public UnityEngine.UI.Text text_UserID;
    public TMPro.TextMeshProUGUI text_PlayerPoints;
    public TMPro.TextMeshProUGUI text_Starfish;
    public UnityEngine.GameObject record;
    public CharacterNameController nameController;
    public BattleEnhancerIndicator enhancerIndicator;
    public bool gateLoaded;
    public bool readyToOpen;
    
    // Methods
    public void Init()
    {
    
    }
    public void SetupNetworkUserInfo(NetworkUserInfo data, CharacterNameID cid, PlayerType playerType)
    {
    
    }

}
