using UnityEngine;
public class PrizesPanel : MonoBehaviour
{
    // Fields
    public static decimal lastGGPAmount;
    private System.Collections.Generic.List<UnityEngine.UI.Image> m_avatars;
    private System.Collections.Generic.List<CustomTitle> m_titles;
    private UnityEngine.GameObject m_shells;
    private UnityEngine.GameObject m_pearls;
    private UnityEngine.GameObject m_tockens;
    private TMPro.TextMeshProUGUI m_prizeTitleText_1;
    private TMPro.TextMeshProUGUI m_prizeTitleText_2;
    private TMPro.TextMeshProUGUI m_shellsCount;
    private TMPro.TextMeshProUGUI m_pearlsCount;
    private TMPro.TextMeshProUGUI m_tockensCount;
    private TMPro.TextMeshProUGUI m_tipsTitle;
    private MotionPanelsControler m_hintImage;
    private MotionPanelsControler m_hintText;
    private MotionPanelsControler congratzPanel;
    private UnityEngine.GameObject TitlePrize;
    private UnityEngine.GameObject AvatarPrize;
    private UnityEngine.GameObject WagerPrize;
    private MotionPanelsControler m_shellsButton;
    private MotionPanelsControler m_pearlsButton;
    private MotionPanelsControler m_tockensButton;
    private PointsGranter m_shellGranter;
    private PointsGranter m_pearlGranter;
    private PointsGranter m_tockenGranter;
    private UnityEngine.GameObject avatarUnclokedText;
    private UnityEngine.GameObject titleUnclokedText;
    private UnityEngine.GameObject unclokedBottomText;
    
    // Methods
    public void SetupHint(UnityEngine.UI.Image image, string text)
    {
        this.m_hintImage.GetComponent<UnityEngine.UI.Image>().sprite = image.sprite;
        this.m_hintText.GetComponent<TMPro.TextMeshProUGUI>().text = text;
    }
    private void OnEnable()
    {
        var val_3 = null;
        this.m_tockensButton.gameObject.SetActive(value:  (Character_GlobalInfo.isCryptoMMOCMode == true) ? 1 : 0);
    }
    private void OnDisable()
    {
        DG.Tweening.Sequence val_1 = this.m_shellsButton.MovetoStart();
        DG.Tweening.Sequence val_2 = this.m_pearlsButton.MovetoStart();
    }
    public DG.Tweening.Sequence Hide()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  this.congratzPanel.MovetoStart());
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.WagerPrize.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, duration:  0.5f), ease:  27));
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.TitlePrize.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.5f), ease:  27));
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.AvatarPrize.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  val_1, callback:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void PrizesPanel::<Hide>b__30_0()));
        return val_1;
    }
    public DG.Tweening.Sequence ShowPrizes(System.Collections.Generic.List<ProfileUnlockables_Base> list)
    {
        var val_94;
        int val_95;
        var val_96;
        int val_98;
        int val_99;
        var val_100;
        int val_101;
        var val_102;
        var val_104;
        UnityEngine.RectTransform val_106;
        UnityEngine.Transform val_107;
        int val_108;
        ProfileUnlockables_Title val_109;
        DG.Tweening.Sequence val_110;
        var val_111;
        MotionPanelsControler val_113;
        var val_114;
        var val_115;
        decimal val_116;
        decimal val_117;
        Currency val_118;
        var val_119;
        Currency val_120;
        var val_121;
        Currency val_122;
        var val_123;
        Currency val_124;
        var val_125;
        Currency val_126;
        var val_127;
        Currency val_128;
        var val_129;
        TMPro.TextMeshProUGUI val_131;
        IntPtr val_133;
        System.Collections.Generic.List<ProfileUnlockables_Base> val_134;
        var val_135;
        DG.Tweening.TweenCallback val_137;
        PrizesPanel.<>c__DisplayClass31_0 val_1 = new PrizesPanel.<>c__DisplayClass31_0();
        .<>4__this = this;
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  val_2, interval:  0.1f);
        .prize = 0m;
        mem[1152921528692633648] = 0;
        val_94 = null;
        val_94 = null;
        InkWars.Model.Model_Manager val_4 = InkWars.Model.Model_Manager.Instance;
        val_95 = 0;
        InkWars.Model.GameResult val_5 = val_4.Model.GameResult;
        if(PostMatchCanvas.IsPrivateWagerMatch == false)
        {
            goto label_8;
        }
        
        if(val_5 == 1)
        {
            goto label_9;
        }
        
        if(val_5 == 6)
        {
            goto label_10;
        }
        
        if(val_5 != 4)
        {
            goto label_19;
        }
        
        label_9:
        val_96 = null;
        val_96 = null;
        val_95 = SetWager.privateWager.__il2cppRuntimeField_8;
        decimal val_6 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = SetWager.privateWager, hi = SetWager.privateWager, lo = val_95, mid = val_95}, d2:  new System.Decimal());
        .prize = val_6;
        mem[1152921528692633648] = val_6.lo;
        mem[1152921528692633652] = val_6.mid;
        goto label_24;
        label_8:
        if(val_5 == 1)
        {
            goto label_17;
        }
        
        if(val_5 == 6)
        {
            goto label_18;
        }
        
        if(val_5 != 4)
        {
            goto label_19;
        }
        
        label_17:
        decimal val_7 = PublicWagerData.lastPrize;
        goto label_20;
        label_19:
        val_98 = 0;
        val_99 = 0;
        goto label_24;
        label_10:
        val_100 = null;
        val_100 = null;
        .prize = SetWager.privateWager;
        mem[1152921528692633648] = SetWager.privateWager.__il2cppRuntimeField_8;
        goto label_24;
        label_18:
        decimal val_8 = PublicWagerData.lastWager;
        label_20:
        .prize = val_8;
        mem[1152921528692633648] = val_8.lo;
        mem[1152921528692633652] = val_8.mid;
        decimal val_9 = PublicWagerData.lastWager;
        val_98 = val_9.flags;
        val_99 = val_9.lo;
        label_24:
        decimal val_10 = CryptoCurrency.CryptoCurency;
        val_101 = val_10.lo;
        decimal val_11 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_101, mid = val_10.mid}, d2:  new System.Decimal() {flags = val_98, hi = val_9.hi, lo = val_99, mid = val_9.mid});
        decimal val_12 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid}, d2:  new System.Decimal() {flags = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize, hi = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize, lo = val_99, mid = val_9.mid});
        PrizesPanel.lastGGPAmount = val_12.flags;
        PrizesPanel.lastGGPAmount.__il2cppRuntimeField_3 = val_12.hi;
        PrizesPanel.lastGGPAmount.__il2cppRuntimeField_8 = val_12.lo;
        PrizesPanel.lastGGPAmount.__il2cppRuntimeField_C = val_12.mid;
        val_102 = null;
        val_102 = null;
        if((PrizesPanel.<>c.<>9__31_0) == null)
        {
            goto label_33;
        }
        
        label_79:
        this.m_avatars.ForEach(action:  PrizesPanel.<>c.<>9__31_0);
        val_104 = null;
        val_104 = null;
        if((PrizesPanel.<>c.<>9__31_1) == null)
        {
            goto label_37;
        }
        
        label_83:
        this.m_titles.ForEach(action:  PrizesPanel.<>c.<>9__31_1);
        this.m_shells.gameObject.SetActive(value:  false);
        this.m_pearls.gameObject.SetActive(value:  false);
        this.avatarUnclokedText.gameObject.SetActive(value:  false);
        this.titleUnclokedText.gameObject.SetActive(value:  false);
        val_106 = 0;
        this.unclokedBottomText.gameObject.SetActive(value:  false);
        List.Enumerator<T> val_18 = list.GetEnumerator();
        val_107 = 1152921528692205904;
        label_75:
        val_108 = 0;
        goto label_66;
        label_65:
        this.m_avatars.Item[0].gameObject.SetActive(value:  true);
        val_101 = this.m_avatars.Item[0];
        val_106 = 0;
        val_101.sprite = val_10.flags + 88;
        label_66:
        if(((-1684065376) & 1) == 0)
        {
            goto label_61;
        }
        
        val_109 = 0.InitialType;
        if((System.Type.op_Equality(left:  val_109.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == true)
        {
            goto label_65;
        }
        
        if(val_108 > 2)
        {
            goto label_66;
        }
        
        this.m_titles.Item[0].gameObject.SetActive(value:  true);
        var val_32 = val_108 + 1;
        if(val_109 != null)
        {
                val_109 = 0;
        }
        
        this.m_titles.Item[0].Setup(title:  val_109);
        goto label_75;
        label_33:
        PrizesPanel.<>c.<>9__31_0 = new System.Action<UnityEngine.UI.Image>(object:  PrizesPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PrizesPanel.<>c::<ShowPrizes>b__31_0(UnityEngine.UI.Image x));
        if(this.m_avatars != null)
        {
            goto label_79;
        }
        
        goto label_79;
        label_37:
        PrizesPanel.<>c.<>9__31_1 = new System.Action<CustomTitle>(object:  PrizesPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PrizesPanel.<>c::<ShowPrizes>b__31_1(CustomTitle x));
        if(this.m_titles != null)
        {
            goto label_83;
        }
        
        goto label_83;
        label_61:
        0.Add(driver:  public System.Void List.Enumerator<ProfileUnlockables_Base>::Dispose(), rectTransform:  val_106, drivenProperties:  val_99);
        val_110 = val_2;
        val_111 = val_108;
        val_114 = null;
        val_114 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize, hi = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false)
        {
            goto label_112;
        }
        
        if((1 > 0) || ( > 0))
        {
            goto label_119;
        }
        
        if(InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch == true)
        {
            goto label_120;
        }
        
        goto label_119;
        label_112:
        if(1 <= 0)
        {
                if( < 1)
        {
            goto label_120;
        }
        
        }
        
        label_119:
        val_113 = this.congratzPanel;
        DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.Append(s:  null, t:  val_113.MovetoEnd());
        label_120:
        val_115 = null;
        val_116 = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize;
        val_115 = null;
        if(((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_116, hi = val_116, lo = val_113, mid = val_113}, d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_10>>0&0xFFFFFFFF, mid = System.Decimal.Powers10.__il2cppRuntimeField_10>>32&0x0})) == false) || (InkWars.Model.MVC_Multiplayer_Manager_Base.IsBotMatch == true))
        {
            goto label_164;
        }
        
        this.WagerPrize.gameObject.SetActive(value:  true);
        val_117 = PublicWagerData.GetDataByLevel(level:  PublicWagerData.<selectedWagerLevel>k__BackingField);
        if(val_117 == null)
        {
            goto label_131;
        }
        
        val_118 = val_45.m_currency;
        if(val_118 != 1)
        {
            goto label_132;
        }
        
        val_119 = null;
        val_119 = null;
        if(PostMatchCanvas.IsPrivateWagerMatch == false)
        {
            goto label_135;
        }
        
        val_120 = val_45.m_currency;
        label_132:
        if(val_120 != 0)
        {
            goto label_136;
        }
        
        val_121 = null;
        val_121 = null;
        if(PostMatchCanvas.IsPrivateWagerMatch == false)
        {
            goto label_139;
        }
        
        val_122 = val_45.m_currency;
        label_136:
        if(val_122 == 2)
        {
            goto label_140;
        }
        
        label_131:
        val_123 = null;
        val_123 = null;
        if(PostMatchCanvas.IsPrivateWagerMatch == false)
        {
            goto label_143;
        }
        
        label_140:
        this.m_tockens.gameObject.SetActive(value:  true);
        val_101 = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize;
        this.m_tockenGranter.SetStartNumber(aNewCount:  new System.Decimal() {flags = val_101, hi = val_101});
        DG.Tweening.Sequence val_48 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  null, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PrizesPanel.<>c__DisplayClass31_0::<ShowPrizes>b__5()));
        DG.Tweening.Sequence val_50 = DG.Tweening.TweenSettingsExtensions.Append(s:  null, t:  this.m_tockensButton.MovetoEnd());
        val_116 = this.m_tockensCount;
        val_111 = ;
        if(val_116 != null)
        {
            goto label_177;
        }
        
        label_178:
        label_177:
        val_116.text = .prize.ToString();
        label_143:
        DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  null, callback:  new DG.Tweening.TweenCallback(object:  0, method:  public static System.Void GameAudio::PlayPurchaseSound()));
        val_107 = this.WagerPrize.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_55 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_58 = DG.Tweening.TweenSettingsExtensions.Join(s:  null, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_107, endValue:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.y, z = val_55.z}, duration:  0.5f), ease:  27));
        DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  null, interval:  1f);
        if(val_117 == null)
        {
            goto label_152;
        }
        
        val_124 = val_45.m_currency;
        if(val_124 != 1)
        {
            goto label_153;
        }
        
        val_125 = null;
        val_125 = null;
        if(PostMatchCanvas.IsPrivateWagerMatch == false)
        {
            goto label_156;
        }
        
        val_126 = val_45.m_currency;
        label_153:
        if(val_126 != 0)
        {
            goto label_157;
        }
        
        val_127 = null;
        val_127 = null;
        if(PostMatchCanvas.IsPrivateWagerMatch == false)
        {
            goto label_160;
        }
        
        val_128 = val_45.m_currency;
        label_157:
        if(val_128 == 2)
        {
            goto label_161;
        }
        
        label_152:
        val_129 = null;
        val_129 = null;
        if(PostMatchCanvas.IsPrivateWagerMatch == false)
        {
            goto label_164;
        }
        
        label_161:
        val_107 = this.m_tockenGranter;
        val_117 = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize;
        System.Action val_60 = null;
        val_101 = val_60;
        val_60 = new System.Action(object:  val_1, method:  System.Void PrizesPanel.<>c__DisplayClass31_0::<ShowPrizes>b__8());
        DG.Tweening.Sequence val_61 = val_107.StartGrantingGGP(_points:  new System.Decimal() {flags = val_117, hi = val_117, lo = val_116, mid = val_116}, duration:  1.5f, _onComplete:  val_60);
        goto label_166;
        label_135:
        this.m_shells.gameObject.SetActive(value:  true);
        DG.Tweening.Sequence val_64 = DG.Tweening.TweenSettingsExtensions.Append(s:  null, t:  this.m_shellsButton.MovetoEnd());
        val_131 = this.m_shellsCount;
        goto label_170;
        label_156:
        val_107 = this.m_shellGranter;
        val_117 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize, hi = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize, lo = val_117, mid = val_117});
        val_133 = 1152921528692445520;
        goto label_173;
        label_139:
        this.m_pearls.gameObject.SetActive(value:  true);
        DG.Tweening.Sequence val_68 = DG.Tweening.TweenSettingsExtensions.Append(s:  null, t:  this.m_pearlsButton.MovetoEnd());
        val_131 = this.m_pearlsCount;
        label_170:
        string val_69 = .prize.ToString();
        if(val_131 != null)
        {
            goto label_177;
        }
        
        goto label_178;
        label_160:
        val_107 = this.m_pearlGranter;
        val_117 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize, hi = (PrizesPanel.<>c__DisplayClass31_0)[1152921528692633616].prize, lo = val_117, mid = val_117});
        System.Action val_71 = null;
        val_133 = 1152921528692483408;
        label_173:
        val_71 = new System.Action(object:  val_1, method:  val_133);
        label_166:
        DG.Tweening.Sequence val_73 = DG.Tweening.TweenSettingsExtensions.Append(s:  null, t:  val_107.StartGranting(_points:  val_117, duration:  1.5f, _onComplete:  val_71));
        label_164:
        val_134 = list;
        if(val_134.Count >= 1)
        {
                val_134 = 1152921505120317440;
            val_135 = null;
            val_135 = null;
            val_137 = PrizesPanel.<>c.<>9__31_2;
            if(val_137 == null)
        {
                DG.Tweening.TweenCallback val_75 = null;
            val_137 = val_75;
            val_75 = new DG.Tweening.TweenCallback(object:  PrizesPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PrizesPanel.<>c::<ShowPrizes>b__31_2());
            PrizesPanel.<>c.<>9__31_2 = val_137;
        }
        
            DG.Tweening.Sequence val_76 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  null, callback:  val_75);
        }
        
        if(val_111 >= 1)
        {
                DG.Tweening.Sequence val_78 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  null, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PrizesPanel.<>c__DisplayClass31_0::<ShowPrizes>b__3()));
            UnityEngine.Vector3 val_80 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_83 = DG.Tweening.TweenSettingsExtensions.Append(s:  null, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.TitlePrize.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_80.x, y = val_80.y, z = val_80.z}, duration:  0.5f), ease:  27));
        }
        
        if(1 < 1)
        {
                return (DG.Tweening.Sequence);
        }
        
        DG.Tweening.Sequence val_85 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  null, callback:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void PrizesPanel.<>c__DisplayClass31_0::<ShowPrizes>b__4()));
        UnityEngine.RectTransform val_86 = this.AvatarPrize.GetComponent<UnityEngine.RectTransform>();
        if(val_111 >= 1)
        {
                UnityEngine.Vector3 val_87 = UnityEngine.Vector3.one;
            DG.Tweening.Sequence val_90 = DG.Tweening.TweenSettingsExtensions.Join(s:  null, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_86, endValue:  new UnityEngine.Vector3() {x = val_87.x, y = val_87.y, z = val_87.z}, duration:  0.5f), ease:  27));
            return (DG.Tweening.Sequence);
        }
        
        UnityEngine.Vector3 val_91 = UnityEngine.Vector3.one;
        DG.Tweening.Sequence val_94 = DG.Tweening.TweenSettingsExtensions.Append(s:  null, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  val_86, endValue:  new UnityEngine.Vector3() {x = val_91.x, y = val_91.y, z = val_91.z}, duration:  0.5f), ease:  27));
        return (DG.Tweening.Sequence);
    }
    public PrizesPanel()
    {
    
    }
    private static PrizesPanel()
    {
        PrizesPanel.lastGGPAmount = 0m;
        PrizesPanel.lastGGPAmount.__il2cppRuntimeField_8 = 0;
    }
    private void <Hide>b__30_0()
    {
        this.titleUnclokedText.gameObject.SetActive(value:  false);
        this.avatarUnclokedText.gameObject.SetActive(value:  false);
        this.unclokedBottomText.gameObject.SetActive(value:  false);
    }

}
