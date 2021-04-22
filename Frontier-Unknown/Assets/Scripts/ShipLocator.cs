using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShipLocator : ScriptableObject
{
    private static ShipLocator _singleton;
    private IEnumerable<ShipScript> _ships;
    public struct ShipData
    {
        public Vector3 Pos;
        public int TeamID;
    }

    public IEnumerable<ShipData> locations
    {
        get
        {
            RebuildShipList();
            return _ships.Select((s) => new ShipData
            {
                Pos = s.transform.position, TeamID = s.TeamID
            });
        }
    }

    public static ShipLocator Singleton {
        get {
            if (_singleton == null) {
                _singleton = FindObjectOfType<ShipLocator>();
            }
            if (_singleton == null) {
                _singleton = CreateInstance<ShipLocator>();
                _singleton.CreateShipLocator();
            }
            return _singleton;
        }
    }

    void CreateShipLocator() {
        RebuildShipList();
    }

    // VERY SLOW, CALL ONLY WHEN NECESSARY
    public void RebuildShipList() {
        _ships = GameObject.FindGameObjectsWithTag("Ship").Where((s)=>s.GetComponent<ShipScript>()!=null).Select((s)=>s.GetComponent<ShipScript>());
    }
}
