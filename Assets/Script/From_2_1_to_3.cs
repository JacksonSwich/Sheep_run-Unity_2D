using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class From_2_1_to_3 : MonoBehaviour
{   
    void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(5);
    }

}
