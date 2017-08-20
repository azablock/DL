using UnityEngine;

public class DebugInputCommand : InputCommand {

  private readonly string _message;

  public DebugInputCommand(string message) {
    _message = message;
  }

  public override void Execute(GameObject gameObject) {
    Debug.Log(string.Format("{0} {1}", gameObject.name, _message));
  }
}