using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    private Transform _target = null;

    public LayerMask ObjectLM;
    public LayerMask NoObjectLM;

    private Vector3 _originalScale;
    private Vector3 _dopPosition = new Vector3(0, 0.6f, 0);
    private float _originalDistance;
    private float _originalMass;

    void Start()
    {
        bool isFullscreen = PlayerPrefs.GetInt("Fullscreen") == 1;        

        int selectedIndex = PlayerPrefs.GetInt("Resolution");

        if (selectedIndex == 0)
        {
            Screen.SetResolution(1920, 1080, isFullscreen);
        }
        else if (selectedIndex == 1)
        {
            Screen.SetResolution(1600, 900, isFullscreen);
        }
        else if (selectedIndex == 2)
        {
            Screen.SetResolution(1280, 720, isFullscreen);
        }
        else if (selectedIndex == 3)
        {
            Screen.SetResolution(1024, 768, isFullscreen);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit objectHit;
            if (Physics.Raycast(transform.position, transform.forward + new Vector3(0, 0.05f, 0), out objectHit, Mathf.Infinity/*, ObjectLM*/) && objectHit.collider.tag == "Object")
            {
               
                _target = objectHit.transform;
                _target.GetComponent<Rigidbody>().isKinematic = true;
                _target.GetComponent<BoxCollider>().enabled = false;
                _originalScale = _target.localScale;
                _originalMass = _target.GetComponent<Rigidbody>().mass;
                _originalDistance = Vector3.Distance(transform.position, _target.position);
            }
        }

        if (Input.GetMouseButtonUp(0) && null != _target)
        {
            _target.GetComponent<Rigidbody>().isKinematic = false;
            _target.GetComponent<BoxCollider>().enabled = true;
            _target = null;
        }
    }

    void FixedUpdate()
    {
        if (null == _target)
            return;

        RaycastHit noObjectHit;
        if (Physics.Raycast(transform.position, transform.forward, out noObjectHit, Mathf.Infinity, NoObjectLM))
        {
            var positionOffsetX = transform.forward * _target.localScale.x;
            var positionOffsetY = transform.up * _target.localScale.y;

            _target.position = noObjectHit.point - positionOffsetX / 2 + (positionOffsetY + _dopPosition) / 2.5f;

            float distance = Vector3.Distance(transform.position, _target.position);
            float scaleMultiplier = distance / _originalDistance;

            if (_originalScale.x * scaleMultiplier <= 17)
            {
                _target.localScale = scaleMultiplier * _originalScale /** Vector3.one*/;
                _target.GetComponent<Rigidbody>().mass = scaleMultiplier * _originalMass;
            }
        }
    }
}
