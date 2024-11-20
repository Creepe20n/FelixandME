using UnityEngine;

public class Movement : MonoBehaviour
{
    Ipatsch inputActions;
    public float Speeeeed;
    public Rigidbody2D fly;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputActions = new();
        inputActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {// Vector2 AD wurde nun inputActions.Movement zugewisen
     // und bildet den Output in der klammer ab.

        Vector2 AD = inputActions.Movememt.AD.ReadValue<Vector2>();
        transform.Translate(AD.x * Speeeeed * Time.deltaTime, 0, 0);

        if (inputActions.Movememt.Jump.triggered)
        {
            fly.AddForce.
        }

    }
}
