using UnityEngine;
public class GameAudio.SoundList
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.AudioSource> sourceList;
    private bool _mute;
    
    // Properties
    public bool mute { get; set; }
    
    // Methods
    public UnityEngine.AudioSource Get()
    {
        System.Collections.Generic.List<UnityEngine.AudioSource> val_8;
        var val_9;
        System.Predicate<UnityEngine.AudioSource> val_11;
        UnityEngine.Object val_12;
        val_8 = this;
        val_9 = null;
        val_9 = null;
        val_11 = GameAudio.SoundList.<>c.<>9__1_0;
        if(val_11 == null)
        {
            goto label_3;
        }
        
        label_17:
        val_12 = this.sourceList.Find(match:  val_11);
        if(0 != val_12)
        {
                return val_12;
        }
        
        val_12 = GameAudio.instance.gameObject.AddComponent<UnityEngine.AudioSource>();
        if(val_12 == null)
        {
            goto label_12;
        }
        
        val_12.playOnAwake = false;
        goto label_13;
        label_3:
        GameAudio.SoundList.<>c.<>9__1_0 = new System.Predicate<UnityEngine.AudioSource>(object:  GameAudio.SoundList.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameAudio.SoundList.<>c::<Get>b__1_0(UnityEngine.AudioSource x));
        if(this.sourceList != null)
        {
            goto label_17;
        }
        
        goto label_17;
        label_12:
        val_12.playOnAwake = false;
        label_13:
        val_12.loop = false;
        val_11 = this._mute;
        val_12.mute = (val_11 == true) ? 1 : 0;
        val_8 = this.sourceList;
        val_8.Add(item:  val_12);
        return val_12;
    }
    public UnityEngine.AudioSource PlayOneShot(UnityEngine.AudioClip clip, float volume = 1)
    {
        UnityEngine.AudioSource val_1 = this.Get();
        if(val_1 != null)
        {
                float val_2 = 0.5f;
            val_2 = volume * val_2;
            val_1.volume = val_2;
            val_1.clip = clip;
            val_1.loop = false;
        }
        else
        {
                float val_3 = 0.5f;
            val_3 = volume * val_3;
            0.volume = val_3;
            0.clip = clip;
            0.loop = false;
        }
        
        val_1.Play();
        return val_1;
    }
    public UnityEngine.AudioSource PlayLoop(UnityEngine.AudioClip clip, float volume = 1)
    {
        UnityEngine.AudioSource val_1 = this.PlayOneShot(clip:  clip, volume:  volume);
        val_1.loop = true;
        return val_1;
    }
    public void Stop(UnityEngine.AudioClip clip)
    {
        if(0 == clip)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this.sourceList.GetEnumerator();
        label_11:
        if(((-1899387928) & 1) == 0)
        {
            goto label_5;
        }
        
        System.Type val_3 = 0.InitialType;
        if(clip != val_3.clip)
        {
            goto label_11;
        }
        
        val_3.Stop();
        goto label_11;
        label_5:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.AudioSource>::Dispose(), rectTransform:  0, drivenProperties:  null);
    }
    public void Pause()
    {
        List.Enumerator<T> val_1 = this.sourceList.GetEnumerator();
        label_4:
        if(((-1899251336) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.Pause();
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.AudioSource>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public void UnPause()
    {
        List.Enumerator<T> val_1 = this.sourceList.GetEnumerator();
        label_4:
        if(((-1899122952) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.UnPause();
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.AudioSource>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public void set_mute(bool value)
    {
        this._mute = value;
        List.Enumerator<T> val_2 = this.sourceList.GetEnumerator();
        label_4:
        if(((-1898994568) & 1) == 0)
        {
            goto label_2;
        }
        
        0.InitialType.mute = value;
        goto label_4;
        label_2:
        0.Add(driver:  public System.Void List.Enumerator<UnityEngine.AudioSource>::Dispose(), rectTransform:  null, drivenProperties:  null);
    }
    public bool get_mute()
    {
        return (bool)this._mute;
    }
    public GameAudio.SoundList()
    {
        this.sourceList = new System.Collections.Generic.List<UnityEngine.AudioSource>();
    }

}
