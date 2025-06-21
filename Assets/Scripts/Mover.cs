using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _step;
    private void Update()
    {
        transform.position += transform.forward * _step * Time.deltaTime;
    }
}
