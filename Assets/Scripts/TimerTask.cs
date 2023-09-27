using UnityEngine;
private class MainThreadDispatcher.TimerTask
{
    // Fields
    public float delay;
    public System.Action action;
    public string key;
    public bool repeat;
    public float interval;
    
    // Methods
    public MainThreadDispatcher.TimerTask()
    {
        this.interval = 9999f;
    }
    public MainThreadDispatcher.TimerTask(System.Action aNewTask, float aNewDelay)
    {
        this.interval = 9999f;
        this.delay = aNewDelay;
        this.action = aNewTask;
    }
    public MainThreadDispatcher.TimerTask(string aNewKey, System.Action aNewTask, float aNewDelay, float aNewInterval)
    {
        this.interval = 9999f;
        this.delay = aNewDelay;
        this.action = aNewTask;
        this.key = aNewKey;
        this.repeat = true;
        this.interval = aNewInterval;
    }

}
