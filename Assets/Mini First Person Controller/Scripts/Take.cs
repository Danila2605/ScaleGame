using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    float distance = 3;
    public Transform pos;
    private Rigidbody rb;
    bool T = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, distance) && T == false)
        {
            rb.useGravity = false;
            rb.isKinematic = true;
            T = true;
            rb.MovePosition(pos.position);
        }
    }

    private void OnMouseUp()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
        T = false;
        //rb.AddForce(Camera.main.transform.forward * 400);
    }

    void FixedUpdate()
    {
        if (rb.isKinematic == true)
        {
            this.gameObject.transform.position = pos.position;
        }
    }
}
