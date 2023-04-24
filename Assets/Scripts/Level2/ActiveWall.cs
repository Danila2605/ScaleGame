using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWall : MonoBehaviour
{
    [SerializeField] GameObject wall;
    [SerializeField] GameObject triggerWall;

    [SerializeField] Animator wallAnim;
    

    [SerializeField] string nameAnimationEnter;
    [SerializeField] string nameAnimationExit;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wallAnim.Play(nameAnimationEnter);
            triggerWall.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            wallAnim.Play(nameAnimationExit);
            triggerWall.SetActive(true);
        }
    }
}
