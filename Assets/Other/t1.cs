using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class t1 : MonoBehaviour {

    public Sprite sprite;
    private Image Image;
    private GameObject obj;
    
    // Use this for initialization
    void Start () {
        Debug.Log("1");
        //SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        //renderer.sprite = sprite;

        //xxxImage = GameObject.Find("XxxImage").GetComponent<Image>();
        //xxxImage.sprite = "切り替えたい画像";
        /*
        obj = GameObject.Find("Top").gameObject as GameObject;
        image = obj.GetComponent<Image>();
        */
        Debug.Log("2");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
