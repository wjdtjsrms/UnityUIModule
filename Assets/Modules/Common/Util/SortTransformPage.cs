namespace Anipen.MetaPubs.UI
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class SortTransformPage : MonoBehaviour
    {
        [SerializeField] private bool isSort = true;

        private void Awake()
        {
            if (isSort)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    var rec = transform.GetChild(i).GetComponent<RectTransform>();

                    if (rec != null)
                    {
                        rec.anchoredPosition = Vector3.zero;
                    }
                }
            }
        }
    }

}




