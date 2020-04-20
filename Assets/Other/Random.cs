using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;

public class Random : MonoBehaviour {
    /*
    private Toggle toggle1;
    private ToggleGroup toggleGroup1;

    void Start() {
        toggle1 = GetComponent<Toggle>();
        toggleGroup1 = GetComponent<ToggleGroup>();
    }

    void Update() {
        Debug.Log(toggleGroup1.AnyTogglesOn());  // いずれかのトグルがオンになっているか
        if (toggleGroup1.AnyTogglesOn()) {
            toggle1 = toggleGroup1.ActiveToggles().FirstOrDefault();  // チェックが付いているトグルを取得
            //Debug.Log(toggle1.name);
        }
    }

    public void OnClick() {
        Debug.Log(toggle1.isOn);  // トグルの状態
    }

    public void Random() {
        audio_Random = GetComponent<AudioSource>();
        //Debug.Log("Random Toggle" + toggle_Random.isOn);  // トグルの状態

        if (toggle_Random.isOn) {
            Debug.Log("Random Toggle ON");
            int iRandNum = UnityEngine.Random.Range(1, 3 + 1);//乱数を作成する・(x,y)のyには乱数の最大値+1
            Debug.Log(iRandNum);
            if (iRandNum == 1) {
               
                audio_Random.PlayOneShot(Laugh1);
                InvokeRepeating("Laugh_1", 2, 2); //始めは2秒後、以後2秒毎に実行
                //Invoke("Laugh_1", 2f);
                Debug.Log("1だよ");
            } else if (iRandNum == 2) {
                audio_Random.PlayOneShot(Laugh2);
                //Invoke("Laugh_2", 2f);
                Debug.Log("2だよ");
            } else if (iRandNum == 3) {
                audio_Random.PlayOneShot(Laugh3);
                Debug.Log("3だよ");
                //Invoke("Laugh_3", 2f);
            }
            //Laugh(Laugh+iRandNum); 
        } else {
            CancelInvoke();
            Debug.Log("Random Toggle OFF");
            audio_Random.mute = true;
        }
    }*/
}
