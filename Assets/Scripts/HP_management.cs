using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;

public class HP_management : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 100;
    int currentHp;
    //Sliderを入れる
    public Slider slider;
    private int[] DamageList;

    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 100;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
        DamageList = new int[] {10, 20, 30};
    }

    public void UpdateSlider(string name)
    {
        switch(name)
        {
            case "Sphere(Clone)":
                DoDamage(DamageList[0]);
                break;
            case "Cube(Clone)":
                DoDamage(DamageList[1]);
                break;
            case "Capsule(Clone)":
                DoDamage(DamageList[2]);
                break;
            default:
                Debug.Log("no match");
                break;
        }
    }
    private void DoDamage(int damage)
    {
        //ダメージは1～5の中でランダムに決める。
        // int damage = Random.Range(1, 5);
        Debug.Log("damage : " + damage);

        //現在のHPからダメージを引く
        currentHp = currentHp - damage;

        //最大HPにおける現在のHPをSliderに反映。
        //int同士の割り算は小数点以下は0になるので、
        //(float)をつけてfloatの変数として振舞わせる。
        slider.value = ((float)currentHp / (float)maxHp) * 100; ;
        // Debug.Log("slider.value : " + slider.value);
    }
    //ColliderオブジェクトのIsTriggerにチェック入れること。
    // private void OnCollisionEnter(Collider collider)
    // {
        //Objectタグのオブジェクトに触れると発動
    //     if (collider.gameObject.tag == "Object")
    //     {
    //         UpdateSlider();
    //     }
    // }
}
