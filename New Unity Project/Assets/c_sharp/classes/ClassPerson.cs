
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Constants;

public class ClassPerson
{
  // Character variables
  private float m_movementSpeed = 1.0f;
  private CHARACTER_STATUS m_statusFSM = CHARACTER_STATUS.IDLE;
  private float m_healthLife = 100.0f;
  Rigidbody2D m_rigidBody;

  //=========================================================================
  // Setters and Getters
  //=========================================================================

  public float MovementSpeed
  {
    get { return m_movementSpeed; }
    set { 
      Assert.AreNotEqual(0, value);
      m_movementSpeed = value; 
    }
  }

  public CHARACTER_STATUS StatusFSM
  {
    get { return m_statusFSM; }
    set { 
      Assert.IsTrue(value == CHARACTER_STATUS.IDLE || 
                    value == CHARACTER_STATUS.IN_AIR || 
                    value == CHARACTER_STATUS.WALKING || 
                    value == CHARACTER_STATUS.RUNNING, 
                    "Invalid ClassPerson Status State: " + value);
      m_statusFSM = value; 
    }
  }  

  //=========================================================================
  // Setters and Getters
  //=========================================================================

  public void UpdateState(bool isGrounded, bool isWalking)
  {
    switch(StatusFSM){
      case CHARACTER_STATUS.IDLE:
        break;
      case CHARACTER_STATUS.WALKING:
        break;
      default:
        Debug.LogError("UpdateState: undefined state " + StatusFSM);
        StatusFSM = CHARACTER_STATUS.IDLE;
        break;
    }
  }

  public void UpdateMovement(float h, float v)
  {
    m_rigidBody.velocity = new Vector2(h*MovementSpeed, v*MovementSpeed);
  }

  public ClassPerson(Rigidbody2D rb, float speed)
  {
    m_rigidBody = rb;
    MovementSpeed = speed;
  }

}
