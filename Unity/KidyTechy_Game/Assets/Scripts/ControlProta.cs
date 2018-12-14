using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlProta : MonoBehaviour
{
    public Transform _startPos;
    public Joystick _joystick;

    float _gravityVel = -10f;
    float _speed = 0.1f;
    bool _isGrounded = false;
    bool _tracked = false;
    Vector3 _gravityVector;
    Rigidbody _boyRG;
    CapsuleCollider _boyColi;
    Animator _anim;

	// Use this for initialization
	void Start ()
    {
        transform.position = _startPos.position;
        _boyRG = GetComponent<Rigidbody>();
        _boyColi = GetComponent<CapsuleCollider>();
        _anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        
        if (_boyColi.enabled)
        {
            _tracked = true;
            AcivateRigidbody();
            _gravityVector = Vector3.up * _gravityVel * Time.deltaTime;
            _boyRG.AddRelativeForce(_gravityVector);
        }
        else if (!_boyColi.enabled)
        {
            _boyRG.isKinematic = true;
        }

        if (_isGrounded && JoyInput() != Vector3.zero)
        {
            MoveBoy();
        }

        /*
        if (_boyColi.enabled && !_update)
        {
            Debug.Log("me caigooooo aaaaaaahhhhhhhhhhhhh!!!!");
            _boyRG.isKinematic = false;
            _gravityVector = Vector3.up * _gravityVel * Time.deltaTime;
            _boyRG.AddRelativeForce(_gravityVector);
        }
        */

 
    }
   
    void AcivateRigidbody()
    {
        _boyRG.isKinematic = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ostion contra el suelooo!!!");
        _isGrounded = true;
    }

    Vector3 JoyInput()
    {
        Vector3 _direction = (Vector3.right * _joystick.Horizontal + Vector3.forward * _joystick.Vertical);
        return _direction;
    }
    void MoveBoy()
    {
        transform.rotation = Quaternion.LookRotation(JoyInput());
        transform.Translate(Vector3.forward * _speed * Time.deltaTime,Space.Self);
        _anim.Play("run");
        Debug.Log("Estoy andando!!!");
    }
}
