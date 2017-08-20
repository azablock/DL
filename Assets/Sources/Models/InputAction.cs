public class InputAction {

  public InputAction(InputState inputState, InputCommand inputCommand) {
    InputState = inputState;
    InputCommand = inputCommand;
  }

  public InputState InputState { get; private set; }
  public InputCommand InputCommand { get; private set; }
}