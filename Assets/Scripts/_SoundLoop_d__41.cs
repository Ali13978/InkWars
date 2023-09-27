using UnityEngine;
private sealed class PlayerCharacterUIController.<SoundLoop>d__41 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PlayerCharacterUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerCharacterUIController.<SoundLoop>d__41(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) <= 1)
        {
                this.<>1__state = 0;
            this.<>4__this.equippedSoundSource = GameAudio.sound.PlayOneShot(clip:  this.<>4__this.superEquippedSound, volume:  0.8f);
            UnityEngine.WaitForSeconds val_4 = null;
            float val_5 = -0.075f;
            val_5 = (this.<>4__this.superEquippedSound.length) + val_5;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  val_5);
            val_5 = 1;
            this.<>2__current = val_4;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
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
