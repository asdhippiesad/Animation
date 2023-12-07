using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _forwardSphere;

    private void Start()
    {
        _forwardSphere = transform;
    }

    private void Update()
    {
        _forwardSphere.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
