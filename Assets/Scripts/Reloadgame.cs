using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloadgame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
