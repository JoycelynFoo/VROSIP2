
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Basketball : UdonSharpBehaviour
{
    private bool ballIn = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("bball"))
        {
            ballIn = true;
            Debug.Log("Bball In");
        }
    }

}
