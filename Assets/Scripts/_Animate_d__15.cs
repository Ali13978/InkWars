using UnityEngine;
private sealed class MovingAwardText.<Animate>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MovingAwardText <>4__this;
    private int <steps>5__2;
    private UnityEngine.Vector3 <pos>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MovingAwardText.<Animate>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_40;
        int val_41;
        int val_42;
        if((this.<>1__state) != 1)
        {
                val_40 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_40;
        }
        
            this.<>1__state = 0;
            val_41 = this;
            this.<steps>5__2 = (System.Int32.Parse(s:  this.<>4__this.start.text.Substring(startIndex:  1))) / (UnityEngine.Mathf.Abs(value:  this.<>4__this.amount));
            UnityEngine.Vector3 val_8 = this.<>4__this.LearpPoints.Item[0].transform.localPosition;
            this.<pos>5__3 = val_8;
            mem[1152921528662480736] = val_8.y;
            mem[1152921528662480740] = val_8.z;
            val_42 = 0;
            this.<>4__this.textList = new System.Collections.Generic.List<TMPro.TextMeshProUGUI>();
            this.<i>5__4 = 0;
        }
        else
        {
                this.<>1__state = 0;
            val_41 = this.<steps>5__2;
            val_42 = (this.<i>5__4) + 1;
            this.<i>5__4 = val_42;
        }
        
        if(val_42 < val_41)
        {
                MovingAwardText.<>c__DisplayClass15_0 val_10 = new MovingAwardText.<>c__DisplayClass15_0();
            .<>4__this = this.<>4__this;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            TMPro.TextMeshProUGUI val_12 = UnityEngine.Object.Instantiate<TMPro.TextMeshProUGUI>(original:  this.<>4__this.text, position:  new UnityEngine.Vector3() {x = this.<pos>5__3, y = V8.16B, z = V9.16B}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w});
            .tmpText = val_12;
            val_12.transform.SetParent(p:  this.<>4__this.parent);
            (MovingAwardText.<>c__DisplayClass15_0)[1152921528662545456].tmpText.transform.localPosition = new UnityEngine.Vector3() {x = this.<pos>5__3, y = V9.16B, z = this.<pos>5__3};
            (MovingAwardText.<>c__DisplayClass15_0)[1152921528662545456].tmpText.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            (MovingAwardText.<>c__DisplayClass15_0)[1152921528662545456].tmpText.text = ((this.<>4__this.amount) > 0) ? "+" : "-"(((this.<>4__this.amount) > 0) ? "+" : "-") + this.<>4__this + 40.ToString()(this.<>4__this + 40.ToString());
            (MovingAwardText.<>c__DisplayClass15_0)[1152921528662545456].tmpText.gameObject.SetActive(value:  true);
            this.<>4__this.textList.Add(item:  (MovingAwardText.<>c__DisplayClass15_0)[1152921528662545456].tmpText);
            val_41 = DG.Tweening.DOTween.Sequence();
            this.<>4__this.start.text = (System.Int32.Parse(s:  this.<>4__this.start.text)) - (UnityEngine.Mathf.Abs(value:  this.<>4__this + 40)).ToString();
            UnityEngine.Vector2 val_29 = this.<>4__this.LearpPoints.Item[1].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_41, t:  DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  (MovingAwardText.<>c__DisplayClass15_0)[1152921528662545456].tmpText.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y}, duration:  this.<>4__this.AnimationTime, snapping:  false));
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_41, callback:  new DG.Tweening.TweenCallback(object:  val_10, method:  System.Void MovingAwardText.<>c__DisplayClass15_0::<Animate>b__0()));
            DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_41, t:  DG.Tweening.ShortcutExtensions46.DOFade(target:  (MovingAwardText.<>c__DisplayClass15_0)[1152921528662545456].tmpText.GetComponent<UnityEngine.CanvasGroup>(), endValue:  0f, duration:  0.5f));
            DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_41, callback:  new DG.Tweening.TweenCallback(object:  val_10, method:  System.Void MovingAwardText.<>c__DisplayClass15_0::<Animate>b__1()));
            val_40 = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.gapBetweenText);
            this.<>1__state = val_40;
            return (bool)val_40;
        }
        
        val_40 = 0;
        return (bool)val_40;
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
