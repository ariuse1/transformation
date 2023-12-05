using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _rateIncrease = 2;    
    [SerializeField] private float _pathRunningTime = 2;
     
    private Vector3 _startLocale;
    private Vector3 _targetLocale;
    private float _pathTime;    

    private void Start()
    {    
        _startLocale = transform.localScale;
        _targetLocale = _startLocale * _rateIncrease;
    }

    private void Update()
    {
        if (transform.localScale == _targetLocale)
        {
            Vector3 temp = _targetLocale;
            _targetLocale = _startLocale;
            _startLocale = temp;
            _pathTime = 0;
        }

        _pathTime += Time.deltaTime;        
        transform.localScale = Vector3.Lerp(_startLocale, _targetLocale, _pathTime / _pathRunningTime); 
    }
}
