using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityShifter : MonoBehaviour
{
    public Vector3 direction;
    public GameObject center;
    public GravityTest target;
    public Collider gravityCollider;
    public int type;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        FPController player = other.transform.GetComponent<FPController>();
        
        /*if (other.tag == "Player")
        {
            target = other.gameObject.GetComponent<GravityTest>();

            switch (type)
            {
                case 0:
                    Debug.Log("tripped0");
                    target.gravityCenter = center;
                    target.gravityMode = 0;
                    break;
                case 1:
                    Debug.Log("tripped1");
                    target.SetDirection(direction.x, direction.y, direction.z);
                    target.gravityMode = 1;
                    break;
                case 2:
                    Debug.Log("tripped2");
                    target.gravityCenterCollider = gravityCollider;
                    target.gravityMode = 2;
                    break;
                default:
                    break;
            }
            if (type == 0)
            {

            }
            if (type == 1)
            {
                Debug.Log("tripped1");
                target = other.gameObject.GetComponent<GravityTest>();
                target.SetDirection(direction.x, direction.y, direction.z);
                target.gravityMode = 1;
            }
            if (type == 2)
            {
                Debug.Log("tripped2");
                target = other.gameObject.GetComponent<GravityTest>();
                target.gravityCenterCollider = gravityCollider;
                target.gravityMode = 2;
            }
        }*/
    }
}
