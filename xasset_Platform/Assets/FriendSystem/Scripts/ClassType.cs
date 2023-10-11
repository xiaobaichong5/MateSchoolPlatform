﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FriendSystem
{
    /// <summary>
    /// 好友
    /// </summary>
    public class Friend
    {
        public string friendPortrait;                                  // 好友头像
        public int id;
        public int friendUserId;                                      // 好友id        
        public string friendChatNo;                                 // 好友微聊好
        public string friendNickName;                               // 好友昵称
        public string black;                                        // 是否拉黑好友
        public string beBlack;                                      // 是否被好友拉黑
        public bool isOnLine;                                       // 是否在线
        public string remark;                                       // 好友备注
        //public List<string> tags = new List<string>();              // 标签列表
        public List<ChatContent> chatMsgList = new List<ChatContent>();   // 聊天内容
        public bool roomLimit;                                  // 访问房间权限限制
        public int unReadCount;                                 // 消息未读数量
        public MyTag tag;                                       // 好友标签
        public void CopyForValue(Friend friend)
        {
            friendPortrait = friend.friendPortrait;
            friendUserId = friend.friendUserId;
            friendChatNo = friend.friendChatNo;
            friendNickName = friend.friendNickName;
            black = friend.black;
            beBlack = friend.beBlack;
            remark = friend.remark;
        }
    }
    /// <summary>
    /// 好友申请
    /// </summary>
    public class ApplyFriend
    {
        public int id;                  // 申请人ID
        public string fromChatNo;       // 申请人微聊好
        public string fromNickName;     // 申请人昵称
        public string reason;           // 申请理由
        public bool isOnLine;           // 是否在线

        public void CopyForValue(ApplyFriend friend)
        {
            id = friend.id;
            fromChatNo = friend.fromChatNo;
            fromNickName = friend.fromNickName;
            reason = friend.reason;
        }
    }

    /// <summary>
    /// 聊天内容
    /// </summary>
    public struct ChatContent
    {
        public bool isMe;
        public string msg;
        public DateTime time;   // 聊天 时间
        public ChatContent(bool isMe, string msg)
        {
            this.isMe = isMe;
            this.msg = msg;
            time = DateTime.Now;
        }
    }
    /// <summary>
    /// 我的标签
    /// </summary>

    public class MyTag
    {
        public string createTime;    // 创建日期
        public int studentId;       // 学生ID
        public int labelId;           // 标签ID
        public string name;           // 标签名称
    }
    /// <summary>
    /// 标签 下 学生 信息
    /// </summary>
    public class TagFriend
    {
        public string sex;          // 性别   （0男 1女 2未知）
        public string avatar;       // 头像
        public string nickName;     // 昵称
        public int id;              // ID
        public string phonenumber;  // 手机号
        public string chatNo;       // 微聊号
    }
    /// <summary>
    /// 普通 成员 不是 好友 人员信息
    /// </summary>
    public class Personnel
    {
        public int id;
        public string chatNo;
        public string nickName;
        public int sex;                  // 性别   （0男 1女 2未知）
        public int portrait;            // 头像
        public string phonenumber;      // 手机号

    }


    /// <summary>
    /// 大学基础信息
    /// </summary>
    public class UniversityInfo
    {
        public int schoolId;                            // 1
        public string schoolName;                       // 北京大学
        public string schoolCode;                       // 4111010001
        public string mainManagementDepartment;         // 教育部
        public string address;                          // 上海市
        public string schoolLevel;                      // 本科
    }
}