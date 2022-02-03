using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float SpeedShip;
    float ChangeSpeed = 0.05f;
    Vector2 vertical = Vector2.zero;
    Vector2 newPos;
    PlayerControls controls;

    void Awake()
    {
        controls = new PlayerControls();

        controls.Player.Move.performed += context => vertical = context.ReadValue<Vector2>();
        controls.Player.Move.canceled += context => vertical = Vector2.zero;
    }

    private void Start()
    {
        
    }

  

     void Movement()
    {
        Vector2 currentPosition = new Vector2(Mathf.Abs(gameObject.transform.position.x), Mathf.Abs(gameObject.transform.position.y));
        SpeedShip = Mathf.Clamp(SpeedShip + ChangeSpeed, 0f, 3f);
        newPos = currentPosition + (vertical * SpeedShip);
        transform.Translate(newPos * Time.fixedDeltaTime);


    }

    public void RotateTowardDirection()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
        if(vertical.magnitude < 0.1f)
        {
            newPos = vertical * SpeedShip;
        }

        

    }


     void OnEnable()
    {
        controls.Player.Enable();
    }
     void OnDisable()
    {
        controls.Player.Disable();
    }
}
