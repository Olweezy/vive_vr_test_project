using UnityEngine;
using System.Collections;
using Valve.VR;

public class ControllerMenu : MonoBehaviour {

    SteamVR_TrackedObject obj;

    public GameObject buttonHolder;

    public bool buttonEnabled;

	// Use this for initialization
	void Awake () {
        obj = GetComponent<SteamVR_TrackedObject>();
        buttonHolder.SetActive(false);
        buttonEnabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	    var device = SteamVR_Controller.Input((int)obj.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            if (buttonEnabled == false)
            {
                buttonHolder.SetActive(true);
                buttonEnabled = true;
            }
            else if (buttonEnabled == true)
            {
                buttonHolder.SetActive(false);
                buttonEnabled = false;
            }
        }
	}
}
