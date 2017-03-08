using UnityEngine;
using System.Collections;

public class toriel : MonoBehaviour {
    // Use this for initialization
    public bool flag = true;
    public GameObject thing;
    void Start () {
           
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            flag = !flag;
        }
        thing.SetActive(flag);


    }
}
