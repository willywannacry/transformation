using System.Runtime.CompilerServices;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    [SerializeField] private float _step;

    private void Update() 
    {
        transform.Rotate(0, _step, 0);
    }
}
