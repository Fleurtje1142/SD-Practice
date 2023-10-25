using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void PlayGame (int gameMode =1)
    {
        if (gameMode == 1 ) {
            SceneManager.LoadScene("2 player");
        }
        if (gameMode == 2 ) {
            SceneManager.LoadScene("1 player");
        }
        if( gameMode == 3 ){
            SceneManager.LoadScene("reverse");
        }
        if(gameMode == 4){
            SceneManager.LoadScene("homescreen");
        }
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
