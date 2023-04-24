using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject floor;
    [SerializeField] GameObject pedistal;
    [SerializeField] GameObject cameraPlayer;
    [SerializeField] GameObject light;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            floor.GetComponent<Rigidbody>().isKinematic = false;
            floor.GetComponent<Rigidbody>().useGravity = true;
            light.SetActive(false);
            /*cameraPlayer.SetActive(false);
            SceneManager.LoadScene(0);*/
        }
    }
}
    