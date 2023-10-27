    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    private float speed = 3f;
    public string leftOrRight;
    private float maxValue = 3.5f;

   
    // paddel movement
    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y <= maxValue) 
        {
            Debug.Log(up);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(down) && transform.position.y >= -maxValue)
        {
            Debug.Log(speed);

            Debug.Log(Time.deltaTime);
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

    }

    
  
    // Update is called once per frame
    void Update()
    {
        if(leftOrRight == "left") 
        {
            // first player keys
            paddleControl(KeyCode.W, KeyCode.S); 
        }
        else if(leftOrRight == "right")
        {
            // second player keys
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
