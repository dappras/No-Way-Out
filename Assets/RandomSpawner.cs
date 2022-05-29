using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject key;
    public GameObject canSoda;

    List<Vector3> keyLocation = new List<Vector3>();
    List<Vector3> canSodaLocation = new List<Vector3>();


    void Start()
    {
        Debug.Log(key.tag);
        Debug.Log(canSoda.tag);
        keyLocation.Add(new Vector3((float)-13.9, (float)0.5, (float)9.5));
        keyLocation.Add(new Vector3(7, (float)0.5, (float)11.2));
        keyLocation.Add(new Vector3(-20,(float)1.8,(float)-10.7));
        keyLocation.Add(new Vector3((float)8.43, (float)0.8, (float)6.45));

        canSodaLocation.Add(new Vector3((float)17.81, (float)1, (float)-6.83));
        canSodaLocation.Add(new Vector3((float)7.6, (float)1, (float)-12.7));
        canSodaLocation.Add(new Vector3((float)-3.64, (float)1, (float)-7.33));
        canSodaLocation.Add(new Vector3((float)-12.4, (float)1, (float)1.73));

        Instantiate(key, keyLocation[Random.Range(0, keyLocation.Count)], Quaternion.Euler(90,0,0));

        // for(int i = 0; i < 3; i++)
        // {
        //     Instantiate(canSoda, canSodaLocation[Random.Range(0, canSodaLocation.Count)], Quaternion.Euler(90, 0, 0));
        // }
        
    }
}