using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(ShipScript))]
public class NetworkShip : MonoBehaviour
{
    [SerializeField] private GameObject _shipGameObject;
    // Start is called before the first frame update
    void Start()
    {
        _shipGameObject.transform.Rotate(0, 90.0f, 0);
        var input = GetComponent<PlayerInput>();
        foreach (MeshCollider col in GetComponentsInChildren<MeshCollider>())
        {
            col.convex = true;
        }
        tag = "Ship";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
