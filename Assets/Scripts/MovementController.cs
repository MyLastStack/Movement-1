using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    // Input variables
    public InputAction moveAction, rotateAction;

    Vector2 moveValue, rotateValue;

    // Movement variables
    float movementSpeed, rotationSpeed;

    [SerializeField] GameObject weapon;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize movement variable;
        movementSpeed = 3.0f;
        rotationSpeed = 300.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Get player input
        moveValue = moveAction.ReadValue<Vector2>();
        rotateValue = rotateAction.ReadValue<Vector2>();

        // Rotate player and weapon
        transform.Rotate(Vector3.up, rotateValue.x * rotationSpeed * Time.deltaTime);

        weapon.transform.Rotate(Vector3.right, rotateValue.y * rotationSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        // Move the object
        transform.Translate(new Vector3(moveValue.x, 0, moveValue.y) * movementSpeed * Time.deltaTime);
}

    private void OnEnable()
    {
        moveAction.Enable();
        rotateAction.Enable();
    }
    private void OnDisable()
    {
        moveAction.Disable();
        rotateAction.Disable();
    }
}
