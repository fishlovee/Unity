using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameConrol : MonoBehaviour
{
    public GameObject []enemys = new GameObject[3];
    public long[] lEnemyWeight = new long[3];
    public float fGenerateRate = 5.0f;
    public float startWait = 1.5f;
    public int minCount = 3;
    public int maxCount = 10;

    public Button restartButton;
    public Text scoreText;

    private bool gameover;
    private long score;
    private float fAbstractPosition;
    public void AddScore()
    {
        score++;
        scoreText.text = "Score:" + score;
    }

    private void Start()
    {
        score = 0;
        scoreText.text = "Score:0";
        gameover = false;
        fAbstractPosition = 6.0f;
        restartButton.gameObject.SetActive(false);
        StartCoroutine(GenerateStone());
        //restartButton.onClick.AddListener(delegate { RestartGame(); });
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GameOver()
    {
        gameover = true;
        restartButton.gameObject.SetActive(true);
        //Instantiate(restartButton, restartButton.transform.position, restartButton.transform.rotation);
    }

    private void Update()
    {
        if (gameover)
        {
        }
    }

    IEnumerator GenerateStone()
    {
        yield return new WaitForSeconds(startWait);
        while (!gameover)
        {
            int nCount = (int)Random.Range(minCount, maxCount);
            for (int i = 0; i < nCount; i++)
            {
                //RandowmStone();
                int nIndex = (int)Random.Range(0, 2);
                //Debug.Log("z=" + transform.position.z);
                Vector3 pos = new Vector3(Random.Range(-fAbstractPosition, fAbstractPosition), transform.position.y,transform.position.z);
                Quaternion rotation = Quaternion.identity;
                Instantiate(enemys[nIndex], pos, rotation);
            }
            yield return new WaitForSeconds(fGenerateRate);
        }
    }

    void RandowmStone()
    {
        int nIndex = (int)Random.Range(0, 2);
        float fXPosition = Random.Range(-fAbstractPosition, fAbstractPosition);
        Vector3 pos = new Vector3(fXPosition, transform.position.y, transform.position.z);
        GameObject go= Instantiate(enemys[nIndex], transform);
        go.transform.position = pos;
    }
}
