using UnityEngine;

namespace InkWars.Model
{
    public class Model_Events : MonoBehaviour
    {
        // Fields
        private static InkWars.Model.Model_Events _instance;
        private static bool alreadyCreated;
        private InkWars.Model.Model_Events.OnPlayerShotDelegate OnPlayerShot;
        private InkWars.Model.Model_Events.OnGameResultDelegate OnGameResult;
        private InkWars.Model.Model_Events.ControllerNetworkMessageDelegate OnMessageReceived;
        private InkWars.Model.Model_Events.ControllerNetworkMessageDelegate OnMessageSent;
        private InkWars.Model.Model_Events.OnBeforePostMatchDelegate OnBeforePostMatch;
        private InkWars.Model.Model_Events.OnPlayerSwitchDelegate OnPlayerSwitch;
        private InkWars.Model.Model_Events.OnBubbleSuctionDelegate OnBubbleSuction;
        private InkWars.Model.Model_Events.OnBubblePopDelegate OnBubblePop;
        private InkWars.Model.Model_Events.OnPlayerMessageDelegate OnComboPop;
        private InkWars.Model.Model_Events.OnPlayerAimlineDelegate OnPlayerAimline;
        private InkWars.Model.Model_Events.OnTargetBubblesPopulatedDelegate OnTargetBubblesPopulated;
        private InkWars.Model.Model_Events.OnRevengeSuperDelegate OnRevengeSuper;
        private InkWars.Model.Model_Events.OnBattleEnhancerDelegate OnBattleEnhancer;
        private InkWars.Model.Model_Events.OnInkEmUpShotDelegate OnInkEmUpShot;
        private InkWars.Model.Model_Events.OnStunnedDelegate OnStunned;
        private InkWars.Model.Model_Events.OnStunBreakDelegate OnStunBreak;
        private InkWars.Model.Model_Events.BasicDelegate OnModelStart;
        
        // Properties
        public static InkWars.Model.Model_Events Instance { get; }
        
        // Methods
        public static InkWars.Model.Model_Events get_Instance()
        {
            InkWars.Model.Model_Events val_6 = InkWars.Model.Model_Events._instance;
            if(val_6 != 0)
            {
                    return (InkWars.Model.Model_Events)InkWars.Model.Model_Events._instance;
            }
            
            if(InkWars.Model.Model_Events.alreadyCreated == true)
            {
                    return (InkWars.Model.Model_Events)InkWars.Model.Model_Events._instance;
            }
            
            InkWars.Model.Model_Events.alreadyCreated = true;
            InkWars.Model.Model_Events._instance = UnityEngine.Object.FindObjectOfType<InkWars.Model.Model_Events>();
            if(InkWars.Model.Model_Events._instance != 0)
            {
                    return (InkWars.Model.Model_Events)InkWars.Model.Model_Events._instance;
            }
            
            UnityEngine.GameObject val_4 = new UnityEngine.GameObject();
            if(val_4 != null)
            {
                    val_4.name = "Event Manager";
            }
            else
            {
                    0.name = "Event Manager";
            }
            
            InkWars.Model.Model_Events._instance = val_4.AddComponent<InkWars.Model.Model_Events>();
            val_6 = InkWars.Model.Model_Events._instance;
            UnityEngine.Object.DontDestroyOnLoad(target:  val_6);
            return (InkWars.Model.Model_Events)InkWars.Model.Model_Events._instance;
        }
        public void add_OnPlayerShot(InkWars.Model.Model_Events.OnPlayerShotDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPlayerShot, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayerShot != 1152921529257665912);
        
        }
        public void remove_OnPlayerShot(InkWars.Model.Model_Events.OnPlayerShotDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPlayerShot, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayerShot != 1152921529257802488);
        
        }
        public void add_OnGameResult(InkWars.Model.Model_Events.OnGameResultDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGameResult, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGameResult != 1152921529257939072);
        
        }
        public void remove_OnGameResult(InkWars.Model.Model_Events.OnGameResultDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGameResult, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGameResult != 1152921529258075648);
        
        }
        public void add_OnMessageReceived(InkWars.Model.Model_Events.ControllerNetworkMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMessageReceived, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMessageReceived != 1152921529258212232);
        
        }
        public void remove_OnMessageReceived(InkWars.Model.Model_Events.ControllerNetworkMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMessageReceived, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMessageReceived != 1152921529258348808);
        
        }
        public void add_OnMessageSent(InkWars.Model.Model_Events.ControllerNetworkMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMessageSent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMessageSent != 1152921529258485392);
        
        }
        public void remove_OnMessageSent(InkWars.Model.Model_Events.ControllerNetworkMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMessageSent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMessageSent != 1152921529258621968);
        
        }
        public void add_OnBeforePostMatch(InkWars.Model.Model_Events.OnBeforePostMatchDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnBeforePostMatch, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBeforePostMatch != 1152921529258758552);
        
        }
        public void remove_OnBeforePostMatch(InkWars.Model.Model_Events.OnBeforePostMatchDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnBeforePostMatch, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBeforePostMatch != 1152921529258895128);
        
        }
        public void add_OnPlayerSwitch(InkWars.Model.Model_Events.OnPlayerSwitchDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPlayerSwitch, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayerSwitch != 1152921529259031712);
        
        }
        public void remove_OnPlayerSwitch(InkWars.Model.Model_Events.OnPlayerSwitchDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPlayerSwitch, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayerSwitch != 1152921529259168288);
        
        }
        public void add_OnBubbleSuction(InkWars.Model.Model_Events.OnBubbleSuctionDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnBubbleSuction, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBubbleSuction != 1152921529259304872);
        
        }
        public void remove_OnBubbleSuction(InkWars.Model.Model_Events.OnBubbleSuctionDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnBubbleSuction, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBubbleSuction != 1152921529259441448);
        
        }
        public void add_OnBubblePop(InkWars.Model.Model_Events.OnBubblePopDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnBubblePop, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBubblePop != 1152921529259578032);
        
        }
        public void remove_OnBubblePop(InkWars.Model.Model_Events.OnBubblePopDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnBubblePop, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBubblePop != 1152921529259714608);
        
        }
        public void add_OnComboPop(InkWars.Model.Model_Events.OnPlayerMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnComboPop, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnComboPop != 1152921529259851192);
        
        }
        public void remove_OnComboPop(InkWars.Model.Model_Events.OnPlayerMessageDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnComboPop, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnComboPop != 1152921529259987768);
        
        }
        public void add_OnPlayerAimline(InkWars.Model.Model_Events.OnPlayerAimlineDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPlayerAimline, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayerAimline != 1152921529260124352);
        
        }
        public void remove_OnPlayerAimline(InkWars.Model.Model_Events.OnPlayerAimlineDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPlayerAimline, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayerAimline != 1152921529260260928);
        
        }
        public void add_OnTargetBubblesPopulated(InkWars.Model.Model_Events.OnTargetBubblesPopulatedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnTargetBubblesPopulated, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTargetBubblesPopulated != 1152921529260397512);
        
        }
        public void remove_OnTargetBubblesPopulated(InkWars.Model.Model_Events.OnTargetBubblesPopulatedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnTargetBubblesPopulated, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnTargetBubblesPopulated != 1152921529260534088);
        
        }
        public void add_OnRevengeSuper(InkWars.Model.Model_Events.OnRevengeSuperDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRevengeSuper, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRevengeSuper != 1152921529260670672);
        
        }
        public void remove_OnRevengeSuper(InkWars.Model.Model_Events.OnRevengeSuperDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRevengeSuper, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRevengeSuper != 1152921529260807248);
        
        }
        public void add_OnBattleEnhancer(InkWars.Model.Model_Events.OnBattleEnhancerDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnBattleEnhancer, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBattleEnhancer != 1152921529260943832);
        
        }
        public void remove_OnBattleEnhancer(InkWars.Model.Model_Events.OnBattleEnhancerDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnBattleEnhancer, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBattleEnhancer != 1152921529261080408);
        
        }
        public void add_OnInkEmUpShot(InkWars.Model.Model_Events.OnInkEmUpShotDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnInkEmUpShot, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnInkEmUpShot != 1152921529261216992);
        
        }
        public void remove_OnInkEmUpShot(InkWars.Model.Model_Events.OnInkEmUpShotDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnInkEmUpShot, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnInkEmUpShot != 1152921529261353568);
        
        }
        public void add_OnStunned(InkWars.Model.Model_Events.OnStunnedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStunned, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStunned != 1152921529261490152);
        
        }
        public void remove_OnStunned(InkWars.Model.Model_Events.OnStunnedDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStunned, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStunned != 1152921529261626728);
        
        }
        public void add_OnStunBreak(InkWars.Model.Model_Events.OnStunBreakDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStunBreak, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStunBreak != 1152921529261763312);
        
        }
        public void remove_OnStunBreak(InkWars.Model.Model_Events.OnStunBreakDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStunBreak, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStunBreak != 1152921529261899888);
        
        }
        public void add_OnModelStart(InkWars.Model.Model_Events.BasicDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnModelStart, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnModelStart != 1152921529262036472);
        
        }
        public void remove_OnModelStart(InkWars.Model.Model_Events.BasicDelegate value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnModelStart, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnModelStart != 1152921529262173048);
        
        }
        public void Event_AimLine(InkWars.Model.Player Id, InkWars.Model.AimTarget aimTarget)
        {
            if(this.OnPlayerAimline == null)
            {
                    return;
            }
            
            this.OnPlayerAimline.Invoke(playerId:  Id, aimTarget:  aimTarget);
        }
        public void Event_Shot(float timeStamp, InkWars.Model.Player Id, InkWars.Model.AimTarget aimTarget, InkWars.Model.BubbleTypes shotBubble, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool sendOverNetwork)
        {
            if(this.OnPlayerShot == null)
            {
                    return;
            }
            
            this.OnPlayerShot.Invoke(timeStamp:  timeStamp, playerId:  Id, aimTarget:  aimTarget, shot:  shotBubble, loaded:  loadedBubble, spare:  spareBubble, sendOverNetwork:  sendOverNetwork);
        }
        public void Event_BubbleSuction(InkWars.Model.Player iD, int ringID, int ringIndex, int amount)
        {
            if(this.OnBubbleSuction == null)
            {
                    return;
            }
            
            this.OnBubbleSuction.Invoke(playerId:  iD, ringID:  ringID, ringIndex:  ringIndex, amount:  amount);
        }
        public void Event_BubblePop(InkWars.Model.BubbleStates state, InkWars.Model.Player responsible, InkWars.Model.Player target, int ringID, int ringIndex, bool isCrossBubbleHit)
        {
            if(this.OnBubblePop == null)
            {
                    return;
            }
            
            this.OnBubblePop.Invoke(state:  state, responsiblePlayer:  responsible, targetPlayer:  target, ring:  ringID, index:  ringIndex, isCrossBubbleHit:  isCrossBubbleHit);
        }
        public void Event_Message(PlayerMessage message)
        {
            if(this.OnComboPop == null)
            {
                    return;
            }
            
            this.OnComboPop.Invoke(message:  message);
        }
        internal void Event_Switch(InkWars.Model.Player Id, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble, bool manualSwitch)
        {
            if(this.OnPlayerSwitch == null)
            {
                    return;
            }
            
            this.OnPlayerSwitch.Invoke(playerId:  Id, loadedBubble:  loadedBubble, spareBubble:  spareBubble, manualSwitch:  manualSwitch);
        }
        internal void Event_RevengeSuper(InkWars.Model.Player id, InkWars.Model.BubbleTypes revengeSuperType, InkWars.Model.RevengeSuperEventState state)
        {
            if(this.OnRevengeSuper == null)
            {
                    return;
            }
            
            this.OnRevengeSuper.Invoke(playerId:  id, bubbleType:  revengeSuperType, state:  state);
        }
        internal void Event_BattleEnhancer(float timestamp, InkWars.Model.Player id, InkWars.Model.BattleEnhancerType type, InkWars.Model.BattleEnhancerState state, int level)
        {
            if(this.OnBattleEnhancer == null)
            {
                    return;
            }
            
            this.OnBattleEnhancer.Invoke(timeStamp:  timestamp, playerId:  id, type:  type, state:  state, level:  level);
        }
        internal void Event_OnInkEmUpShot(InkWars.Model.Player id, float timeRemaining)
        {
            if(this.OnInkEmUpShot == null)
            {
                    return;
            }
            
            this.OnInkEmUpShot.Invoke(playerId:  id, timeRemaining:  timeRemaining);
        }
        internal void Event_StunBreak(InkWars.Model.Player id, float revengeSuperLevel, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
        {
            if(this.OnStunBreak == null)
            {
                    return;
            }
            
            this.OnStunBreak.Invoke(playerId:  id, revengeSuperLevel:  revengeSuperLevel, loadedBubbble:  loadedBubble, spareBubble:  spareBubble);
        }
        internal void Event_Stunned(InkWars.Model.Player id, float stunLevel, bool isRevengeStun)
        {
            if(this.OnStunned == null)
            {
                    return;
            }
            
            this.OnStunned.Invoke(playerId:  id, stunLevel:  stunLevel, isRevengeStun:  isRevengeStun);
        }
        internal void Event_TargetBubblesPopulated(InkWars.Model.Player iD, InkWars.Model.BubbleTypes loadedBubble, InkWars.Model.BubbleTypes spareBubble)
        {
            if(this.OnTargetBubblesPopulated == null)
            {
                    return;
            }
            
            this.OnTargetBubblesPopulated.Invoke(playerId:  iD, loadedBubble:  loadedBubble, spareBubble:  spareBubble);
        }
        internal void Event_OnBeforePostMatch()
        {
            if(this.OnBeforePostMatch == null)
            {
                    return;
            }
            
            this.OnBeforePostMatch.Invoke();
        }
        internal void Event_GameResult(InkWars.Model.GameResult gameResult, bool isFinished)
        {
            if(this.OnGameResult == null)
            {
                    return;
            }
            
            this.OnGameResult.Invoke(result:  gameResult, afterFinished:  isFinished);
        }
        internal void SendNetworkMessage(InkWars.Model.Controller_Network_Message message)
        {
            if(this.OnMessageSent == null)
            {
                    return;
            }
            
            this.OnMessageSent.Invoke(message:  message);
        }
        internal void ReceiveNetworkMessage(InkWars.Model.Controller_Network_Message message)
        {
            if(this.OnMessageReceived == null)
            {
                    return;
            }
            
            this.OnMessageReceived.Invoke(message:  message);
        }
        internal void StartModel()
        {
            if(this.OnModelStart == null)
            {
                    return;
            }
            
            this.OnModelStart.Invoke();
        }
        public Model_Events()
        {
        
        }
    
    }

}
