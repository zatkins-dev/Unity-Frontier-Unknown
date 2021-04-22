using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    // Start is called before the first frame update

    float timer = 0;
    public float speed;
    public float width;
    public float height;
    public float y;
 
    void Start()
    {
        speed = .75f;
        width = 100;
        height = 100;
        y = 75f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*speed;

       
        float z = Mathf.Sin(timer) * height;
        float x = Mathf.Cos(timer) * width;
        transform.position = new Vector3(x, y, z); 

    }
}
