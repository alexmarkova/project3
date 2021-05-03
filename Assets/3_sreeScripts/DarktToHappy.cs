using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DarktToHappy : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            SceneManager.LoadScene(0);
        }



    }
}