using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{

    [SerializeField] private Text _fruitsText;
    [SerializeField] private int _countFruits;
    [SerializeField] private GameObject _hideTerrain;
    public static int fruits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _fruitsText.text = "Needs collected " + (_countFruits-fruits) + " of 3 fruits"; 
        
        if (fruits == 3 && ButtonControll.buttonActivate == true)
        {
            _hideTerrain.SetActive(true);
        }
        else
        {
            _hideTerrain.SetActive(false);
        }
    }
}
