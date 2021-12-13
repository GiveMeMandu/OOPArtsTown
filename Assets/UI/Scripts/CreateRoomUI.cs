using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoomUI : MonoBehaviour
{
    [SerializeField]
    private List<Button> maxPlayerCountButtons;

    private CreateGameRoomData roomData;

    public void UpdateMaxPlayerCount(int count)
    {
        roomData.maxPlayerCount = count;
    }
}

public class CreateGameRoomData
{
    public int maxPlayerCount;
}