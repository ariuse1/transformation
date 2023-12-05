using UnityEngine;

public class CubeRotation: MonoBehaviour
{
    [SerializeField] private float _speed = 13;

    private void Update()
    {       
        transform.Translate(transform.forward * _speed * Time.deltaTime, Space.World);
    }
}
