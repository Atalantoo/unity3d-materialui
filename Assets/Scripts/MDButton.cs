﻿using UnityEngine;
using UnityEngine.UI;

namespace MDUI.Component
{
    public class MDButton : MonoBehaviour
    {
        // fields visible in Unity3d inspector
        // TODO

        // Use this for initialization
        void Start()
        {
            apply(this.GetComponentInChildren<RectTransform>());
        }

        // Update is called once per frame
        void Update()
        {

        }

        // Use this for editor reset component button
        void Reset()
        {
            apply(this.GetComponentInChildren<RectTransform>());
        }

        public static void apply(RectTransform comp)
        {
            SetSize(comp, new Vector2(260, 80));
        }

        [System.Obsolete]
        public static void SetSize(RectTransform trans, Vector2 size)
        {
            Vector2 currSize = trans.rect.size;
            Vector2 sizeDiff = size - currSize;
            trans.offsetMin = trans.offsetMin -
            new Vector2(sizeDiff.x * trans.pivot.x,
                sizeDiff.y * trans.pivot.y);
            trans.offsetMax = trans.offsetMax +
            new Vector2(sizeDiff.x * (1.0f - trans.pivot.x),
                sizeDiff.y * (1.0f - trans.pivot.y));
        }
    }
}