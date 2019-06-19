using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace StrixLibrary_Example
{
    public interface IObserverSubjectExample
    {
        void Damaged(int iDamageAmount);
        void Recovery(int iAmount);
    }

    public class ObserverSubject_Example_Damager : MonoBehaviour
    {
        IObserverSubjectExample[] arrExample;

        private void Awake()
        {
            arrExample = FindObjectsOfType<MonoBehaviour>().OfType<IObserverSubjectExample>().ToArray();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                for (int i = 0; i < arrExample.Length; i++)
                    arrExample[i].Damaged(1);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                for (int i = 0; i < arrExample.Length; i++)
                    arrExample[i].Recovery(1);
            }
        }
    }
}

