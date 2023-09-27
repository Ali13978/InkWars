using UnityEngine;
private sealed class GameOverPanelSummary.<SubtractText>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int _totalPoints;
    public int _earnedPoints;
    public bool _subtract;
    public TMPro.TextMeshProUGUI _totalPointsText;
    public TMPro.TextMeshProUGUI _earnedPointsText;
    public bool _overwritePP;
    public GameOverPanelSummary <>4__this;
    private float <elapsedTextTime>5__2;
    private int <totalEarnedPoints>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameOverPanelSummary.<SubtractText>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.RectTransform val_7;
        object val_8;
        int val_9;
        int val_10;
        float val_11;
        float val_12;
        int val_13;
        DataUIRef val_14;
        var val_15;
        UnityEngine.RectTransform val_16;
        DataUIRef val_17;
        val_7 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        object[] val_1 = new object[2];
        val_1[0] = this._totalPoints;
        val_8 = this._earnedPoints;
        val_1[1] = val_8;
        UnityEngine.Debug.LogFormat(format:  "Subtract Text: TP {0}, EP {1}", args:  val_1);
        val_9 = this._earnedPoints;
        val_10 = 0;
        this.<elapsedTextTime>5__2 = 0.15f;
        this.<totalEarnedPoints>5__3 = val_9;
        this.<i>5__4 = 0;
        goto label_12;
        label_1:
        val_9 = this._earnedPoints;
        this.<>1__state = 0;
        val_10 = (this.<i>5__4) + 1;
        this.<i>5__4 = val_10;
        label_12:
        if(val_10 < val_9)
        {
                int val_7 = this.<totalEarnedPoints>5__3;
            val_7 = val_7 - 1;
            this.<totalEarnedPoints>5__3 = val_7;
            int val_8 = this._totalPoints;
            val_8 = ((this._subtract == false) ? (-0) : 0) + val_8;
            this._totalPoints = val_8;
            if(val_8 > 0)
        {
                this._earnedPointsText.text = this.<totalEarnedPoints>5__3.ToString();
            val_8 = this._totalPointsText;
            val_8.text = this._totalPoints.ToString();
            val_11 = this.<elapsedTextTime>5__2;
            val_12 = 0f;
            if(val_11 > 0f)
        {
                float val_5 = UnityEngine.Time.deltaTime;
            val_5 = val_5 * (-0.1f);
            val_12 = val_11 + val_5;
        }
        
            this.<elapsedTextTime>5__2 = val_12;
            this.<>2__current = val_12;
            val_13 = 1;
            this.<>1__state = val_13;
            return (bool)val_13;
        }
        
            this._totalPointsText.text = "0";
        }
        
        if((this.<>4__this) == null)
        {
            goto label_20;
        }
        
        if(this._overwritePP == false)
        {
            goto label_21;
        }
        
        label_26:
        this.<>4__this.m_PPSaved = true;
        val_14 = this.<>4__this.m_DataReferences;
        if((this.<>4__this.m_DataReferences) != null)
        {
            goto label_23;
        }
        
        val_14 = this.<>4__this.m_DataReferences;
        if(val_14 == null)
        {
            goto label_29;
        }
        
        label_23:
        val_15 = 1152921504848060416;
        val_7 = this.<>4__this.m_DataReferences.PositiveSignPP;
        val_16 = this.<>4__this.m_DataReferences.NegativeSignPP;
        goto label_25;
        label_20:
        if(this._overwritePP == true)
        {
            goto label_26;
        }
        
        label_21:
        this.<>4__this.m_BPSaved = true;
        val_17 = this.<>4__this.m_DataReferences;
        if((this.<>4__this.m_DataReferences) != null)
        {
            goto label_28;
        }
        
        val_17 = this.<>4__this.m_DataReferences;
        if(val_17 == null)
        {
            goto label_29;
        }
        
        label_28:
        val_15 = 1152921504848060416;
        val_7 = this.<>4__this.m_DataReferences.PositiveSignBP;
        val_16 = this.<>4__this.m_DataReferences.NegativeSignBP;
        label_25:
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_11 = val_6.x;
        val_16.localScale = new UnityEngine.Vector3() {x = val_11, y = val_6.y, z = val_6.z};
        val_7.localScale = new UnityEngine.Vector3() {x = val_11, y = val_6.y, z = val_6.z};
        label_2:
        val_13 = 0;
        return (bool)val_13;
        label_29:
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
