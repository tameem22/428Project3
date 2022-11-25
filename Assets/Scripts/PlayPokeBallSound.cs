using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPokeBallSound : MonoBehaviour
{
    public AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision) {
        // if (collision.gameObject.tag == "Target"){
        //     src.Play();
        // }
        src.Play();
    }
}
