1. struct 内不能定义无参构造函数
2. 如果重载operator > ，则也必须重载 operator <。并且都同时必须是public static 的.
3. 重载的operator 不像C++一样只需要1个参数，而是需要2个参数。
4. 

```C#

public struct ST_CARD
{
    public byte byPoint;
    public byte byType;

    // struct can not contain explicit parameterless constructor
    //public ST_CARD()
    //{
    //    byPoint = 0;
    //    byType = 0;
    //}

    public ST_CARD(byte p,byte t)
    {
        byPoint = p;
        byType = t;
    }

    public bool IsValid()
    {
        return (byPoint >= 1 && byPoint <= 9 && byType >= (byte)EN_MJ_TYPE.EN_MJ_TP_WAN && byType <= (byte)EN_MJ_TYPE.EN_MJ_TP_HUA);
    }

    public bool IsWan() { return byType == (byte)EN_MJ_TYPE.EN_MJ_TP_WAN; }
    public bool IsTiao() { return byType == (byte)EN_MJ_TYPE.EN_MJ_TP_TIAO; }
    public bool IsTong() { return byType == (byte)EN_MJ_TYPE.EN_MJ_TP_TONG; }
    public bool IsHua() { return byType == (byte)EN_MJ_TYPE.EN_MJ_TP_HUA; }

    static public bool operator > (ST_CARD lhs,ST_CARD rhs)
    {
        return true;
    }

    static public bool operator < (ST_CARD lhs, ST_CARD rhs)
    {
        return true;
    }
}

```