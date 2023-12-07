using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
