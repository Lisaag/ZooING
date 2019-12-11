using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    public class Animal : MonoBehaviour
    {
        [SerializeField]
        public string name;
        [SerializeField]
        private GameObject Balloon;
        [SerializeField]
        private Text text;

        public void SayHello()
        {
            Balloon.SetActive(true);
            text.text = "Halleuuu daar";
        }

        public void EatLeaves()
        {
                Balloon.SetActive(true);
                text.text = "lkkr blaadjes hihihihihi";
        }

        public void EatMeat()
        {
                Balloon.SetActive(true);
                text.text = "chill stukje vlees";
        }

        public void PerformTrick()
        {
                StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
