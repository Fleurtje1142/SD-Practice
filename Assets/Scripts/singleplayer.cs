using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class singleplayer : MonoBehaviour
{
    public float xPosition = -2f;
    public float yPosition = -2f;
    public float ySpeed = 3f;
    public float xSpeed = 3f;
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
        
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("horizontalWall")) 
        {  
            ySpeed = ySpeed * -1f;
        } else if (collision.gameObject.CompareTag("verticalWall"))
        {
          
            xSpeed = xSpeed * -1.1f;
        }
        else if (collision.gameObject.CompareTag("LeftWall"))
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            rightscore++;
            scoreText.text = leftscore + "-" + rightscore;
        }
        else if (collision.gameObject.CompareTag("RightWall"))
        {
            xSpeed = xSpeed * -1f;
            xPosition = 0f;
            yPosition = 0f;
            leftscore++;
            scoreText.text = leftscore + "-" + rightscore;
        }
    }

}
