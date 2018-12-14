using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_points : MonoBehaviour
{
    public Text _pointsText;

    public static int _puntuacionActual;
    //int _puntuacion;

    // Use this for initialization
    void Awake()
    {
        _puntuacionActual = 0;

    }
	// Update is called once per frame
	void Update ()
    {
        _pointsText.text = "" + _puntuacionActual;
    }
    
}
