/// <summary>
/// 麻将花色
/// </summary>
enum EN_MJ_TYPE
{
    EN_MJ_TP_INVALID = 0,       // 非法
    EN_MJ_TP_WAN,                   // 万
    EN_MJ_TP_TIAO,                  // 条
    EN_MJ_TP_TONG,                  // 筒
    EN_MJ_TP_HUA,                   // 其他牌 东南西北中发白
}




public struct ST_CARD
{
    static private int nWeight = 100;
    public byte byPoint;
    public byte byType;

    // struct can not contain explicit parameterless constructor
    //public ST_CARD()
    //{
    //    byPoint = 0;
    //    byType = 0;
    //}

    public ST_CARD(byte p, byte t)
    {
        byPoint = p;
        byType = t;
    }

    public void Set(byte p, byte t)
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

    public int GetValue()
    {
        if (!IsValid())
        {
            return 0;
        }
        return nWeight*byType + byPoint;
    }


    static public bool operator > (ST_CARD lhs,ST_CARD rhs)
    {
        return lhs.GetValue() > rhs.GetValue();
    }

    static public bool operator < (ST_CARD lhs, ST_CARD rhs)
    {
        return lhs.GetValue() < rhs.GetValue();
    }


    static public bool operator == (ST_CARD lhs, ST_CARD rhs)
    {
        return lhs.GetValue() == rhs.GetValue();
    }

    static public bool operator != (ST_CARD lhs, ST_CARD rhs)
    {
        return lhs.GetValue() != rhs.GetValue();
    }

}

/// <summary>
/// 句子：吃、碰、杠
/// </summary>
public class CardSentence
{
    public ST_CARD[] m_astCard = new ST_CARD[4];
    public int m_nCount;
    public EN_SENTENCE_TYPE m_eType;
    public CardSentence()
    {
        m_nCount = 0;
        m_eType = EN_SENTENCE_TYPE.EN_ST_INVALID;
    }

    public bool AddCard(ST_CARD stCard)
    {
        if (m_nCount >= 4)
        {
            return false;
        }

        m_astCard[m_nCount++] = stCard;
        return true;
    }

    public bool AddSentence(ST_CARD[] astCard,int nCount, EN_SENTENCE_TYPE e)
    {
        if (astCard == null || nCount <= 0 || nCount > astCard.Length || e == EN_SENTENCE_TYPE.EN_ST_INVALID)
        {
            return false;
        }

        for (int i = 0; i < nCount; i++)
        {
            m_astCard[i] = astCard[i];
        }
        m_eType = e;
        m_nCount = nCount;
        return true;
    }
}

public class CardGroup {
    static public byte byOneHandMax = 14;                                   // 一手牌最大张数
    private ST_CARD[] astCards = new ST_CARD[byOneHandMax];                 // 手牌
    private byte byCardNum;                                                 // 手牌张数

    public CardGroup()
    {
        Init();
    }

    public void Init()
    {
        byCardNum = 0;
    }

    public bool AddCard(ST_CARD stCard)
    {
        if (byCardNum >= byOneHandMax)
            return false;

        // 插入
        if (byCardNum == 0)
        {
            astCards[byCardNum] = stCard;
        }
        else
        {
            int nPos = byOneHandMax;
            for (; nPos >= 0; nPos--)
            {
                if (astCards[nPos - 1] < stCard)
                {
                    break;
                }
            }

            for (int i = byCardNum; i > nPos + 1; i--)
            {
                astCards[i] = astCards[i - 1];
            }
            astCards[nPos + 1] = stCard;
        }
        byCardNum++;
        return true;
    }

    public bool DelCard(ST_CARD stCard)
    {
        for (int i = 0; i < byCardNum; i++)
        {
            if (stCard == astCards[i])
            {
                for (int k = i; k < byCardNum - 1; k++)
                {
                    astCards[k] = astCards[k + 1];
                }

                byCardNum--;
                return true;
            }
        }
        return false;
    }
}

