using UnityEngine;
public class BPAmplifierCanvas : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image m_amplifierPlus;
    private UnityEngine.UI.Image m_amplifierShield;
    private UnityEngine.UI.Image m_amplifierTypeBG;
    private UnityEngine.UI.Image m_selectedAmplifierImage;
    private UnityEngine.Canvas m_parentCanvas;
    private TMPro.TextMeshProUGUI m_selectedAmplifierName;
    private TMPro.TextMeshProUGUI m_selectedAmplifierDescription;
    private UnityEngine.UI.Button m_activateButton;
    private UnityEngine.UI.Button m_stockUpButton;
    private UnityEngine.UI.GridLayoutGroup m_parentLayout;
    private UnityEngine.GameObject m_preview;
    private UnityEngine.GameObject m_stockEmpty;
    private UnityEngine.AudioClip activateClip;
    private BPAmplifierList m_bPAmplifiersList;
    private System.Collections.Generic.Dictionary<BPAmplifierItem, UnityEngine.UI.Button> m_bpButtonList;
    private BPAmplifierItem m_activeItem;
    private System.Collections.Generic.List<UnityEngine.UI.Image> objectList;
    public System.Action m_activateAction;
    
    // Methods
    private void OnEnable()
    {
        this.m_activateButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifierCanvas::OnClickActivate()));
        this.m_stockUpButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifierCanvas::OnStockUpClick()));
    }
    private void OnDisable()
    {
        this.m_activateButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifierCanvas::OnClickActivate()));
        this.m_stockUpButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void BPAmplifierCanvas::OnStockUpClick()));
    }
    private void OnStockUpClick()
    {
        var val_5;
        GameAudio.PlayButtonSound();
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.PlayerPrefs.SetString(key:  "LastLevel", value:  val_1.m_Handle.name);
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_5 = null;
        val_5 = null;
        BEPACanvasController.PreviousScene = val_3.m_Handle.name;
        BEPACanvasController.GotoBattleAmplifierCanvas = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  "Scene_GetBEPA");
    }
    private void FillItemsGrid()
    {
        var val_8;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        UnityEngine.UI.Image val_44;
        float val_45;
        float val_46;
        float val_47;
        System.Collections.Generic.List<BPAmplifierItem> val_48;
        var val_49;
        val_40 = null;
        val_40 = null;
        this.m_bPAmplifiersList = DataStructs.UserDataDictionary.Items.GetAmplifierList();
        int val_2 = val_1.items.Count;
        UnityEngine.GameObject val_3 = this.m_preview.gameObject;
        if(val_3 == null)
        {
            goto label_7;
        }
        
        if(val_2 == 0)
        {
            goto label_8;
        }
        
        label_12:
        val_3.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.m_stockEmpty.gameObject;
        val_41 = 0;
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
        
        label_8:
        val_3.SetActive(value:  false);
        val_41 = 1;
        label_11:
        this.m_stockEmpty.gameObject.SetActive(value:  true);
        List.Enumerator<T> val_6 = this.objectList.GetEnumerator();
        label_19:
        if(((-1742426208) & 1) == 0)
        {
            goto label_16;
        }
        
        val_8.InitialType.gameObject.SetActive(value:  false);
        goto label_19;
        label_16:
        val_8.Add(driver:  public System.Void List.Enumerator<UnityEngine.UI.Image>::Dispose(), rectTransform:  0, drivenProperties:  null);
        this.objectList.Clear();
        this.m_bpButtonList.Clear();
        val_42 = 0;
        goto label_27;
        label_58:
        .<>4__this = this;
        .tmpBPAplifierItem = this.m_bPAmplifiersList.items.Item[0];
        if(val_12.amplifierType == 1)
        {
                val_43 = 1152921504848113664;
            val_44 = this.m_amplifierPlus;
        }
        else
        {
                val_43 = 1152921504848113664;
            val_44 = this.m_amplifierShield;
        }
        
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
        val_45 = val_13.y;
        UnityEngine.UI.Image val_14 = UnityEngine.Object.Instantiate<UnityEngine.UI.Image>(original:  val_44, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_45, z = val_13.z, w = val_13.w});
        val_14.GetComponentInChildren<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new BPAmplifierCanvas.<>c__DisplayClass21_0(), method:  System.Void BPAmplifierCanvas.<>c__DisplayClass21_0::<FillItemsGrid>b__0()));
        val_14.transform.SetParent(p:  this.m_parentLayout.transform);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
        val_46 = val_21.x;
        val_47 = val_21.z;
        val_14.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_46, y = val_21.y, z = val_47};
        val_14.GetComponentInChildren<TMPro.TextMeshProUGUI>().SetText(text:  (BPAmplifierCanvas.<>c__DisplayClass21_0)[1152921528634321984].tmpBPAplifierItem.precentage.ToString()((BPAmplifierCanvas.<>c__DisplayClass21_0)[1152921528634321984].tmpBPAplifierItem.precentage.ToString()) + "%"("%"));
        val_14.gameObject.SetActive(value:  true);
        this.objectList.Add(item:  val_14);
        this.m_bpButtonList.Add(key:  (BPAmplifierCanvas.<>c__DisplayClass21_0)[1152921528634321984].tmpBPAplifierItem, value:  val_14.GetComponentInChildren<UnityEngine.UI.Button>());
        val_42 = 1;
        label_27:
        val_48 = this.m_bPAmplifiersList.items;
        if(val_42 < val_48.Count)
        {
            goto label_58;
        }
        
        val_49 = 0;
        goto label_59;
        label_76:
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.identity;
        val_45 = val_29.y;
        UnityEngine.UI.Image val_30 = UnityEngine.Object.Instantiate<UnityEngine.UI.Image>(original:  this.m_amplifierTypeBG, position:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, rotation:  new UnityEngine.Quaternion() {x = val_29.x, y = val_45, z = val_29.z, w = val_29.w});
        val_30.transform.SetParent(p:  this.m_parentLayout.transform);
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.one;
        val_46 = val_34.x;
        val_47 = val_34.z;
        val_30.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_46, y = val_34.y, z = val_47};
        val_30.gameObject.SetActive(value:  true);
        val_48 = this.objectList;
        val_48.Add(item:  val_30);
        val_49 = 1;
        label_59:
        if(val_49 < (8 - this.m_bPAmplifiersList.items.Count))
        {
            goto label_76;
        }
        
        if(this.m_bPAmplifiersList.items.Count < 1)
        {
                return;
        }
        
        this.OnClickAmplifier(item:  this.m_bPAmplifiersList.items.Item[0]);
    }
    private void Awake()
    {
        this.m_bpButtonList = new System.Collections.Generic.Dictionary<BPAmplifierItem, UnityEngine.UI.Button>();
        this.objectList = new System.Collections.Generic.List<UnityEngine.UI.Image>();
        this.FillItemsGrid();
    }
    private void OnClickAmplifier(BPAmplifierItem item)
    {
        TMPro.TextMeshProUGUI val_11;
        System.Object[] val_12;
        string val_13;
        if(item.amplifierType == 2)
        {
            goto label_2;
        }
        
        if(item.amplifierType != 1)
        {
            goto label_3;
        }
        
        this.m_selectedAmplifierName.SetText(text:  LanguageManager.GetText(key:  "LK.bp.title1"));
        val_11 = this.m_selectedAmplifierDescription;
        val_12 = new object[1];
        val_12[0] = item.precentage.ToString();
        val_13 = "LK.bp.description1";
        goto label_9;
        label_2:
        this.m_selectedAmplifierName.SetText(text:  LanguageManager.GetText(key:  "LK.bp.title2"));
        val_11 = this.m_selectedAmplifierDescription;
        object[] val_5 = new object[1];
        val_12 = val_5;
        val_12[0] = item.precentage.ToString();
        val_13 = "LK.bp.description2";
        label_9:
        val_11.SetText(text:  LanguageManager.GetTextFormat(key:  val_13, list:  val_5));
        label_3:
        this.m_activeItem = item;
        this.m_selectedAmplifierImage.sprite = this.m_bpButtonList.Item[item].GetComponent<UnityEngine.UI.Image>().sprite;
    }
    private void OnClickActivate()
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(this.m_activeItem.precentage != 0)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(this.m_activeItem.precentage == 0)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_2[0] = this.m_activeItem.precentage;
        YesNoDialog val_6 = YesNoDialog.Show(title:  LanguageManager.GetText(key:  "LK.bp.ActivateMsgTitle"), msg:  LanguageManager.GetTextFormat(key:  (this.m_activeItem.amplifierType == 1) ? "LK.bp.ActivateMsg1" : "LK.bp.ActivateMsg2", list:  val_2), yesAction:  new System.Action(object:  this, method:  System.Void BPAmplifierCanvas::<OnClickActivate>b__24_0()), noAction:  0);
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public BPAmplifierCanvas()
    {
    
    }
    private void <OnClickActivate>b__24_0()
    {
        var val_8;
        var val_9;
        BPAmplifierItem val_10;
        if(this.m_activeItem != null)
        {
                int val_7 = this.m_activeItem.precentage;
            val_7 = val_7 | (this.m_activeItem.amplifierType << 7);
            val_8 = val_7 << 20;
        }
        else
        {
                val_8 = 0;
        }
        
        val_9 = null;
        val_9 = null;
        CodeStage.AntiCheat.ObscuredTypes.ObscuredInt val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredInt.op_Implicit(value:  0);
        DataStructs.UserDataDictionary.Settings.SelectedBPAmplifier = new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_1.currentCryptoKey, hiddenValue = val_1.hiddenValue, fakeValue = val_1.fakeValue, inited = val_1.inited};
        System.DateTime val_2 = System.DateTime.Now;
        System.DateTime val_3 = val_2.dateData.AddSeconds(value:  10800);
        DataStructs.UserDataDictionary.GameSave.BPAmplifierExpireDate = new System.DateTime() {dateData = val_3.dateData};
        val_10 = this.m_activeItem;
        if(this.m_activeItem != null)
        {
            goto label_11;
        }
        
        val_10 = this.m_activeItem;
        if(val_10 == null)
        {
            goto label_12;
        }
        
        label_11:
        DataStructs.UserDataDictionary.Items.RemoveAmplifier(type:  this.m_activeItem.amplifierType, level:  this.m_activeItem.precentage);
        this.FillItemsGrid();
        UnityEngine.AudioSource val_6 = GameAudio.sound.PlayOneShot(clip:  BattleEnhancerCollection.GetSFX(state:  1), volume:  1f);
        BPAmplifier.Hide();
        return;
        label_12:
    }

}
