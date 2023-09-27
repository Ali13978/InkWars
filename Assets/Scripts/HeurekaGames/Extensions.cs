using UnityEngine;

namespace HeurekaGames
{
    public static class Extensions
    {
        // Methods
        public static UnityEngine.Vector2 YZ(UnityEngine.Vector3 v)
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  v.x, y:  v.z);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public static UnityEngine.Vector2[] YZ(UnityEngine.Vector3[] v)
        {
            int val_3;
            UnityEngine.Vector2[] val_1 = new UnityEngine.Vector2[0];
            val_3 = v.Length;
            if(val_3 < 1)
            {
                    return val_1;
            }
            
            do
            {
                if(0 >= val_3)
            {
                    val_3 = v.Length;
            }
            
                var val_2 = v + (0 * 12);
                var val_3 = v + (0 * 12);
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  (0 * 12) + v + 32, y:  (0 * 12) + v + 40);
                val_1[0] = val_4.x;
                val_1[0] = val_4.y;
            }
            while((0 + 1) < v.Length);
            
            return val_1;
        }
        public static float Remap(float value, float from1, float to1, float from2, float to2)
        {
            value = value - from1;
            from1 = to1 - from1;
            value = value / from1;
            value = value * (to2 - from2);
            value = value + from2;
            return (float)value;
        }
        public static string ToCamelCase(string camelCaseString)
        {
            string val_1 = System.Text.RegularExpressions.Regex.Replace(input:  camelCaseString, pattern:  "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", replacement:  "$1 ");
            if(val_1 != null)
            {
                    return val_1.Trim();
            }
            
            return val_1.Trim();
        }
        public static void SetComponentRecursively<T>(UnityEngine.GameObject gameObject, bool tf)
        {
            bool val_6;
            var val_7;
            val_6 = tf;
            bool val_1 = val_6;
            val_7 = 0;
            goto label_13;
            label_27:
            System.Reflection.PropertyInfo val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48 + 8}).GetProperty(name:  "enabled");
            if(((System.Reflection.PropertyInfo.op_Inequality(left:  0, right:  val_3)) != false) && ((val_3 & 1) != 0))
            {
                
            }
            else
            {
                    System.Console.WriteLine(value:  "BLABLA");
            }
            
            val_7 = 1;
            label_13:
            if(val_7 < (__RuntimeMethodHiddenParam + 48))
            {
                goto label_27;
            }
        
        }
        public static void CastList<T>(System.Collections.Generic.List<T> targetList)
        {
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        public static bool Has<T>(System.Enum type, T value)
        {
            return (bool)((1152921504628039680 & mem[type]) == null) ? 1 : 0;
        }
        public static bool Is<T>(System.Enum type, T value)
        {
            return (bool)(mem[type] == null) ? 1 : 0;
        }
        public static T Add<T>(System.Enum type, T value)
        {
            var val_3;
            object val_1 = 1152921504628039680 | mem[type];
            if(val_1 != 0)
            {
                    val_3 = val_1;
                if(val_1 != 0)
            {
                    return (object)val_3;
            }
            
            }
            
            val_3 = 0;
            return (object)val_3;
        }
        public static T Remove<T>(System.Enum type, T value)
        {
            var val_3;
            object val_1 = mem[type] & (~1152921504628039680);
            if(val_1 != 0)
            {
                    val_3 = val_1;
                if(val_1 != 0)
            {
                    return (object)val_3;
            }
            
            }
            
            val_3 = 0;
            return (object)val_3;
        }
        public static UnityEngine.Color ModifiedAlpha(UnityEngine.Color color, float alpha)
        {
            return new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = alpha};
        }
    
    }

}
