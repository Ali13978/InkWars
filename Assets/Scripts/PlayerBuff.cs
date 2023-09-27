using UnityEngine;
[Serializable]
public class PlayerBuff
{
    // Fields
    public static bool enable;
    public System.Collections.Generic.List<PlayerBuff.BuffData> buffList;
    
    // Methods
    public static PlayerBuff GetLocalPlayerBuff()
    {
        PlayerBuff val_1 = new PlayerBuff();
        val_1.LoadFromLocalPlayer();
        return val_1;
    }
    public int GetBuffValue(BattleBonusType aNewType)
    {
        int val_4;
        var val_5;
        .aNewType = aNewType;
        if((this.buffList.Find(match:  new System.Predicate<BuffData>(object:  new PlayerBuff.<>c__DisplayClass4_0(), method:  System.Boolean PlayerBuff.<>c__DisplayClass4_0::<GetBuffValue>b__0(PlayerBuff.BuffData x)))) == null)
        {
                return (int)val_4;
        }
        
        val_5 = null;
        val_5 = null;
        if(PlayerBuff.enable != false)
        {
                val_4 = val_3.value;
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }
    public float GetBuffValueSec(BattleBonusType aNewType)
    {
        float val_2 = 1000f;
        val_2 = ((float)this.GetBuffValue(aNewType:  aNewType)) / val_2;
        return (float)val_2;
    }
    public float GetBuffValuePercent01(BattleBonusType aNewType)
    {
        float val_2 = 100f;
        val_2 = ((float)this.GetBuffValue(aNewType:  aNewType)) / val_2;
        return (float)val_2;
    }
    public void SetBuffValue(BattleBonusType aNewType, int aNewValue)
    {
        .aNewType = aNewType;
        if((this.buffList.Find(match:  new System.Predicate<BuffData>(object:  new PlayerBuff.<>c__DisplayClass7_0(), method:  System.Boolean PlayerBuff.<>c__DisplayClass7_0::<SetBuffValue>b__0(PlayerBuff.BuffData x)))) != null)
        {
                val_3.value = aNewValue;
            return;
        }
        
        PlayerBuff.BuffData val_4 = null;
        .bonusType = 17;
        val_4 = new PlayerBuff.BuffData();
        .bonusType = (PlayerBuff.<>c__DisplayClass7_0)[1152921528932884960].aNewType;
        .value = aNewValue;
        this.buffList.Add(item:  val_4);
    }
    public void AddBuffValue(BattleBonusType aNewType, int aNewOffsetValue)
    {
        .aNewType = aNewType;
        if((this.buffList.Find(match:  new System.Predicate<BuffData>(object:  new PlayerBuff.<>c__DisplayClass8_0(), method:  System.Boolean PlayerBuff.<>c__DisplayClass8_0::<AddBuffValue>b__0(PlayerBuff.BuffData x)))) != null)
        {
                int val_5 = val_3.value;
            val_5 = val_5 + aNewOffsetValue;
            val_3.value = val_5;
            return;
        }
        
        PlayerBuff.BuffData val_4 = null;
        .bonusType = 17;
        val_4 = new PlayerBuff.BuffData();
        .bonusType = (PlayerBuff.<>c__DisplayClass8_0)[1152921528933063520].aNewType;
        .value = aNewOffsetValue;
        this.buffList.Add(item:  val_4);
    }
    public PlayerBuff()
    {
        this.buffList = new System.Collections.Generic.List<BuffData>();
        this.LoadDefault();
    }
    public void LoadFromLocalPlayer()
    {
        var val_9;
        var val_12;
        this.buffList.Clear();
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_22:
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_9 = 0;
        if(val_3.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_9 = 1;
        val_3.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  null, drivenProperties:  null);
        this.AddBuffValue(aNewType:  1152921504628039680, aNewOffsetValue:  BattleBonusConfig.GetBonusValueForLocalPlayer(type:  1152921504628039680));
        goto label_22;
        label_12:
        val_12 = 0;
        if(val_3 != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_3.Dispose();
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public string ToJson()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    public void LoadFromJson(string json)
    {
        this.buffList.Clear();
        PlayerBuff val_1 = UnityEngine.JsonUtility.FromJson<PlayerBuff>(json:  json);
        this.buffList = val_1.buffList;
    }
    public void LoadDefault()
    {
        this.buffList.Clear();
        PlayerBuff.BuffData val_1 = null;
        .bonusType = 17;
        val_1 = new PlayerBuff.BuffData();
        .bonusType = 0;
        this.buffList.Add(item:  val_1);
        PlayerBuff.BuffData val_2 = null;
        .bonusType = 17;
        val_2 = new PlayerBuff.BuffData();
        .bonusType = 1;
        this.buffList.Add(item:  val_2);
        PlayerBuff.BuffData val_3 = null;
        .bonusType = 17;
        val_3 = new PlayerBuff.BuffData();
        .bonusType = 2;
        this.buffList.Add(item:  val_3);
        PlayerBuff.BuffData val_4 = null;
        .bonusType = 17;
        val_4 = new PlayerBuff.BuffData();
        .bonusType = 3;
        this.buffList.Add(item:  val_4);
        PlayerBuff.BuffData val_5 = null;
        .bonusType = 17;
        val_5 = new PlayerBuff.BuffData();
        .bonusType = 4;
        this.buffList.Add(item:  val_5);
        PlayerBuff.BuffData val_6 = null;
        .bonusType = 17;
        val_6 = new PlayerBuff.BuffData();
        .bonusType = 5;
        this.buffList.Add(item:  val_6);
        PlayerBuff.BuffData val_7 = null;
        .bonusType = 17;
        val_7 = new PlayerBuff.BuffData();
        .bonusType = 8;
        this.buffList.Add(item:  val_7);
        PlayerBuff.BuffData val_8 = null;
        .bonusType = 17;
        val_8 = new PlayerBuff.BuffData();
        .bonusType = 9;
        this.buffList.Add(item:  val_8);
        PlayerBuff.BuffData val_9 = null;
        .bonusType = 17;
        val_9 = new PlayerBuff.BuffData();
        .bonusType = 10;
        this.buffList.Add(item:  val_9);
        PlayerBuff.BuffData val_10 = null;
        .bonusType = 17;
        val_10 = new PlayerBuff.BuffData();
        .bonusType = 11;
        this.buffList.Add(item:  val_10);
    }
    private static PlayerBuff()
    {
        PlayerBuff.enable = true;
    }

}
