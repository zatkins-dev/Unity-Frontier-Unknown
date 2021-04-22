using Mirror;
using TMPro;
using UnityEngine;
using System;

public class JoinInputScript : MonoBehaviour
{
    public TMP_Text ipInput;
    public void OnIPEndEdit() {
        ipInput.color = (Color.black); 
        string[] ipStringArr = ipInput.text.Split('.');
        int[] ipIntArr = new int[ipStringArr.Length];
        if (ipInput.text.Split('.').Length != 4)
        {
            Debug.Log("wrong length");
            ipInput.color = (Color.red); 
            return;
        }
        string text = ipInput.text.Substring(0,ipInput.text.Length-1);
        foreach (string str in text.Split('.')) {
            string part = str.Replace("\n", "").Replace("\t", "").Replace(" ", "");
            Debug.Log(part.Length);
            int val = Convert.ToInt32(part);
            Debug.Log(val);
            if (val < 0 || val > 256) {
                Debug.Log("bad val");
                ipInput.color = Color.red; 
                return;
            }
        }
        NetworkManager.singleton.networkAddress = text;
    }

    public void ButtonJoin() {
        try {
            NetworkManager.singleton.StartClient();
        } catch {
            NetworkManager.singleton.StopClient();
        }
    }
}
