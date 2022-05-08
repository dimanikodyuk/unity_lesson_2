using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckpointControll : MonoBehaviour
{
    [SerializeField] Animator _checkpointAnimator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _checkpointAnimator.SetBool("checkpointActivate", true);
            SceneManager.LoadScene(2);
        }
    }

}
