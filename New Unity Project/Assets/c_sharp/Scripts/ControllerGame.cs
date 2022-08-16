using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGame : MonoBehaviour
{
  public GameObject Player;
  public GameObject Camera;
  public GameObject m_userInterface;
  // Start is called before the first frame update
  void Start()
  {
    Player = GameObject.FindWithTag("Player");
    Camera = GameObject.FindWithTag("MainCamera");

    // TODO
    // m_userInterface = GameObject.FindWithTag("HUD");
  }

  // Update is called once per frame
  void Update()
  {
    
  }
}
