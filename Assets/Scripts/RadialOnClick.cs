using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using VRTK;

public class RadialOnClick : MonoBehaviour
{
    public int buttonIndex;
    public List<GameObject> Blocks;
    VRTK_InteractGrab grabbingController;

    void Start()
    {
       
    }

    // Use this for initialization
    void onClick()
    {
        buttonIndex = 0;
        AttachBlockToController(buttonIndex);
    }

    // Update is called once per frame
    void Update() {
       
	}

    public void AttachBlockToController(int buttonIndex)
    {
        var selectedBlock = Instantiate(Blocks[buttonIndex]);

        Debug.Log("Here is the selected block {0}", selectedBlock);
        selectedBlock.transform.SetParent(GameObject.Find("Controller (left)").transform);
        selectedBlock.transform.position = selectedBlock.transform.parent.localPosition;
        grabbingController = selectedBlock.GetComponentInParent<VRTK_InteractGrab>();
        grabbingController.gameObject.GetComponent<VRTK_InteractTouch>().ForceTouch(selectedBlock);
        grabbingController.AttemptGrab();
        
        Debug.Log(grabbingController.GetGrabbedObject());
    }
}
