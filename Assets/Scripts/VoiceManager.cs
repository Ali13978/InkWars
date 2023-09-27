using UnityEngine;
public class VoiceManager : MonoBehaviour
{
    // Fields
    public static VoiceManager instance;
    public UnityEngine.AudioClip[] ika_0;
    public UnityEngine.AudioClip[] ika_1;
    public UnityEngine.AudioClip[] ika_2;
    public UnityEngine.AudioClip[] ika_3;
    public UnityEngine.AudioClip[] ika_4;
    public UnityEngine.AudioClip[] ika_5;
    public UnityEngine.AudioClip[] ika_6;
    public UnityEngine.AudioClip[] ika_7;
    public UnityEngine.AudioClip[] ika_8;
    public UnityEngine.AudioClip[] ika_9;
    public UnityEngine.AudioClip[] ika_10;
    public UnityEngine.AudioClip[] ika_11;
    public UnityEngine.AudioClip[] ika_12;
    public UnityEngine.AudioClip[] ika_13;
    public UnityEngine.AudioClip[] Tako_0;
    public UnityEngine.AudioClip[] Tako_1;
    public UnityEngine.AudioClip[] Tako_2;
    public UnityEngine.AudioClip[] Tako_3;
    public UnityEngine.AudioClip[] Tako_4;
    public UnityEngine.AudioClip[] Tako_5;
    public UnityEngine.AudioClip[] Tako_6;
    public UnityEngine.AudioClip[] Tako_7;
    public UnityEngine.AudioClip[] Tako_8;
    public UnityEngine.AudioClip[] Tako_9;
    public UnityEngine.AudioClip[] Tako_10;
    public UnityEngine.AudioClip[] Tako_11;
    public UnityEngine.AudioClip[] Tako_12;
    private bool postsound;
    private float volume;
    private bool loriiAttack;
    public bool isForInk;
    
    // Properties
    public UnityEngine.AudioSource Source { get; }
    
    // Methods
    public UnityEngine.AudioSource get_Source()
    {
        SoundList val_1 = GameAudio.sound;
        if(val_1 != null)
        {
                return val_1.Get();
        }
        
        return val_1.Get();
    }
    private void Start()
    {
        VoiceManager val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        val_6 = null;
        if(VoiceManager.instance == 0)
        {
                val_7 = null;
            VoiceManager.instance = val_4;
            return;
        }
        
        val_8 = null;
        if(this == this)
        {
                return;
        }
        
        val_4 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  val_4);
    }
    public void PlayAttackSound(int Left, int SoundType, int modifiers)
    {
    
    }
    public VoiceManager()
    {
        this.postsound = true;
        this.volume = 1f;
    }
    private static VoiceManager()
    {
    
    }

}
