using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyFollow : MonoBehaviour
{
    public Transform _target;
    public float _actionRadio = 10f;
    public float _aimRadio = 30f;
    public float _velocity = 5f;

    float _distance;
    Animator _anim;


    // Use this for initialization
    void Start()
    {
        _anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(transform.position, _target.position);

        if (_distance < _aimRadio)
        {
            transform.LookAt(_target);
        }

        if (Vector3.Distance(transform.position, _target.position) < _actionRadio)
        {
            Vector3 enemyPos = transform.position;
            Vector3 objetivoPos = _target.position;

            //Debug.Log("Estoy en la zona");

            enemyPos.y = transform.position.y;

            transform.position = Vector3.MoveTowards(enemyPos, objetivoPos, _velocity * Time.deltaTime);
            _anim.SetBool("run",true);
        }

    }
}
