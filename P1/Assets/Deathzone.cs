using UnityEngine;
using System.Collections;

public class Deathzone : MonoBehaviour {


    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        GameObject.Find("GameManager").GetComponent<GameManagerr>().lives -= 1;

        GameObject.Find("Veld").GetComponent<Stoten>().spawnBall = false; 
    }
}
