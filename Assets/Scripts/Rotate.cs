using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _rotateCube;

    private void Start()
    {
        _rotateCube = transform;
    }

    private void Update()
    {
        _rotateCube.Rotate(Vector3.right * _speed * Time.deltaTime);
    }
}
