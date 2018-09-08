using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform player;

    private void OnTriggerEnter(Collider col)
    {

            col.transform.position = spawnPoint.transform.position;
    }

}
