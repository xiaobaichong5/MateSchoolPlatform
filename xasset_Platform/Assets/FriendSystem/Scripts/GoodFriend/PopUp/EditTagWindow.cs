using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FriendSystem
{
    public class EditTagWindow : MonoBehaviour
    {
        [SerializeField] Button close;
        [SerializeField] Transform content;
        [SerializeField] Text tagCountTxT;

        GameObject prefab;

        private void Awake()
        {
            prefab = content.transform.GetChild(0).gameObject;
            prefab.SetActive(false);
            close.onClick.AddListener(() => ToggleEnable(false));
        }


        // �л���ʾ ����
        private void ToggleEnable(bool state)
        {
            transform.GetChild(0).gameObject.SetActive(state);
        }

        /// <summary>
        /// ��ʾ ����
        /// </summary>
        public void Show()          
        {
            ToggleEnable(true);
            int index = 0;
            foreach (var item in GoodFriendManager.getInstance.myTags)
            {
                index++;
                EditFriendTagPrefab tagItem;
                if (content.childCount > index)
                {
                    tagItem = content.GetChild(index).GetComponent<EditFriendTagPrefab>();
                }
                else
                {
                    tagItem = Instantiate(prefab, content).GetComponent<EditFriendTagPrefab>();
                }
                tagItem.Show(item);
                tagItem.gameObject.SetActive(true);
            }
            tagCountTxT.text = GoodFriendManager.getInstance.myTags.Count.ToString();
        }
        public void Hide()
        {
            ToggleEnable(false);
        }
    }
}
