using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ECamType
{
    OT
}

public class PlayerCameras
{
    private static List<Vector3> camPos = new List<Vector3>()
    {
        new Vector3(0f, 7f, -10f)
    };
    private static List<Vector3> camRot = new List<Vector3>()
    {
        new Vector3(35f, 0f, 0f)
    };

    public static Vector3 GetCamPosition(ECamType camType) { return camPos[(int)camType]; }
    public static Vector3 GetCamRotation(ECamType camType) { return camRot[(int)camType]; }
    //public static Vector3 OT { get { return Vector3[(int)ECamType.OT]; } }

    //public static Vector3 OT { get { return Vector3[(int)ECamType.OT]; } }
}
