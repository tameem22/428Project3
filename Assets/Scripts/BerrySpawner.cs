using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerrySpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public AudioSource src;
    void Start()
    {
        src = GetComponent<AudioSource> ();
    }
    void OnTriggerEnter()
    {
        // Instantiate(objectToSpawn, new Vector3((float)-26.3,(float)-0.6,(float)4.25), Quaternion.identity);
        Instantiate(objectToSpawn, new Vector3((float)-17.8708,(float)-0.3505838,(float)9.5), Quaternion.identity);
        src.Play();
    }

}
