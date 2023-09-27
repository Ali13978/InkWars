using UnityEngine;
private sealed class LineController.<InkThemUpSequenceP2>d__218 : IEnumerator<object>, IEnumerator, IDisposable
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
    public LineController.<InkThemUpSequenceP2>d__218(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_215;
        int val_216;
        bool val_219;
        float val_222;
        float val_223;
        float val_225;
        var val_243;
        var val_244;
        var val_245;
        var val_246;
        val_215 = this;
        if((this.<>1__state) > 20)
        {
            goto label_1;
        }
        
        var val_216 = 40844616 + (this.<>1__state) << 2;
        val_216 = val_216 + 40844616;
        goto (40844616 + (this.<>1__state) << 2 + 40844616);
        label_234:
        val_244 = null;
        val_244 = null;
        if((LineController.inkBubbles + 32) == 0)
        {
            goto label_202;
        }
        
        SoundList val_82 = GameAudio.sound;
        UnityEngine.AudioSource val_83 = val_82.PlayOneShot(clip:  null, volume:  null);
        val_245 = null;
        val_245 = null;
        UnityEngine.Vector3 val_86 = LineController.inkBubbles + 32.gameObject.transform.position;
        UnityEngine.Quaternion val_87 = UnityEngine.Quaternion.identity;
        val_222 = val_87.x;
        val_223 = val_87.z;
        UnityEngine.GameObject val_88 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_82, position:  new UnityEngine.Vector3() {x = val_86.x, y = val_86.y, z = val_86.z}, rotation:  new UnityEngine.Quaternion() {x = val_222, y = val_87.y, z = val_223, w = val_87.w});
        mem[1152921526287238448] = val_88;
        UnityEngine.Transform val_89 = val_88.transform;
        val_89.SetParent(parent:  UnityEngine.GameObject.Find(name:  "ScoreTextHandler").transform, worldPositionStays:  false);
        UnityEngine.RectTransform val_92 = val_89.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_95 = LineController.inkBubbles + 32.gameObject.transform.position;
        val_225 = val_95.y;
        val_92.position = new UnityEngine.Vector3() {x = val_95.x, y = val_225, z = val_95.z};
        popScoreScript val_96 = val_92.GetComponent<popScoreScript>();
        val_96.scoreCounter = ;
        UnityEngine.PlayerPrefs.SetInt(key:  "Score2", value:   + (UnityEngine.PlayerPrefs.GetInt(key:  "Score2")));
        UnityEngine.Object.Destroy(obj:  LineController.inkBubbles + 32.gameObject);
        val_243 =  + 1;
        if(( - 4) <= 37)
        {
            goto label_234;
        }
        
        label_202:
        LineControllerP2 val_100 = GetComponent<LineControllerP2>();
        val_100.animController.PlayAnimation(newAnimName:  15, forceOverride:  false);
        val_246 = null;
        val_246 = null;
        VoiceManager.instance.PlayAttackSound(Left:  0, SoundType:  2, modifiers:  0);
        GameAudio.SwitchMusicOneShot(clip:  null, forcePlay:  false);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  2f);
        val_216 = 19;
        goto label_535;
        label_1:
        val_219 = 0;
        return (bool)val_219;
        label_535:
        this.<>1__state = ;
        val_219 = 1;
        return (bool)val_219;
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
