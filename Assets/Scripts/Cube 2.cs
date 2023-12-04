using UnityEngine;

public class Cube2 : MonoBehaviour
{
    [SerializeField] private float _speed = 13;  

    void Start()
    {
        Transform transform = GetComponent<Transform>();       
    }

    void Update()
    {       
        transform.Translate(transform.forward * _speed * Time.deltaTime, Space.World);
    }
}
