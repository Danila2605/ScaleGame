using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libra : MonoBehaviour
{
    public GameObject _gj;
    private Vector3 ChangePos;
    private Vector3 TransformY;
    private float StartPos;
    private bool flag = true;

    private void Start()
    {
        ChangePos = new Vector3(0, transform.position.y, 0);
        StartPos = gameObject.transform.position.y;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>().mass >= 10)
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        else
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }
    private void Update()
    {
        TransformY = new Vector3(0, transform.position.y, 0);
        flag = true;
        if (ChangePos != TransformY)
        {
            flag = false;
            ChangePos -= new Vector3(0, transform.position.y, 0);
            _gj.transform.position += ChangePos;
            ChangePos = TransformY;
        }
        if (Mathf.Abs(TransformY.y - StartPos) >= 0.1f && flag)
        {
            gameObject.transform.position += new Vector3(0, 0.02f, 0);
        }
    }
}
