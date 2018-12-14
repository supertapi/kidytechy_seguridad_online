using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_teleport_verde : MonoBehaviour
{
    public GameObject _boy;
    public Transform _destino;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _boy.transform.position = _destino.transform.position;
            _boy.transform.rotation = _destino.transform.rotation;
        }
    }

}
