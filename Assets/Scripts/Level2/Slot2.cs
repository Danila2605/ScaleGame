using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot2 : MonoBehaviour
{
    public GameObject _GO;
    public GameObject _GO2;
    private float _sc;

    void Start()
    {
        _sc = gameObject.transform.lossyScale.y*2;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            if (other.GetComponent<Transform>().localScale.y <= _sc + 0.1f && other.GetComponent<Transform>().localScale.y >= _sc - 0.2f)
            {
                Debug.Log(111);
                other.transform.position = gameObject.transform.position;
                /*other.GetComponent<Rigidbody>().useGravity = false;*/
                other.GetComponent<Transform>().localScale = gameObject.transform.localScale*2;
                //Какие либо изменения
                _GO.SetActive(false);
                _GO2.SetActive(true);
            }
        }
    }
}
