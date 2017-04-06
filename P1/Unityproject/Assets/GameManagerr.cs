using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManagerr : MonoBehaviour
{


    public int score;
    public int lives;
    public Text tekstvakje;
    public Text tekstlives;
    public Animator anim;

    void Update()
    {
        //Score Board
        tekstvakje.text = score.ToString();
        tekstlives.text = lives.ToString();

        //GameOver Screen
        if (lives <= 0)
        {
            GameObject.Find("Veld").GetComponent<Stoten>().spawnBall = true;
            print("Game Over!");
            anim.SetTrigger("IsGameOver");
        }
    }
}


