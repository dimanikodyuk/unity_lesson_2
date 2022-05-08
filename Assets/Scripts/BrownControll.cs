using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownControll : MonoBehaviour
{
    [SerializeField] private Animator _checkpointAnimator;
    [SerializeField] private float _speedRotate;


    // Update is called once per frame
    void Update()
    {
            _checkpointAnimator.SetBool("checkpointActivate", true);
            float scaleMoveSpeed = _speedRotate * Time.deltaTime;
            transform.Rotate(0, 0, 10 * scaleMoveSpeed);
    }

}
