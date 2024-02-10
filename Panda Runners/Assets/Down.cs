using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Down : MonoBehaviour
{
    public TMP_Text arrow;
    public GameObject Name;
    public GameObject Room;
   
    private void OnTriggerEnter(Collider other)
    {
        if (Name.activeSelf == true)
        {
            arrow.transform.position = new Vector3(-0.025f, 0.03f, 0.119f);
            Name.SetActive(false);
            Room.SetActive(true);
        }
        if (Room.activeSelf == true)
        {
            arrow.transform.position = new Vector3(-0.025f, 0.07f, 0.119f);
            Name.SetActive(true);
            Room.SetActive(false);
        }

    }
}
