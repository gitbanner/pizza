using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNumber: MonoBehaviour
{
    public NameScript nameScript;
    public string Handtag;
    public float Letter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == Handtag)
        {
            nameScript.NameVar += Letter;
        }
    }
}