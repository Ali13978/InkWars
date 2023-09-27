using UnityEngine;
[Serializable]
public class RevengeCharacterInformation.BubbleInfo
{
    // Fields
    public InkWars.Model.BubbleTypes BubbleType;
    public UnityEngine.Sprite StunnerBallSprite;
    public UnityEngine.Sprite CannonBallSprite;
    public UnityEngine.Sprite EraserBallSprite;
    public UnityEngine.Color StunnerBallGlowColor;
    public UnityEngine.Color CannonBallGlowColor;
    public UnityEngine.Color EraserBallGlowColor;
    public UnityEngine.Color RainbowTransformerGlowColor;
    internal UnityEngine.Color VirusGlowColor;
    public UnityEngine.Sprite[] StunnerBallTextSprites;
    public UnityEngine.Sprite[] CannonBallTextSprites;
    public UnityEngine.Sprite[] EraserBallTextSprites;
    public float TextAnimationSwapRate;
    
    // Methods
    public RevengeCharacterInformation.BubbleInfo()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.StunnerBallGlowColor = val_1;
        mem[1152921528469468836] = val_1.g;
        mem[1152921528469468840] = val_1.b;
        mem[1152921528469468844] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.CannonBallGlowColor = val_2;
        mem[1152921528469468852] = val_2.g;
        mem[1152921528469468856] = val_2.b;
        mem[1152921528469468860] = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        this.EraserBallGlowColor = val_3;
        mem[1152921528469468868] = val_3.g;
        mem[1152921528469468872] = val_3.b;
        mem[1152921528469468876] = val_3.a;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.RainbowTransformerGlowColor = val_4;
        mem[1152921528469468884] = val_4.g;
        mem[1152921528469468888] = val_4.b;
        mem[1152921528469468892] = val_4.a;
        UnityEngine.Color val_5 = UnityEngine.Color.white;
        this.VirusGlowColor = val_5;
        mem[1152921528469468900] = val_5.g;
        mem[1152921528469468904] = val_5.b;
        mem[1152921528469468908] = val_5.a;
        this.TextAnimationSwapRate = 0.25f;
    }

}
