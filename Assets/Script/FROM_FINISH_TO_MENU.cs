using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FROM_FINISH_TO_MENU : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(0);
    }
}
