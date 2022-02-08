using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SpellManager : MonoBehaviour
{
    public static SpellManager instance;

    public List<Image> spellsFillers;

    [SerializeField] private int id;

    [SerializeField] private bool isFill = true;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FillAmount();
        }
    }

    void FillAmount()
    {
        if (id == spellsFillers.Count)
        {
            isFill = false;
            id = spellsFillers.Count-1 ;
        }
        else if (id==-1)
        {
            isFill = true;
            id = 0;
        }
        if (isFill)
        {
            spellsFillers[id].DOFillAmount(0, 0.5f).OnComplete((() =>
                spellsFillers[id].transform.parent.gameObject.transform.DOScale(1.2f, 0.175f)
                    .OnComplete((() =>
                    {
                        spellsFillers[id].transform.parent.gameObject.transform.DOScale(1f, 0.125f);
                        id++;
                    }))));
        }
        else
        {
            spellsFillers[id].DOFillAmount(1, 0.5f).OnComplete((() =>
                spellsFillers[id].transform.parent.gameObject.transform.DOScale(1.2f, 0.175f)
                    .OnComplete((() =>
                    {
                        spellsFillers[id].transform.parent.gameObject.transform.DOScale(1f, 0.125f);
                        id--;
                    }))));
        }
    }
}
