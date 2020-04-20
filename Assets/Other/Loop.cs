using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loop : MonoBehaviour {
    
    public Toggle toggle;
    public string tog;

    void Start (){
        toggle = GetComponent<Toggle>();
        Debug.Log(toggle.isOn);
        if (toggle.isOn) {
            tog = "on";
            Debug.Log(tog);
        }
    }

    public void test() {
        tog = "www";
        string d = "da";
        Debug.Log(d);
    }

    public void to() {
        toggle = GetComponent<Toggle>();

        if (toggle.isOn) {
            string a = "on";
            tog = "on";
            Debug.Log(a);
        }
        Debug.Log(toggle.isOn);
    }
	
	/*
	void Update () {
        Debug.Log(toggle.isOn);
    }*/
}
