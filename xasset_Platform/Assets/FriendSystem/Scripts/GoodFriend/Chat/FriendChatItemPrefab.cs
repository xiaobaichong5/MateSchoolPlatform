﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace FriendSystem
{
    /// <summary>
    /// 好友 聊天 条目
    /// </summary>
    public class FriendChatItemPrefab : MonoBehaviour
    {
        [SerializeField] Image icon;
        [SerializeField] Text nickName;
        [SerializeField] Text timeTxT;
        [SerializeField] Toggle toggle;
        [SerializeField] ChatContentView chatView;

        private void Awake()
        {
            toggle.onValueChanged.AddListener(OpenChatPanel);
        }
        private void OnEnable()
        {
            StartCoroutine(Refresh());
        }
        private void OnDisable()
        {
            //gameObject.SetActive(false);
        }
        Friend friend;
        public void Show(Friend friend)
        {
            this.friend = friend;
            toggle.SetIsOnWithoutNotify(true );
            OpenChatPanel(true);
            gameObject.SetActive(true);
        }
        private IEnumerator Refresh()
        {
            icon.sprite = HeadSculptureWindow.getInstance.GetSprite(friend.friendPortrait);
            nickName.text = friend.friendNickName;
            if (friend.chatMsgList.Count > 0)
            {
                TimeSpan time = DateTime.Now - friend.chatMsgList[friend.chatMsgList.Count - 1].time;
                if (time.Days > 0)
                {
                    timeTxT.text = $"{time.Days}天{time.Hours}小时";
                }
                else
                {
                    timeTxT.text = $"{time.Hours}小时";
                }
            }
            else
            {
                timeTxT.text = "一分钟前";
            }
            yield return null;
            yield return new WaitForSeconds(GoodFriendManager.getInstance.requestTime);
        }
        /// <summary>
        /// 打开 聊天 窗口
        /// </summary>
        private void OpenChatPanel(bool isOpen)
        {
            if(isOpen)
            {
                // TODO 打开 聊天 面板
                Debug.Log("打开聊天 面板"+friend);
                chatView.Open(friend);
            }
        }
    }
}
