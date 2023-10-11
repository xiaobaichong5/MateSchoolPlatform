using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ApiCore
{
    public static string Host = "http://47.101.199.191:8090/";

    //public static string Url_GetFileList = "api/Meta/getFileList";
    //public static string Url_Upload = "api/Meta/upload";
    //public static string Url_Delete = "api/Meta/del";
    /// <summary>
    /// ѧ��ע��
    /// </summary>
    public static string Url_Register = "open-api/common/register";
    /// <summary>
    /// ������֤��
    /// </summary>
    public static string Url_Send = "open-api/common/SMS";
    /// <summary>
    /// ��½�ӿ�
    /// </summary>
    public static string Url_Login = "open-api/common/login";
    #region ���������
    /// <summary>
    /// ��ѯѧУ����
    /// </summary>
    public static string Url_SchoolList = "open-api/business/listSchool";
    /// <summary>
    /// ��ѯ��������-δ���
    /// </summary>
    public static string Url_ListUnAuditMainScene = "open-api/business/listUnAuditMainScene";
    /// <summary>
    /// ��ѯ��������-�����
    /// </summary>
    public static string Url_ListAuditMainScene = "open-api/business/listAuditMainScene";
    /// <summary>
    /// ��ѯ�����Ӱ�-δ���
    /// </summary>
    public static string Url_ListUnAuditChildScene = "open-api/business/listUnAuditChildScene";
    /// <summary>
    /// ��ѯ�����Ӱ�-�����
    /// </summary>
    public static string Url_ListAuditChildScene = "open-api/business/listAuditChildScene";
    /// <summary>
    /// ��ѯ���ⳡ����
    /// </summary>
    public static string Url_listScenePackageByIds = "open-api/common/listScenePackageByIds";
    #endregion

    #region ������ؽӿ�
    /// <summary>
    /// ��ѯ�����б�
    /// </summary>
    public static string Url_FriendList = "open-api/chat/friend/list";
    /// <summary>
    /// ���������б�
    /// </summary>
    public static string Url_ApplyList = "open-api/chat/apply/list";
    /// <summary>
    /// �������Ӻ���
    /// </summary>
    public static string Url_Apply = "open-api/chat/apply";
    /// <summary>
    /// �����������
    /// </summary>
    public static string Url_ApplyAudit = "open-api/chat/apply/audit";
    /// <summary>
    /// ����ɾ��
    /// </summary>
    public static string Url_DeleteFr = "open-api/chat/friend/del";
    /// <summary>
    /// ��������
    /// </summary>
    public static string Url_BlackFr = "open-api/chat/friend/black";
    #endregion
    #region �������͵����
    /// <summary>
    /// ���Ӵ��͵�
    /// </summary>
    public static string Url_addPackageTransmission = "open-api/common/addScenePackageTransmission";
    /// <summary>
    /// ɾ�����͵�
    /// </summary>
    public static string Url_RemoveTransmission = "open-api/common/removeScenePackageTransmission";
    /// <summary>
    /// �޸Ĵ��͵�
    /// </summary>
    public static string Url_updateScenePackageTransmission = "open-api/common/updateScenePackageTransmission";
    /// <summary>
    /// ��ѯ���͵��б�
    /// </summary>
    public static string selectScenePackageTransmission = "open-api/common/selectScenePackageTransmission";
    #endregion
    #region Ⱥ�����
    /// <summary>
    /// ����Ⱥ
    /// </summary>
    public static string Url_GroupCreate = "open-api/chat/group/add";
    /// <summary>
    /// ��ȡȺ��Ϣ
    /// </summary>
    public static string Url_GetGroupInfo = "open-api/chat/group/get";
    /// <summary>
    /// ˢ��Ⱥ��Ϣ
    /// </summary>
    public static string Url_UpdateGroupInfo = "open-api/chat/group/update";
    /// <summary>
    /// ɾ��Ⱥ��Ϣ
    /// </summary>
    public static string Url_DelGroup = "open-api/chat/group/del";
    /// <summary>
    /// ����Ⱥ
    /// </summary>
    public static string Url_JoinGroup = "open-api/chat/group/join";
    /// <summary>
    /// �˳�Ⱥ
    /// </summary>
    public static string Url_QuitGroup = "open-api/chat/group/quit";
    /// <summary>
    /// ��õ�ǰ������
    /// </summary>
    public static string Url_GetOnlineUsers = "online/getUsers";

    public static string Url_GetCodeGroup = "";
    /// <summary>
    /// ���ָ����SCENID��Ϣ
    /// </summary>
    public static string Url_GetScenePackageInfo = "open-api/business/scenePackageInfo";
    #endregion
    #region �༭ѧ����Ϣ
    /// <summary>
    /// ����ѧ����Ϣ
    /// </summary>
    public static string Url_EditStudengtInfo = "open-api/business/editStudent";
    /// <summary>
    /// ���ѧ��������Ϣͨ��token
    /// </summary>
    public static string Url_GetStudentInfoByToken = "open-api/business/getStudentByToken";
    /// <summary>
    /// ���ѧ����Ϣ
    /// </summary>
    public static string Url_GetStudentInfoByNum = "open-api/business/getStudent";
    /// <summary>
    /// ͨ����ǩ����ѧ��
    /// </summary>
    public static string Url_TagAddStudent = "open-api/common/addLabelStudent";
    /// <summary>
    /// ͨ����ǩɾ��ѧ��
    /// </summary>
    public static string Url_TagDelStudent = "open-api/common/delLabelStudent";
    /// <summary>
    /// ���� ���� ��ע
    /// </summary>

    public static string Url_UpdateFriendRemark = "open-api/chat/friend/updateFriendRemark";
    #endregion
    #region չ����ؽӿ�
    /// <summary>
    /// ����չ����Ϣ��ؽӿ�
    /// </summary>
    public static string Url_SaveScenePackageShowroom = "open-api/common/saveScenePackageShowroom";
    /// <summary>
    /// ��ѯչ����Ϣ��ؽӿ�
    /// </summary>
    public static string Url_ListScenePackageShowroom = "open-api/common/listScenePackageShowroom";
    /// <summary>
    /// �ϴ�չ������ļ�
    /// </summary>
    public static string Url_Upload = "open-api/common/upload";
    #endregion
    public static string GetUrl(string Api)
    {
        return Host + Api;
    }
}
