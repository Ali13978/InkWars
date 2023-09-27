using UnityEngine;
public class CharacterStore_PanelController : MonoBehaviour
{
    // Fields
    public ShopPanel shopPanelType;
    private UnityEngine.GameObject template;
    
    // Methods
    private void Awake()
    {
        CharacterStore_Controller val_36;
        UnityEngine.GameObject val_37;
        var val_40;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        val_36 = this;
        if(((UnityEngine.Resources.Load(path:  "Characters/CharacterShopButton", systemTypeInstance:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != null) && (null != null))
        {
                val_37 = 0;
        }
        
        this.template = val_37;
        System.Collections.IEnumerator val_6 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_41:
        var val_38 = 0;
        val_38 = val_38 + 1;
        if(val_6.MoveNext() == false)
        {
            goto label_13;
        }
        
        var val_39 = 0;
        val_39 = val_39 + 1;
        object val_10 = val_6.Current;
        if((CharacterHelper.IsHidden(cid:  1152921504628039680)) == true)
        {
            goto label_41;
        }
        
        CharacterData val_12 = CharacterDataManager.Get(id:  1152921504628039680);
        if((val_12 == 0) || (val_12.iapId == 0))
        {
            goto label_41;
        }
        
        if(this.shopPanelType == 2)
        {
            goto label_29;
        }
        
        if(this.shopPanelType == 1)
        {
            goto label_30;
        }
        
        if((this.shopPanelType != 0) || ((val_12.clan != 0) || (val_12.realPersonCharacter == true)))
        {
            goto label_41;
        }
        
        UnityEngine.GameObject val_15 = this.CreateShopButton(charNameID:  1152921504628039680, displayPriority:  0);
        goto label_41;
        label_29:
        if(val_12.realPersonCharacter == false)
        {
            goto label_41;
        }
        
        this.CreateShopButton(charNameID:  1152921504628039680, displayPriority:  val_12.inStorePriority).transform.SetAsFirstSibling();
        goto label_41;
        label_30:
        if((val_12.clan != 1) || (val_12.realPersonCharacter == true))
        {
            goto label_41;
        }
        
        UnityEngine.GameObject val_19 = this.CreateShopButton(charNameID:  1152921504628039680, displayPriority:  0);
        goto label_41;
        label_13:
        val_40 = 0;
        if(val_6 != null)
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_6.Dispose();
        }
        
        if(this.shopPanelType == 2)
        {
            goto label_65;
        }
        
        if(this.shopPanelType == 1)
        {
            goto label_66;
        }
        
        if(this.shopPanelType != 0)
        {
                return;
        }
        
        this.SortOrder();
        val_43 = null;
        val_43 = null;
        val_36 = this.gameObject.transform.GetChild(index:  0).gameObject.GetComponent<CharacterStore_Controller>();
        if(sceneCharacters.instance == null)
        {
            goto label_74;
        }
        
        sceneCharacters.instance.firstIka = val_36;
        if(val_36 != null)
        {
            goto label_97;
        }
        
        goto label_94;
        label_66:
        this.SortOrder();
        val_44 = null;
        val_44 = null;
        val_36 = this.gameObject.transform.GetChild(index:  0).gameObject.GetComponent<CharacterStore_Controller>();
        if(sceneCharacters.instance == null)
        {
            goto label_83;
        }
        
        sceneCharacters.instance.firstTako = val_36;
        if(val_36 != null)
        {
            goto label_97;
        }
        
        goto label_94;
        label_65:
        this.SortOrder();
        val_45 = null;
        val_45 = null;
        val_36 = this.gameObject.transform.GetChild(index:  0).gameObject.GetComponent<CharacterStore_Controller>();
        if(sceneCharacters.instance == null)
        {
            goto label_92;
        }
        
        sceneCharacters.instance.firstSpecial = val_36;
        if(val_36 != null)
        {
            goto label_97;
        }
        
        goto label_94;
        label_83:
        val_46 = 200;
        goto label_96;
        label_92:
        val_46 = 208;
        goto label_96;
        label_74:
        val_46 = 216;
        label_96:
        mem[216] = val_36;
        val_36 = mem[216];
        if(val_36 != 0)
        {
            goto label_97;
        }
        
        label_94:
        label_97:
        UnityEngine.Coroutine val_37 = val_36.StartCoroutine(routine:  val_36.SelectCharacter());
    }
    private UnityEngine.GameObject CreateShopButton(CharacterNameID charNameID, int displayPriority = 0)
    {
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.template, parent:  this.gameObject.transform);
        CharacterStore_Controller val_4 = val_3.GetComponent<CharacterStore_Controller>();
        val_4.charNameID = charNameID;
        CharacterStore_Controller val_5 = val_3.GetComponent<CharacterStore_Controller>();
        val_5.displayPriority = displayPriority;
        val_3.GetComponent<CharacterStore_Controller>().Initialize();
        return val_3;
    }
    private void SortOrder()
    {
        var val_40;
        var val_41;
        var val_42;
        System.Func<CharacterStore_Controller, System.Int32> val_44;
        UnityEngine.Transform val_45;
        var val_46;
        UnityEngine.Object val_47;
        var val_48;
        var val_51;
        var val_54;
        val_40 = this;
        val_41 = new UnityEngine.GameObject(name:  "TempHolder").transform;
        val_41.SetParent(p:  this.gameObject.transform);
        if(this.shopPanelType <= 1)
        {
            goto label_4;
        }
        
        if(this.shopPanelType != 2)
        {
                return;
        }
        
        System.Collections.Generic.List<CharacterStore_Controller> val_7 = new System.Collections.Generic.List<CharacterStore_Controller>();
        val_7.AddRange(collection:  this.gameObject.GetComponentsInChildren<CharacterStore_Controller>());
        val_42 = null;
        val_42 = null;
        val_44 = CharacterStore_PanelController.<>c.<>9__4_0;
        if(val_44 == null)
        {
                System.Func<CharacterStore_Controller, System.Int32> val_8 = null;
            val_44 = val_8;
            val_8 = new System.Func<CharacterStore_Controller, System.Int32>(object:  CharacterStore_PanelController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 CharacterStore_PanelController.<>c::<SortOrder>b__4_0(CharacterStore_Controller x));
            CharacterStore_PanelController.<>c.<>9__4_0 = val_44;
        }
        
        val_45 = 1152921526053740384;
        val_46 = 1152921505123938304;
        val_40 = System.Linq.Enumerable.ToList<CharacterStore_Controller>(source:  System.Linq.Enumerable.OrderByDescending<CharacterStore_Controller, System.Int32>(source:  val_7, keySelector:  val_8));
        val_47 = 0;
        goto label_13;
        label_21:
        val_40.gameObject.transform.GetChild(index:  0).transform.parent = val_47.transform;
        label_4:
        int val_18 = val_40.gameObject.transform.childCount;
        if(val_18 > 1)
        {
            goto label_21;
        }
        
        val_46 = 0;
        goto label_22;
        label_70:
        System.Collections.IEnumerator val_19 = val_18.GetEnumerator();
        label_41:
        var val_42 = 0;
        val_42 = val_42 + 1;
        if(val_19.MoveNext() == false)
        {
            goto label_30;
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        object val_23 = val_19.Current;
        val_48 = 1;
        CharacterStore_Controller val_27 = 0.gameObject.GetComponent<CharacterStore_Controller>();
        if(val_46 != (CharNameIDConverter.StageOrder(charNameID:  val_27.charNameID)))
        {
            goto label_41;
        }
        
        val_45 = val_40.gameObject.transform;
        0.transform.SetParent(p:  val_45);
        label_30:
        var val_45 = 1;
        val_51 = 0;
        if(val_19 != null)
        {
                var val_44 = 0;
            val_44 = val_44 + 1;
            val_19.Dispose();
        }
        
        if(val_45 != 1)
        {
                var val_33 = (219 == 219) ? 1 : 0;
            val_33 = ((val_45 >= 0) ? 1 : 0) & val_33;
            val_45 = val_45 - val_33;
        }
        
        val_46 = 1;
        label_22:
        val_41 = val_47.transform.childCount;
        if(val_41 > 0)
        {
            goto label_70;
        }
        
        val_47.transform.SetAsLastSibling();
        UnityEngine.Object.Destroy(obj:  val_47);
        return;
        label_83:
        val_40.GetComponent<CharacterStore_Controller>().transform.SetSiblingIndex(index:  0);
        val_54 = 38161477;
        if(((mem[1103844756844] & 2) != 0) && (mem[1103844756765] == 0))
        {
                val_54 = 38161477;
        }
        
        val_41 = mem[mem[1103844756733] + 192];
        val_41 = mem[1103844756733] + 192;
        val_41.Add(item:  val_40.GetComponent<CharacterStore_Controller>());
        val_47 = 1;
        label_13:
        if(val_47 < val_40.Count)
        {
            goto label_83;
        }
    
    }
    private void Update()
    {
    
    }
    public CharacterStore_PanelController()
    {
    
    }

}
