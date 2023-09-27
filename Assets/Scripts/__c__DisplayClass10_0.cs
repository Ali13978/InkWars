using UnityEngine;
private sealed class OptionButton.<>c__DisplayClass10_0
{
    // Fields
    public float value;
    
    // Methods
    public OptionButton.<>c__DisplayClass10_0()
    {
    
    }
    internal bool <OnEnable>b__0(OptionButton.OptionStatus x)
    {
        return (bool)(x.value == this.value) ? 1 : 0;
    }

}
