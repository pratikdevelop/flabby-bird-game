using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour
{
    public void loadGame()
    {
        Debug.Log("Started up logging.");
        SceneManager.LoadSceneAsync(1);
    }

}
