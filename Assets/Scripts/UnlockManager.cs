using UnityEngine;
public static class UnlockManager
{
    // Methods
    public static void UnlockEveryThing()
    {
        UnlockManager.UnlockAllIAPItems();
        UnlockManager.UnlockAllCharacters();
        UnlockManager.UnlockAllMusic();
        UnlockManager.UnlockAllStages();
        AvatarTitleUnlockChecker.UnlockAll();
    }
    public static void LockEverything()
    {
        UnlockManager.LockAllIAPItems();
        UnlockManager.LockAllMusic();
        UnlockManager.LockAllStages();
        AvatarTitleUnlockChecker.LockAll();
    }
    public static void UnlockAllProfileAvatars()
    {
        AvatarTitleUnlockChecker.UnlockAll();
    }
    public static void LockAllProfileAvatars()
    {
        AvatarTitleUnlockChecker.LockAll();
    }
    public static void UnlockAllMusic()
    {
        var val_15;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_15 = 1152921505100083200;
        label_20:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        object val_7 = val_3.Current;
        val_18 = null;
        val_18 = null;
        DataStructs.UserDataDictionary.Items.SetMusicUnlock(id:  21192704, unlock:  true);
        goto label_20;
        label_11:
        val_19 = 0;
        val_20 = 1152921504621170688;
        val_21 = val_3;
        if(val_21 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_21.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_21 = ???;
        val_20 = ???;
        val_15 = ???;
    }
    public static void LockAllMusic()
    {
        var val_15;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_15 = 1152921505100083200;
        label_20:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        object val_7 = val_3.Current;
        val_18 = null;
        val_18 = null;
        DataStructs.UserDataDictionary.Items.SetMusicUnlock(id:  21192704, unlock:  false);
        goto label_20;
        label_11:
        val_19 = 0;
        val_20 = 1152921504621170688;
        val_21 = val_3;
        if(val_21 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_21.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_21 = ???;
        val_20 = ???;
        val_15 = ???;
    }
    public static void UnlockAllCharacters()
    {
        var val_16;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_16 = 1152921505065684992;
        label_21:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        object val_7 = val_3.Current;
        if(null == 999999)
        {
            goto label_21;
        }
        
        val_19 = null;
        val_19 = null;
        DataStructs.UserDataDictionary.Items.SetCharacterUnlock(id:  1152921504628039680, unlocked:  true, displayAvatarUnlockPopup:  false);
        goto label_21;
        label_11:
        val_20 = 0;
        val_21 = 1152921504621170688;
        val_22 = val_3;
        if(val_22 != null)
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_22.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_22 = ???;
        val_21 = ???;
        val_16 = ???;
    }
    public static void LockAllCharacters()
    {
        var val_16;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_16 = 1152921505065684992;
        label_21:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        object val_7 = val_3.Current;
        if(null == 999999)
        {
            goto label_21;
        }
        
        val_19 = null;
        val_19 = null;
        DataStructs.UserDataDictionary.Items.SetCharacterUnlock(id:  1152921504628039680, unlocked:  false, displayAvatarUnlockPopup:  true);
        goto label_21;
        label_11:
        val_20 = 0;
        val_21 = 1152921504621170688;
        val_22 = val_3;
        if(val_22 != null)
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_22.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_22 = ???;
        val_21 = ???;
        val_16 = ???;
    }
    public static void UnlockAllStages()
    {
        var val_15;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_15 = 1152921505100668928;
        label_20:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        object val_7 = val_3.Current;
        val_18 = null;
        val_18 = null;
        DataStructs.UserDataDictionary.Items.SetStageUnlock(id:  21192704, unlock:  true);
        goto label_20;
        label_11:
        val_19 = 0;
        val_20 = 1152921504621170688;
        val_21 = val_3;
        if(val_21 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_21.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_21 = ???;
        val_20 = ???;
        val_15 = ???;
    }
    public static void LockAllStages()
    {
        var val_15;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        val_15 = 1152921505100668928;
        label_20:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        object val_7 = val_3.Current;
        val_18 = null;
        val_18 = null;
        DataStructs.UserDataDictionary.Items.SetStageUnlock(id:  21192704, unlock:  false);
        goto label_20;
        label_11:
        val_19 = 0;
        val_20 = 1152921504621170688;
        val_21 = val_3;
        if(val_21 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_21.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_21 = ???;
        val_20 = ???;
        val_15 = ???;
    }
    public static void UnlockAllIAPItems()
    {
        var val_17;
        var val_18;
        var val_19;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_20:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        object val_7 = val_3.Current;
        if((IapItemInfo.GetItemType(id:  1152921504628039680)) == 1)
        {
            goto label_20;
        }
        
        UnityIAPHandler.OnPurchaseComplete(id:  1152921504628039680, isRestoreMode:  true, onDone:  0);
        goto label_20;
        label_11:
        val_17 = 0;
        val_18 = 1152921504621170688;
        val_19 = val_3;
        if(val_19 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_19.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_19 = ???;
        val_18 = ???;
    }
    public static void LockAllIAPItems()
    {
        var val_17;
        var val_18;
        var val_19;
        System.Collections.IEnumerator val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).GetEnumerator();
        label_20:
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        object val_7 = val_3.Current;
        if((IapItemInfo.GetItemType(id:  1152921504628039680)) == 1)
        {
            goto label_20;
        }
        
        UnityIAPHandler.OnPurchaseComplete(id:  1152921504628039680, isRestoreMode:  false, onDone:  0);
        goto label_20;
        label_11:
        val_17 = 0;
        val_18 = 1152921504621170688;
        val_19 = val_3;
        if(val_19 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_19.Dispose();
        }
        
        if( == false)
        {
                return;
        }
        
        val_19 = ???;
        val_18 = ???;
    }

}
