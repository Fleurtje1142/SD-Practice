using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -2f;
    public float xSpeed = 3f;
    public float ySpeed = 3f;
    public TMP_Text scoreText;
    public int leftscore = 0;
    public int rightscore = 0;
    public int winscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // paddle goes up
        xPosition = xPosition + xSpeed * Time.deltaTime;  
        yPosition = yPosition + ySpeed * Time.deltaTime; 
        transform.position = new Vector3(xPosition, yPosition, 0f);

        // score board till 10 then a player winst
        if (leftscore >= 10)
        {
            scoreText.text = "Left player has won!";
            xPosition = 0;
            yPosition = 0;

        }
        else if (rightscore >= 10)
        {
            scoreText.text = "Right player has won!";
            xPosition = 0;
            yPosition = 0;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("horizontalWall")) 
        {
            
            ySpeed = ySpeed * -1f; // Change direction of the ball
        } else if (collision.gameObject.CompareTag("verticalWall"))
        {
            if (xSpeed <=8 || xSpeed <= -8)
            xSpeed = xSpeed * -1.1f; // speeds ball up if hit the paddle
        }
        else if (collision.gameObject.CompareTag("LeftWall")) // score right player
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            rightscore++;
            scoreText.text = leftscore + "-" + rightscore;
        }
        else if (collision.gameObject.CompareTag("RightWall")) // score left player
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            leftscore++;
            scoreText.text = leftscore + "-" + rightscore;
        }
    }

}
