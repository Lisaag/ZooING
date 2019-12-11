using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class AnimalManager : MonoBehaviour
    {
        [SerializeField]
        private List<GameObject> animalObjects;

        [SerializeField]
        GameObject canvas;

        [SerializeField]
        InputField inputField;

        private List<Animal> animals = new List<Animal>();

        private void Start()
        {
            Debug.Log("spawning animals");
            foreach (GameObject o in animalObjects)
            {
                GameObject animalInstance = Instantiate(o, canvas.transform);
                Animal animal = animalInstance.GetComponent<Animal>();
                animals.Add(animal);
            }
        }

        public void GiveLeavesButton()
        {
            foreach (Animal a in animals)
            {
                if (a is IHerbivore)
                {
                    a.EatLeaves();
                }
            }
        }

        public void GiveMeatButton()
        {
            foreach (Animal a in animals)
            {
                if (a is ICarnivore)
                {
                    a.EatMeat();

                }
            }
        }

        public void TricksButton()
        {
            foreach (Animal a in animals)
            {
                if (a is ITrick)
                {
                    a.PerformTrick();
                }
            }
        }

        public void HelloButton()
        {
            foreach (Animal a in animals)
            {
                if(inputField.text == "")
                {
                    a.SayHello();
                }
                else
                {
                    if(inputField.text == a.name)
                    {
                        a.SayHello();
                    }
                }
            }
        }
    }
}
