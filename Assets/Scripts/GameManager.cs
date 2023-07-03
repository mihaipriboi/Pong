using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject paddle1;
    public GameObject paddle2;

    public TMPro.TMP_Text p1ScoreText;
    public TMPro.TMP_Text p2ScoreText;
    public TMPro.TMP_Text gameStartText;

    private int p1Score = 0;
    private int p2Score = 0;

    private bool gameStarted;

    void Start()
    {
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameStartText.text = "";
                gameStarted = true;
                spawnBall(-1);
            }
        }

        p1ScoreText.text = p1Score.ToString();
        p2ScoreText.text = p2Score.ToString();
    }

    public void increasePScore(int player)
    {
        paddle1.GetComponent<Rigidbody2D>().transform.position = paddle1.GetComponent<Rigidbody2D>().transform.position * new Vector2(1f, 0f);
        paddle2.GetComponent<Rigidbody2D>().transform.position = paddle2.GetComponent<Rigidbody2D>().transform.position * new Vector2(1f, 0f);

        if (player == 1)
        {
            p1Score++;
            spawnBall(1);
        }
        else
        {
            p2Score++;
            spawnBall(-1);
        }

    }

    private void spawnBall(int dir)
    {
        GameObject b = Instantiate(ball);
        b.GetComponent<Ball>().startDir = new Vector2(dir, 0);
    }
}
