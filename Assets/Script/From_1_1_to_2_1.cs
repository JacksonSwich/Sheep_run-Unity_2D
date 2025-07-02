using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class From_1_1_to_2_1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(4);
    }
}
