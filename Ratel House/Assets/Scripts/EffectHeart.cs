using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class EffectHeart : MonoBehaviour
    {
        [SerializeField] private RectTransform heartParent;
        [SerializeField] private Image heart;
        [SerializeField] private TextMeshProUGUI text;

        private int m_hp = 3;

        public int life
        {
            get => m_hp;
            set
            {
                m_hp = value;
                UpdateText();
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                AddHp();
            }
        }

        void AddHp()
        {
            life++;
            heartParent.DOScale(1.2f, 0.175f)
                .OnComplete(() => heartParent.DOScale(1,0.125f));
        }

        void UpdateText()
        {
            text.text = $"x{life}";
        }
    }
   
}