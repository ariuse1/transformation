using UnityEngine;

public class Cube : MonoBehaviour
{    
    [SerializeField] private int _speed = 180;   

    private void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime,0);
    }
}
