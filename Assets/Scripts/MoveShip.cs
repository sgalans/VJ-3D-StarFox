using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MoveShip : MonoBehaviour
{
    public float forwardSpeed, horizontalSpeed;
    public InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 velocity = transform.forward * forwardSpeed;

        Vector2 input = moveAction.ReadValue<Vector2>();

        velocity += input.x * horizontalSpeed * transform.right;

        Vector3 pos = transform.position + velocity * Time.fixedDeltaTime;
        if (pos.x > 2.0f)
            pos.x = 2.0f;
        if (pos.x < -2.0f)
            pos.x = -2.0f;

        GetComponent<Rigidbody>().MovePosition(pos);
    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnEnable()
    {
        moveAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }
}
