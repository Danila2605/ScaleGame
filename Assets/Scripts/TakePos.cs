using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TakePos : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rb;
    bool T = true;
    private float scale, scaleLow, distance = 5;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        scaleLow = 1;
    }
    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray) && T)
        {
            gameObject.layer = 2;

            rb.useGravity = false;
            rb.isKinematic = true;
            T = false;

            gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
        }
    }

    void OnMouseUp()
    {
        if (T == false)
        {
            gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
        }

        scaleLow = scale;
        gameObject.layer = 0;

        rb.useGravity = true;
        rb.isKinematic = false;
        T = true;
    }
    void FixedUpdate()
    {
        if (rb.isKinematic == true)
        {
            /*Debug.LogWarning(player.GetComponent<Take>().hit1.distance);
            Debug.LogWarning(scaleLow);*/

            scale = (scaleLow * player.GetComponent<Take>().hit1.distance) / (distance+1);
            gameObject.transform.localScale = (new Vector3(1, 1, 1) * scale);
            this.gameObject.transform.position = player.GetComponent<Take>().pointer.position;
        }
    }
}
