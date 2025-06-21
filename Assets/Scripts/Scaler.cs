using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _step; 

    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime;
    }
}
