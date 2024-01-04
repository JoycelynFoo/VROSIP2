
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
using TMPro;

public class Basketball : UdonSharpBehaviour
{
    private bool ballIn = false;
    private int balls = 0;
    public TextMeshPro scoreTextBall;

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
