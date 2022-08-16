using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMainCamera : MonoBehaviour
{
  public GameObject Player;
  Vector3 CurrentPosition;
  // Start is called before the first frame update
  void Start()
  {
    Player = GameObject.FindWithTag("Player");
    CurrentPosition = new Vector3(0, 0, -10);
    CurrentPosition.x = Player.transform.position.x;
    CurrentPosition.y = Player.transform.position.y;
  }

  // Update last
  void LateUpdate()
  {
    transform.position = CurrentPosition;
    CurrentPosition.x = Player.transform.position.x;
    CurrentPosition.y = Player.transform.position.y;
  }
}
