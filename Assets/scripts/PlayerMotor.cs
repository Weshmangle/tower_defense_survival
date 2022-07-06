using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    [SerializeField]
    protected Camera camera;
    protected Rigidbody rigidbody;
    protected Vector3 m_velocity;
    protected Vector3 m_rotationHorizontal;
    protected Vector3 m_rotationVertical;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        PerformMovement();
        PerformRotation();
    }

    public void Move(Vector3 velocity)
    {
        m_velocity = velocity;
    }

    public void RotateHorizontal(Vector3 rotation)
    {
        m_rotationHorizontal = rotation;
    }

    public void RotateVertical(Vector3 rotation)
    {
        m_rotationVertical = rotation;
    }

    protected void PerformMovement()
    {
        if(m_velocity != Vector3.zero)
        {
            rigidbody.MovePosition(rigidbody.position + m_velocity * Time.deltaTime);
        }
    }

    protected void PerformRotation()
    {
        rigidbody.MoveRotation(rigidbody.rotation * Quaternion.Euler(m_rotationHorizontal));
        camera.transform.Rotate(-m_rotationVertical);
    }
}
