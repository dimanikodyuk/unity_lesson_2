using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControll : MonoBehaviour
{
    [SerializeField] private Animator animButton;
    public static bool buttonActivate = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            buttonActivate = true;
            animButton.SetBool("button_activate", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            buttonActivate = false;
            animButton.SetBool("button_activate", false);
        }
        
    }


}
