using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShpereCollision : MonoBehaviour
{

     Material sphereMaterial;
     AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        sphereMaterial = GetComponent<Renderer>().material;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            sphereMaterial.color = Color.red;
            audioSource.Play();
        }
       
    }
    
}
