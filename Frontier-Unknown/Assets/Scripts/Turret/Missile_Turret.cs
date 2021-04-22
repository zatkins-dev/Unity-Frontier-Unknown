using Mirror;
using UnityEngine;
using UnityEngine.InputSystem;


public class Missile_Turret : TurretScript
{
    [Header("Graphics & Sound")]
    //Graphics

    //sfx
    public float xSensitivity = 1.0f;
    public  float ySensitivity = 1.0f;

    Vector3 angles;

    
    private void Awake()
    {
        //fill magazine
        m_bulletsLeft = m_magazineSize;
        m_ready = true;
        m_soundEffects = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
    }

    Transform Raycast(Transform src)
    {
        if (Physics.Raycast(src.position, src.forward, out var hit,LayerMask.GetMask($"Team{m_ship.TeamID}")))
        {
            if (hit.collider == null) return null;
            return hit.collider.transform;
        }

        return null;
    }

    protected override void CreateBullet()
    {
        var target = Raycast(Camera.main.transform);
        if (target != null)
            Debug.Log($"Turret aiming at: {target.gameObject.name}");
        m_ship.CmdCreateMissileBullet(m_bullet, m_attackPoint.position, m_attackPoint.rotation, target);
    }
}
