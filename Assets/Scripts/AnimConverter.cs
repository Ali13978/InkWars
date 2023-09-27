using UnityEngine;
public class AnimConverter
{
    // Methods
    public static string ToString(CharacterAnimationName animName)
    {
        var val_1;
        if(animName <= 16)
        {
                val_1 = mem[51420896 + (animName) << 3];
            val_1 = 51420896 + (animName) << 3;
            return (string)val_1;
        }
        
        val_1 = "";
        return (string)val_1;
    }
    public AnimConverter()
    {
    
    }

}
