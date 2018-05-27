using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    private Player[] players = new Player[4];
    private List<ST_CARD> m_astCardWall;
    private int m_nBanker;


	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void StartGame()
    {

    }

    // 发牌
    void DealCard()
    {
        InitCardWall(); // 初始化原始牌墙
        for (int i = 0; i < players.Length; i++)
        {
            for (int count = 0; count < PubDefs.EVERY_CARD_NO_BEG; count++)
            {
                int index = Random.Range(0, m_astCardWall.Count);
                players[i].AddCard(m_astCardWall[index]);
                m_astCardWall.RemoveAt(index);
            }
        }

        // 随机庄家 
        m_nBanker = Random.Range(0, players.Length);
    }

    // 初始化牌墙
    void InitCardWall()
    {
        m_astCardWall.Clear();
        for (byte color = (byte)EN_MJ_TYPE.EN_MJ_TP_WAN; color <= (byte)EN_MJ_TYPE.EN_MJ_TP_HUA; color++)
        {
            for (byte i = 0; i < PubDefs.CARD_NO_PER_FLOWER; i++)
            {
                m_astCardWall.Add(new ST_CARD(i, color));
            }
        }
    }

    // 调试信息
    /// <summary>
    /// 打印牌墙
    /// </summary>
    public void PrintWall()
    {
        string strWallCards = "";
        for (int i = 0; i < m_astCardWall.Count; i++)
        {
            strWallCards += m_astCardWall[i].GetName();
        }
        PubDefs.Print(strWallCards);
    }

    public void PrintHandCard(byte byChair)
    {
        PubDefs.Print(players[byChair].GetHandCardName()); 
    }

    public void PrintOutCard(byte byChair)
    {
        PubDefs.Print(players[byChair].GetOutCardName());
    }
}
