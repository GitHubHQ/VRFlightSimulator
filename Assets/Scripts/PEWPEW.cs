using UnityEngine;
using System.Collections;

public class PEWPEW : MonoBehaviour {
    public AudioSource pewSound;
    public int fireRate = 0;
    public GameObject projectile;
    public bool canFire = true;
    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        RaycastHit hit;
        Ray pew = new Ray(gameObject.transform.position, gameObject.transform.forward);
        if(fireRate%40 == 0)
        {
            canFire = true;
        }else
 
        if (Input.GetAxis("Oculus_GearVR_RIndexTrigger")!= 0) 
        {
            if (canFire)
            {
                canFire = false;
                Vector3 pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y , gameObject.transform.position.z)+gameObject.transform.forward*7;
                GameObject clone = (GameObject)Instantiate(projectile, pos, gameObject.transform.rotation);

                clone.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity + clone.transform.forward*10;
                pewSound.Play();
            }
//            if (Physics.Raycast(pew, out hit))
 //           {
 //               if (hit.collider.tag == "ball")
     //            {
                   // Destroy(hit.transform.gameObject);
  //              }

//            }
        }
        fireRate++;

    }
}
