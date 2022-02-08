using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public void Pop(Image image)
    {
        if (image.transform.localScale.x>-1)
        {
            image.rectTransform.DOScale(1f, 0.175f).SetEase(Ease.OutBack, 1.87f);
            image.DOFade(1, 0.175f);
        }
    }

    public void DePop(Image image)
    {
        image.transform.DOScale(0f, 0.175f).SetEase(Ease.InBack,1.87f);
        image.DOFade(0, 0.175f);
    }
}
