using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    /*[SerializeField] private Image arrow;
    [SerializeField] private Image hand;
    [SerializeField] private Image black;
    [SerializeField] private GameObject Text;
    [SerializeField] private Image settings;
    [SerializeField] private Image blackCircle;
    [SerializeField] private Image ad;
    [SerializeField] private Image Dimand;
    [SerializeField] private Image Cloth;
    [SerializeField] private Image black1;
    [SerializeField] private Image level1;
    [SerializeField] private Image level2;
    [SerializeField] private Image black2;
    [SerializeField] private Image dollar;
    [SerializeField] private Image black3;
    [SerializeField] private Image key;
    [SerializeField] private Image _1;
    [SerializeField] private Image _2;
    [SerializeField] private Image _3;
    [SerializeField] private Image _4;
    [SerializeField] private Image _5;*/

    public static UI Instance { get; private set; }
    [SerializeField] private GameObject[] objectsToDisable;

    private void Awake() {
        Instance = this;
    }
    public void UIStart()
    {
        foreach (GameObject obj in objectsToDisable)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}
