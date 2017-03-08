using UnityEngine;
using System.Collections;

public class fly : MonoBehaviour {
    public float acceleration = 1f;
    public int counter = 0;
    public AudioSource nyoom;
    public AudioSource nyoom2;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 v = gameObject.transform.TransformDirection(Vector3.forward);
        Vector3 vr = gameObject.transform.TransformDirection(Vector3.right);

        if (Input.GetKey(KeyCode.Joystick1Button0)){
            gameObject.GetComponent<Rigidbody>().velocity = v*(gameObject.GetComponent<Rigidbody>().velocity.magnitude + acceleration);
            if(counter%12 == 0)
                nyoom.Play();
        }
        counter++;
        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            gameObject.GetComponent<Rigidbody>().velocity = v * (gameObject.GetComponent<Rigidbody>().velocity.magnitude - acceleration);
            if (counter % 12 == 0)
                nyoom2.Play();
        }
        gameObject.GetComponent<Rigidbody>().velocity = v * (gameObject.GetComponent<Rigidbody>().velocity.magnitude);


        Vector3 inDirection = Vector3.zero;
        inDirection.z = Input.GetAxis("Oculus_GearVR_LThumbstickY");
        inDirection.x = Input.GetAxis("Oculus_GearVR_RThumbstickX");

        Vector3 inDirectionR = Vector3.zero;
        inDirectionR.x = Input.GetAxis("Oculus_GearVR_LThumbstickX");

        if (Mathf.Abs(inDirection.z) > 0.1f)
        {
            gameObject.GetComponent<Rigidbody>().rotation *= Quaternion.Euler(Vector3.right * inDirection.z*.4f);

        }
        if (Mathf.Abs(inDirection.x) > 0.1f)
        {
            gameObject.GetComponent<Rigidbody>().rotation *= Quaternion.Euler(Vector3.forward * -1 * inDirection.x*.4f);
        
        }
        if (Mathf.Abs(inDirectionR.x) > 0.1f)
        {
            gameObject.GetComponent<Rigidbody>().rotation *= Quaternion.Euler(Vector3.up * inDirectionR.x * .4f);

        }



    }
}
