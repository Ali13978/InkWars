using UnityEngine;

namespace InkWars.Model
{
    public static class Model_Constants
    {
        // Fields
        public const int Mussels_PearlCost_One = 300;
        public const int Mussels_PearlCost_Four = 1000;
        public const int TargetBubblePoolSize = 5;
        public const float BubbleSuctionSpeed = 0.5;
        public static UnityEngine.Vector3 SwitcherBubbleRotation;
        public static float BubblePopSubsequentDelay;
        public static float StunnerBubbleFlipTime;
        public const int OuterRingSize = 17;
        public const int MiddleRingSize = 13;
        public const int InnerRingSize = 9;
        public const float RapidRainbowChance = 0.25;
        public const int OuterRingBridge = 8;
        public const int MiddleRingBridge = 6;
        public const int InnerRingBridge = 4;
        public static InkWars.Model.BubbleTypes[] RegularBubbles;
        public static System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> BubblesNoSwitcher;
        public const float SwitchBubbleTime = 0.1;
        public const float DoubleKOGraceTime = 0.1;
        public const float TimeScale = 1.5;
        public const float RevengeSuper_DrainRate = 0;
        public const float RevengeSuper_PercentageYourPopIncreases = 3;
        public const float RevengeSuper_PercentageTheirPopIncreasesMax = 8;
        public const float RevengeSuper_PercentageTheirPopIncreasesDecay = 2;
        public const float RevengeSuper_PercentageTheirPopIncreasesMin = 2;
        public const float RevengeSuper_AnimationTime = 2;
        public const float RevengeSuper_BubbleDiffMiddleSpecial = 8;
        public const float RevengeSuper_BubbleDiffEraser = 13;
        public static float[] CharacterReload_AttackShakeTime;
        public static float[] CharacterReload_MaxPostAttackDuration;
        public const float CharacterReload_ShakeIntensity = 0.5;
        public const float stunTimeBaseAmount = 0.3;
        public static float[] StunTime;
        public const float StunnerStunTime = 15;
        public const float EnhancedStunnerStunTime = 20;
        public static float StunMultipuler_CrossLink;
        public static float StunMultipuler_BridgeLink;
        public static float StunMultipuler_CrossBridgeLink;
        public static float[] RainbowFrequency;
        public static float[] MatchFrequency;
        public const float StunBreakMinTime = 3;
        public const float StunBreakDoubleTapTime = 0.5;
        public const float StunBreakPauseTime = 1;
        public const int Max_BattleEnhancerLevel = 6;
        private static float[] DistanceToReachEnemyGrid;
        private static float[] DistanceInsideGrid;
        private static float[] DistanceToReachOwnGrid;
        public const float TrashDistance = 4.32;
        public const float OpponentDistance = 8.64;
        public const float BubbleSpeed = 14;
        public const float BubbleSpeed_OpponentHit = 21;
        public static float[] TotalTimeToReachEnemyGrid;
        public static float[] TotalTimeToLeaveEnemyGrid;
        public static float[] TotalTimeToReachOwnGrid;
        public static float[] TotalTimeToLeaveOwnGrid;
        public static float TotalTrashTime;
        public static float TotalOpponentTime;
        public static float[] CollisionTimeToProjectForward;
        public static float[] AdventureModeAIReactionTimes;
        public static int[] AdventureModeSpeedRatings;
        public static int[] AdventureModeAttackRatings;
        public const int AI_Level_BossPart2 = 12;
        public const int AI_Level_SpecialChallenger = 13;
        public const int AI_Level_XTreme = 14;
        public static float CameraShakeIntensity_KO;
        public static float CameraShakeTime_KO;
        public static float CameraShakeIntensity_InkHit;
        public static float CameraShakeTime_InkHit;
        public static float CameraShakeIntensity_InkHitFinal;
        public static float CameraShakeTime_InkHitFinal;
        public static int Score_BubblePop_Base;
        public static int Score_BubblePop_ComboAdd;
        public static int Score_BubblePop_Eraser;
        public static int Score_BubblePop_CannonBall;
        public static int Score_BubblePop_SPD;
        public static int Score_BubblesRemaining;
        public static int Score_BubblePop_Suicide;
        public static int ScoreInkEmUp_Activated;
        public static int ScoreInkEmUp_Hit;
        public static int ScoreInkEmUp_FullInked;
        public static int ScoreInkEmUp_BubblesRemaining;
        public static int ScoreRebound_RSave;
        public static int ScoreRebound_RInterception;
        public static int ScoreRebound_RCounter;
        public static float ScoreMultiplier_Cross;
        public static float ScoreMultiplier_Bridge;
        public static float ScoreMultiplier_CrossBridge;
        public static float ScoreMultiplier_InkEmUp_TimeRemaining;
        public static int[] GameDurationOptions;
        
        // Methods
        private static Model_Constants()
        {
            InkWars.Model.Model_Constants.AI_Level_XTreme = 0;
            InkWars.Model.Model_Constants.AI_Level_XTreme.__il2cppRuntimeField_3 = 0;
            InkWars.Model.Model_Constants.AI_Level_XTreme.__il2cppRuntimeField_8 = 0;
            InkWars.Model.Model_Constants.BubblePopSubsequentDelay = 0.15f;
            InkWars.Model.Model_Constants.StunnerBubbleFlipTime = 0.25f;
            InkWars.Model.Model_Constants.RegularBubbles = new InkWars.Model.BubbleTypes[6];
            System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes> val_2 = new System.Collections.Generic.HashSet<InkWars.Model.BubbleTypes>();
            if(val_2 != null)
            {
                    bool val_3 = val_2.Add(item:  12);
                bool val_4 = val_2.Add(item:  13);
            }
            else
            {
                    bool val_5 = val_2.Add(item:  12);
                bool val_6 = val_2.Add(item:  13);
            }
            
            bool val_7 = val_2.Add(item:  14);
            InkWars.Model.Model_Constants.BubblesNoSwitcher = val_2;
            InkWars.Model.Model_Constants.CharacterReload_AttackShakeTime = new float[4] {2.723027E+23f, -4.289679E+08f, -4.284436E+08f, -4.294922E+08f};
            InkWars.Model.Model_Constants.CharacterReload_MaxPostAttackDuration = new float[4] {2.720076E+23f, -4.284436E+08f, 4.172329E-08f, -6.33201E-23f};
            InkWars.Model.Model_Constants.StunTime = new float[4] {-6.352689E-23f, 1.090392E+24f, -6.33201E-23f, 1.08803E+24f};
            InkWars.Model.Model_Constants.StunMultipuler_CrossLink = 1.125f;
            InkWars.Model.Model_Constants.StunMultipuler_BridgeLink = 1.25f;
            InkWars.Model.Model_Constants.StunMultipuler_CrossBridgeLink = 1.5f;
            InkWars.Model.Model_Constants.RainbowFrequency = new float[4] {-4.284436E+08f, -4.294921E+08f, -6.33201E-23f, -4.284436E+08f};
            InkWars.Model.Model_Constants.MatchFrequency = new float[4] {4.600463E-41f, 2.725979E+23f, 5.639924E-20f, -490.8144f};
            InkWars.Model.Model_Constants.DistanceToReachEnemyGrid = new float[3] {9.359263E+29f, -2.882315E+20f, -2.209975E-35f};
            InkWars.Model.Model_Constants.DistanceInsideGrid = new float[3] {1.761339E-26f, 1.874517E-41f, 3.240679E+17f};
            InkWars.Model.Model_Constants.DistanceToReachOwnGrid = new float[3] {-5.205971E-17f, 2.715649E+23f, -1.010667E+27f};
            InkWars.Model.Model_Constants.AdventureModeAIReactionTimes = new float[15] {2.304856E-41f, 2.717125E+23f, 4.169419E-08f, 8.96831E-44f, -4.294922E+08f, 4.183971E-08f, -6.35269E-23f, 4.600603E-41f, -4.284436E+08f, 4.172329E-08f, -6.33201E-23f, 8.82818E-44f, 8.82818E-44f, 4.600603E-41f, 4.600603E-41f};
            InkWars.Model.Model_Constants.AdventureModeSpeedRatings = new int[12] {1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4};
            InkWars.Model.Model_Constants.AdventureModeAttackRatings = new int[12] {1, 1, 2, 3, 2, 2, 3, 3, 3, 3, 3, 4};
            InkWars.Model.Model_Constants.CameraShakeIntensity_KO = 1.5f;
            InkWars.Model.Model_Constants.CameraShakeTime_KO = 1.5f;
            InkWars.Model.Model_Constants.CameraShakeIntensity_InkHit = 1f;
            InkWars.Model.Model_Constants.CameraShakeTime_InkHit = 0.5f;
            InkWars.Model.Model_Constants.CameraShakeIntensity_InkHitFinal = 2f;
            InkWars.Model.Model_Constants.CameraShakeTime_InkHitFinal = 2f;
            InkWars.Model.Model_Constants.Score_BubblePop_Base = 100;
            InkWars.Model.Model_Constants.Score_BubblePop_ComboAdd = 50;
            InkWars.Model.Model_Constants.Score_BubblePop_Eraser = 200;
            InkWars.Model.Model_Constants.Score_BubblePop_CannonBall = 150;
            InkWars.Model.Model_Constants.Score_BubblePop_SPD = 300;
            InkWars.Model.Model_Constants.Score_BubblesRemaining = 200;
            InkWars.Model.Model_Constants.Score_BubblePop_Suicide = 99;
            InkWars.Model.Model_Constants.ScoreInkEmUp_Activated = 1000;
            InkWars.Model.Model_Constants.ScoreInkEmUp_Hit = 400;
            InkWars.Model.Model_Constants.ScoreInkEmUp_FullInked = 1000;
            InkWars.Model.Model_Constants.ScoreInkEmUp_BubblesRemaining = 200;
            InkWars.Model.Model_Constants.ScoreRebound_RSave = 100;
            InkWars.Model.Model_Constants.ScoreRebound_RInterception = 300;
            InkWars.Model.Model_Constants.ScoreRebound_RCounter = 400;
            InkWars.Model.Model_Constants.ScoreMultiplier_Cross = 1.2f;
            InkWars.Model.Model_Constants.ScoreMultiplier_Bridge = 1.4f;
            InkWars.Model.Model_Constants.ScoreMultiplier_CrossBridge = 1.6f;
            InkWars.Model.Model_Constants.ScoreMultiplier_InkEmUp_TimeRemaining = 1000f;
            InkWars.Model.Model_Constants.GameDurationOptions = new int[4] {-1, 99, 120, 180};
            InkWars.Model.Model_Constants.TotalTrashTime = 0.3085714f;
            InkWars.Model.Model_Constants.TotalOpponentTime = 0.4114286f;
            InkWars.Model.Model_Constants.TotalTimeToReachEnemyGrid = new float[3];
            InkWars.Model.Model_Constants.TotalTimeToLeaveEnemyGrid = new float[3];
            InkWars.Model.Model_Constants.TotalTimeToReachOwnGrid = new float[3];
            InkWars.Model.Model_Constants.TotalTimeToLeaveOwnGrid = new float[3];
            var val_33 = 0;
            InkWars.Model.Model_Constants.CollisionTimeToProjectForward = new float[3];
            do
            {
                float val_28 = mem[1152921529252800728] + 32;
                val_28 = val_28 / 14f;
                mem2[0] = val_28;
                float val_29 = mem[1152921529252796600] + 32;
                val_29 = val_29 / 14f;
                mem2[0] = val_29;
                float val_30 = -0.03197479f;
                val_30 = val_30 + ((mem[1152921529252800728] + 32) / 14f);
                mem2[0] = val_30;
                float val_31 = -0.03197479f;
                val_31 = val_31 + ((mem[1152921529252804856] + 32) / 14f);
                mem2[0] = val_31;
                float val_32 = -0.03197479f;
                val_32 = val_32 + ((mem[1152921529252800728] + 32) / 14f);
                mem2[0] = val_32;
                val_33 = val_33 + 1;
            }
            while(val_33 != 3);
            
            float val_34 = mem[1152921529252842240];
            val_34 = val_34 * 0.0625f;
            mem[1152921529252842240] = val_34;
            float val_35 = mem[1152921529252842244];
            val_35 = val_35 / 12f;
            mem[1152921529252842244] = val_35;
            float val_36 = mem[1152921529252842248];
            val_36 = val_36 * 0.125f;
            mem[1152921529252842248] = val_36;
        }
    
    }

}
