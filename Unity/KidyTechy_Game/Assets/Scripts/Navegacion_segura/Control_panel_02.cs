using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_panel_02 : MonoBehaviour
{
    public GameObject _panel02;
    public Text _pointsText;
    public AudioSource _audio;

    //public Control_points _pointsScript;

    public int _cuenta = 0;

	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
      
		
	}

    public void OnTriggerEnter(Collider other)
    
        {
            if (other.gameObject.tag == "Player")
            {
                _audio.clip = Resources.Load<AudioClip>("openPanel 1");
                _audio.Play();
                _panel02.SetActive(true);
                _cuenta++;
            }
        }

    public void RespuestaCorrecta()
    {
        switch (_cuenta)
        {
            case 1:
                Control_points._puntuacionActual += 10;
                //_pointsText.text += "" + 10; 
                break;
            case 2:
                Control_points._puntuacionActual += 5;
                //_pointsText.text += "" + 5;
                break;
            case 3:
                Control_points._puntuacionActual += 1;
                break;
        }

        _audio.clip = Resources.Load <AudioClip> ("scan_success_trumpet 1");
        _audio.Play();
    }

    public void RespuestaIncorrecta()
    {
        _audio.clip = Resources.Load<AudioClip>("failOption 1");
        _audio.Play();
    }
        
}
