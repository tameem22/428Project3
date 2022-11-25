using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeballSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    void OnTriggerEnter()
    {
        Instantiate(objectToSpawn, new Vector3((float)-26.3,(float)-0.6,(float)4.25), Quaternion.identity);
    }

}
