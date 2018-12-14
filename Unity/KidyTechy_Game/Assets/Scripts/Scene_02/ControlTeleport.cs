using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTeleport : MonoBehaviour
{
    public float _teleport;
    public GameObject _boy;
    
    public Transform _isla02;
    public Transform _isla03;

    public Animator _anim01;
    public Animator _anim02;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" & _teleport == 1)
        {
            _boy.transform.position = _isla02.transform.position;
            _boy.transform.rotation = _isla02.transform.rotation;
            _anim01.SetTrigger("flash");
            _anim02.SetTrigger("flash");
            GetComponent<AudioSource>().Play();
        }
        else if (other.gameObject.tag == "Player" & _teleport == 2)
        {
            _boy.transform.position = _isla03.transform.position;
            _boy.transform.rotation = _isla03.transform.rotation;
            _anim01.SetTrigger("flash");
            _anim02.SetTrigger("flash");
            GetComponent<AudioSource>().Play();
        }
        
    }
}
