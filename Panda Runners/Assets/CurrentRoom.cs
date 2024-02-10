using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class CurrentRoom : MonoBehaviour
{
    public TMP_Text CRoomText;

    // Update is called once per frame
    void Update()
    {
        CRoomText.text = PhotonNetwork.CurrentRoom.Name;
    }
}
