using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Similar to GameOver script, player can restart the game by pressing Space
        //If the player hit space. . .
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Then load the 'Example 3' scene
            SceneManager.LoadScene("Example 3");
        }
    }
}
