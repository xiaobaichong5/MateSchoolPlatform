using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    public static string token = "eyJhbGciOiJIUzUxMiJ9.eyJleHAiOjE2OTIwMjQwMTUsImxvZ2luX3N0dWRlbnRfa2V5Ijp7ImNyZWF0ZUJ5Ijoic3lzLXJlZ2lzdGVyIiwiY3JlYXRlVGltZSI6IjIwMjMtMDctMjQgMjA6NDU6NDYiLCJ1cGRhdGVCeSI6Inl5eCIsInVwZGF0ZVRpbWUiOiIyMDIzLTA4LTExIDEwOjMxOjA0IiwiaWQiOjE2NSwidXNlck5hbWUiOiJ5eXgiLCJ1c2VyR2FtZU5hbWUiOm51bGwsIm5pY2tOYW1lIjoieXl4IiwicGhvbmVudW1iZXIiOiIxNTI3MDM1Mjc3MCIsInNleCI6IjAiLCJhdmF0YXIiOiI3IiwicGFzc3dvcmQiOiIkMmEkMTAkeThhLndkRFdnVHFQWS5kcFdDYkE2ZXhEMTBvdWdlOEs4MTNYZ2czWWFZeGJicDMxQXdnN2EiLCJhZ2UiOiI4MCIsIndvcmtVbml0Ijoi5pWZ6IKy6YOo6ZeoIiwibWFpbGJveCI6IjEwNDcxODUyMDlAcXEuY29tIiwiam9iIjoi54m55YqhIiwiZWR1Y2F0aW9uIjoiW3snc2Nob29sJzon5LiK5rW35biI6IyD5aSn5a2m5aSp5Y2O5a2m6ZmiJywnc2VyaWUnOifpmaLns7sxJywndGltZSc6JzE5NzUvOS8xJywnbGV2ZWwnOiflsI_lraYnfSx7J3NjaG9vbCc6J-axn-ilv-WGnOS4muWkp-WtpuWNl-aYjOWVhuWtpumZoicsJ3NlcmllJzon6Zmi57O7NCcsJ3RpbWUnOicxOTkwLzkvMScsJ2xldmVsJzon5pys56eRJ30seydzY2hvb2wnOifmsZ_opb_lhpzkuJrlpKflrabljZfmmIzllYblrabpmaInLCdzZXJpZSc6J-mZouezuzUnLCd0aW1lJzonMjAwNS85LzEnLCdsZXZlbCc6J-acrOenkSd9LHsnc2Nob29sJzon5LiK5rW355CG5bel5aSn5a2mJywnc2VyaWUnOifpmaLns7syJywndGltZSc6JzIwMjMvOS8xJywnbGV2ZWwnOifmnKznp5EnfV0iLCJyb2xlSW5mbyI6bnVsbCwic3RhdHVzIjoiMCIsImRlbEZsYWciOiIwIiwic2Nob29sSWQiOm51bGwsImNoYXRObyI6ImExZjc3M2M4OTgwYjQwY2I5NmU3NWMxNGI1MGM4ODY0IiwicmVtYXJrIjpudWxsfX0.iRJ3RCX9yRFyuMXr-SM5uIPkZ87HetpQyAA_3GWyi2J00ZpLnm2LMgxuUMeh-W7S7eZFm2rYH8ajSpn9A1q__Q";
    public static string UserName = "YZL";
    public static string nickname = "YZL";
    public static string mobile = "13013659176";
    public static int uid = 165;                            // 身份 ID
    public static string chatNo = "a1f773c8980b40cb96e75c14b50c8864";   // 微聊号
    public static int portrait;         // 头像 序号
    public static string roleinfo = "";
    /// <summary>   
    /// 当前学校名称
    /// </summary>
    public static string currentschoolname = "测试学校888";
    /// <summary>
    /// 当前URL
    /// </summary>
    public static string curentschoolurl;
    /// <summary>
    /// 当前路径名
    /// </summary>
    public static string currentfilename;
    /// <summary>
    /// 当前场景名
    /// </summary>
    public static string currentsenename;
    /// <summary>
    /// 即将跳转的场景名
    /// </summary>
    public static string gotoscenename;

    /// <summary>
    /// 当前场景编号
    /// </summary>
    public static string currentseneid = "";
    /// <summary>
    /// 记录当前子包id
    /// </summary>
    public static string currentchildsceneid = "";
    /// <summary>
    /// 当前的位置信息
    /// </summary>
    public static Vector3 current_pos;

    public static int incamationId = 1;     //角色名
    /// <summary>
    /// 当前包是否处于可编辑状态
    /// </summary>
    public static bool isCanEdit = false;
    /// <summary>
    /// 要前往的个人空间名称
    /// </summary>
    public static string gotospacename = "";
}