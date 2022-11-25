using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolurkCry : MonoBehaviour
{
    public AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource> ();
        src.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
