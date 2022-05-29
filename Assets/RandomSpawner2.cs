using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner2 : MonoBehaviour
{
    public GameObject key;
    public GameObject canSoda;

    List<Vector3> keyLocation = new List<Vector3>();
    List<Vector3> canSodaLocation = new List<Vector3>();

    void Start()
    {
        keyLocation.Add(new Vector3(27, 2, 19));
        keyLocation.Add(new Vector3(5, 4, -19));
        keyLocation.Add(new Vector3(-14, 2, 11));
        keyLocation.Add(new Vector3(18, 3, 4));

        canSodaLocation.Add(new Vector3((float)18.25, (float)0.5, (float)-12.57));
        canSodaLocation.Add(new Vector3((float)-0.85, (float)0.5, (float)1.67));
        canSodaLocation.Add(new Vector3((float)-3.27, (float)0.5, (float)-7.07));
        canSodaLocation.Add(new Vector3((float)3.47, (float)0.5, (float)12.91));
        canSodaLocation.Add(new Vector3((float)-6.27, (float)0.5, (float)13));
        canSodaLocation.Add(new Vector3((float)6.68, (float)0.5, (float)-5.04));

        Instantiate(key, keyLocation[Random.Range(0, keyLocation.Count)], Quaternion.Euler(90, 0, 0));

        for (int i = 0; i < 3; i++)
        {
            Instantiate(canSoda, canSodaLocation[Random.Range(0, canSodaLocation.Count)], Quaternion.Euler(90, 0, 0));
        }
    }
}