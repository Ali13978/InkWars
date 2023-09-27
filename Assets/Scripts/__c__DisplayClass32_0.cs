using UnityEngine;
private sealed class PostMatchCanvas.<>c__DisplayClass32_0
{
    // Fields
    public UnityEngine.RectTransform winRT;
    public PostMatchCanvas <>4__this;
    
    // Methods
    public PostMatchCanvas.<>c__DisplayClass32_0()
    {
    
    }
    internal void <UpdateWLD>b__1()
    {
        NetworkUserInfo val_1 = DataStructs.UserDataDictionary.ToNetworkUserInfo();
        this.<>4__this.win.text = val_1.win.ToString();
        UnityEngine.Color val_3 = UnityEngine.Color.green;
        UnityEngine.Vector2 val_4 = this.winRT.sizeDelta;
        val_4.x = val_4.x * 0.5f;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4.x, y:  0f);
        this.<>4__this.PlayStarAnimation(parent:  this.winRT, anchoredPosition:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, scale:  2f);
        UnityEngine.AudioSource val_7 = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.winAudioClip, volume:  1f);
    }

}
