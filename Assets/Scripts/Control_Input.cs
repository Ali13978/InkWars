using UnityEngine;
public class Control_Input : Control_Base<Control_Input>
{
    // Fields
    public UnityEngine.UI.Image controlImage;
    public UnityEngine.RectTransform PointTop;
    public UnityEngine.RectTransform PointBottom;
    public UnityEngine.RectTransform PointCuttOff;
    public UnityEngine.UI.Button ButtonSwitcher;
    private bool Touching;
    private bool TryShoot;
    private InkWars.Model.AimTarget AimSegment;
    private int AimTargetCount;
    private float AimSegmentSize;
    private float TouchAreaTotalHeight;
    private bool UseMouseForInput;
    private int touchID;
    private System.Nullable<UnityEngine.Vector3> LastTouchPos;
    
    // Methods
    internal override void Start()
    {
        this.Start();
        this.ButtonSwitcher.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Control_Input::<Start>b__14_0()));
        this.controlImage.alphaHitTestMinimumThreshold = 0.5f;
        this.AimTargetCount = 8;
        int val_3 = UnityEngine.Screen.width;
        this.AimSegment = 0;
        float val_5 = (float)this.AimTargetCount;
        val_5 = (float)UnityEngine.Screen.height / val_5;
        this.AimSegmentSize = val_5;
        this.TouchAreaTotalHeight = (float)UnityEngine.Screen.height;
    }
    private void OnEnable()
    {
        InkWars.Model.Model_Events.Instance.add_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void Control_Input::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
    }
    private void OnDisable()
    {
        InkWars.Model.Model_Events.Instance.remove_OnGameResult(value:  new Model_Events.OnGameResultDelegate(object:  this, method:  System.Void Control_Input::OnGameResult(InkWars.Model.GameResult result, bool isFinished)));
    }
    private void OnGameResult(InkWars.Model.GameResult result, bool isFinished)
    {
        this.PointerUp();
    }
    public void PointerDown()
    {
        var val_4;
        if((this.Touching == true) || (this.UseMouseForInput == true))
        {
            goto label_3;
        }
        
        val_4 = 0;
        label_5:
        if(val_4 >= val_1.Length)
        {
            goto label_3;
        }
        
        var val_3 = (UnityEngine.Input.touches + (0 * 68)) + 32;
        val_4 = val_4 + 1;
        if(Seconds != 0)
        {
            goto label_5;
        }
        
        this.touchID = fingerId;
        label_3:
        this.Touching = true;
    }
    public void PointerUp()
    {
        var val_4;
        mem[1152921528276156156] = 0;
        this.LastTouchPos = 0;
        if(this.Touching == false)
        {
                return;
        }
        
        if(this.UseMouseForInput != false)
        {
                label_6:
            this.Touching = true;
            this.TryShoot = true;
            return;
        }
        
        UnityEngine.Touch[] val_1 = UnityEngine.Input.touches;
        val_4 = 0;
        goto label_3;
        label_8:
        var val_2 = 0 + 32;
        if(this.touchID == fingerId)
        {
                if(Seconds == 3)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 1;
        label_3:
        if(val_4 < val_1.Length)
        {
            goto label_8;
        }
    
    }
    private void Update()
    {
        var val_10;
        if(this.IsControlActive() == false)
        {
                return;
        }
        
        this.UpdateInput();
        val_10 = 1152921528276280912;
        InkWars.Model.Model_Core val_2 = Control_Base<Control_Input>.Model;
        if(val_2.Feature_InkEmUp != false)
        {
                InkWars.Model.Model_Core val_3 = Control_Base<Control_Input>.Model;
            if(val_3.InkEmUp_CurrentPhase == 4)
        {
                if(this.TryShoot == false)
        {
                return;
        }
        
            val_10 = Control_Base<Control_Input>.Model;
            if(this.PlayerModel != val_5.InkEmUp_Player)
        {
                return;
        }
        
            InkWars.Model.Model_Player val_6 = this.PlayerModel;
            val_6.TryInk = true;
            this.TryShoot = false;
            return;
        }
        
        }
        
        InkWars.Model.Model_Core val_7 = Control_Base<Control_Input>.Model;
        if(val_7.gamePhase != 1)
        {
                return;
        }
        
        if((this.TryShoot != false) && (this.AimSegment != 1))
        {
                if(this.AimSegment != 99)
        {
            goto label_15;
        }
        
        }
        
        this.PlayerModel.TryAimAt = this.AimSegment;
        return;
        label_15:
        InkWars.Model.Model_Player val_9 = this.PlayerModel;
        val_9.TryShoot = true;
        this.TryShoot = false;
        this.AimSegment = 99;
    }
    private void Switcher()
    {
        if(this.IsControlActive() == false)
        {
                return;
        }
        
        InkWars.Model.Model_Player val_2 = this.PlayerModel;
        val_2.TrySwitch = true;
        GameAudio.PlayBubbleSwitchSound();
    }
    private void UpdateInput()
    {
        float val_19;
        var val_27;
        float val_28;
        UnityEngine.RectTransform val_29;
        float val_30;
        float val_31;
        var val_32;
        int val_33;
        float val_34;
        InkWars.Model.AimTarget val_35;
        if(this.Touching == false)
        {
                return;
        }
        
        if(this.UseMouseForInput == false)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        goto label_3;
        label_2:
        if(UnityEngine.Input.touchCount == 0)
        {
                return;
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        val_27 = 0;
        goto label_5;
        label_11:
        var val_4 = 0 + 32;
        if(this.touchID == fingerId)
        {
                val_28 = V0.16B;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_28, y = V1.16B});
        }
        
        val_27 = 1;
        label_5:
        if(val_27 < val_3.Length)
        {
            goto label_11;
        }
        
        label_3:
        val_29 = 1152921511166049744;
        if(((-2099902576) & 1) == 0)
        {
                return;
        }
        
        if((16 & 1) == 0)
        {
            goto label_13;
        }
        
        label_20:
        this.LastTouchPos = 0;
        mem[1152921528276760428] = 0;
        InkWars.Model.Model_Player val_7 = this.PlayerModel;
        if(val_7.LoadedBubble != 8)
        {
            goto label_15;
        }
        
        this.AimSegment = 7;
        return;
        label_13:
        if(((-2099902672) & 1) == 0)
        {
                return;
        }
        
        val_28 = 0;
        val_30 = val_6.z;
        val_31 = val_6.y;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 0f, y = val_6.y, z = val_30}, rhs:  new UnityEngine.Vector3() {x = 0f, y = val_31, z = val_6.z})) == true)
        {
            goto label_20;
        }
        
        return;
        label_15:
        UnityEngine.Vector3 val_10 = this.PointTop.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_13 = this.PointBottom.position;
        UnityEngine.Vector3 val_14 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_30 = val_14.y;
        val_29 = this.PointCuttOff;
        UnityEngine.Vector3 val_16 = val_29.position;
        val_31 = val_16.z;
        UnityEngine.Vector3 val_17 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_31});
        val_28 = val_17.x;
        val_32 = null;
        val_32 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat val_18 = DataStructs.UserDataDictionary.Settings.ControllerSensitivity;
        float val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat() {hiddenValue = new CodeStage.AntiCheat.Common.ACTkByte4(), fakeValue = val_19, inited = val_19});
        val_33 = this.AimTargetCount;
        float val_21 = val_11.y - val_30;
        val_20 = val_20 * 0.5f;
        val_20 = val_20 + 0.5f;
        val_34 = val_21 * val_20;
        float val_24 = (float)val_33;
        val_24 = val_34 / val_24;
        this.AimSegmentSize = val_24;
        this.TouchAreaTotalHeight = val_34;
        if((val_33 & 2147483648) != 0)
        {
            goto label_36;
        }
        
        val_34 = val_21 - val_34;
        var val_26 = 0;
        label_35:
        float val_25 = this.AimSegmentSize;
        val_34 = 0f;
        val_25 = val_25 * val_34;
        val_25 = val_30 + val_25;
        val_25 = (val_34 * 0.5f) + val_25;
        if(val_21 < 0)
        {
            goto label_34;
        }
        
        val_33 = this.AimTargetCount;
        val_26 = val_26 + 1;
        if(val_26 <= val_33)
        {
            goto label_35;
        }
        
        goto label_36;
        label_34:
        val_33 = this.AimTargetCount;
        float val_27 = (float)val_33;
        val_27 = val_27 * 0.5f;
        InkWars.Model.AimTarget val_23 = (val_27 < 0) ? 2 : (0 + 1);
        val_23 = val_26 - val_23;
        this.AimSegment = val_23;
        label_36:
        if(this.AimSegment <= val_33)
        {
            goto label_37;
        }
        
        val_35 = 6;
        goto label_38;
        label_37:
        if((this.AimSegment & 2147483648) == 0)
        {
            goto label_39;
        }
        
        val_35 = 0;
        label_38:
        this.AimSegment = val_35;
        label_39:
        if(val_35 == 0)
        {
            goto label_40;
        }
        
        label_44:
        if(val_34 < 0)
        {
            goto label_41;
        }
        
        return;
        label_40:
        if(val_34 <= val_28)
        {
            goto label_43;
        }
        
        label_41:
        this.AimSegment = 99;
        this.Touching = false;
        return;
        label_43:
        if(val_35 != 0)
        {
            goto label_44;
        }
    
    }
    public bool IsControlActive()
    {
        var val_14;
        var val_15;
        var val_16;
        val_14 = this;
        if((Control_Base<Control_Input>.Model) == null)
        {
                return (bool)val_15;
        }
        
        InkWars.Model.Model_Manager val_2 = InkWars.Model.Model_Manager.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  MVC_Bot_Base.P1Bot)) != false)
        {
                if(MVC_Bot_Base.P1Bot.isActiveAndEnabled != false)
        {
                var val_5 = (val_2.Model.PlayersFlippedLocally == true) ? 1 : 0;
            val_15 = 0;
            val_5 = val_5 & ((UnityEngine.Object.__il2cppRuntimeField_127 != 0) ? 1 : 0);
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  MVC_Bot_Base.P2Bot)) != false)
        {
                if(MVC_Bot_Base.P2Bot.isActiveAndEnabled != false)
        {
                if(((val_2.Model.PlayersFlippedLocally == true) ? 1 : 0) == ((MVC_Bot_Base.__il2cppRuntimeField_static_fields == 0) ? 1 : 0))
        {
            goto label_23;
        }
        
        }
        
        }
        
        val_16 = null;
        val_16 = null;
        if(Character_GlobalInfo.gameMode == 5)
        {
            goto label_25;
        }
        
        if(Character_GlobalInfo.gameMode == 0)
        {
            goto label_20;
        }
        
        label_26:
        val_14 = Control_Base<Control_Input>.Model;
        if(val_12.PlayersFlippedLocally == true)
        {
            goto label_25;
        }
        
        goto label_23;
        label_20:
        InkWars.Model.Model_Core val_13 = Control_Base<Control_Input>.Model;
        if(val_13.PlayersFlippedLocally == false)
        {
            goto label_25;
        }
        
        if(val_13.PlayersFlippedLocally == true)
        {
            goto label_26;
        }
        
        label_23:
        val_15 = 0;
        return (bool)val_15;
        label_25:
        val_15 = 1;
        return (bool)val_15;
    }
    public Control_Input()
    {
        this.AimSegment = 0;
    }
    private void <Start>b__14_0()
    {
        this.Switcher();
    }

}
