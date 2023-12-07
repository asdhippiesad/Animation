using UnityEngine;

public class RotatingAndGrowingCube : MonoBehaviour
{
    [SerializeField] private float _rotate;
    [SerializeField] private float _scale;
    [SerializeField] private float _speedForward;

    private Transform _rotateCube;
    private Transform _scaleCube;
    private Transform _speedCube;


    private void Start()
    {
        _rotateCube = transform;
        _scaleCube = transform;
        _speedCube = transform;
    }

    private void Update()
    {
        float scaleAmount = _scale * Time.deltaTime;
        _rotateCube.Rotate(Vector3.right * _rotate * Time.deltaTime);
        _scaleCube.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);
        _speedCube.Translate(Vector3.forward * _speedForward * Time.deltaTime);
    }
}
