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
        keyLocation.Add(new Vector3(7, (float)2.4, (float)11.2));
        keyLocation.Add(new Vector3(-20, (float)1.8, (float)-11.2));
        keyLocation.Add(new Vector3((float)8.43, (float)0.78, (float)6.45));

        canSodaLocation.Add(new Vector3((float)17.81, (float)1, (float)-6.83));
        canSodaLocation.Add(new Vector3((float)7.6, (float)1, (float)-12.7));
        canSodaLocation.Add(new Vector3((float)-3.64, (float)1, (float)-7.33));
        canSodaLocation.Add(new Vector3((float)-12.4, (float)1, (float)1.73));

        Instantiate(key, keyLocation[Random.Range(0, keyLocation.Count)], Quaternion.Euler(90,0,0));

        for(int i = 0; i < canSodaLocation.Count; i++)
        {
            Instantiate(canSoda, canSodaLocation[i], Quaternion.Euler(90, 0, 0));
        }
        // Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 17), 4, Random.Range(-18, 38));
        // Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        // int lokasi = new Random(1, 4);

    }
    // Update is called once per frame
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.RightAlt))
    //     {
    //         int lokasi = Random.Range(1, 5);
    //         switch (lokasi)
    //         {
    //             case 1:
    //                 Instantiate(cubePrefab, kamar1, Quaternion.identity);
    //                 break;
    //             case 2:
    //                 Instantiate(cubePrefab, kamar2, Quaternion.identity);
    //                 break;
    //             case 3:
    //                 Instantiate(cubePrefab, kamar3, Quaternion.identity);
    //                 break;
    //             case 4:
    //                 Instantiate(cubePrefab, kamar4, Quaternion.identity);
    //                 break;
    //         }
    //         // Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 17), 4, Random.Range(-18, 38));
    //         // Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
    //     }
    // }
}
