
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class CubeButtonUp : UdonSharpBehaviour
{
    public Rigidbody ball;
    public float moveSpeed = 1f;
    private bool up;
    private bool back;
    private bool left;
    private bool right;


    private void Update()
    {
        if (up == true)
        {
            MoveBall(Vector3.forward);
            Debug.Log("ball moving forwards");
        }
        if (back == true)
        {
            MoveBall(Vector3.back);
        }
        if (left == true)
        {
            MoveBall(Vector3.left);
        }
        if (right == true)
        {
            MoveBall(Vector3.right);
        }

    }

    public override void Interact()
    {
        if (gameObject.name.Contains("Up"))
        {
            up = true;
            //ball(Vector3.forward);
        }
        if (gameObject.name.Contains("Down"))
        {
            back = true;
        }
        if (gameObject.name.Contains("Right"))
        {
            right = true;
        }
        if (gameObject.name.Contains("Left"))
        {
            left = true;
        }
    }

    void MoveBall(Vector3 direction)
    {
        ball.AddForce(direction * moveSpeed, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        // Check if the ball's velocity is too low
        if (ball.velocity.magnitude < 0.1f)
        {
            // Apply a force to get the ball moving again
            ball.AddForce(new Vector3(1f, 0f, 1f), ForceMode.Impulse);
        }
    }
}
