using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LaserSight : MonoBehaviour
{
    private LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);
        RaycastHit hit;
        float distance = 5000f;
        if (Physics.Raycast(transform.position, transform.forward, out hit)) {
            distance = hit.distance;
        } 
        lr.SetPosition(1, transform.position + distance*transform.forward);
    }
}
