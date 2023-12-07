using UnityEngine;

public class ScaleCapsule : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private void Update()
    {
        float growthAmount = _growthSpeed * Time.deltaTime;
        transform.localScale = new Vector3 (growthAmount, growthAmount, growthAmount);
    }
}
