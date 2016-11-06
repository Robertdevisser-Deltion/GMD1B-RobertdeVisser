using UnityEngine;
using System.Collections;

public class Stoten : MonoBehaviour
{

    public float power;
    public GameObject prefab;
    public GameObject spawnLocation;
    public bool spawnBall;


    void Update()
    {
        if (spawnBall == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SpawnPinball();
                spawnBall = true;
            }
        }
    }

    void SpawnPinball()
    {
        GameObject pinball = (GameObject)(Instantiate(prefab, spawnLocation.GetComponent<Transform>().position, spawnLocation.GetComponent<Transform>().rotation));
        pinball.GetComponent<Rigidbody>().velocity = -transform.forward * power;
    }
}


