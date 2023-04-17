using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotTrigger : MonoBehaviour
{
    private float _sc;
    public GameObject Gm;
    public string NameAnimation;
    private Animator _an;

    void Start()
    {
        _an = Gm.GetComponent<Animator>();
        _sc = gameObject.transform.localScale.x;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            if (other.GetComponent<Transform>().localScale.x <= _sc && other.GetComponent<Transform>().localScale.x >= _sc - 0.2f)
            {
                other.transform.position = gameObject.transform.position;
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Transform>().localScale = gameObject.transform.localScale;
            }
            if (other.GetComponent<Transform>().localScale == gameObject.transform.localScale)
            {
                //Какие либо изменения

                _an.Play(NameAnimation);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            other.GetComponent<Rigidbody>().useGravity = true;
            //Если достать из паза

            _an.Play("New State");
        }
    }
}
