using System;
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
        [SerializeField] private Image glow;

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

        private void Start()
        {
            //Glow();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                AddHp();
            }
        }

        public void AddHp()
        {
            life++;
            heartParent.DOScale(1.2f, 0.175f)
                .OnComplete(() => heartParent.DOScale(1,0.125f));
        }

        void UpdateText()
        {
            text.text = $"x{life}";
        }

        /*void Glow()
        {
            glow.DOColor(1.2f, 0.175f).OnComplete(() => glow.rectTransform.DOScale(1, 0.125f))
                .OnComplete((() => Glow()));
        }*/
    }
    
   
}