using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        // Loads the game if the button is pressed
        SceneManager.LoadScene("_Scene_0");
    }
}
