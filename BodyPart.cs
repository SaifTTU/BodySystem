using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    public string name;
    public string description;
    public string secondaryDescription;

    public List<GameObject> joint = new List<GameObject>();

    bool jointsCreated = false;

    // Start is called before the first frame update
    void Start()
    {
        name = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision){
        if(collision.gameObject.tag=="BodyPart"){
            if(jointsCreated==false)    
                CreateJoint(collision.gameObject, gameObject);
            
        }
    }

    void CreateJoint(GameObject toBeAttached, GameObject self){
        if(joint.Contains(toBeAttached)==false){
                joint.Add(toBeAttached);
        }
    }
}
