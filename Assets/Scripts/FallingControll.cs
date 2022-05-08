using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingControll : MonoBehaviour
{
    [SerializeField] private Animator _checkpointAnimator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        _checkpointAnimator.SetBool("FallingOn", true);
    }

}
