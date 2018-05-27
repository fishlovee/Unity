using System;
using UnityEngine;

class PubDefs
{
    static public byte UNDEF_CHAIR = 4;  // 非法椅子号
    static public int CARD_NO_PER_FLOWER = 9;  //  每个花色牌的张数
    static public int EVERY_CARD_NO_BEG = 13;   // 每人初始牌张数

   static  void DebugPrint(string str)
    {
        Debug.Log(str);
    }

    static public void Print(string str)
    {
#if _DEBUG
        Debug.Log(str);
#endif
    }
}

/// <summary>
/// 麻将操作，C#的枚举位操作好鸡肋。如果是C++不用在枚举中位移赋值！！
/// </summary>
public enum EN_MJ_OPERATOR
{
    EN_MO_INVALID = 0,              // 非法操作
    EN_MO_OUT = 1 << 1,             // 出牌
    EN_MO_CHI = 1 << 2,             // 吃
    EN_MO_PENG = 1 << 3,            // 碰
    EN_MO_GANG = 1 <<4,             // 杠
    EN_MO_HU = 1 <<5                // 胡
}

/// <summary>
/// 杠牌类型
/// </summary>
enum EN_GANGT_TYPE
{
    EN_GT_INVALID = 0,  // 没有杠
    EN_GT_DIANGANG,     // 点杠
    EN_GT_MINGGANG,     // 明杠（加杠）
    EN_GT_ANGANG,       // 暗杠
}

/// <summary>
/// 句子类型
/// </summary>
public enum EN_SENTENCE_TYPE
{
    EN_ST_INVALID,
    EN_ST_CHI,
    EN_ST_PENG,
    EN_ST_GANG
}



// 麻将操作解析
class COperator
{
    private ulong m_dwOperator;
    public COperator(ulong op = 0)
    {
        m_dwOperator = op;
    }

    public void Init()
    {
        m_dwOperator = 0;
    }

    /// <summary>
    /// 是否能操作
    /// </summary>
    /// <param name="eop"></param>
    /// <returns></returns>
    private bool HasOperator(EN_MJ_OPERATOR eop)
    {
        return (m_dwOperator & (ulong)eop) != 0;
    }

    public bool HasPeng()
    {
        return HasOperator(EN_MJ_OPERATOR.EN_MO_PENG);
    }

    public bool HasChi()
    {
        return HasOperator(EN_MJ_OPERATOR.EN_MO_CHI);
    }

    public bool HasOut()
    {
        return HasOperator(EN_MJ_OPERATOR.EN_MO_OUT);
    }

    public bool HasGang()
    {
        return HasOperator(EN_MJ_OPERATOR.EN_MO_GANG);
    }

    public bool HasHu()
    {
        return HasOperator(EN_MJ_OPERATOR.EN_MO_HU);
    }
    
    public void SetFlag(EN_MJ_OPERATOR eFlag)
    {
        if (!HasOperator(eFlag))
        {
            m_dwOperator += (ulong)eFlag;
        }
    }


    ///// <summary>
    ///// 获取可以操作索引
    ///// </summary>
    ///// <param name="eop"></param>
    ///// <returns></returns>
    //public int GetOpIndex(EN_MJ_OPERATOR eop)
    //{
    //    if (HasOperator(eop))
    //    {
    //        return (int)Math.Log((ulong)eop,2);
    //    }

    //    return -1;
    //}
}