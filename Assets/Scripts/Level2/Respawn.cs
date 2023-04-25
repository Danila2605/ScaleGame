using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject board;
    [HideInInspector] Vector3 PositionStart;


    private void Start()
    {
        PositionStart = board.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            /* Position = Start2Level.PositionStart;*/
            player.transform.position = Start2Level.PositionStart;
            print("Enter");
        }
        if (other.CompareTag("Object"))
        {
            other.transform.position = PositionStart;
        }
    }
}
