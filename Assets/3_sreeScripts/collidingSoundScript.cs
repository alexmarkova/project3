using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidingSoundScript : MonoBehaviour
{

    public AudioSource bounceSound;


    // Start is called before the first frame update
    void Start()
    {
        bounceSound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        bounceSound.Play();
    }
}
