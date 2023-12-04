using UnityEngine;

public class Cube : MonoBehaviour
{    
    [SerializeField] private int _speed = 180;   

    void Start()
    {
        Transform transform = GetComponent<Transform>();
    }    
   
    void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime,0);
    }
}
