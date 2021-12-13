using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class CreateRoomUI : MonoBehaviour
{
    [SerializeField]
    private List<Button> maxPlayerCountButtons;

    private CreateGameRoomData roomData;

    public void UpdateMaxPlayerCount(int count)
    {
        roomData.maxPlayerCount = count;
    }

    public void CreateRoom()
    {
        var manager = OOPArtsTownNetworkManager.singleton;
        // 방 설정 작업 처리
        //
        // 생성 및 참가
        manager.StartHost();
    }
}

public class CreateGameRoomData
{
    public int maxPlayerCount;
}