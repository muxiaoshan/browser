/**
 * InstanceDataInfoMessageReceiverInOut.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.7.6  Built on : Jul 30, 2017 (09:08:31 BST)
 */
package com.hanyun.hycd.aiadt.webservice.client;


/**
 *  InstanceDataInfoMessageReceiverInOut message receiver
 */
public class InstanceDataInfoMessageReceiverInOut extends org.apache.axis2.receivers.AbstractInOutMessageReceiver {
    public void invokeBusinessLogic(
        org.apache.axis2.context.MessageContext msgContext,
        org.apache.axis2.context.MessageContext newMsgContext)
        throws org.apache.axis2.AxisFault {
        try {
            // get the implementation class for the Web Service
            Object obj = getTheImplementationObject(msgContext);

            InstanceDataInfoSkeleton skel = (InstanceDataInfoSkeleton) obj;

            //Out Envelop
            org.apache.axiom.soap.SOAPEnvelope envelope = null;

            //Find the axisOperation that has been set by the Dispatch phase.
            org.apache.axis2.description.AxisOperation op = msgContext.getOperationContext()
                                                                      .getAxisOperation();

            if (op == null) {
                throw new org.apache.axis2.AxisFault(
                    "Operation is not located, if this is doclit style the SOAP-ACTION should specified via the SOAP Action to use the RawXMLProvider");
            }

            java.lang.String methodName;

            if ((op.getName() != null) &&
                    ((methodName = org.apache.axis2.util.JavaUtils.xmlNameToJavaIdentifier(
                            op.getName().getLocalPart())) != null)) {
                if ("clearLog".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.ClearLogResponse clearLogResponse129 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.ClearLog wrappedParam = (cn.com.dhcc.www.epr.metaservice.ClearLog) fromOM(msgContext.getEnvelope()
                                                                                                                                        .getBody()
                                                                                                                                        .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.ClearLog.class);

                    clearLogResponse129 = skel.clearLog(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            clearLogResponse129, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "ClearLogResponse"));
                } else
                 if ("changeStatus".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse changeStatusResponse131 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.ChangeStatus wrappedParam = (cn.com.dhcc.www.epr.metaservice.ChangeStatus) fromOM(msgContext.getEnvelope()
                                                                                                                                                .getBody()
                                                                                                                                                .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.ChangeStatus.class);

                    changeStatusResponse131 = skel.changeStatus(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            changeStatusResponse131, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "ChangeStatusResponse"));
                } else
                 if ("getCurrentStatus".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse getCurrentStatusResponse133 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetCurrentStatus wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetCurrentStatus) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetCurrentStatus.class);

                    getCurrentStatusResponse133 = skel.getCurrentStatus(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getCurrentStatusResponse133, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetCurrentStatusResponse"));
                } else
                 if ("getAllLogs".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse getAllLogsResponse135 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetAllLogs wrappedParam = (cn.com.dhcc.www.epr.metaservice.GetAllLogs) fromOM(msgContext.getEnvelope()
                                                                                                                                            .getBody()
                                                                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetAllLogs.class);

                    getAllLogsResponse135 = skel.getAllLogs(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getAllLogsResponse135, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetAllLogsResponse"));
                } else
                 if ("saveData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.SaveDataResponse saveDataResponse137 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.SaveData wrappedParam = (cn.com.dhcc.www.epr.metaservice.SaveData) fromOM(msgContext.getEnvelope()
                                                                                                                                        .getBody()
                                                                                                                                        .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.SaveData.class);

                    saveDataResponse137 = skel.saveData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            saveDataResponse137, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "SaveDataResponse"));
                } else
                 if ("getParentGroupList".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse getParentGroupListResponse139 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetParentGroupList wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetParentGroupList) fromOM(msgContext.getEnvelope()
                                                                                              .getBody()
                                                                                              .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetParentGroupList.class);

                    getParentGroupListResponse139 = skel.getParentGroupList(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getParentGroupListResponse139, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetParentGroupListResponse"));
                } else
                 if ("getFinalLog".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse getFinalLogResponse141 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetFinalLog wrappedParam = (cn.com.dhcc.www.epr.metaservice.GetFinalLog) fromOM(msgContext.getEnvelope()
                                                                                                                                              .getBody()
                                                                                                                                              .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetFinalLog.class);

                    getFinalLogResponse141 = skel.getFinalLog(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getFinalLogResponse141, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetFinalLogResponse"));
                } else
                 if ("addInstanceLog".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse addInstanceLogResponse143 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.AddInstanceLog wrappedParam = (cn.com.dhcc.www.epr.metaservice.AddInstanceLog) fromOM(msgContext.getEnvelope()
                                                                                                                                                    .getBody()
                                                                                                                                                    .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.AddInstanceLog.class);

                    addInstanceLogResponse143 = skel.addInstanceLog(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            addInstanceLogResponse143, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "AddInstanceLogResponse"));
                } else
                 if ("checkFinalStatus".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse checkFinalStatusResponse145 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.CheckFinalStatus wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.CheckFinalStatus) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.CheckFinalStatus.class);

                    checkFinalStatusResponse145 = skel.checkFinalStatus(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            checkFinalStatusResponse145, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "CheckFinalStatusResponse"));
                } else
                 if ("getGroupItemList".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse getGroupItemListResponse147 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetGroupItemList wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetGroupItemList) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetGroupItemList.class);

                    getGroupItemListResponse147 = skel.getGroupItemList(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getGroupItemListResponse147, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetGroupItemListResponse"));
                } else
                 if ("initAfterMultiOper".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse initAfterMultiOperResponse149 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.InitAfterMultiOper wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.InitAfterMultiOper) fromOM(msgContext.getEnvelope()
                                                                                              .getBody()
                                                                                              .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.InitAfterMultiOper.class);

                    initAfterMultiOperResponse149 = skel.initAfterMultiOper(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            initAfterMultiOperResponse149, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "InitAfterMultiOperResponse"));
                } else
                 if ("getInstanceData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse getInstanceDataResponse151 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetInstanceData wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetInstanceData) fromOM(msgContext.getEnvelope()
                                                                                           .getBody()
                                                                                           .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetInstanceData.class);

                    getInstanceDataResponse151 = skel.getInstanceData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getInstanceDataResponse151, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetInstanceDataResponse"));
                } else
                 if ("getData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetDataResponse getDataResponse153 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetData wrappedParam = (cn.com.dhcc.www.epr.metaservice.GetData) fromOM(msgContext.getEnvelope()
                                                                                                                                      .getBody()
                                                                                                                                      .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetData.class);

                    getDataResponse153 = skel.getData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getDataResponse153, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetDataResponse"));
                } else
                 if ("checkHappenDateTimeValid".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse checkHappenDateTimeValidResponse155 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValid wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValid) fromOM(msgContext.getEnvelope()
                                                                                                    .getBody()
                                                                                                    .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValid.class);

                    checkHappenDateTimeValidResponse155 = skel.checkHappenDateTimeValid(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            checkHappenDateTimeValidResponse155, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "CheckHappenDateTimeValidResponse"));
                } else
                 if ("testSaveMultipleData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse testSaveMultipleDataResponse157 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.TestSaveMultipleData wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.TestSaveMultipleData) fromOM(msgContext.getEnvelope()
                                                                                                .getBody()
                                                                                                .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.TestSaveMultipleData.class);

                    testSaveMultipleDataResponse157 = skel.testSaveMultipleData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            testSaveMultipleDataResponse157, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "TestSaveMultipleDataResponse"));
                } else
                 if ("updateEPRLogs".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse updateEPRLogsResponse159 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.UpdateEPRLogs wrappedParam = (cn.com.dhcc.www.epr.metaservice.UpdateEPRLogs) fromOM(msgContext.getEnvelope()
                                                                                                                                                  .getBody()
                                                                                                                                                  .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.UpdateEPRLogs.class);

                    updateEPRLogsResponse159 = skel.updateEPRLogs(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            updateEPRLogsResponse159, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "UpdateEPRLogsResponse"));
                } else
                 if ("getNormalData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse getNormalDataResponse161 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetNormalData wrappedParam = (cn.com.dhcc.www.epr.metaservice.GetNormalData) fromOM(msgContext.getEnvelope()
                                                                                                                                                  .getBody()
                                                                                                                                                  .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetNormalData.class);

                    getNormalDataResponse161 = skel.getNormalData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getNormalDataResponse161, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetNormalDataResponse"));
                } else
                 if ("getKBDiagnosIDByEpisodeID".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse getKBDiagnosIDByEpisodeIDResponse163 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeID wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeID) fromOM(msgContext.getEnvelope()
                                                                                                     .getBody()
                                                                                                     .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeID.class);

                    getKBDiagnosIDByEpisodeIDResponse163 = skel.getKBDiagnosIDByEpisodeID(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getKBDiagnosIDByEpisodeIDResponse163, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetKBDiagnosIDByEpisodeIDResponse"));
                } else
                 if ("getRefInstanceID".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse getRefInstanceIDResponse165 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetRefInstanceID wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetRefInstanceID) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetRefInstanceID.class);

                    getRefInstanceIDResponse165 = skel.getRefInstanceID(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getRefInstanceIDResponse165, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetRefInstanceIDResponse"));
                } else
                 if ("saveMultipleData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse saveMultipleDataResponse167 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.SaveMultipleData wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.SaveMultipleData) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.SaveMultipleData.class);

                    saveMultipleDataResponse167 = skel.saveMultipleData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            saveMultipleDataResponse167, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "SaveMultipleDataResponse"));
                } else
                 if ("importInstanceData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse importInstanceDataResponse169 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.ImportInstanceData wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.ImportInstanceData) fromOM(msgContext.getEnvelope()
                                                                                              .getBody()
                                                                                              .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.ImportInstanceData.class);

                    importInstanceDataResponse169 = skel.importInstanceData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            importInstanceDataResponse169, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "ImportInstanceDataResponse"));
                } else
                 if ("getTemplateIDByID".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse getTemplateIDByIDResponse171 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetTemplateIDByID wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetTemplateIDByID) fromOM(msgContext.getEnvelope()
                                                                                             .getBody()
                                                                                             .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetTemplateIDByID.class);

                    getTemplateIDByIDResponse171 = skel.getTemplateIDByID(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getTemplateIDByIDResponse171, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetTemplateIDByIDResponse"));
                } else
                 if ("getDataByInstanceID".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse getDataByInstanceIDResponse173 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetDataByInstanceID wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetDataByInstanceID) fromOM(msgContext.getEnvelope()
                                                                                               .getBody()
                                                                                               .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetDataByInstanceID.class);

                    getDataByInstanceIDResponse173 = skel.getDataByInstanceID(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getDataByInstanceIDResponse173, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetDataByInstanceIDResponse"));
                } else
                 if ("getDataByID".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse getDataByIDResponse175 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetDataByID wrappedParam = (cn.com.dhcc.www.epr.metaservice.GetDataByID) fromOM(msgContext.getEnvelope()
                                                                                                                                              .getBody()
                                                                                                                                              .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetDataByID.class);

                    getDataByIDResponse175 = skel.getDataByID(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getDataByIDResponse175, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetDataByIDResponse"));
                } else
                 if ("getMultipleData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse getMultipleDataResponse177 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetMultipleData wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetMultipleData) fromOM(msgContext.getEnvelope()
                                                                                           .getBody()
                                                                                           .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetMultipleData.class);

                    getMultipleDataResponse177 = skel.getMultipleData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getMultipleDataResponse177, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetMultipleDataResponse"));
                } else
                 if ("replaceGroupData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse replaceGroupDataResponse179 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.ReplaceGroupData wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.ReplaceGroupData) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.ReplaceGroupData.class);

                    replaceGroupDataResponse179 = skel.replaceGroupData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            replaceGroupDataResponse179, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "ReplaceGroupDataResponse"));
                } else
                 if ("getDescDataByID".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse getDescDataByIDResponse181 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetDescDataByID wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetDescDataByID) fromOM(msgContext.getEnvelope()
                                                                                           .getBody()
                                                                                           .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetDescDataByID.class);

                    getDescDataByIDResponse181 = skel.getDescDataByID(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getDescDataByIDResponse181, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetDescDataByIDResponse"));
                } else
                 if ("initAfterSingleOper".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse initAfterSingleOperResponse183 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.InitAfterSingleOper wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.InitAfterSingleOper) fromOM(msgContext.getEnvelope()
                                                                                               .getBody()
                                                                                               .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.InitAfterSingleOper.class);

                    initAfterSingleOperResponse183 = skel.initAfterSingleOper(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            initAfterSingleOperResponse183, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "InitAfterSingleOperResponse"));
                } else
                 if ("getGroupDataByID".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse getGroupDataByIDResponse185 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetGroupDataByID wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetGroupDataByID) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetGroupDataByID.class);

                    getGroupDataByIDResponse185 = skel.getGroupDataByID(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getGroupDataByIDResponse185, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetGroupDataByIDResponse"));
                } else
                 if ("replaceTemplateData".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse replaceTemplateDataResponse187 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.ReplaceTemplateData wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.ReplaceTemplateData) fromOM(msgContext.getEnvelope()
                                                                                               .getBody()
                                                                                               .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.ReplaceTemplateData.class);

                    replaceTemplateDataResponse187 = skel.replaceTemplateData(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            replaceTemplateDataResponse187, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "ReplaceTemplateDataResponse"));
                } else
                 if ("addLog".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.AddLogResponse addLogResponse189 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.AddLog wrappedParam = (cn.com.dhcc.www.epr.metaservice.AddLog) fromOM(msgContext.getEnvelope()
                                                                                                                                    .getBody()
                                                                                                                                    .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.AddLog.class);

                    addLogResponse189 = skel.addLog(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            addLogResponse189, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "AddLogResponse"));
                } else
                 if ("getNormalDataOld".equals(methodName)) {
                    cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse getNormalDataOldResponse191 =
                        null;
                    cn.com.dhcc.www.epr.metaservice.GetNormalDataOld wrappedParam =
                        (cn.com.dhcc.www.epr.metaservice.GetNormalDataOld) fromOM(msgContext.getEnvelope()
                                                                                            .getBody()
                                                                                            .getFirstElement(),
                            cn.com.dhcc.www.epr.metaservice.GetNormalDataOld.class);

                    getNormalDataOldResponse191 = skel.getNormalDataOld(wrappedParam);

                    envelope = toEnvelope(getSOAPFactory(msgContext),
                            getNormalDataOldResponse191, false,
                            new javax.xml.namespace.QName(
                                "http://www.dhcc.com.cn/epr/metaservice",
                                "GetNormalDataOldResponse"));
                } else {
                    throw new java.lang.RuntimeException("method not found");
                }

                newMsgContext.setEnvelope(envelope);
            }
        } catch (java.lang.Exception e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    //
    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ClearLog param, boolean optimizeContent)
        throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ClearLog.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ClearLogResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ClearLogResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ChangeStatus param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ChangeStatus.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetCurrentStatus param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetCurrentStatus.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetAllLogs param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetAllLogs.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.SaveData param, boolean optimizeContent)
        throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.SaveData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.SaveDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.SaveDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetParentGroupList param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetParentGroupList.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetFinalLog param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetFinalLog.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.AddInstanceLog param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.AddInstanceLog.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.CheckFinalStatus param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.CheckFinalStatus.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetGroupItemList param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetGroupItemList.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.InitAfterMultiOper param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.InitAfterMultiOper.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetInstanceData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetInstanceData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetData param, boolean optimizeContent)
        throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValid param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValid.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.TestSaveMultipleData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.TestSaveMultipleData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.UpdateEPRLogs param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.UpdateEPRLogs.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetNormalData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetNormalData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeID param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeID.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetRefInstanceID param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetRefInstanceID.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.SaveMultipleData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.SaveMultipleData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ImportInstanceData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ImportInstanceData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetTemplateIDByID param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetTemplateIDByID.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetDataByInstanceID param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetDataByInstanceID.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetDataByID param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetDataByID.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetMultipleData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetMultipleData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ReplaceGroupData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ReplaceGroupData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetDescDataByID param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetDescDataByID.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.InitAfterSingleOper param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.InitAfterSingleOper.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetGroupDataByID param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetGroupDataByID.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ReplaceTemplateData param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ReplaceTemplateData.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.AddLog param, boolean optimizeContent)
        throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.AddLog.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.AddLogResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.AddLogResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetNormalDataOld param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetNormalDataOld.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.om.OMElement toOM(
        cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse param,
        boolean optimizeContent) throws org.apache.axis2.AxisFault {
        try {
            return param.getOMElement(cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse.MY_QNAME,
                org.apache.axiom.om.OMAbstractFactory.getOMFactory());
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.ClearLogResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.ClearLogResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.ClearLogResponse wrapClearLog() {
        cn.com.dhcc.www.epr.metaservice.ClearLogResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.ClearLogResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse wrapChangeStatus() {
        cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse wrapGetCurrentStatus() {
        cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse wrapGetAllLogs() {
        cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.SaveDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.SaveDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.SaveDataResponse wrapSaveData() {
        cn.com.dhcc.www.epr.metaservice.SaveDataResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.SaveDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse wrapGetParentGroupList() {
        cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse wrapGetFinalLog() {
        cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse wrapAddInstanceLog() {
        cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse wrapCheckFinalStatus() {
        cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse wrapGetGroupItemList() {
        cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse wrapInitAfterMultiOper() {
        cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse wrapGetInstanceData() {
        cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetDataResponse wrapGetData() {
        cn.com.dhcc.www.epr.metaservice.GetDataResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse wrapCheckHappenDateTimeValid() {
        cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse wrapTestSaveMultipleData() {
        cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse wrapUpdateEPRLogs() {
        cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse wrapGetNormalData() {
        cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse wrapGetKBDiagnosIDByEpisodeID() {
        cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse wrapGetRefInstanceID() {
        cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse wrapSaveMultipleData() {
        cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse wrapImportInstanceData() {
        cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse wrapGetTemplateIDByID() {
        cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse wrapGetDataByInstanceID() {
        cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse wrapGetDataByID() {
        cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse wrapGetMultipleData() {
        cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse wrapReplaceGroupData() {
        cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse wrapGetDescDataByID() {
        cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse wrapInitAfterSingleOper() {
        cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse wrapGetGroupDataByID() {
        cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse wrapReplaceTemplateData() {
        cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse wrappedElement =
            new cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.AddLogResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.AddLogResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.AddLogResponse wrapAddLog() {
        cn.com.dhcc.www.epr.metaservice.AddLogResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.AddLogResponse();

        return wrappedElement;
    }

    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory,
        cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse param,
        boolean optimizeContent, javax.xml.namespace.QName elementQName)
        throws org.apache.axis2.AxisFault {
        try {
            org.apache.axiom.soap.SOAPEnvelope emptyEnvelope = factory.getDefaultEnvelope();

            emptyEnvelope.getBody()
                         .addChild(param.getOMElement(
                    cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse.MY_QNAME,
                    factory));

            return emptyEnvelope;
        } catch (org.apache.axis2.databinding.ADBException e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }
    }

    private cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse wrapGetNormalDataOld() {
        cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse wrappedElement = new cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse();

        return wrappedElement;
    }

    /**
     *  get the default envelope
     */
    private org.apache.axiom.soap.SOAPEnvelope toEnvelope(
        org.apache.axiom.soap.SOAPFactory factory) {
        return factory.getDefaultEnvelope();
    }

    private java.lang.Object fromOM(org.apache.axiom.om.OMElement param,
        java.lang.Class type) throws org.apache.axis2.AxisFault {
        try {
            if (cn.com.dhcc.www.epr.metaservice.AddInstanceLog.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.AddInstanceLog.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.AddInstanceLogResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.AddLog.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.AddLog.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.AddLogResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.AddLogResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ChangeStatus.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.ChangeStatus.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ChangeStatusResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.CheckFinalStatus.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.CheckFinalStatus.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.CheckFinalStatusResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValid.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValid.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.CheckHappenDateTimeValidResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ClearLog.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.ClearLog.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ClearLogResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ClearLogResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetAllLogs.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.GetAllLogs.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetAllLogsResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetCurrentStatus.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetCurrentStatus.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetCurrentStatusResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetData.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.GetData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetDataByID.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.GetDataByID.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetDataByIDResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetDataByInstanceID.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetDataByInstanceID.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetDataByInstanceIDResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetDescDataByID.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetDescDataByID.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetDescDataByIDResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetFinalLog.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.GetFinalLog.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetFinalLogResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetGroupDataByID.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetGroupDataByID.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetGroupDataByIDResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetGroupItemList.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetGroupItemList.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetGroupItemListResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetInstanceData.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetInstanceData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetInstanceDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeID.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeID.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetKBDiagnosIDByEpisodeIDResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetMultipleData.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetMultipleData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetMultipleDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetNormalData.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.GetNormalData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetNormalDataOld.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetNormalDataOld.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetNormalDataOldResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetNormalDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetParentGroupList.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetParentGroupList.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetParentGroupListResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetRefInstanceID.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetRefInstanceID.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetRefInstanceIDResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetTemplateIDByID.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetTemplateIDByID.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.GetTemplateIDByIDResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ImportInstanceData.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ImportInstanceData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ImportInstanceDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.InitAfterMultiOper.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.InitAfterMultiOper.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.InitAfterMultiOperResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.InitAfterSingleOper.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.InitAfterSingleOper.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.InitAfterSingleOperResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ReplaceGroupData.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ReplaceGroupData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ReplaceGroupDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ReplaceTemplateData.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ReplaceTemplateData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.ReplaceTemplateDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.SaveData.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.SaveData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.SaveDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.SaveDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.SaveMultipleData.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.SaveMultipleData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.SaveMultipleDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.TestSaveMultipleData.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.TestSaveMultipleData.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.TestSaveMultipleDataResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.UpdateEPRLogs.class.equals(type)) {
                return cn.com.dhcc.www.epr.metaservice.UpdateEPRLogs.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }

            if (cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse.class.equals(
                        type)) {
                return cn.com.dhcc.www.epr.metaservice.UpdateEPRLogsResponse.Factory.parse(param.getXMLStreamReaderWithoutCaching());
            }
        } catch (java.lang.Exception e) {
            throw org.apache.axis2.AxisFault.makeFault(e);
        }

        return null;
    }

    private org.apache.axis2.AxisFault createAxisFault(java.lang.Exception e) {
        org.apache.axis2.AxisFault f;
        Throwable cause = e.getCause();

        if (cause != null) {
            f = new org.apache.axis2.AxisFault(e.getMessage(), cause);
        } else {
            f = new org.apache.axis2.AxisFault(e.getMessage());
        }

        return f;
    }
} //end of class
