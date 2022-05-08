using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHeadController : MonoBehaviour
{
    [SerializeField] private Animator _rockHeadAnimator;
    [SerializeField] private Rigidbody2D _rockHead;
    [SerializeField] private float _speedAttack;
    [SerializeField] private int arrowAttack;
    private bool _isAttack = false;

    void Update()
    {
        if (_isAttack == true)
        {
            //float scaleAttackSpeed = _speedAttack * Time.deltaTime;
            if (arrowAttack < 0)
            {
                _rockHead.AddForce(Vector2.left * _speedAttack);
                _rockHeadAnimator.SetBool("left_hit", true);


            }
            else if (arrowAttack > 0)
            {
                _rockHead.AddForce(Vector2.right * _speedAttack);
                _rockHeadAnimator.SetBool("right_hit", true);
            }
        }
        else
        {
            _rockHeadAnimator.SetBool("left_hit", false);
            _rockHeadAnimator.SetBool("right_hit", false);
        }
    }
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _rockHeadAnimator.SetBool("blink", true);
            _isAttack = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //_rockHeadAnimator.SetBool("blink", false);
            _isAttack = false;
        }
    }

}
