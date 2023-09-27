using UnityEngine;
public class MVC_Bot_Base : MonoBehaviour
{
    // Fields
    public static MVC_Bot_Base.AutoBotModes NetworkControlMode;
    public static MVC_Bot_Base P1Bot;
    public static MVC_Bot_Base P2Bot;
    public System.Collections.Generic.List<CharacterNameID> SelectTheseCharacters;
    private bool _controlsPlayer2;
    public MVC_Bot_Base.AutoBotModes AutomaticMode;
    public InkWars.Model.BubbleTypes specialBubble;
    public float MinTimeToAim;
    public float MaxTimeToAim;
    public float MinInkEmUpTime;
    public float MaxInkEmUpTime;
    internal float nextReaction;
    internal float nextTimeToAim;
    internal float nextTimeToAimTotal;
    internal InkWars.Model.AimTarget nextAimingAt;
    
    // Properties
    public bool ControlsPlayer2 { get; set; }
    internal InkWars.Model.Model_Player Player { get; }
    internal InkWars.Model.Model_Player OtherPlayer { get; }
    
    // Methods
    public bool get_ControlsPlayer2()
    {
        return (bool)this._controlsPlayer2;
    }
    public void set_ControlsPlayer2(bool value)
    {
        this._controlsPlayer2 = value;
        this.OnDisable();
        this.OnEnable();
    }
    private void OnDisable()
    {
        if(this == MVC_Bot_Base.P2Bot)
        {
                MVC_Bot_Base.P2Bot = 0;
        }
        
        if(this != MVC_Bot_Base.P1Bot)
        {
                return;
        }
        
        MVC_Bot_Base.P1Bot = 0;
    }
    private void OnEnable()
    {
        var val_4;
        InkWars.Model.BubbleTypes val_5;
        var val_1 = (this._controlsPlayer2 == true) ? 1152921505091514384 : 1152921505091514376;
        mem2[0] = this;
        if(this.AutomaticMode != 0)
        {
                MVC_Bot_Base.NetworkControlMode = this.AutomaticMode;
        }
        
        this.nextReaction = 2f;
        val_4 = null;
        val_4 = null;
        if(Character_GlobalInfo.gameMode != 4)
        {
                return;
        }
        
        if(UnityEngine.Random.value > 0.3333333f)
        {
                return;
        }
        
        if(UnityEngine.Random.value < 0.5f)
        {
                val_5 = 9;
        }
        else
        {
                val_5 = 8;
        }
        
        this.specialBubble = val_5;
    }
    internal InkWars.Model.Model_Player get_Player()
    {
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        return (InkWars.Model.Model_Player)(this._controlsPlayer2 == false) ? val_1.Model.Player1 : val_1.Model.Player2;
    }
    internal InkWars.Model.Model_Player get_OtherPlayer()
    {
        InkWars.Model.Model_Manager val_1 = InkWars.Model.Model_Manager.Instance;
        return (InkWars.Model.Model_Player)(this._controlsPlayer2 == false) ? val_1.Model.Player2 : val_1.Model.Player1;
    }
    public MVC_Bot_Base()
    {
        this.MinTimeToAim = ;
        this.MaxTimeToAim = ;
        this.MinInkEmUpTime = 0.1f;
        this.MaxInkEmUpTime = 0.2f;
    }

}
