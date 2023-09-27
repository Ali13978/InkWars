using UnityEngine;
public class CharAudioController : MonoBehaviour
{
    // Fields
    public static float audioChance_attack;
    private AudioCheck attackSequence;
    public bool audioLoaded;
    private CharacterAudio allAudio;
    private UnityEngine.AudioSource currentSound;
    private UnityEngine.AudioClip lastPlayedClip;
    private CharacterAnimationName lastAnimPlayed;
    private float fadeOutTime;
    
    // Methods
    public System.Collections.IEnumerator LoadAudio_Gameplay(CharacterAssetLoader assetLoader)
    {
        CharAudioController.<LoadAudio_Gameplay>d__8 val_1 = new CharAudioController.<LoadAudio_Gameplay>d__8();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .assetLoader = assetLoader;
        return (System.Collections.IEnumerator)val_1;
    }
    public System.Collections.IEnumerator LoadAudio_CharacterSelect(CharacterAssetLoader assetLoader)
    {
        CharAudioController.<LoadAudio_CharacterSelect>d__9 val_1 = new CharAudioController.<LoadAudio_CharacterSelect>d__9();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .assetLoader = assetLoader;
        return (System.Collections.IEnumerator)val_1;
    }
    public void Play(CharacterAnimationName audioName, bool inkingSequence)
    {
        bool val_21 = inkingSequence;
        if(audioName > 16)
        {
                return;
        }
        
        var val_21 = 40836636 + (audioName) << 2;
        val_21 = val_21 + 40836636;
        goto (40836636 + (audioName) << 2 + 40836636);
    }
    private System.Collections.IEnumerator FadeSoundOut(UnityEngine.AudioSource audio)
    {
        CharAudioController.<FadeSoundOut>d__11 val_1 = new CharAudioController.<FadeSoundOut>d__11();
        .<>1__state = 0;
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .audio = audio;
        return (System.Collections.IEnumerator)val_1;
    }
    public CharAudioController()
    {
        this.fadeOutTime = 0.2f;
    }
    private static CharAudioController()
    {
        CharAudioController.audioChance_attack = 0.4f;
    }

}
