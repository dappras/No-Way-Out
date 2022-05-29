using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaCanTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject brian;
    public brianNavMesh chasingPlayer;
    public AI patroll;
    public ChasingCanSoda chasingCanSoda;
    public float Distance_;

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player" && Distance_ <12)
        {
            Debug.Log("Kesentuh Player dan jarak kurang dari 15");
            chasingPlayer.enabled = true;
            //chasingCanSoda.enabled = true;
            patroll.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Distance_ = Vector3.Distance(player.transform.position, brian.transform.position);
    }
}
