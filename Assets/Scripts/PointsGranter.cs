using UnityEngine;
public class PointsGranter : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI start;
    private TMPro.TextMeshProUGUI end;
    private float gapBetweenCount;
    private UnityEngine.AudioClip countingAudio;
    private UnityEngine.AudioClip countingFinishedAudio;
    private bool shouldBeColorChanged;
    private UnityEngine.AudioSource loopCountingSoundSource;
    private static float globalSpeedFactor;
    private decimal startAmount;
    private decimal endAmount;
    
    // Methods
    public void SetStartNumber(decimal aNewCount)
    {
        int val_8;
        var val_9;
        val_8 = aNewCount.flags;
        decimal val_1 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_8, hi = aNewCount.hi, lo = aNewCount.lo, mid = aNewCount.mid}, d2:  new System.Decimal());
        this.startAmount = val_1;
        mem[1152921528663152008] = val_1.lo;
        mem[1152921528663152012] = val_1.mid;
        val_9 = null;
        val_9 = null;
        if(Character_GlobalInfo.isCryptoMMOCMode != false)
        {
                decimal val_2 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_8, hi = aNewCount.hi, lo = aNewCount.lo, mid = aNewCount.mid}, d2:  new System.Decimal());
            decimal val_3 = System.Math.Truncate(d:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
            val_8 = val_3.lo;
            decimal val_4 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_8, mid = val_3.mid}, d2:  new System.Decimal());
            string val_5 = System.String.Format(format:  "{0:0.00}", arg0:  val_4);
        }
        
        this.start.text = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_8, hi = aNewCount.hi, lo = aNewCount.lo, mid = aNewCount.mid}).ToString();
    }
    public void SetEndNumber(decimal aNewCount)
    {
        var val_8;
        TMPro.TextMeshProUGUI val_9;
        decimal val_1 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = aNewCount.flags, hi = aNewCount.hi, lo = aNewCount.lo, mid = aNewCount.mid}, d2:  new System.Decimal());
        this.endAmount = val_1;
        mem[1152921528663302936] = val_1.lo;
        mem[1152921528663302940] = val_1.mid;
        val_8 = null;
        val_8 = null;
        if(Character_GlobalInfo.isCryptoMMOCMode != false)
        {
                val_9 = this.end;
            decimal val_2 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = aNewCount.flags, hi = aNewCount.hi, lo = aNewCount.lo, mid = aNewCount.mid}, d2:  new System.Decimal());
            decimal val_3 = System.Math.Truncate(d:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
            decimal val_4 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal());
            string val_5 = System.String.Format(format:  "{0:0.00}", arg0:  val_4);
        }
        else
        {
                val_9 = this.start;
        }
        
        val_9.text = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = aNewCount.flags, hi = aNewCount.hi, lo = aNewCount.lo, mid = aNewCount.mid}).ToString();
    }
    public DG.Tweening.Sequence StartGranting(int _points = 100, float duration = 1.5, System.Action _onComplete)
    {
        var val_24;
        DG.Tweening.TweenCallback val_25;
        DG.Tweening.TweenCallback val_26;
        PointsGranter.<>c__DisplayClass12_0 val_1 = new PointsGranter.<>c__DisplayClass12_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        ._onComplete = _onComplete;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_2, isIndependentUpdate:  true);
        this.start.text = _points.ToString();
        val_24 = null;
        val_24 = null;
        float val_25 = PointsGranter.globalSpeedFactor;
        val_25 = (duration / System.Math.Abs((float)_points)) * val_25;
        this.gapBetweenCount = val_25;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass12_0::<StartGranting>b__0()));
        if(_points < 1)
        {
            goto label_10;
        }
        
        new DG.Tweening.TweenCallback() = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass12_0::<StartGranting>b__1());
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback());
        if(_points < 1)
        {
            goto label_17;
        }
        
        var val_26 = 0;
        do
        {
            val_25 = (PointsGranter.<>c__DisplayClass12_0)[1152921528663573808].<>9__5;
            if(val_25 == null)
        {
                DG.Tweening.TweenCallback val_10 = null;
            val_25 = val_10;
            val_10 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass12_0::<StartGranting>b__5());
            .<>9__5 = val_25;
        }
        
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  val_10);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  this.gapBetweenCount);
            val_26 = val_26 + 1;
        }
        while(val_26 < _points);
        
        goto label_17;
        label_10:
        new DG.Tweening.TweenCallback() = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass12_0::<StartGranting>b__2());
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback());
        int val_15 = UnityEngine.Mathf.Abs(value:  _points);
        if(val_15 >= 1)
        {
                int val_16 = val_15 + 1;
            do
        {
            val_26 = (PointsGranter.<>c__DisplayClass12_0)[1152921528663573808].<>9__6;
            if(val_26 == null)
        {
                DG.Tweening.TweenCallback val_17 = null;
            val_26 = val_17;
            val_17 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass12_0::<StartGranting>b__6());
            .<>9__6 = val_26;
        }
        
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  val_17);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  this.gapBetweenCount);
            val_16 = val_16 - 1;
        }
        while(val_16 > 1);
        
        }
        
        label_17:
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass12_0::<StartGranting>b__3()));
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass12_0::<StartGranting>b__4()));
        return val_2;
    }
    public DG.Tweening.Sequence StartGrantingGGP(decimal _points, float duration = 1.5, System.Action _onComplete)
    {
        var val_20;
        var val_21;
        var val_22;
        DG.Tweening.TweenCallback val_23;
        PointsGranter.<>c__DisplayClass13_0 val_1 = new PointsGranter.<>c__DisplayClass13_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        ._onComplete = _onComplete;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Sequence>(t:  val_2, isIndependentUpdate:  true);
        float val_20 = 100f;
        val_20 = null;
        val_20 = (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = _points.flags, hi = _points.hi, lo = _points.lo, mid = _points.mid})) * val_20;
        val_20 = null;
        float val_22 = PointsGranter.globalSpeedFactor;
        val_22 = (duration / System.Math.Abs(val_20)) * val_22;
        this.gapBetweenCount = val_22;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass13_0::<StartGrantingGGP>b__0()));
        DG.Tweening.TweenCallback val_8 = null;
        val_21 = 0;
        val_8 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass13_0::<StartGrantingGGP>b__1());
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  val_8);
        val_22 = 0;
        goto label_11;
        label_15:
        val_23 = (PointsGranter.<>c__DisplayClass13_0)[1152921528663850672].<>9__4;
        if(val_23 == null)
        {
                DG.Tweening.TweenCallback val_10 = null;
            val_21 = 0;
            val_23 = val_10;
            val_10 = new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass13_0::<StartGrantingGGP>b__4());
            .<>9__4 = val_23;
        }
        
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  val_10);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  this.gapBetweenCount);
        val_22 = 1;
        label_11:
        decimal val_13 = System.Decimal.op_Implicit(value:  1);
        decimal val_14 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = _points.flags, hi = _points.hi, lo = _points.lo, mid = _points.mid}, d2:  new System.Decimal());
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_13.flags, hi = val_13.hi, lo = val_13.lo, mid = val_13.mid}, d2:  new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid})) == true)
        {
            goto label_15;
        }
        
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass13_0::<StartGrantingGGP>b__2()));
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_2, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PointsGranter.<>c__DisplayClass13_0::<StartGrantingGGP>b__3()));
        return val_2;
    }
    public PointsGranter()
    {
    
    }
    private static PointsGranter()
    {
        PointsGranter.globalSpeedFactor = 0.5f;
    }

}
