using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public TMP_Text RoomJoin;

    private void OnTriggerEnter(Collider other)
    {
        CreateAndjoinRoom();
    }
    void CreateAndjoinRoom()
    {
        PhotonNetwork.CreateRoom(RoomJoin.text);
        PhotonNetwork.JoinRoom(RoomJoin.text);
    }
}
