using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bumper : MonoBehaviour {

    public Text tekstvakje;
    public int score;
    public Vector3 v;
    public Rigidbody bal;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        bal.AddForce(v);

        score = score + 10;
        tekstvakje.text = score.ToString();
    }
}
