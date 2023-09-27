using UnityEngine;
public abstract class UnlockableGridView<ITEM_TYPE, DATA_TYPE> : MonoBehaviour
{
    // Fields
    public bool loadAtStart;
    public CharacterNameID initCid;
    public int constraintCount;
    public bool forceChildSquire;
    public UnityEngine.Vector2 spacing;
    public UnlockableGridView.OnEquipedEvent<ITEM_TYPE, DATA_TYPE> OnEquip;
    protected UnityEngine.UI.GridLayoutGroup gridView;
    protected UnityEngine.UI.ScrollRect gridScrollView;
    protected CharacterSelectScrollView scrollView;
    protected ITEM_TYPE itemTemplate;
    protected System.Collections.Generic.List<ITEM_TYPE> items;
    protected CharacterNameID currentCid;
    
    // Methods
    protected virtual void OnEnable()
    {
        UnityEngine.RectTransform val_1 = GetComponent<UnityEngine.RectTransform>();
        UnityEngine.Rect val_2 = val_1.rect;
        val_1.constraintCount = W21;
        val_1.spacing = new UnityEngine.Vector2() {x = V9.16B, y = V10.16B};
        if((public UnityEngine.RectTransform UnityEngine.Component::GetComponent<UnityEngine.RectTransform>()) != 0)
        {
                float val_10 = (float)val_1.constraintCount;
            float val_4 = val_2.m_XMin / val_10;
            val_10 = val_4 - V10.16B;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_10, y:  val_4 - val_2.m_Width);
            val_1.cellSize = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        
        if(0 == val_1)
        {
                return;
        }
        
        mem[1152921528856676192] = this;
        mem[1152921528856676200] = typeof(UnlockableGridView<ITEM_TYPE, DATA_TYPE>).__il2cppRuntimeField_1A0;
        mem[1152921528856676176] = typeof(UnlockableGridView<ITEM_TYPE, DATA_TYPE>).__il2cppRuntimeField_1A0;
        val_1.AddListener(call:  null);
        mem[1152921528856640092] = val_1.selection;
        CharacterNameID val_9 = val_1.selection;
    }
    protected virtual void OnDisable()
    {
        if(0 == static_value_0333B000)
        {
                return;
        }
        
        mem[1152921528856805600] = this;
        mem[1152921528856805608] = typeof(UnlockableGridView<ITEM_TYPE, DATA_TYPE>).__il2cppRuntimeField_1A0;
        mem[1152921528856805584] = typeof(UnlockableGridView<ITEM_TYPE, DATA_TYPE>).__il2cppRuntimeField_1A0;
        static_value_0333B018.RemoveListener(call:  null);
    }
    protected virtual void Start()
    {
        UnityEngine.UI.ScrollRect val_2 = this.transform.GetComponentInChildren<UnityEngine.UI.ScrollRect>(includeInactive:  true);
        if(0 == val_2)
        {
                return;
        }
        
        val_2.vertical = true;
    }
    protected virtual void OnSelectionChanged(CharacterNameID cid)
    {
    
    }
    public virtual void SetCommonItems()
    {
    
    }
    public void SetItems(System.Collections.Generic.List<DATA_TYPE> newItems)
    {
        var val_1;
        var val_2;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        label_6:
        if(((-1519387008) & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2.InitialType.gameObject);
        goto label_6;
        label_2:
        val_20 = 0;
        val_21 = 0;
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        val_1 = val_2;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 40 + 286) == 0)
        {
            goto label_12;
        }
        
        var val_17 = __RuntimeMethodHiddenParam + 24 + 192 + 40 + 176;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_14:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 40 + 176 + 8) + -8) == null)
        {
            goto label_13;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (__RuntimeMethodHiddenParam + 24 + 192 + 40 + 286))
        {
            goto label_14;
        }
        
        label_12:
        val_22 = 0;
        goto label_15;
        label_13:
        val_23 = ((__RuntimeMethodHiddenParam + 24 + 192 + 40) + (((__RuntimeMethodHiddenParam + 24 + 192 + 40 + 176 + 8)) << 4)) + 296;
        label_15:
        val_2.Dispose();
        if( != 0)
        {
                val_22 = 0;
        }
        
        if( != 1)
        {
                var val_6 = (61 == 61) ? 1 : 0;
            val_6 = (( >= 0) ? 1 : 0) & val_6;
            val_24 =  - val_6;
        }
        else
        {
                val_24 = 0;
        }
        
        label_23:
        if(((-1519387040) & 1) == 0)
        {
            goto label_21;
        }
        
        System.Type val_8 = val_2.InitialType;
        if(newItems != null)
        {
            goto label_23;
        }
        
        goto label_23;
        label_21:
        var val_9 = 0 + 1;
        val_25 = 0;
        mem2[0] = 132;
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 96;
        val_1 = val_2;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286) == 0)
        {
            goto label_32;
        }
        
        var val_19 = __RuntimeMethodHiddenParam + 24 + 192 + 96 + 176;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_31:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8) + -8) == null)
        {
            goto label_30;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (__RuntimeMethodHiddenParam + 24 + 192 + 96 + 286))
        {
            goto label_31;
        }
        
        goto label_32;
        label_30:
        val_26 = ((__RuntimeMethodHiddenParam + 24 + 192 + 96) + (((__RuntimeMethodHiddenParam + 24 + 192 + 96 + 176 + 8)) << 4)) + 296;
        label_32:
        val_2.Dispose();
        if(val_9 != 1)
        {
                var val_11 = ((1152921528857263648 + ((0 + 1)) << 2) == 132) ? 1 : 0;
            val_11 = ((val_9 >= 0) ? 1 : 0) & val_11;
            val_11 = val_9 - val_11;
            val_11 = val_11 + 1;
            val_27 = (long)val_11;
        }
        else
        {
                val_27 = 0;
        }
        
        label_42:
        if(((-1519387008) & 1) == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.one;
        val_2.InitialType.transform.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        goto label_42;
        label_37:
        val_28 = 0;
        val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 40;
        val_1 = val_2;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 40 + 286) == 0)
        {
            goto label_52;
        }
        
        var val_21 = __RuntimeMethodHiddenParam + 24 + 192 + 40 + 176;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_51:
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 40 + 176 + 8) + -8) == null)
        {
            goto label_50;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (__RuntimeMethodHiddenParam + 24 + 192 + 40 + 286))
        {
            goto label_51;
        }
        
        goto label_52;
        label_50:
        val_29 = ((__RuntimeMethodHiddenParam + 24 + 192 + 40) + (((__RuntimeMethodHiddenParam + 24 + 192 + 40 + 176 + 8)) << 4)) + 296;
        label_52:
        val_2.Dispose();
        if( == 0)
        {
                return;
        }
    
    }
    protected virtual ITEM_TYPE OnItemAdd(DATA_TYPE data)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  static_value_0333B000);
        val_1.transform.SetParent(p:  transform);
        if(val_1 == null)
        {
            
        }
    
    }
    public virtual void OnItemClick(DATA_TYPE data)
    {
        var val_2;
        var val_3;
        val_2 = this;
        if((data & 1) != 0)
        {
                UnityEngine.Debug.Log(message:  data + " Clicked");
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 120];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 120;
        }
    
    }
    protected virtual void ShowUnlockDesc(DATA_TYPE data)
    {
    
    }
    protected UnlockableGridView<ITEM_TYPE, DATA_TYPE>()
    {
        mem[1152921528857805980] = 999999;
        mem[1152921528857805988] = 1;
        mem[1152921528857806000] = __RuntimeMethodHiddenParam + 24 + 192 + 136;
        mem[1152921528857806040] = __RuntimeMethodHiddenParam + 24 + 192 + 152;
        mem[1152921528857806048] = 999999;
    }

}
