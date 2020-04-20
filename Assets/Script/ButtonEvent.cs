using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;

[RequireComponent(typeof(AudioSource))]
public class ButtonEvent : MonoBehaviour {
    public AudioClip Laugh1, Laugh2, Laugh3,Laugh4,Laugh5, Laugh6, Laugh7, Laugh8, Laugh9, Laugh10, Laugh11, Laugh12, Laugh13, Laugh14, Laugh15, Laugh16, Laugh17, Laugh18, Laugh19, Laugh20, Laugh21;
    public AudioSource audio;
    public string text;
    public Toggle toggle_Mute;
    public ToggleGroup toggleGroup_Mute;
    public Toggle toggle_Loop;
    public ToggleGroup toggleGroup_Loop;
    public Toggle toggle_Random;
    public ToggleGroup toggleGroup_Random;
    private float timeleft;//数秒ごとの処理を行う際に使用

    public Sprite sp0;
    public Sprite sp1;
    public GameObject im;
    public Image image;

    public Texture2D texture;

    // 再生したいEffectのプレハブを指定する
    public GameObject Effect01 = null;

    void Start() {
        //読み込み時の画像表示
        //texture = Resources.Load("Image/Top2") as Texture2D;

        //im = GameObject.Find("../Image/Top2.jpg").gameObject as GameObject;
        // im = GameObject.Find("Image");
        //image = im.GetComponent<Image>();
        //image.sprite = sp0;
        //image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

         texture = Resources.Load("Top2") as Texture2D;
         image = GameObject.Find("Image").GetComponent<Image>();
         image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);

        GameObject obj_Mute = GameObject.Find("Mute");
        toggle_Mute = obj_Mute.GetComponent<Toggle>();
        toggleGroup_Mute = GetComponent<ToggleGroup>();

        GameObject obj_Loop = GameObject.Find("Loop");
        toggle_Loop = obj_Loop.GetComponent<Toggle>();
        toggleGroup_Loop = GetComponent<ToggleGroup>();

        GameObject obj_Random = GameObject.Find("Random");
        toggle_Random = obj_Random.GetComponent<Toggle>();
        toggleGroup_Random = GetComponent<ToggleGroup>();


        //タッチエフェクトを仮実装
        if(Input.GetMouseButtonDown(0)){
            // タッチした画面座標からワールド座標へ変換
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5.0f));
            // 指定したエフェクトを作成
            GameObject go = (GameObject)Instantiate(Effect01, pos, Quaternion.identity);
            // エフェクトを消す
            Destroy(go, 0.4f);
            Debug.Log("sss");
        }
    }

void Update() {
        //だいたい1秒ごとに処理を行う → 2秒～3秒ごとに変更
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0) {
            timeleft = 1.0f;
            if (toggle_Random.isOn) {
                Random();//だいたい1秒ごとにRandom()を呼び出す → 2秒～3秒ごとに変更
            }
        }
    }

    public void Random() {
        audio = GetComponent<AudioSource>();
        int iRandNum = UnityEngine.Random.Range(1, 21 + 1);//乱数を作成する・(x,y)のyには乱数の最大値+1
        if(iRandNum == 1) {
            InvokeRepeating("Laugh_1", 2, 2); //始めは2秒後、以後2秒毎に実行
        }else if (iRandNum == 2) {
            InvokeRepeating("Laugh_2", 2, 2); //始めは2秒後、以後2秒毎に実行
        }else if (iRandNum == 3) {
            InvokeRepeating("Laugh_3", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 4) {
            InvokeRepeating("Laugh_4", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 5) {
            InvokeRepeating("Laugh_5", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 6) {
            InvokeRepeating("Laugh_6", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 7) {
            InvokeRepeating("Laugh_7", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 8) {
            InvokeRepeating("Laugh_8", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 9) {
            InvokeRepeating("Laugh_9", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 10) {
            InvokeRepeating("Laugh_10", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 11) {
            InvokeRepeating("Laugh_11", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 12) {
            InvokeRepeating("Laugh_12", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 13) {
            InvokeRepeating("Laugh_13", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 14) {
            InvokeRepeating("Laugh_14", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 15) {
            InvokeRepeating("Laugh_15", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 16) {
            InvokeRepeating("Laugh_16", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 17) {
            InvokeRepeating("Laugh_17", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 18) {
            InvokeRepeating("Laugh_18", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 19) {
            InvokeRepeating("Laugh_19", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 20) {
            InvokeRepeating("Laugh_20", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else if (iRandNum == 21) {
            InvokeRepeating("Laugh_21", 2, 2); //始めは2秒後、以後2秒毎に実行
        }
        return;
    }

    public void Mute() {
        audio = GetComponent<AudioSource>();
        if (toggle_Mute.isOn) {
            audio.mute = true;
        } else {
            audio.mute = false;
        }
    }
    
    /*public void Loop(){}*/

    void Laugh(AudioClip Laugh) {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(Laugh);
    }

    public void Laugh_1() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh1);
            CancelInvoke();
            Invoke("Laugh_1", 2f);
        } else {
            CancelInvoke();
            Laugh(Laugh1);
        }

        //画像の切り替え
        // im = GameObject.Find("Image");
        //image = im.GetComponent<Image>();
        //image.sprite = sp1;
        //image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        texture = Resources.Load("2") as Texture2D;
        image = GameObject.Find("Image").GetComponent<Image>();
        image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }

    public void Laugh_2() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh2);
            CancelInvoke();
            InvokeRepeating("Laugh_2", 2, 2); //始めは2秒後、以後2秒毎に実行
        } else {
            CancelInvoke();
            Laugh(Laugh2);
        }
    }

    public void Laugh_3() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh3);
            CancelInvoke();
            Invoke("Laugh_3", 2f);
        } else {
            Laugh(Laugh3);
        }
    }

    public void Laugh_4() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh4);
            CancelInvoke();
            Invoke("Laugh_4", 2f);
        } else {
            Laugh(Laugh4);
        }
    }

    public void Laugh_5() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh5);
            CancelInvoke();
            Invoke("Laugh_5", 2f);
        } else {
            Laugh(Laugh5);
        }
    }

    public void Laugh_6() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh6);
            CancelInvoke();
            Invoke("Laugh_6", 2f);
        } else {
            Laugh(Laugh6);
        }
    }

    public void Laugh_7() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh7);
            CancelInvoke();
            Invoke("Laugh_7", 2f);
        } else {
            Laugh(Laugh7);
        }
    }

    public void Laugh_8() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh8);
            CancelInvoke();
            Invoke("Laugh_8", 2f);
        } else {
            Laugh(Laugh8);
        }
    }

    public void Laugh_9() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh9);
            CancelInvoke();
            Invoke("Laugh_9", 2f);
        } else {
            Laugh(Laugh9);
        }
    }

    public void Laugh_10() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh10);
            CancelInvoke();
            Invoke("Laugh_10", 2f);
        } else {
            Laugh(Laugh10);
        }
    }

    public void Laugh_11() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh11);
            CancelInvoke();
            Invoke("Laugh_11", 2f);
        } else {
            Laugh(Laugh11);
        }
    }

    public void Laugh_12() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh12);
            CancelInvoke();
            Invoke("Laugh_12", 2f);
        } else {
            Laugh(Laugh12);
        }
    }

    public void Laugh_13() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh13);
            CancelInvoke();
            Invoke("Laugh_13", 2f);
        } else {
            Laugh(Laugh13);
        }
    }

    public void Laugh_14() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh14);
            CancelInvoke();
            Invoke("Laugh_14", 2f);
        } else {
            Laugh(Laugh14);
        }
    }

    public void Laugh_15() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh15);
            CancelInvoke();
            Invoke("Laugh_15", 2f);
        } else {
            Laugh(Laugh15);
        }
    }

    public void Laugh_16() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh16);
            CancelInvoke();
            Invoke("Laugh_16", 2f);
        } else {
            Laugh(Laugh16);
        }
    }

    public void Laugh_17() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh17);
            CancelInvoke();
            Invoke("Laugh_17", 2f);
        } else {
            Laugh(Laugh17);
        }
    }

    public void Laugh_18() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh18);
            CancelInvoke();
            Invoke("Laugh_18", 2f);
        } else {
            Laugh(Laugh18);
        }
    }

    public void Laugh_19() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh19);
            CancelInvoke();
            Invoke("Laugh_19", 2f);
        } else {
            Laugh(Laugh19);
        }
    }

    public void Laugh_20() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh20);
            CancelInvoke();
            Invoke("Laugh_20", 2f);
        } else {
            Laugh(Laugh20);
        }
    }

    public void Laugh_21() {
        GameObject obj = GameObject.Find("Loop");
        Toggle toggle = obj.GetComponent<Toggle>();
        if (toggle.isOn) {
            Laugh(Laugh21);
            CancelInvoke();
            Invoke("Laugh_21", 2f);
        } else {
            Laugh(Laugh21);
        }
    }
}