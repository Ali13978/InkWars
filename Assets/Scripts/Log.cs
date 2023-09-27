using UnityEngine;
public class Reporter.Log
{
    // Fields
    public int count;
    public Reporter._LogType logType;
    public string condition;
    public string stacktrace;
    public int sampleId;
    
    // Methods
    public Reporter.Log CreateCopy()
    {
        var val_4;
        if(this.MemberwiseClone() == null)
        {
                return (Log)val_4;
        }
        
        val_4 = 0;
        return (Log)val_4;
    }
    public float GetMemoryUsage()
    {
        int val_3 = this.stacktrace.Length + this.condition.Length;
        val_3 = val_3 << 1;
        val_3 = val_3 + 12;
        return (float)(float)val_3;
    }
    public Reporter.Log()
    {
        this.count = 1;
    }

}
