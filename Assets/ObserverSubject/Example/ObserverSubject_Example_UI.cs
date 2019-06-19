using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StrixLibrary_Example
{
    public class ObserverSubject_Example_UI : MonoBehaviour
    {
        public Image p_Image_HP;
        public Text p_TextState;

        private void Awake()
        {
            GetComponent<ObserverSubject_Example_UseObserverPattern>().p_Event_OnChangeHP.Subscribe_And_Listen_CurrentData += OnChange_HP;
        }

        private void OnChange_HP(ObserverSubject_Example_UseObserverPattern.OnChangeHP_Arg pArg)
        {
            p_Image_HP.fillAmount = pArg.fCurrentHP_0_1;

            if (pArg.fCurrentHP_0_1 <= 0f)
                p_TextState.text = "Dead";
            else
                p_TextState.text = "Alive";
        }
    }
}
