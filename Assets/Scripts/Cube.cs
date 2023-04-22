using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    //TODO Example
    [SerializeField] GameObject _prefabCoin;
    [SerializeField] float _moveSpeed;

    [HideInInspector] float _money = 0;
    float _rotationSpeed = 150f;
    float _horizontal, _vertical;
    Vector3 _positionStart;




    private void Start()
    {
        _positionStart = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        
    }

    void Update()
    {

        Vector3 positionNow = transform.position;
        if (positionNow.y < -5)
        {
            SceneManager.LoadScene(0);
        }

        _horizontal = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        transform.Rotate(0, _horizontal, 0);
        _vertical = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, _vertical);
    }
}
