using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private List<Transform> menus;
    [SerializeField] private Vector3 translation;
    [SerializeField] private GameObject engrenage;

    private bool isMenu;

    public void Translate()
    {
        if (!isMenu)
        {
            for (int i = 0; i < menus.Count; i++)
            {
                menus[i].DOMove(menus[i].position + translation, 0.175f).SetEase(Ease.OutBack,1.87f);
            }

            isMenu = true;
        }
        else
        {
            for (int i = 0; i < menus.Count; i++)
            {
                menus[i].DOMove(menus[i].position - translation, 0.175f).SetEase(Ease.OutBack,1.87f);
            }

            isMenu = false;
        }

        engrenage.transform.DORotate(engrenage.transform.eulerAngles + new Vector3(0, 360), 0.175f).SetEase(Ease.OutBack, 1.87f);
    }
}
