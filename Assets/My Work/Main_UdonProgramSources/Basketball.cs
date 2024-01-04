
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using TMPro;

public class Basketball : UdonSharpBehaviour
{
    private bool ballIn = false;
    private int balls = 0;
    public TextMeshPro scoreTextBall;
    public GameObject wall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("bball"))
        {
            ballIn = true;
        }
    }


    private void Update()
    {
        if (balls == 3)
        {
            Destroy(wall);
            Debug.Log("3 balls are in");
        }
        if (ballIn == true)
        {
            ballIn = false;
            balls += 1;
            scoreTextBall.text = balls.ToString();
            Debug.Log(balls);
        }
    }
}
