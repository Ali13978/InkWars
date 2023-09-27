using UnityEngine;
private sealed class PostMatchCommonPanel.<>c__DisplayClass65_0
{
    // Fields
    public PostMatchCommonPanel <>4__this;
    public int _score;
    
    // Methods
    public PostMatchCommonPanel.<>c__DisplayClass65_0()
    {
    
    }
    internal void <ShowScore>b__0()
    {
        this.<>4__this.m_scorePanel.gameObject.SetActive(value:  true);
        this.<>4__this.m_score.text = this._score.ToString();
    }

}
