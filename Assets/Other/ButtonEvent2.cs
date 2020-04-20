using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonEvent2 : MonoBehaviour {
    //public Sprite sprite;
    //public Image image3;

    void Start() {
        //初期画像表示処理
        /*
        //画像読み込み
        Sprite image1 = Resources.Load<Sprite>("Image/matu.jpg");
        //Sprite[] image = Resources.LoadAll<Sprite>("Images/enemy/");//フォルダごとまとめて読込み

        //器のゲームオブジェクトを作成。引数はオブジェクト名
        GameObject work_image = new GameObject("WorkImage");

        //work_image.GetComponent<Image>().sprite = Sprite.Create(image, new Rect(0, 0, 320, 240), Vector2.zero);
        work_image.AddComponent<Image>().sprite = Sprite.Create(image1, new Rect(0, 0, 320, 240), Vector2.zero);

        //作ったゲームオブジェクトをCanvasの子にします。これしないと表示されない
        work_image.transform.parent = GameObject.Find("Canvas").transform;
        */
        /*
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.sprite = sprite;

       // image3.sprite = sprite;

        Image image2;

        image2 = GetComponent<Image>();        */
    }



    //Image image;

    public AudioClip Laugh1;
    public AudioClip Laugh2;

    public AudioClip impact;
    public AudioSource audio;

    public string text;

    public void Laugh_1() {
        Debug.Log("Laugh1");

        audio = GetComponent<AudioSource>();

        //audio.PlayOneShot(Laugh1);
        audio.Play();


        //GetComponent<AudioSource>().PlayOneShot(Laugh1);

        //Destroy(GetComponent<AudioSource>());

        //  Destroy(Laugh1);
        // Destroy(Laugh2);
        //image.sprite = sprite;

        //GetComponent<Image>().sprite = Sprite.Create(image, new Rect(0, 0, 320, 240), Vector2.zero);
        /*
        GameObject image_g = new GameObject("WorkImage");
        image_g.transform.parent = GameObject.Find("Canvas").transform;
        image_g.AddComponent<Image>().anchoredPosition = new Vector3(0, 0, 0);
        image_g.AddComponent().sprite = Resources.Load("counter");
    */
        //image_g.AddComponent<Image>().sprite = Sprite.Create(image, new Rect(0, 0, 320, 240), Vector2.zero);

        // audio.Stop();

        //this.GetComponent<Text>().text = "点数";
        // this.GameObject<Text>.Find("Canvas").text = "ok";

        //text = "aa";
        //guiText.text = "カウンター：";
        //GameObject childText = gameObject.transform.FindChild("Text").gameObject;
        //childText.text = "aa";
        //GetComponent<GUIText>().text = "こんにちは";

        if (audio.mute) {
            audio.mute = false;
        } else {
            audio.mute = true;
        }


    }

    public void Laugh_2() {
        Debug.Log("Laugh2");

        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(Laugh2, 0.7F);



        if (audio.mute) {
            audio.mute = true;
        } else {
            audio.mute = false;
        }
        //Destroy(audio);

        //GetComponent<AudioSource>().PlayOneShot(Laugh2);

        //Destroy(GetComponent<AudioSource>().PlayOneShot(Laugh1));
        //Destroy(Laugh1);
    }
    /*
    public void Cry() {
        Debug.Log("Cry");
    }*/


    public void Laugh_3() {
        Debug.Log("Laugh3");
        //GetComponent<AudioSource>().Pause();
        //Stop();
        audio = GetComponent<AudioSource>();
        audio.mute = true;

        //Destroy(GetComponent<AudioSource>().PlayOneShot(Laugh1));
        Destroy(audio);
    }
}

