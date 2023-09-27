using UnityEngine;
private sealed class Scene_CharacterSelection_Adventure.<Start>d__46 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Scene_CharacterSelection_Adventure <>4__this;
    private System.Collections.Generic.List<CharacterNameID> <clanCharacterList>5__2;
    private CharacterAssetLoader <assetLoader>5__3;
    private int <countClanCharacters>5__4;
    private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, int>> <orderList>5__5;
    private int <i>5__6;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Scene_CharacterSelection_Adventure.<Start>d__46(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        var val_98;
        Scene_CharacterSelection_Adventure val_99;
        int val_100;
        var val_101;
        var val_102;
        int val_105;
        CharacterAssetLoader val_106;
        var val_107;
        var val_108;
        int val_111;
        int val_112;
        System.Collections.Generic.List<CharacterNameID> val_113;
        CharacterAssetLoader val_114;
        UnityEngine.DrivenTransformProperties val_115;
        var val_116;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_118;
        UnityEngine.RectTransform val_119;
        float val_120;
        var val_121;
        var val_123;
        val_99 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_100 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_100;
        }
        
        this.<>1__state = 0;
        val_101 = null;
        val_101 = null;
        Scene_CharacterSelection_Adventure.ready = false;
        CharacterInfo val_1 = Character_GlobalInfo.GetMainPlayer();
        System.Collections.Generic.List<CharacterNameID> val_4 = new System.Collections.Generic.List<CharacterNameID>();
        this.<clanCharacterList>5__2 = val_4;
        System.Collections.IEnumerator val_7 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_32:
        var val_97 = 0;
        val_97 = val_97 + 1;
        val_102 = 0;
        if(val_7.MoveNext() == false)
        {
            goto label_17;
        }
        
        var val_98 = 0;
        val_98 = val_98 + 1;
        val_102 = 1;
        val_7.Current.Add(driver:  public System.Object System.Collections.IEnumerator::get_Current(), rectTransform:  null, drivenProperties:  null);
        null.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
        if(((null.ToString().StartsWith(value:  (val_2 == 0) ? "IKA" : "TAKO")) == false) || ((CharacterHelper.IsHidden(cid:  null)) == true))
        {
            goto label_32;
        }
        
        this.<clanCharacterList>5__2.Add(item:  null);
        goto label_32;
        label_1:
        val_105 = 0;
        val_106 = this.<assetLoader>5__3;
        this.<>1__state = val_105;
        goto label_33;
        label_17:
        val_107 = 0;
        val_108 = 0;
        if(val_7 != null)
        {
                var val_99 = 0;
            val_99 = val_99 + 1;
            val_7.Dispose();
        }
        
        if( == 1)
        {
            goto label_52;
        }
        
        var val_17 = (188 == 188) ? 1 : 0;
        val_17 = (( >= 0) ? 1 : 0) & val_17;
        val_105 =  - val_17;
        if(val_99 != null)
        {
            goto label_60;
        }
        
        label_61:
        label_60:
        this.<assetLoader>5__3 = val_99.gameObject.AddComponent<CharacterAssetLoader>();
        val_111 = this;
        this.<countClanCharacters>5__4 = this.<clanCharacterList>5__2.Count;
        this.<>4__this.allClanCharactersInOrder = new CharacterNameID[0];
        this.<>4__this.characterDynamicPoses = new UnityEngine.Sprite[0];
        this.<>4__this.characterStats = new UnityEngine.Sprite[0];
        val_112 = 0;
        this.<orderList>5__5 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>();
        this.<i>5__6 = 0;
        goto label_59;
        label_52:
        if(val_99 != null)
        {
            goto label_60;
        }
        
        goto label_61;
        label_82:
        val_106 = this;
        val_113 = this.<clanCharacterList>5__2;
        UnityEngine.Coroutine val_28 = val_99.StartCoroutine(routine:  this.<assetLoader>5__3.RetrieveBundle(inputCharID:  val_4.Item[val_7], callback:  0));
        label_33:
        val_114 = this.<assetLoader>5__3;
        if(val_20.ready == false)
        {
            goto label_65;
        }
        
        val_115 = public System.Void System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>::.ctor(System.Int32 key, System.Int32 value);
        UnityEngine.SocialPlatforms.Range val_31 = new UnityEngine.SocialPlatforms.Range(fromValue:  this.<i>5__6, valueCount:  CharNameIDConverter.StageOrder(charNameID:  this.<clanCharacterList>5__2.Item[this.<i>5__6]));
        this.<orderList>5__5.Add(item:  new System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>() {Value = val_31.from});
        this.<>4__this.allClanCharactersInOrder[(this.<i>5__6) << 2] = this.<clanCharacterList>5__2.Item[this.<i>5__6];
        this.<>4__this.characterDynamicPoses[this.<i>5__6] = this.<assetLoader>5__3.LoadPose_Dynamic();
        this.<>4__this.characterStats[this.<i>5__6] = CharacterAssetLoader.LoadResource_CharacterStatType(charNameID:  this.<clanCharacterList>5__2.Item[this.<i>5__6], left:  true);
        val_111 = this.<countClanCharacters>5__4;
        val_112 = (this.<i>5__6) + 1;
        this.<i>5__6 = val_112;
        label_59:
        if(val_112 < val_111)
        {
            goto label_82;
        }
        
        val_116 = null;
        val_116 = null;
        val_118 = Scene_CharacterSelection_Adventure.<>c.<>9__46_0;
        if(val_118 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_36 = null;
            val_118 = val_36;
            val_115 = public System.Void System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>::.ctor(object object, IntPtr method);
            val_36 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  Scene_CharacterSelection_Adventure.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 Scene_CharacterSelection_Adventure.<>c::<Start>b__46_0(System.Collections.Generic.KeyValuePair<int, int> x));
            Scene_CharacterSelection_Adventure.<>c.<>9__46_0 = val_118;
        }
        
        val_119 = public static System.Linq.IOrderedEnumerable<TSource> System.Linq.Enumerable::OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> keySelector);
        this.<orderList>5__5 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(source:  this.<orderList>5__5, keySelector:  val_36));
        List.Enumerator<T> val_42 = this.<orderList>5__5.GetEnumerator();
        goto label_89;
        label_106:
        System.Type val_44 = val_31.from.InitialType;
        if(val_44.GetHashCode() >= (this.<>4__this.allClanCharactersInOrder.Length))
        {
                val_119 = 0;
        }
        
        if(0 >= val_39.Length)
        {
                val_119 = 0;
        }
        
        new CharacterNameID[0][0] = this.<>4__this.allClanCharactersInOrder[((long)(int)(val_45)) << 2];
        int val_46 = val_44.GetHashCode();
        if(val_46 >= (this.<>4__this.characterDynamicPoses.Length))
        {
                val_119 = 0;
        }
        
        UnityEngine.Sprite val_101 = this.<>4__this.characterDynamicPoses[(long)val_46];
        if((val_101 != null) && (val_101 == null))
        {
                val_119 = 0;
        }
        
        if(0 >= val_40.Length)
        {
                val_119 = 0;
        }
        
        new UnityEngine.Sprite[0][0] = val_101;
        int val_47 = val_44.GetHashCode();
        if(val_47 >= (this.<>4__this.characterStats.Length))
        {
                val_119 = 0;
        }
        
        UnityEngine.Sprite val_102 = this.<>4__this.characterStats[(long)val_47];
        if((val_102 != null) && (val_102 == null))
        {
                val_119 = 0;
        }
        
        if(0 >= val_41.Length)
        {
                val_119 = 0;
        }
        
        new UnityEngine.Sprite[0][0] = val_102;
        label_89:
        if(((-1619606496) & 1) != 0)
        {
            goto label_106;
        }
        
        mem[192] = 748;
        val_31.from.Add(driver:  public System.Void List.Enumerator<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>::Dispose(), rectTransform:  val_119, drivenProperties:  val_115);
        goto label_122;
        label_65:
        val_100 = 1;
        this.<>2__current = 0;
        this.<>1__state = val_100;
        return (bool)val_100;
        label_122:
        this.<>4__this.allClanCharactersInOrder = val_114;
        this.<>4__this.characterDynamicPoses = this.<assetLoader>5__3;
        this.<>4__this.characterStats = this;
        this.<>4__this.swipeButtons[0].SetActive(value:  false);
        this.<>4__this.swipeButtons[1].SetActive(value:  false);
        this.<>4__this.instructionalPanel.SetActive(value:  false);
        this.<>4__this.backButton.SetActive(value:  false);
        this.<>4__this.iconHolder.SetActive(value:  false);
        this.<>4__this.imageStats.SetActive(value:  false);
        this.<>4__this.imageName.SetActive(value:  false);
        this.<>4__this.imageNew.SetActive(value:  false);
        this.<>4__this.lockedImage.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.<>4__this.nextButton.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_52 = this.<>4__this.displayImages.Item[0].transform.position;
        this.<>4__this.imagePos_Left = val_52;
        mem2[0] = val_52.y;
        mem2[0] = val_52.z;
        UnityEngine.Vector3 val_55 = this.<>4__this.displayImages.Item[1].transform.position;
        this.<>4__this.imagePos_Middle = val_55;
        mem2[0] = val_55.y;
        mem2[0] = val_55.z;
        UnityEngine.Vector3 val_58 = this.<>4__this.displayImages.Item[2].transform.position;
        this.<>4__this.imagePos_Right = val_58;
        mem2[0] = val_58.y;
        mem2[0] = val_58.z;
        var val_105 = -4294967296;
        val_105 = val_105 + ((this.<>4__this.characterDynamicPoses.Length) << 32);
        this.<>4__this.displayImages.Item[0].sprite = this.<>4__this.characterDynamicPoses[val_105 >> 32];
        this.<>4__this.displayImages.Item[1].sprite = this.<>4__this.characterDynamicPoses[0];
        this.<>4__this.displayImages.Item[2].sprite = this.<>4__this.characterDynamicPoses[1];
        this.<>4__this.displayImages.Item[0].transform.localScale = new UnityEngine.Vector3() {x = this.<>4__this.scaleSide, y = V9.16B, z = V10.16B};
        this.<>4__this.displayImages.Item[1].transform.localScale = new UnityEngine.Vector3() {x = this.<>4__this.scaleCenter, y = V9.16B, z = V10.16B};
        this.<>4__this.displayImages.Item[2].transform.localScale = new UnityEngine.Vector3() {x = this.<>4__this.scaleSide, y = V9.16B, z = V10.16B};
        val_99.SetNameImage();
        val_114 = this.<>4__this.imageNew.GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Vector3 val_71 = val_114.localScale;
        val_113 = 1152921504848060416;
        val_120 = val_71.x;
        UnityEngine.Vector3 val_72 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_120, y = val_71.y, z = val_71.z}, d:  0.75f);
        DG.Tweening.Tweener val_75 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.imageNew.GetComponent<UnityEngine.RectTransform>(), endValue:  new UnityEngine.Vector3() {x = val_72.x, y = val_72.y, z = val_72.z}, duration:  1f), ease:  4), loops:  0, loopType:  1);
        val_98 = 1152921504858337280;
        val_121 = 0;
        goto label_174;
        label_214:
        CharacterNameID val_109 = this.<>4__this.allClanCharactersInOrder[0];
        UnityEngine.RectTransform val_76 = CharacterHelper.GetUnlockButtonPrefab(id:  val_109);
        if(0 == val_76)
        {
                val_109.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  0, drivenProperties:  public static DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetLoops<DG.Tweening.Tweener>(DG.Tweening.Tweener t, int loops, DG.Tweening.LoopType loopType));
            UnityEngine.RectTransform val_81 = new UnityEngine.GameObject(name:  "Unlock Button " + val_109.ToString()).AddComponent<UnityEngine.RectTransform>();
        }
        else
        {
                UnityEngine.RectTransform val_82 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  val_76);
        }
        
        val_82.transform.parent = this.<>4__this.buyButtons.transform;
        UnityEngine.Vector3 val_85 = UnityEngine.Vector3.zero;
        val_82.localPosition = new UnityEngine.Vector3() {x = val_85.x, y = val_85.y, z = val_85.z};
        UnityEngine.Vector3 val_86 = UnityEngine.Vector3.one;
        val_120 = val_86.z;
        if(val_82 != null)
        {
                val_82.localScale = new UnityEngine.Vector3() {x = val_86.x, y = val_86.y, z = val_120};
        }
        else
        {
                val_82.localScale = new UnityEngine.Vector3() {x = val_86.x, y = val_86.y, z = val_120};
        }
        
        val_82.gameObject.SetActive(value:  false);
        val_114 = CharacterDataManager.Get(id:  null);
        if(val_88.unlockType == 3)
        {
            goto label_200;
        }
        
        if(val_88.unlockType == 8)
        {
            goto label_201;
        }
        
        if(val_88.unlockType != 4)
        {
            goto label_209;
        }
        
        ExpressCharacterBuyButton val_89 = val_82.GetComponent<ExpressCharacterBuyButton>();
        val_114 = val_88.iapId;
        mem2[0] = val_114;
        goto label_209;
        label_201:
        val_114 = val_88.virtualCurrency;
        val_82.GetComponent<PearlBuyButton>().Setup(aNewItemName:  val_114.localizedText.name, aNewItem:  val_88.iapId, aNewPrice:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredInt() {currentCryptoKey = val_88.virtualPrice, hiddenValue = val_88.virtualPrice, fakeValue = 1152921505065472000, inited = false}, aNewCurrency:  val_114);
        val_113 = val_113;
        val_98 = val_98;
        val_99 = val_99;
        goto label_209;
        label_200:
        TwitterFollowButton val_93 = val_82.GetComponent<TwitterFollowButton>();
        UnityEngine.Events.UnityAction val_94 = null;
        val_114 = val_94;
        val_94 = new UnityEngine.Events.UnityAction(object:  val_99, method:  public System.Void Scene_CharacterSelection_Adventure::UnlockCharacter());
        val_93.OnTwitterFollowSuccess.AddListener(call:  val_94);
        label_209:
        val_121 = 1;
        label_174:
        if(val_121 < (this.<>4__this.allClanCharactersInOrder.Length))
        {
            goto label_214;
        }
        
        val_123 = null;
        val_123 = null;
        Scene_CharacterSelection_Adventure.ready = true;
        UnityEngine.Coroutine val_96 = val_99.StartCoroutine(routine:  val_99.AnimationAtStart());
        val_100 = 0;
        return (bool)val_100;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
