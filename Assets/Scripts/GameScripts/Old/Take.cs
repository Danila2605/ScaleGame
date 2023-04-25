using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    public Transform pointer;
    private Ray ray;
    public RaycastHit hit1;
    public LayerMask layerMask;

    void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit1))
        {
            pointer.position = hit1.point;
        }
    }
}
