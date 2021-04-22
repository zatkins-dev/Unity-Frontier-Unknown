using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;


[Serializable] public enum ProjectileType
{
    Missile,
    Turret
}
public class ProjectileTeam : NetworkBehaviour
{
    [SyncVar] public int TeamID;
    [SerializeField] private ProjectileType _type;
    public ProjectileType Type => _type;
}
