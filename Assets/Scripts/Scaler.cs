using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _step; 

    private void Update()
    {
        transform.localScale += new Vector3(_step, _step, _step);
    }
}
