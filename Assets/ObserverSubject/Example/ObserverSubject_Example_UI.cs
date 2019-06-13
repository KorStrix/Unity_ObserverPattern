﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StrixLibrary_Example
{
    public class ObserverSubject_Example_UI : MonoBehaviour
    {
        public Image p_Image_HP;

        private void Awake()
        {
            GetComponent<ObserverSubject_Example_UseObserverPattern>().p_Event_OnChangeHP.Subscribe += OnChange_HP;
        }

        private void OnChange_HP(ObserverSubject_Example_UseObserverPattern.OnChangeHP_Arg pArg)
        {
            p_Image_HP.fillAmount = pArg.fCurrentHP_0_1;
        }
    }
}
