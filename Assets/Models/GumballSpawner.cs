using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumballSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    void OnTriggerEnter()
    {
        Instantiate(objectToSpawn, new Vector3((float)0.25,(float)-1.4,(float)2.95), Quaternion.identity);
    }

}