using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_NS : MonoBehaviour {

    public GameObject _boy;
    public Transform _puntoDestino;
    public AudioSource _Fx;
    public ParticleSystem _humo;

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
            _boy.transform.position = _puntoDestino.transform.position;
            _boy.transform.rotation = _puntoDestino.transform.rotation;
            _Fx.Play();
            _humo.Play();
        }
    }
}
