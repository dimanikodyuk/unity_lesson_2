using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireControll : MonoBehaviour
{
    [SerializeField] private Animator _fireAnimator;

    private float _waitTime = 1f;
    private float _duration = 0f;
    private bool _onFire = false;
    private bool _isPlayer = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_onFire == true)
        {
            fireOn();
        }

        else
        {
            _fireAnimator.SetBool("fire_hit", false);
            _fireAnimator.SetBool("fire_on", false);
        }
    }

    IEnumerator ExecuteAfterTime(float timeInSec)
    {
        yield return new WaitForSeconds(timeInSec);
        SceneManager.LoadScene(0);
    }

    private void fireOn()
    {
        _fireAnimator.SetBool("fire_hit", true);
        _duration += Time.deltaTime;

        if (_duration >= _waitTime)
        {
            _fireAnimator.SetBool("fire_on", true);
        }
        if (_fireAnimator.GetBool("fire_on") && _isPlayer)
        {
            Timer();
        }
    }

    void Timer()
    {
        float timeLeft = 0.007f;
        
        timeLeft -= Time.deltaTime;
        Debug.Log(timeLeft);
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(0);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _isPlayer = true;
        }
        _onFire = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _fireAnimator.SetBool("fire_hit", false);
        _fireAnimator.SetBool("fire_on", false);
        _duration = 0;
        _isPlayer = false;
        _onFire = false;

    }

   

}
