using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    void OnTriggerEnter()
    {
        Instantiate(objectToSpawn, new Vector3((float)-3.4,(float)-0.55,(float)2.8), Quaternion.identity);
    }

}
