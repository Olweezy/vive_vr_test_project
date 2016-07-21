using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RadialOnClick : MonoBehaviour
{
    public int buttonIndex;
    public List<GameObject> Blocks;

    // Use this for initialization
    void Start()
    {
        buttonIndex = 0;
        AttachBlockToController(buttonIndex);
    }

    // Update is called once per frame
    void Update() {
       
	}

    void AttachBlockToController(int buttonIndex)
    {
        var selectedBlock = Instantiate(Blocks[buttonIndex]);
        Debug.Log("Here is the selected block {0}", selectedBlock);
        selectedBlock.transform.SetParent(GameObject.Find("Controller (left)").transform);
        Debug.Log("selected block's parent {0}", selectedBlock.transform.parent);
    }
}
