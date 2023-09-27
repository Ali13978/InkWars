using UnityEngine;
public class FindPublicMatch : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Button m_allSkillButton;
    public UnityEngine.UI.Button m_mySkillButton;
    public UnityEngine.UI.Button m_findMatch;
    public UnityEngine.UI.Image m_skillTypeActive;
    public UnityEngine.UI.Image m_skillTypeInActive;
    private SkillType m_currentSkillType;
    
    // Methods
    private void OnEnable()
    {
        this.m_allSkillButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FindPublicMatch::OnAllSkillButtonClick()));
        this.m_mySkillButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FindPublicMatch::OnMySkillButtonClick()));
        this.m_findMatch.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FindPublicMatch::OnFindMatchClick()));
    }
    private void OnDisable()
    {
        this.m_allSkillButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FindPublicMatch::OnAllSkillButtonClick()));
        this.m_mySkillButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FindPublicMatch::OnMySkillButtonClick()));
        this.m_findMatch.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FindPublicMatch::OnFindMatchClick()));
    }
    private void Awake()
    {
        this.m_currentSkillType = 1;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    private void OnAllSkillButtonClick()
    {
        this.m_allSkillButton.GetComponent<UnityEngine.UI.Image>().sprite = this.m_skillTypeActive.sprite;
        this.m_mySkillButton.GetComponent<UnityEngine.UI.Image>().sprite = this.m_skillTypeInActive.sprite;
        this.m_currentSkillType = 0;
    }
    private void OnMySkillButtonClick()
    {
        this.m_allSkillButton.GetComponent<UnityEngine.UI.Image>().sprite = this.m_skillTypeInActive.sprite;
        this.m_mySkillButton.GetComponent<UnityEngine.UI.Image>().sprite = this.m_skillTypeActive.sprite;
        this.m_currentSkillType = 1;
    }
    private void OnFindMatchClick()
    {
    
    }
    public FindPublicMatch()
    {
    
    }

}
