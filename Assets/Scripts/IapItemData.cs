using UnityEngine;
private class IapItemInfo.IapItemData
{
    // Fields
    public IAPItemIds id;
    public string ggpID;
    public string iosKey;
    public string androidKey;
    public ProductType type;
    public int indianGuysNumberBasedId;
    
    // Methods
    public IapItemInfo.IapItemData(IAPItemIds aNewId)
    {
        this.id = aNewId;
    }
    public IapItemInfo.IapItemData AddiOSKey(string aNewKey)
    {
        this.iosKey = aNewKey;
        return (IapItemData)this;
    }
    public IapItemInfo.IapItemData AddAndroidKey(string aNewKey)
    {
        this.androidKey = aNewKey;
        return (IapItemData)this;
    }
    public IapItemInfo.IapItemData SetGGPID(string aid)
    {
        this.ggpID = aid;
        return (IapItemData)this;
    }
    public IapItemInfo.IapItemData SetType(ProductType aNewType)
    {
        this.type = aNewType;
        return (IapItemData)this;
    }
    public IapItemInfo.IapItemData SetNumKey(int number)
    {
        this.indianGuysNumberBasedId = number;
        return (IapItemData)this;
    }
    public override string ToString()
    {
        object[] val_1 = new object[5];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(this.id != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.id == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = this.id;
        val_1[1] = this.type;
        val_1[2] = this.iosKey;
        val_1[3] = this.androidKey;
        val_1[4] = this.indianGuysNumberBasedId;
        return (string)System.String.Format(format:  "[IapItemData {0}, {1}, ios: {2}, Android: {3}, numberKey: {4}]", args:  val_1);
    }

}
