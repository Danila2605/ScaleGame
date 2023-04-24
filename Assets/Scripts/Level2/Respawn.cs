using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] GameObject player;
    [HideInInspector] Vector3 Position;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            /* Position = Start2Level.PositionStart;*/
            player.transform.position = Start2Level.PositionStart;
            print("Enter");
        }
    }
}
