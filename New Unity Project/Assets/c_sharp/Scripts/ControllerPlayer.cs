using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
  public float Speed = 1.0f;
  
  ClassPlayer m_player;

  // Start is called before the first frame update
  void Start()
  {
    m_player = new ClassPlayer(GetComponent<Rigidbody2D>(), Speed);
  }

  // Evaluates player movement from keyboard control
  void EvalMovement()
  {
    float h = Input.GetAxisRaw("Horizontal");
    float v = Input.GetAxisRaw("Vertical");
    m_player.UpdateMovement(h, v);
  }

  // Update is called once per frame
  void Update()
  {
    EvalMovement();
  }

  void FixedUpdate()
  {
    // m_player.UpdateState(m_isGrounded, m_isWalking); // Only called once
    Debug.Log("STATUS_STATE = " + m_player.StatusFSM);
    // ApplyAnimation();
  }
}
