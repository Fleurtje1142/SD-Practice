using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void PlayGame (int gameMode =1)
    {
        // button player 2
        if (gameMode == 1 ) {
            SceneManager.LoadScene("2 player");
        }
        
        // button player 1
        if (gameMode == 2 ) {
            SceneManager.LoadScene("1 player");
        }
        
        // button reverse
        if( gameMode == 3 ){
            SceneManager.LoadScene("reverse");
        }
        
        // button homescreen
        if(gameMode == 4){
            SceneManager.LoadScene("homescreen");
        }
    }
    
    // button quit
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
