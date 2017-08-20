using System.Collections.Generic;
using UnityEngine;

public class JoystickInputUtils {

  public static readonly Dictionary<string, KeyCode> Buttons = new Dictionary<string, KeyCode> {
    {"A", KeyCode.Joystick1Button0},
    {"B", KeyCode.Joystick1Button1},
    {"X", KeyCode.Joystick1Button2},
    {"Y", KeyCode.Joystick1Button3},
    {"LB", KeyCode.Joystick1Button4},
    {"RB", KeyCode.Joystick1Button5},
    {"Back", KeyCode.Joystick1Button6},
    {"Start", KeyCode.Joystick1Button7},
    {"LeftStickPress", KeyCode.Joystick1Button8},
    {"RightStickPress", KeyCode.Joystick1Button9}
  };

  public static readonly Dictionary<string, string> Axes = new Dictionary<string, string> {
    {"LStickH", "LeftStickHorizontal"},
    {"LStickV", "LeftStickVertical"},
    {"RStickH", "RightStickHorizontal"},
    {"RStickV", "RightStickVertical"},
    {"DPadH", "DPadHorizontal"},
    {"DPadV", "DPadVertical"},
    {"Triggers", "Triggers"}
  };
}