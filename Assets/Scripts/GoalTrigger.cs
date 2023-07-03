using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public int playerNo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            FindObjectOfType<GameManager>().increasePScore(playerNo);
            Debug.Log("Goal from player" + (playerNo == 1 ? 2 : 1));
        }
    }
}
