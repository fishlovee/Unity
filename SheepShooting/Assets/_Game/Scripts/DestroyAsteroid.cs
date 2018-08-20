using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour
{
    public GameObject stoneExplosions;
    public GameObject playerExplosion;

    private GameConrol gamecontrol;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gamecontrol = gameControllerObject.GetComponent<GameConrol>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
        {
            return;
        }

        if (other.CompareTag("Bolt") && gamecontrol != null)
        {
            gamecontrol.AddScore();
        }

        //Instantiate(stoneExplosions, transform);
        Instantiate(stoneExplosions, transform.position, transform.rotation);

        if (other.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position,other.transform.rotation);
            if (gamecontrol != null)
            {
                gamecontrol.GameOver();
            }
        }
        
        //Debug.Log("Destroy:" + other.gameObject.name);
        //Debug.Log("Destroy:" + gameObject.name);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
