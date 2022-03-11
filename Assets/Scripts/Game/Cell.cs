using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cell : MonoBehaviour
{
  public UnityEvent openCellEvent;

  public void Open()
  {
    openCellEvent?.Invoke();
  }
}
