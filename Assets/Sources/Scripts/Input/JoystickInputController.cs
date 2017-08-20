using System.Collections.Generic;
using UnityEngine;
using ISF = InputStateFactory;

public class JoystickInputController : MonoBehaviour {

  private readonly List<InputAction> _actions = new List<InputAction> {
    new InputAction(ISF.ButtonPressed("A"), new DebugInputCommand("A")),
    new InputAction(ISF.ButtonPressed("B"), new DebugInputCommand("B")),
    new InputAction(ISF.ButtonPressed("Y"), new DebugInputCommand("Y")),
    new InputAction(ISF.ButtonPressed("X"), new DebugInputCommand("X")),
    new InputAction(ISF.ButtonPressed("LB"), new DebugInputCommand("LB")),
    new InputAction(ISF.ButtonPressed("RB"), new DebugInputCommand("RB")),
    new InputAction(ISF.ButtonPressed("Back"), new DebugInputCommand("Back")),
    new InputAction(ISF.ButtonPressed("Start"), new DebugInputCommand("Start")),
    new InputAction(ISF.ButtonPressed("LeftStickPress"), new DebugInputCommand("LeftStickPress")),
    new InputAction(ISF.ButtonPressed("RightStickPress"), new DebugInputCommand("RightStickPress")),
    
    new InputAction(ISF.AxisTriggered("LStickH"), new DebugInputCommand("LStickH")),
    new InputAction(ISF.AxisTriggered("LStickV"), new DebugInputCommand("LStickV")),
    new InputAction(ISF.AxisTriggered("RStickH"), new DebugInputCommand("RStickH")),
    new InputAction(ISF.AxisTriggered("RStickV"), new DebugInputCommand("RStickV")),
    new InputAction(ISF.AxisTriggered("DPadH"), new DebugInputCommand("DPadH")),
    new InputAction(ISF.AxisTriggered("DPadV"), new DebugInputCommand("DPadV")),
    new InputAction(ISF.AxisTriggered("Triggers"), new DebugInputCommand("Triggers"))
  };

  private void Update() {
    _actions
      .FindAll(action => action.InputState.IsPresent())
      .ForEach(action => action.InputCommand.Execute(gameObject));
  }
}