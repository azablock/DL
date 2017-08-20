using UnityEngine;

public abstract class InputCommand {
  public delegate void InputExecution(GameObject gameObject);
  public event InputExecution InputExecutionEvent;

  protected InputCommand() {
    InputExecutionEvent += Execute;
  }

  public abstract void Execute(GameObject gameObject);

  protected virtual void OnInputExecutionEvent(GameObject gameObject) {
    var handler = InputExecutionEvent;
    if (handler != null) handler(gameObject);
  }
}