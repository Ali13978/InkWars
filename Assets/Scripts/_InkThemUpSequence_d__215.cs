using UnityEngine;
private sealed class LineController.<InkThemUpSequence>d__215 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineController <>4__this;
    private int <count>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineController.<InkThemUpSequence>d__215(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        CharAnimationController_Physical val_500;
        LineController.<InkThemUpSequence>d__215 val_501;
        bool val_504;
        float val_509;
        float val_510;
        float val_512;
        var val_548;
        var val_549;
        var val_550;
        var val_551;
        var val_552;
        var val_558;
        val_501 = this;
        if((this.<>1__state) > 30)
        {
            goto label_329;
        }
        
        var val_505 = 40844396 + (this.<>1__state) << 2;
        val_505 = val_505 + 40844396;
        goto (40844396 + (this.<>1__state) << 2 + 40844396);
        label_297:
        val_548 = null;
        val_548 = null;
        if((LineController.inkBubbles + 32) == 0)
        {
            goto label_265;
        }
        
        SoundList val_84 = GameAudio.sound;
        UnityEngine.AudioSource val_85 = val_84.PlayOneShot(clip:  null, volume:  null);
        val_549 = null;
        val_549 = null;
        UnityEngine.Vector3 val_88 = LineController.inkBubbles + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_89 = UnityEngine.Quaternion.identity;
        val_509 = val_89.x;
        val_510 = val_89.z;
        UnityEngine.GameObject val_90 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_84, position:  new UnityEngine.Vector3() {x = val_88.x, y = val_88.y, z = val_88.z}, rotation:  new UnityEngine.Quaternion() {x = val_509, y = val_89.y, z = val_510, w = val_89.w});
        mem[1152921526283958416] = val_90;
        UnityEngine.Transform val_91 = val_90.transform;
        val_91.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.RectTransform val_94 = val_91.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_97 = LineController.inkBubbles + 32.gameObject.transform.position;
        val_512 = val_97.y;
        val_94.position = new UnityEngine.Vector3() {x = val_97.x, y = val_512, z = val_97.z};
        val_550 = null;
        if((val_94.GetComponent<popScoreScript>()) == null)
        {
                val_550 = null;
        }
        
        val_98.scoreCounter = ;
        int val_516 = ;
        val_516 = val_516 + ;
        LineController.userScore = val_516;
        int val_518 = LineController.inkBubbles.Length;
        UnityEngine.Object.Destroy(obj:  LineController.inkBubbles + 32.gameObject);
         =  + 1;
        if(( - 4) <= 37)
        {
            goto label_297;
        }
        
        label_265:
        InGameBackgroundController val_100 = InGameBackgroundController.instance;
        val_100.EnableInkSequenceDark(enable:  false);
        val_100.PlayAnimation(newAnimName:  15, forceOverride:  false);
        if(val_518 != 11)
        {
            goto label_301;
        }
        
        val_518 = val_518 - 1;
        if(val_518 > 1)
        {
            goto label_301;
        }
        
        val_551 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Sound/GAME_CLEARED");
        val_552 = null;
        goto label_304;
        label_329:
        val_504 = 0;
        return (bool);
        label_301:
        val_552 = null;
        label_304:
        GameAudio.SwitchMusicOneShot(clip:  null, forcePlay:  false);
        val_500 = 1152921505145610240;
        val_558 = null;
        val_558 = null;
        val_504 = 1;
        VoiceManager.instance.PlayAttackSound(Left:  1, SoundType:  2, modifiers:  0);
        mem[1152921526283679864] = new UnityEngine.WaitForSeconds(seconds:  2f);
        this.<>1__state = 26;
        return (bool);
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
