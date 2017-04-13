using UnityEngine;
using System.Collections;

public class Firstcamera : MonoBehaviour
{

    public Vector3 lichaam;
    public Vector3 camera1; 
    public GameObject cam;
    public GameObject body;
    public float hoofd;


    void Update()
    {
        camera1.x = -Input.GetAxis("Mouse Y");
        {
            cam.transform.Rotate(camera1);
        }
        lichaam.y = Input.GetAxis("Mouse X");
        {
            body.transform.Rotate(lichaam);
        }
    }

}
