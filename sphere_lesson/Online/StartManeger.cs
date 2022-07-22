using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class StartManeger : MonoBehaviourPunCallbacks
{
    public Text LogText;
    void Start()
    {
        PhotonNetwork.NickName = "Player" + Random.Range(1, 100);

        Log("Player name is set to " + PhotonNetwork.NickName);

        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            JoinRoom();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            CreateRoom();
        }
    }

    public override void OnConnectedToMaster()
    {
        Log("Connected to Master");
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 6 });
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinedRoom()
    {
        Log("Join the Room");

        PhotonNetwork.LoadLevel("morgue");
    }

    private void Log(string message)
    {
        Debug.Log(message);
        LogText.text += "\n";
        LogText.text += message;
    }
}
