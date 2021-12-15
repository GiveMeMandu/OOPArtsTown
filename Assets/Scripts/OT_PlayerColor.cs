using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EPlayerColor
{
    Red, Blue, Green,
    Pink, Orange, Yellow,
    Black, White, Purple,
    Brown, Cyan, Lime
}

public class OT_PlayerColor
{
    private static List<Color> colors = new List<Color>()
    {
        new Color(1f, 0f, 0f),
        new Color(.1f, .1f, 1f),
        new Color(0f, .6f, 0f),
        new Color(1f, .3f, .9f),
        new Color(1f, .4f, 0f),
        new Color(1f, .9f, .1f),
        new Color(.2f, .2f, .2f),
        new Color(.9f, 1f, 1f),
        new Color(.6f, 0f, .6f),
        new Color(.7f, .2f, 0f),
        new Color(0f, 1f, 1f),
        new Color(.1f, 1f, .1f)
    };

    public static Color GetColor(EPlayerColor playerColor) { return colors[(int)playerColor]; }
    public static Color Red { get { return colors[(int)EPlayerColor.Red]; } }
    public static Color Blue { get { return colors[(int)EPlayerColor.Blue]; } }
    public static Color Green { get { return colors[(int)EPlayerColor.Green]; } }
    public static Color Pink { get { return colors[(int)EPlayerColor.Pink]; } }
    public static Color Orange { get { return colors[(int)EPlayerColor.Orange]; } }
    public static Color Yellow { get { return colors[(int)EPlayerColor.Yellow]; } }
    public static Color Black { get { return colors[(int)EPlayerColor.Black]; } }
    public static Color White { get { return colors[(int)EPlayerColor.White]; } }
    public static Color Purple { get { return colors[(int)EPlayerColor.Purple]; } }
    public static Color Brown { get { return colors[(int)EPlayerColor.Brown]; } }
    public static Color Cyan { get { return colors[(int)EPlayerColor.Cyan]; } }
    public static Color Lime { get { return colors[(int)EPlayerColor.Lime]; } }
}
