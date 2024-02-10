using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Disconnect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PhotonNetwork.Disconnect();
    }
}
