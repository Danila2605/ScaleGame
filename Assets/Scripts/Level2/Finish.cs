using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] GameObject floor;
    [SerializeField] GameObject wall1;
    [SerializeField] GameObject wall2;
    [SerializeField] GameObject wall3;
    [SerializeField] GameObject wall4;
    [SerializeField] GameObject wall5;
    [SerializeField] GameObject wall6;
    [SerializeField] GameObject mainBox;
    [SerializeField] GameObject secondBox;
    [SerializeField] GameObject cameraPlayer;
    [SerializeField] GameObject light;
    [SerializeField] GameObject sphereSpace;
    [SerializeField] GameObject triggerTimer;

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            floor.GetComponent<Rigidbody>().isKinematic = false;
            wall1.GetComponent<Rigidbody>().isKinematic = false;
            wall2.GetComponent<Rigidbody>().isKinematic = false;
            wall3.GetComponent<Rigidbody>().isKinematic = false;
            wall4.GetComponent<Rigidbody>().isKinematic = false;
            wall5.GetComponent<Rigidbody>().isKinematic = false;
            wall6.GetComponent<Rigidbody>().isKinematic = false;
            mainBox.GetComponent<Rigidbody>().isKinematic = false;
            secondBox.GetComponent<Rigidbody>().isKinematic = false;
            sphereSpace.GetComponent<SphereCollider>().isTrigger = false;
            light.SetActive(false);
            triggerTimer.SetActive(true);
            /*cameraPlayer.SetActive(false);
            SceneManager.LoadScene(0);*/
        }
    }
}
    