using UnityEngine;
public class ListQ<T> : List<T>
{
    // Properties
    public T Top { get; set; }
    
    // Methods
    public T get_Top()
    {
        if(this == null)
        {
            
        }
    
    }
    private void set_Top(T value)
    {
    
    }
    public T Dequeue()
    {
        if(this != null)
        {
                return (object)this;
        }
        
        return (object)this;
    }
    public void PushBack(T item)
    {
        if(this != null)
        {
            
        }
    
    }
    public ListQ<T>()
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 56 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 56 + 294;
        if((val_1 & 1) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 56 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 56 + 294;
        }
        
        if(((val_1 & 512) != 0) && ((__RuntimeMethodHiddenParam + 24 + 192 + 56 + 216) == 0))
        {
            
        }
    
    }

}
