using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libra : MonoBehaviour
{
    public GameObject _gj;
    private Vector3 StartPos;
    private Vector3 StartPosGJ;
    private Vector3 ChangePos;
    private Vector3 TransformY;

    private void Start()
    {
        StartPos = new Vector3(0, transform.position.y, 0);
        StartPosGJ = new Vector3(0, _gj.transform.position.y, 0);
        ChangePos = new Vector3(0, transform.position.y, 0);
    }
    private void Update()
    {
        TransformY = new Vector3(0, transform.position.y, 0);
        if (ChangePos != TransformY)
        {
            Debug.Log(111);
            ChangePos -= new Vector3(0, transform.position.y, 0);
            _gj.transform.position += ChangePos ;
            ChangePos = TransformY;
        }
    }
}
