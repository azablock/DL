using UnityEngine;

public class ButtonPressedInputState : InputState {

  private readonly KeyCode _keyCode;

  public ButtonPressedInputState(KeyCode keyCode) {
    _keyCode = keyCode;
  }

  public bool IsPresent() {
    return Input.GetKeyDown(_keyCode);
  }
}