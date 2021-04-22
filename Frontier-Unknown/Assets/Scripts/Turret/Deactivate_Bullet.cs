using UnityEngine;

public class Deactivate_Bullet : MonoBehaviour
{
    public float time_to_live;
    private float time_left;
    // Start is called before the first frame update
    void OnEnable()
    {
        time_left = time_to_live;
    }

    private void Update()
    {
        time_left -= Time.deltaTime;
        if (time_left <= 0f)
        {
            gameObject.SetActive(false);
        }
    }
}
