using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected PlayerMotor motor;

    [SerializeField]
    protected float mouseSensitivity;
    
    [SerializeField]
    protected float speed;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 horizontal = xMov * transform.right;
        Vector3 vertical = zMov * transform.forward;
        Vector3 velocity = (vertical + horizontal).normalized * speed;

        motor.Move(velocity);

        float yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 rotationHorizontal = new Vector3(0, yRotation, 0) * mouseSensitivity;
        motor.RotateHorizontal(rotationHorizontal);

        float xRotation = Input.GetAxisRaw("Mouse Y");
        Vector3 rotationVertical = new Vector3(xRotation, 0, 0) * mouseSensitivity;
        motor.RotateVertical(rotationVertical);
    }
}
