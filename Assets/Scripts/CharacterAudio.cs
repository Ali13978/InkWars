using UnityEngine;
public struct CharacterAudio
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.AudioClip> attack;
    public System.Collections.Generic.List<UnityEngine.AudioClip> attackChargeLead;
    public System.Collections.Generic.List<UnityEngine.AudioClip> attackCharge;
    public System.Collections.Generic.List<UnityEngine.AudioClip> defence;
    public System.Collections.Generic.List<UnityEngine.AudioClip> defenceChargeLead;
    public System.Collections.Generic.List<UnityEngine.AudioClip> defenceCharge;
    public System.Collections.Generic.List<UnityEngine.AudioClip> drawLead;
    public System.Collections.Generic.List<UnityEngine.AudioClip> draw;
    public System.Collections.Generic.List<UnityEngine.AudioClip> idle;
    public System.Collections.Generic.List<UnityEngine.AudioClip> loseLead;
    public System.Collections.Generic.List<UnityEngine.AudioClip> lose;
    public System.Collections.Generic.List<UnityEngine.AudioClip> postAttack;
    public System.Collections.Generic.List<UnityEngine.AudioClip> postReceiveDamage;
    public System.Collections.Generic.List<UnityEngine.AudioClip> receiveDamage;
    public System.Collections.Generic.List<UnityEngine.AudioClip> receiveDamageLose;
    public System.Collections.Generic.List<UnityEngine.AudioClip> winLead;
    public System.Collections.Generic.List<UnityEngine.AudioClip> win;
    
    // Methods
    public void Initialize()
    {
        mem2[0] = this.attackCharge.SyncRoot;
        mem2[0] = mem[this.attackCharge + 4];
        mem2[0] = mem[this.attackCharge + 8];
        mem2[0] = mem[this.attackCharge + 16];
    }

}
