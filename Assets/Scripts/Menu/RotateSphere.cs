using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    [SerializeField] float speedRotate;
    void Update()
    {
        transform.Rotate(speedRotate, speedRotate, speedRotate);
    }
}
