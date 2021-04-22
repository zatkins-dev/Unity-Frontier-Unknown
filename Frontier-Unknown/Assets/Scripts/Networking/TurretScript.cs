using UnityEngine;
using Mirror;
using TMPro;

public class TurretScript : MonoBehaviour
{
    [Header("Prefabs")]
    //bullet
    public GameObject m_bullet;

    [Header("Reference")]
    //Reference
    public Transform m_attackPoint;

    [Header("Turrent Stats")]
    //bullet force
    public float m_force;

    //gun stats
    public float m_interBurstDelay, m_shotDelayInBurst, m_spreadRadius, m_reloadTime;
    public int m_magazineSize, m_bulletsPerTap;
    public bool m_isAutomatic;
    public int m_weaponLife;

    protected int m_bulletsLeft;
    protected int m_bulletsShot;

    //bools
    protected bool m_shooting, m_ready, m_reloading;

    protected ShipScript m_ship;
    protected bool m_lock = false;


    [Header("Graphics & Sound")]
    //Graphics
    public GameObject m_muzzleFlash;
    public TextMeshProUGUI m_ammunitionGUI;
    public int Ammo() => m_bulletsLeft;
    //sfx
    protected AudioSource m_soundEffects;
    private void Awake()
    {
        //fill magazine
        m_bulletsLeft = m_magazineSize;
        m_ready = true;
    }

    private void Start()
    {
        m_soundEffects = GetComponent<AudioSource>();
    }

    private void Update()
    {

    }

    public void SetShip(ShipScript ship) {
        m_ship = ship;
    }

    public Vector3 GetBulletDirection() {
        float x = Random.Range(-m_spreadRadius, m_spreadRadius);
        float y = Random.Range(-m_spreadRadius, m_spreadRadius);

        //new direction with spread
        return (m_attackPoint.forward + new Vector3(x, y, 0)).normalized;
    }

    public void Fire() {
        Debug.Log("Fire called in turret");
        if (m_ready && !m_reloading && m_bulletsLeft <= 0)
            Reload();

        //shooting
        if (!m_ready || m_reloading || m_bulletsLeft <= 0) return;
        m_soundEffects.Play();
        m_bulletsShot = 0;

        Shoot();
    }

    public void Reload() {
        if (m_bulletsLeft < m_magazineSize && !m_reloading) {
            StartReload();
        }
    }

    protected virtual void CreateBullet()
    {
        m_ship.CmdCreateTurretBullet(m_bullet, m_attackPoint.position, m_attackPoint.rotation, m_force);
    }

    protected void Shoot()
    {
        Debug.Log("Shooting in turret");
        m_ready = false;
        if (m_lock) { return; }
        CreateBullet();
        //if (bullet) { Destroy(bullet, 20f); }

        GameObject flash = null;
        if (m_muzzleFlash != null)
            flash = Instantiate(m_muzzleFlash, m_attackPoint.position, Quaternion.identity);
        if (flash) { Destroy(flash, 4f); }

        m_bulletsLeft--;
        m_bulletsShot++;

        Invoke(nameof(ResetShot), m_interBurstDelay);

        if (m_bulletsShot < m_bulletsPerTap && m_bulletsLeft > 0)
            Invoke(nameof(Shoot), m_shotDelayInBurst);
        
        if (m_ammunitionGUI != null)
            m_ammunitionGUI.SetText(m_bulletsLeft + " / " + m_magazineSize);
    }

    protected void ResetShot()
    {
        m_ready = true;
    }

    protected void StartReload()
    {
        m_reloading = true;
        Invoke(nameof(ReloadFinished), m_reloadTime);
    }

    protected void ReloadFinished()
    {
        m_bulletsLeft = m_magazineSize;
        m_reloading = false;
    }

    public void Reset() 
    {
        m_lock = true;
        m_bulletsLeft = m_magazineSize;
        m_bulletsShot = 0;
        m_ready = true;
        m_reloading = false;
        m_lock = false;
    }
}
