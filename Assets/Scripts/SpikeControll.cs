using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeControll : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _endPosition;

    [SerializeField] private Transform _target;
    [SerializeField] private float _duration;


    private float _timeCounter = 0f;

    private bool _changeAxis = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_changeAxis == false)
        {
            MotionRight();
        }
        else
        {
            MotionLeft();
        }

    }

    private void MotionRight()
    {
        var normalizedTime = _timeCounter / _duration;

        if(_timeCounter < _duration && _changeAxis == false)
        {
            _target.position = Vector3.Lerp(_startPosition.position, _endPosition.position, normalizedTime);
            _timeCounter += Time.deltaTime;
        }
        else
        {
            _changeAxis = true;
            _timeCounter = 0;
        }
 
    }


    private void MotionLeft()
    {
        var normalizedTime = _timeCounter / _duration;

        if (_timeCounter < _duration && _changeAxis == true)
        {
            _target.position = Vector3.Lerp(_endPosition.position, _startPosition.position, normalizedTime);
            _timeCounter += Time.deltaTime;
        }
        else
        {
            _changeAxis = false;
            _timeCounter = 0;
        }
    }
}
