using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HappyToDark : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            SceneManager.LoadScene(1);
        }



    }
}


