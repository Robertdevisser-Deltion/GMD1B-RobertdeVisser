using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{

    public Vector3 lopen;

    public float hor;
    public float ver;
    public float speed; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     

        hor = Input.GetAxis("Horizontal");

        ver = Input.GetAxis("Vertical");

        lopen.x = hor;
        lopen.z = ver; 
        transform.Translate(lopen * Time.deltaTime * speed);


    } 
   
}
