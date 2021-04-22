using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    /* Begin
     * Missile Variables
     */

    [Header("Missile Variables")]
    public Transform missileTarget;
    public Rigidbody missileRigidBody;

    public float turnSpeed = 1f;
    public float missileSpeed = 10f;
    Vector3 directionToFace;
    private Transform missileLocalTransform;


    /* End
    * Missile Variables
    */

    private void Start()
    {
        if (!missileTarget)
        {
            Debug.Log("Forgot to set the missile target transform!");
        }

        //missileLocalTransform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        if (!missileRigidBody)
        {
            return;
        }

        missileRigidBody.velocity = transform.forward * missileSpeed;
        //var missileTargetRotation = Quaternion.LookRotation(missileTarget.position - missileLocalTransform.position);
        //missileRigidBody.MoveRotation(Quaternion.RotateTowards(missileLocalTransform.rotation, missileTargetRotation, turnSpeed));

        if(!missileTarget)
        {
            directionToFace = transform.forward * missileSpeed;
        }
        else
        {
            directionToFace = missileTarget.position - transform.position;
            transform.rotation = Quaternion.LookRotation(directionToFace);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
