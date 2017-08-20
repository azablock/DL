using System;
using UnityEngine;

public class AxisTriggeredInputState : InputState {

  private readonly string _axisName;

  public AxisTriggeredInputState(string axisName) {
    _axisName = axisName;
  }

  public bool IsPresent() {
    var axisName = JoystickInputUtils.Axes[_axisName];
    return Math.Abs(Input.GetAxis(axisName)) > 0.0f;
  }
}