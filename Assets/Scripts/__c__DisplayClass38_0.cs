using UnityEngine;
private sealed class PostMatchCommonPanel.<>c__DisplayClass38_0
{
    // Fields
    public PostMatchCommonPanel <>4__this;
    public bool show;
    
    // Methods
    public PostMatchCommonPanel.<>c__DisplayClass38_0()
    {
    
    }
    internal void <ShowRematchPanel>b__0()
    {
        this.<>4__this.m_returningtoLobbyText.gameObject.SetActive(value:  true);
        this.<>4__this.GotoLobby(rounds:  1);
    }
    internal void <ShowRematchPanel>b__1()
    {
        UnityEngine.Debug.Log(message:  "start Rematch 2");
        this.<>4__this.rematchPanel.gameObject.SetActive(value:  (this.show == true) ? 1 : 0);
        UnityEngine.Debug.Log(message:  "Rematch Actived");
    }

}
