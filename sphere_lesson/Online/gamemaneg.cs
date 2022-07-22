using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class gamemaneg : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPrefab,Organ;
    public GameObject[] Golov;

    private void Start()
    {
        PhotonNetwork.Instantiate(Golov[Random.Range(0, 3)].name, new Vector3(Random.Range(1, -1), 1.5f, 2.5f), Quaternion.identity);
        PhotonNetwork.InstantiateSceneObject(Organ.name, new Vector3(Random.Range(-0.7378974f, -0.7378975f), (2.410393f ),0.374f), Quaternion.identity);
        
    }
    public void leave()
    {
        PhotonNetwork.LeaveRoom();
    }
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.LogFormat("Player voshel v room", newPlayer.NickName);
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.LogFormat("Player exit room", otherPlayer.NickName);
    }


}
