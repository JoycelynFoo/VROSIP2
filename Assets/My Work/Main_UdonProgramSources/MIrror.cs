
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MIrror : UdonSharpBehaviour
{
    public GameObject mirror;
    public bool mirrorOn;
    

    public override void Interact()
    {
        if(mirrorOn == false)
        {
            mirror.SetActive(true);
            mirrorOn = true;
        }
        else
        {
            mirror.SetActive(false);
            mirrorOn = false;
        }
       

    }
}
