using UnityEngine;
public static class QuickPlayAiSettings
{
    // Fields
    private static MVC_Bot2 quickPlayBot;
    public static Practice_Mode_Difficulty BotDifficulty;
    
    // Methods
    public static void RemoveQuickPlayBot()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(0 == QuickPlayAiSettings.quickPlayBot)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.Object.Destroy(obj:  QuickPlayAiSettings.quickPlayBot.gameObject);
    }
    private static void SetDificulty(Practice_Mode_Difficulty dif)
    {
        var val_7;
        MVC_Bot2 val_8;
        var val_9;
        var val_10;
        DG.Tweening.TweenCallback val_12;
        val_7 = null;
        val_7 = null;
        val_8 = QuickPlayAiSettings.quickPlayBot;
        QuickPlayAiSettings.quickPlayBot.Settings = MVC_Bot_Profile.GetAdventureModeBot(level:  dif);
        val_9 = null;
        if(QuickPlayAiSettings.quickPlayBot != null)
        {
                QuickPlayAiSettings.quickPlayBot.__unknownFiledOffset_30 = 0;
        }
        else
        {
                mem[48] = 0;
            val_9 = null;
        }
        
        QuickPlayAiSettings.quickPlayBot.__unknownFiledOffset_2C = 0;
        QuickPlayAiSettings.quickPlayBot.ControlsPlayer2 = true;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_2, t:  PracticeModeDifficultyCanvas.Hide());
        val_10 = null;
        val_10 = null;
        val_12 = QuickPlayAiSettings.<>c.<>9__3_0;
        if(val_12 == null)
        {
                DG.Tweening.TweenCallback val_5 = null;
            val_12 = val_5;
            val_5 = new DG.Tweening.TweenCallback(object:  QuickPlayAiSettings.<>c.__il2cppRuntimeField_static_fields, method:  System.Void QuickPlayAiSettings.<>c::<SetDificulty>b__3_0());
            QuickPlayAiSettings.<>c.<>9__3_0 = val_12;
        }
        
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Sequence>(t:  val_2, action:  val_5);
    }
    public static void SetupAndPlayPracticeMode()
    {
        QuickPlayAiSettings.RemoveQuickPlayBot();
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "Quick Play AI");
        QuickPlayAiSettings.quickPlayBot = val_1.AddComponent<MVC_Bot2>();
        PracticeModeDifficultyCanvas.Show(action:  new System.Action<Practice_Mode_Difficulty>(object:  0, method:  static System.Void QuickPlayAiSettings::SetDificulty(Practice_Mode_Difficulty dif)));
        UnityEngine.Object.DontDestroyOnLoad(target:  val_1);
    }
    public static void SetupQuickPlayBot()
    {
        QuickPlayAiSettings.RemoveQuickPlayBot();
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "Quick Play AI");
        QuickPlayAiSettings.quickPlayBot = val_1.AddComponent<MVC_Bot2>();
        Settings = MVC_Bot_Profile.GetAdventureModeBot(level:  0);
        UnityEngine.Object.DontDestroyOnLoad(target:  val_1);
        QuickPlayAiSettings.quickPlayBot.ControlsPlayer2 = true;
    }
    private static QuickPlayAiSettings()
    {
    
    }

}
