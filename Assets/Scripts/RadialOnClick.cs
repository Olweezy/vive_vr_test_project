using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using VRTK;

public class RadialOnClick : MonoBehaviour
{
    private int buttonIndex;
    public List<GameObject> Blocks;
    VRTK_InteractGrab grabbingController;

    void Start()
    {
       
    }

    // Use this for initialization
    void onClick()
    {
        AttachBlockToController(buttonIndex);
    }

    // Update is called once per frame
    void Update() {
       
	}

    public void AttachBlockToController(int buttonIndex)
    {
        grabbingController = GameObject.Find("Controller (left)").GetComponent<VRTK_InteractGrab>();
        //Check if already holding an object before instantiating a new one
        if (grabbingController.GetGrabbedObject() == null)
        {
            var selectedBlock = Instantiate(Blocks[buttonIndex]);

            //Find the left controller and force it to touch the instantiated object
            grabbingController.gameObject.GetComponent<VRTK_InteractTouch>().ForceTouch(selectedBlock);
            //Grab touched object
            grabbingController.AttemptGrab();
        }
    }
}
