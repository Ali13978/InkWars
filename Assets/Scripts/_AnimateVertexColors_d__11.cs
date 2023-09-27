using UnityEngine;
private sealed class VertexJitter.<AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.VertexJitter <>4__this;
    private TMPro.TMP_TextInfo <textInfo>5__2;
    private int <loopCount>5__3;
    private TMPro.Examples.VertexJitter.VertexAnim[] <vertexAnim>5__4;
    private TMPro.TMP_MeshInfo[] <cachedMeshInfo>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VertexJitter.<AnimateVertexColors>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TMPro.TMP_TextInfo val_38;
        VertexJitter.<AnimateVertexColors>d__11 val_39;
        VertexAnim[] val_40;
        var val_41;
        var val_42;
        float val_43;
        float val_44;
        VertexAnim val_46;
        int val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        object val_53;
        int val_54;
        var val_55;
        val_39 = this;
        if(((this.<>1__state) == 2) || ((this.<>1__state) == 1))
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        this.<textInfo>5__2 = this.<>4__this.m_TextComponent.textInfo;
        this.<loopCount>5__3 = 0;
        this.<>4__this.hasTextChanged = true;
        val_40 = new VertexAnim[1024];
        val_41 = 0;
        val_42 = 0;
        val_43 = 10f;
        val_44 = 1f;
        this.<vertexAnim>5__4 = val_40;
        goto label_7;
        label_12:
        val_40 = this.<vertexAnim>5__4;
        val_42 = 1;
        val_41 = 12;
        label_7:
        val_40[val_41] = UnityEngine.Random.Range(min:  val_43, max:  25f);
        val_46 = UnityEngine.Random.Range(min:  val_44, max:  3f);
        this.<vertexAnim>5__4[val_41] = val_46;
        if(val_42 != 1023)
        {
            goto label_12;
        }
        
        this.<cachedMeshInfo>5__5 = this.<textInfo>5__2.CopyMeshInfoVertexData();
        if((this.<>4__this) != null)
        {
            goto label_16;
        }
        
        goto label_15;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_16;
        }
        
        label_15:
        label_16:
        if((this.<>4__this.hasTextChanged) != false)
        {
                this.<cachedMeshInfo>5__5 = this.<textInfo>5__2.CopyMeshInfoVertexData();
            this.<>4__this.hasTextChanged = false;
        }
        
        val_38 = this.<textInfo>5__2;
        val_47 = this.<textInfo>5__2.characterCount;
        if(val_47 == 0)
        {
            goto label_20;
        }
        
        if(val_47 >= 1)
        {
                val_48 = 0;
            val_49 = 0;
            val_50 = 368;
            do
        {
            if((this.<textInfo>5__2.characterInfo[1]) != 0)
        {
                VertexAnim val_45 = this.<vertexAnim>5__4[val_48];
            VertexAnim val_46 = this.<vertexAnim>5__4[val_48];
            this.<textInfo>5__2.characterInfo[368] = (this.<textInfo>5__2.characterInfo[368]) - 280;
            this.<textInfo>5__2.characterInfo[368] = (this.<textInfo>5__2.characterInfo[368]) - 260;
            TMPro.TMP_CharacterInfo[] val_7 = (this.<cachedMeshInfo>5__5) + (1152921508488074800 * 72);
            val_51 = mem[mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 24];
            val_51 = mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 24;
            if(null >= val_51)
        {
                val_51 = mem[mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 24];
            val_51 = mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 24;
        }
        
            TMPro.TMP_CharacterInfo[] val_8 = (mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48]) + (1152921508488074800 * 12);
            var val_47 = 12;
            val_47 = (mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48]) + ((long)(long)(int)(W9) * val_47);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[(1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32], y = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 4, z = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32, y = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 4, z = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 8});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  2f);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            TMPro.TMP_CharacterInfo[] val_13 = (this.<textInfo>5__2.meshInfo) + (1152921508488074800 * 72);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32, y = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 4, z = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            val_49 = val_49;
            TMPro.TMP_CharacterInfo[] val_15 = (mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48]) + (1152921508488074800 * 12);
            mem2[0] = val_14.x;
            mem2[0] = val_14.y;
            mem2[0] = val_14.z;
            var val_48 = (long)(long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8);
            val_48 = (mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48]) + (val_48 * 12);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32, y = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 4, z = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            var val_17 = (mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48]) + (val_48 * 12);
            mem2[0] = val_16.x;
            mem2[0] = val_16.y;
            mem2[0] = val_16.z;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32, y = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 4, z = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            var val_19 = (mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48]) + ((long)(long)(int)(W9) * 12);
            mem2[0] = val_18.x;
            mem2[0] = val_18.y;
            mem2[0] = val_18.z;
            var val_49 = (long)(long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8);
            val_49 = (mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48]) + (val_49 * 12);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32, y = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 32 + 4, z = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<cachedMeshInfo>5__5 + 48] + 40}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            var val_21 = (mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48]) + (val_49 * 12);
            mem2[0] = val_20.x;
            mem2[0] = val_20.y;
            mem2[0] = val_20.z;
            float val_50 = 0f;
            val_50 = val_50 / 25f;
            val_50 = val_46 * val_50;
            float val_24 = UnityEngine.Random.Range(min:  -0.25f, max:  0.25f);
            float val_25 = UnityEngine.Random.Range(min:  -0.25f, max:  0.25f);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  this.<>4__this + 32);
            UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  (UnityEngine.Random.Range(min:  -5f, max:  5f)) * (this.<>4__this + 24));
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_31 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, q:  new UnityEngine.Quaternion() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w}, s:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.z});
            val_46 = val_45;
            mem2[0] = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32;
            mem2[0] = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4;
            mem2[0] = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8;
            mem2[0] = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32;
            mem2[0] = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4;
            mem2[0] = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8;
            mem2[0] = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32;
            mem2[0] = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4;
            mem2[0] = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8;
            val_44 = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8;
            mem2[0] = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32;
            mem2[0] = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4;
            mem2[0] = val_44;
            val_43 = val_12.y;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32, y = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4, z = (1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_43, z = val_12.z});
            mem2[0] = val_36.x;
            mem2[0] = val_36.y;
            mem2[0] = val_36.z;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32, y = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4, z = ((long)(int)((1152921508488074800 * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_43, z = val_12.z});
            mem2[0] = val_37.x;
            mem2[0] = val_37.y;
            mem2[0] = val_37.z;
            val_47 = val_47;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32, y = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4, z = ((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_43, z = val_12.z});
            mem2[0] = val_38.x;
            mem2[0] = val_38.y;
            mem2[0] = val_38.z;
            val_48 = val_48;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32, y = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 4, z = ((long)(int)(((long)(int)(W9) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8) * 12) + mem[(1152921508488074800 * 72) + this.<textInfo>5__2.meshInfo + 48] + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_43, z = val_12.z});
            mem2[0] = val_39.x;
            mem2[0] = val_39.y;
            mem2[0] = val_39.z;
            val_39 = val_39;
            val_50 = 368;
            mem2[0] = val_46;
            mem2[0] = UnityEngine.Mathf.SmoothStep(from:  -val_45, to:  val_45, t:  UnityEngine.Mathf.PingPong(t:  val_50, length:  1f));
            mem2[0] = val_46;
        }
        
            val_49 = val_49 + 1;
            val_42 = val_48 + 12;
            val_50 = val_50 + 344;
        }
        while(val_47 != val_49);
        
        }
        
        val_52 = 0;
        goto label_78;
        label_93:
        var val_40 = val_1.meshInfo + (0 * 72);
        64.vertices = (0 * 72) + val_1.meshInfo + 48;
        val_42 = mem[this.<>4__this + 40];
        val_42 = this.<>4__this + 40;
        var val_41 = val_1.meshInfo + (0 * 72);
        val_52 = 1;
        label_78:
        val_38 = mem[val_1 + 96];
        val_38 = val_1.meshInfo;
        if(val_52 < val_1.meshInfo.Length)
        {
            goto label_93;
        }
        
        mem[1152921529178740096] = 1;
        UnityEngine.WaitForSeconds val_42 = null;
        val_53 = val_42;
        val_42 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        val_54 = 2;
        goto label_94;
        label_20:
        UnityEngine.WaitForSeconds val_43 = null;
        val_53 = val_43;
        val_43 = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        val_54 = 1;
        label_94:
        val_55 = 1;
        this.<>2__current = val_53;
        this.<>1__state = val_54;
        return (bool)val_55;
        label_3:
        val_55 = 0;
        return (bool)val_55;
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
