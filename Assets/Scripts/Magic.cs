using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    private Transform _target = null;

    public LayerMask ObjectLM;
    public LayerMask NoObjectLM;

    private float _originalScale;
    private float _originalDistance;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit objectHit;
            if (Physics.Raycast(transform.position, transform.forward, out objectHit, Mathf.Infinity, ObjectLM))
            {
                _target = objectHit.transform;
                _target.GetComponent<Rigidbody>().isKinematic = true;
                _originalScale = _target.localScale.x;
                _originalDistance = Vector3.Distance(transform.position, _target.position);
            }
        }

        if (Input.GetMouseButtonUp(0) && null != _target)
        {
            _target.GetComponent<Rigidbody>().isKinematic = false;
            _target = null;
        }
    }

    void FixedUpdate()
    {
        if (null == _target)
            return;

        RaycastHit noObjectHit;
        if (Physics.Raycast(transform.position,transform.forward, out noObjectHit, Mathf.Infinity, NoObjectLM))
        {
            var positionOffset = transform.forward * _target.localScale.x;

            _target.position = noObjectHit.point - positionOffset;

            float distance = Vector3.Distance(transform.position, _target.position);
            float scaleMultiplier = distance / _originalDistance;

            _target.localScale = scaleMultiplier * _originalScale * Vector3.one;
        }
    }
}
