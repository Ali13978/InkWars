using UnityEngine;
public struct InAppBrowser.EdgeInsets
{
    // Fields
    public int top;
    public int left;
    public int right;
    public int bottom;
    
    // Methods
    public InAppBrowser.EdgeInsets(int horizontal, int vertical)
    {
        mem[1152921526123812824] = horizontal;
        mem[1152921526123812828] = vertical;
        mem[1152921526123812816] = vertical;
        mem[1152921526123812820] = horizontal;
    }
    public InAppBrowser.EdgeInsets(int paddingTop, int paddingBottom, int paddingLeft, int paddingRight)
    {
        mem[1152921526123924824] = paddingRight;
        mem[1152921526123924828] = paddingBottom;
        mem[1152921526123924816] = paddingTop;
        mem[1152921526123924820] = paddingLeft;
    }

}
