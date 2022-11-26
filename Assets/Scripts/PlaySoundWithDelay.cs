using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundWithDelay : MonoBehaviour
{

    public AudioSource src;
    
    void Start () {
        src = GetComponent<AudioSource> ();
        // while (true){
        //     src.PlayDelayed(3);
        // }
    }

    void Update() {
        src.PlayDelayed(3);
    }
}
