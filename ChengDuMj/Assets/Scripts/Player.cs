using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private byte m_byChair;                     // 玩家椅子号，0~3顺时针增加
    private byte    m_byCurTurn;                // 当前操作者      
    private COperator m_clsOperator;            // 操作码
    private CardGroup m_clsHandCard;            // 手牌
    private List<CardSentence> m_astSentence;   // 碰、杠、吃后的句子
    private ST_CARD m_stCurCard;                // 最后打出的牌
    private List<ST_CARD> m_astOutCard;         // 已经打出的牌

    public Player()
    {
        m_byChair = PubDefs.UNDEF_CHAIR;
        m_byCurTurn = PubDefs.UNDEF_CHAIR;
        m_clsOperator.Init();
        m_clsHandCard.Init();
        m_stCurCard.Set(0, 0);
        m_astSentence.Clear();
        m_astOutCard.Clear();
    }

    public void AddCard(ST_CARD stCard)
    {
        m_clsHandCard.AddCard(stCard);
    }

    public string GetHandCardName()
    {
        return m_clsHandCard.GetCardsName();
    }

    public string GetOutCardName()
    {
        string strName = "";
        for (int i = 0; i < m_astOutCard.Count; i++)
        {
            strName += m_astOutCard[i].GetName() + "|";
        }
        return strName;
    }
}
