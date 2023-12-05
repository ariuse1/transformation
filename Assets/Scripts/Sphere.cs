using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _speed = 3;

    private void Update()
    {       
        transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;   
    }
}
        
