using UnityEngine;
private sealed class InstanceAnimator.<instantiateObjects>d__74 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public InstanceAnimator <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InstanceAnimator.<instantiateObjects>d__74(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_34;
        var val_36;
        var val_46;
        var val_55;
        var val_57;
        var val_67;
        var val_74;
        InstanceAnimator val_142;
        int val_143;
        var val_144;
        UnityEngine.GameObject val_145;
        var val_146;
        string val_147;
        var val_148;
        var val_149;
        var val_150;
        var val_151;
        UnityEngine.Sprite val_154;
        UnityEngine.Sprite val_155;
        UnityEngine.Sprite val_156;
        UnityEngine.Sprite val_157;
        UnityEngine.Sprite val_158;
        UnityEngine.Sprite val_159;
        var val_160;
        var val_165;
        var val_167;
        var val_168;
        UnityEngine.Sprite val_169;
        var val_171;
        UnityEngine.Sprite val_174;
        UnityEngine.Sprite val_175;
        UnityEngine.Sprite val_181;
        UnityEngine.Sprite val_182;
        val_142 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_143 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_143;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_142 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  0.04f);
        val_143 = 1;
        this.<>2__current = val_142;
        this.<>1__state = val_143;
        return (bool)val_143;
        label_1:
        this.<>1__state = 0;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        val_144 = null;
        if(InstanceAnimator.IsTutorialLevel == false)
        {
            goto label_8;
        }
        
        this.<>4__this.cpuBridge = UnityEngine.GameObject.FindWithTag(tag:  "CpuBridge");
        val_145 = UnityEngine.GameObject.FindWithTag(tag:  "PlayerBridge");
        if(val_142 == null)
        {
            goto label_10;
        }
        
        this.<>4__this.playerBridge = val_145;
        goto label_11;
        label_8:
        val_146 = null;
        val_146 = null;
        if(InstanceAnimator.UniversalX == 4.46f)
        {
                val_147 = "Colliders";
        }
        else
        {
                val_147 = "Colliders1";
        }
        
        val_148 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  val_147));
        if(val_148 != null)
        {
                UnityEngine.GameObject val_7 = (null == null) ? (val_148) : 0;
        }
        
        this.<>4__this.colliders = val_7;
        if(val_142 == null)
        {
            goto label_20;
        }
        
        label_130:
        val_7.gameObject.transform.SetParent(p:  this.<>4__this.colliderHolder.transform);
        val_145 = 1152921526078016624;
        UnityEngine.Vector3 val_13 = this.<>4__this.colliderHolder.gameObject.GetComponent<UnityEngine.Transform>().localScale;
        UnityEngine.Vector3 val_16 = this.<>4__this.colliderHolder.gameObject.GetComponent<UnityEngine.Transform>().localScale;
        UnityEngine.Vector3 val_19 = this.<>4__this.colliderHolder.gameObject.GetComponent<UnityEngine.Transform>().localScale;
        val_149 = null;
        val_149 = null;
        float val_151 = (float)InstanceAnimator.playerNegateX;
        val_151 = 0f * val_151;
        this.<>4__this.colliderHolder.gameObject.GetComponent<UnityEngine.Transform>().localScale = new UnityEngine.Vector3() {x = val_151, y = 0f, z = 0f};
        val_150 = 1152921505064992768;
        val_151 = null;
        val_151 = null;
        if(Character_GlobalInfo.gameMode != 5)
        {
            goto label_181;
        }
        
        System.Collections.IEnumerator val_23 = this.<>4__this.colliders.transform.GetEnumerator();
        label_128:
        var val_152 = 0;
        val_152 = val_152 + 1;
        if(val_23.MoveNext() == false)
        {
            goto label_49;
        }
        
        var val_153 = 0;
        val_153 = val_153 + 1;
        object val_27 = val_23.Current;
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "BattleGrid_Player")) == false)
        {
            goto label_92;
        }
        
        CharacterInfo val_33 = Character_GlobalInfo.GetMainPlayer();
        if(val_34 == 0)
        {
            goto label_62;
        }
        
        CharacterInfo val_35 = Character_GlobalInfo.GetMainPlayer();
        if(val_36 != 1)
        {
            goto label_65;
        }
        
        System.Type val_154 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_40 = UnityEngine.Resources.Load(path:  "BattleGrid_Tako", systemTypeInstance:  val_154);
        if(val_40 == null)
        {
            goto label_71;
        }
        
        val_154 = (null == null) ? (val_40) : 0;
        goto label_72;
        label_62:
        System.Type val_155 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_44 = UnityEngine.Resources.Load(path:  "BattleGrid_Ika", systemTypeInstance:  val_155);
        if(val_44 == null)
        {
            goto label_78;
        }
        
        val_155 = (null == null) ? (val_44) : 0;
        goto label_79;
        label_65:
        CharacterInfo val_45 = Character_GlobalInfo.GetMainPlayer();
        if(val_46 != 2)
        {
            goto label_92;
        }
        
        System.Type val_156 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_50 = UnityEngine.Resources.Load(path:  "BattleGrid_Ufa", systemTypeInstance:  val_156);
        if(val_50 == null)
        {
            goto label_88;
        }
        
        val_156 = (null == null) ? (val_50) : 0;
        goto label_89;
        label_78:
        val_155 = 0;
        label_79:
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_155;
        goto label_92;
        label_71:
        val_154 = 0;
        label_72:
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_154;
        goto label_92;
        label_88:
        val_156 = 0;
        label_89:
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_156;
        label_92:
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "BattleGrid_Cpu")) == false)
        {
            goto label_128;
        }
        
        CharacterInfo val_54 = Character_GlobalInfo.GetOpponentPlayer();
        if(val_55 == 0)
        {
            goto label_98;
        }
        
        CharacterInfo val_56 = Character_GlobalInfo.GetOpponentPlayer();
        if(val_57 != 1)
        {
            goto label_101;
        }
        
        System.Type val_157 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_61 = UnityEngine.Resources.Load(path:  "BattleGrid_Tako", systemTypeInstance:  val_157);
        if(val_61 == null)
        {
            goto label_107;
        }
        
        val_157 = (null == null) ? (val_61) : 0;
        goto label_108;
        label_98:
        System.Type val_158 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_65 = UnityEngine.Resources.Load(path:  "BattleGrid_Ika", systemTypeInstance:  val_158);
        if(val_65 == null)
        {
            goto label_114;
        }
        
        val_158 = (null == null) ? (val_65) : 0;
        goto label_115;
        label_101:
        CharacterInfo val_66 = Character_GlobalInfo.GetOpponentPlayer();
        if(val_67 != 2)
        {
            goto label_128;
        }
        
        System.Type val_159 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_71 = UnityEngine.Resources.Load(path:  "BattleGrid_Ufa", systemTypeInstance:  val_159);
        if(val_71 == null)
        {
            goto label_124;
        }
        
        val_159 = (null == null) ? (val_71) : 0;
        goto label_125;
        label_114:
        val_158 = 0;
        label_115:
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_158;
        goto label_128;
        label_107:
        val_157 = 0;
        label_108:
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_157;
        goto label_128;
        label_124:
        val_159 = 0;
        label_125:
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_159;
        goto label_128;
        label_20:
        if((this.<>4__this.colliders) != null)
        {
            goto label_130;
        }
        
        goto label_130;
        label_10:
        mem[280] = val_145;
        label_11:
        val_142.StopCoroutine(methodName:  "instantiateObjects");
        this.<>2__current = 0;
        this.<>1__state = 2;
        val_143 = 1;
        return (bool)val_143;
        label_49:
        val_160 = 0;
        val_145 = 0;
        if(val_23 != null)
        {
                var val_160 = 0;
            val_160 = val_160 + 1;
            val_23.Dispose();
        }
        
        if( == 1)
        {
            goto label_181;
        }
        
        if(1544 != 1544)
        {
            goto label_182;
        }
        
        goto label_410;
        label_181:
        val_160 = 0;
        label_182:
        CharacterInfo val_73 = Character_GlobalInfo.GetMainPlayer();
        if(val_74 == 0)
        {
            goto label_186;
        }
        
        label_402:
        val_165 = null;
        val_165 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_410;
        }
        
        this.<>4__this.whirlpoolsPlayerInactive.SetActive(value:  false);
        System.Collections.IEnumerator val_76 = this.<>4__this.colliders.transform.GetEnumerator();
        val_150 = 1152921504687943680;
        goto label_219;
        label_226:
        var val_161 = 0;
        val_161 = val_161 + 1;
        object val_78 = val_76.Current;
        val_167 = 1;
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "PuzzleHomebasePlayer")) != false)
        {
                0.gameObject.SetActive(value:  true);
            System.Type val_162 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_168 = UnityEngine.Resources.Load(path:  "BattleGrid_Homebase_Tako", systemTypeInstance:  val_162);
            if(val_168 != null)
        {
                val_162 = (null == null) ? (val_168) : 0;
        }
        else
        {
                val_169 = 0;
        }
        
            0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_169;
        }
        
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "BattleGrid_Player")) != false)
        {
                0.gameObject.SetActive(value:  false);
        }
        
        label_219:
        var val_163 = 0;
        val_163 = val_163 + 1;
        if(val_76.MoveNext() == true)
        {
            goto label_226;
        }
        
        val_145 = 0;
        var val_95 = val_160 + 1;
        mem2[0] = 1544;
        goto label_227;
        label_186:
        val_171 = null;
        val_171 = null;
        if(Character_GlobalInfo.gameMode != 3)
        {
            goto label_326;
        }
        
        this.<>4__this.whirlpoolsPlayerInactive.SetActive(value:  false);
        System.Collections.IEnumerator val_97 = this.<>4__this.colliders.transform.GetEnumerator();
        val_167 = 1152921504687943680;
        val_168 = "PuzzleHomebasePlayer";
        label_276:
        var val_164 = 0;
        val_164 = val_164 + 1;
        if(val_97.MoveNext() == false)
        {
            goto label_240;
        }
        
        var val_165 = 0;
        val_165 = val_165 + 1;
        object val_101 = val_97.Current;
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "PuzzleHomebasePlayer")) != false)
        {
                0.gameObject.SetActive(value:  true);
            System.Type val_166 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_111 = UnityEngine.Resources.Load(path:  "BattleGrid_Homebase_Ika", systemTypeInstance:  val_166);
            if(val_111 != null)
        {
                val_166 = (null == null) ? (val_111) : 0;
        }
        else
        {
                val_174 = 0;
        }
        
            0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_174;
        }
        
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "BattleGrid_Player")) != false)
        {
                0.gameObject.SetActive(value:  false);
        }
        
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "BattleGrid_Cpu")) == false)
        {
            goto label_276;
        }
        
        System.Type val_167 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_122 = UnityEngine.Resources.Load(path:  "BattleGrid_Tako", systemTypeInstance:  val_167);
        if(val_122 != null)
        {
                val_167 = (null == null) ? (val_122) : 0;
        }
        else
        {
                val_175 = 0;
        }
        
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_175;
        goto label_276;
        label_240:
        val_145 = 0;
        val_160 = 0 + 1;
        mem2[0] = 1544;
        if(val_97 != null)
        {
                var val_168 = 0;
            val_168 = val_168 + 1;
            val_97.Dispose();
        }
        
        if(val_160 == 1)
        {
            goto label_325;
        }
        
        if((1152921526237965088 + ((0 + 1)) << 2) != 1544)
        {
            goto label_326;
        }
        
        goto label_410;
        label_325:
        val_160 = 0;
        label_326:
        System.Collections.IEnumerator val_125 = this.<>4__this.colliders.transform.GetEnumerator();
        val_167 = 1152921504687943680;
        label_365:
        var val_169 = 0;
        val_169 = val_169 + 1;
        if(val_125.MoveNext() == false)
        {
            goto label_336;
        }
        
        var val_170 = 0;
        val_170 = val_170 + 1;
        object val_129 = val_125.Current;
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "BattleGrid_Player")) != false)
        {
                System.Type val_171 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_138 = UnityEngine.Resources.Load(path:  "BattleGrid_Ika", systemTypeInstance:  val_171);
            if(val_138 != null)
        {
                val_171 = (null == null) ? (val_138) : 0;
        }
        else
        {
                val_181 = 0;
        }
        
            0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_181;
        }
        
        if((System.String.op_Equality(a:  0.gameObject.name, b:  "BattleGrid_Cpu")) == false)
        {
            goto label_365;
        }
        
        System.Type val_172 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_145 = UnityEngine.Resources.Load(path:  "BattleGrid_Tako", systemTypeInstance:  val_172);
        if(val_145 != null)
        {
                val_172 = (null == null) ? (val_145) : 0;
        }
        else
        {
                val_182 = 0;
        }
        
        0.gameObject.GetComponent<UnityEngine.SpriteRenderer>().sprite = val_182;
        goto label_365;
        label_336:
        val_145 = 0;
        mem2[0] = 1544;
        if(val_125 != null)
        {
                var val_173 = 0;
            val_173 = val_173 + 1;
            val_125.Dispose();
        }
        
        if(((0 + 1) == 1) || ((1152921526237965088 + ((0 + 1)) << 2) != 1544))
        {
            goto label_402;
        }
        
        goto label_410;
        label_227:
        if(val_97 != null)
        {
                var val_174 = 0;
            val_174 = val_174 + 1;
            val_97.Dispose();
        }
        
        label_410:
        this.<>4__this.cpuBridge = UnityEngine.GameObject.FindWithTag(tag:  "CpuBridge");
        val_143 = 0;
        this.<>4__this.playerBridge = UnityEngine.GameObject.FindWithTag(tag:  "PlayerBridge");
        return (bool)val_143;
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
