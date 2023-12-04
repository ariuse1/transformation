using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float _speed = 3;   

    void Start()
    {
        Transform transform = GetComponent<Transform>();     
    }

    void Update()
    {       
        transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;   
    }
}
        
