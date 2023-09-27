using UnityEngine;
public class CharacterAnimFunction : MonoBehaviour
{
    // Fields
    public static bool hasReceiveDamageFinishedCpu;
    public static bool hasReceiveDamageFinishedPlayer;
    public static bool hasAttackFinishedCpu;
    public static bool hasAttackFinishedPlayer;
    
    // Methods
    private void Start()
    {
        CharacterAnimFunction.hasReceiveDamageFinishedCpu = false;
        CharacterAnimFunction.hasReceiveDamageFinishedPlayer = false;
        CharacterAnimFunction.hasAttackFinishedCpu = false;
        CharacterAnimFunction.hasAttackFinishedPlayer = false;
    }
    public void receiveDamageAnimEnd()
    {
        if((System.String.op_Equality(a:  this.gameObject.name, b:  "CPUPlayer")) == false)
        {
                return;
        }
        
        CharacterAnimFunction.hasReceiveDamageFinishedCpu = true;
    }
    public void receiveDamageAnimEndPlayer()
    {
        if((System.String.op_Equality(a:  this.gameObject.name, b:  "Player")) == false)
        {
                return;
        }
        
        CharacterAnimFunction.hasReceiveDamageFinishedPlayer = true;
    }
    public void attackAnimEndCpu()
    {
        if((System.String.op_Equality(a:  this.gameObject.name, b:  "CPUPlayer")) == false)
        {
                return;
        }
        
        CharacterAnimFunction.hasAttackFinishedCpu = true;
    }
    public void attackAnimEndPlayer()
    {
        if((System.String.op_Equality(a:  this.gameObject.name, b:  "Player")) == false)
        {
                return;
        }
        
        CharacterAnimFunction.hasAttackFinishedPlayer = true;
    }
    public CharacterAnimFunction()
    {
    
    }

}
