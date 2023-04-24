using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearEmptyWall : MonoBehaviour
{
    [SerializeField] GameObject triggerWall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerWall.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerWall.SetActive(true);
        }
    }
}
