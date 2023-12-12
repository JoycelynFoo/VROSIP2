
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using VRC.SDKBase;
using VRC.Udon;

public class Interactable : UdonSharpBehaviour
{
    private bool gotSandBags = false;
    private int sandBags = 0; 
    public TextMeshPro scoreText;

    public GameObject glassWall;
    public GameObject glassDoor;

    private void Update()
    {   
        if (sandBags == 3)
        {
            Destroy(glassDoor);
            Destroy(glassWall);
        }

        if(gotSandBags == true)
        {
            gotSandBags = false;
            sandBags += 1;
            scoreText.text = sandBags.ToString();
            Debug.Log(sandBags);
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("sandBag"))
        {
            gotSandBags = true;

            //check if 3 bags are in, in yes, destroy glass and sand bag
            //Destroy(gameObject);

            //sandBags += 1 ;
            //Debug.Log(sandBags);
            //ChangeScore(1);

            //if(sandBags >= minimumSandBags)
            //{
            //   Destroy(gameObject);
            //}
        }
        //if (other.gameObject.name.Contains("SandBagDeadZone"))
        //{
        //    Destroy(gameObject);
        //}

        // if (sandBagHit == false)
        //{
        //    sandBag.SetActive(true);
        //    sandBagHit = false;
        //}
        //else
        //{
        //    sandBag.SetActive(false);
        //    sandBagHit = true;
        //}
    }
}
