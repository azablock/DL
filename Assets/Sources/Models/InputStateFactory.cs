public class InputStateFactory {

  public static ButtonPressedInputState ButtonPressed(string buttonName) {
    return new ButtonPressedInputState(JoystickInputUtils.Buttons[buttonName]);
  }

  public static InputState AxisTriggered(string axisName) {
    return new AxisTriggeredInputState(JoystickInputUtils.Axes[axisName]);
  }
}