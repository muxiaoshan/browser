/**
 * ExtensionMapper.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.7.6  Built on : Jul 30, 2017 (09:08:58 BST)
 */
package cn.com.dhcc.www.epr.metaservice;


/**
 *  ExtensionMapper class
 */
@SuppressWarnings({"unchecked",
    "unused"
})
public class ExtensionMapper {
    public static java.lang.Object getTypeObject(
        java.lang.String namespaceURI, java.lang.String typeName,
        javax.xml.stream.XMLStreamReader reader) throws java.lang.Exception {
        if ("http://www.dhcc.com.cn/epr/metaservice".equals(namespaceURI) &&
                "EMixInstanceLog".equals(typeName)) {
            return cn.com.dhcc.www.epr.metaservice.EMixInstanceLog.Factory.parse(reader);
        }

        if ("http://www.dhcc.com.cn/epr/metaservice/SELECTGroupListNew".equals(
                    namespaceURI) &&
                "SELECTGroupListNew_type0".equals(typeName)) {
            return cn.com.dhcc.www.epr.metaservice.selectgrouplistnew.SELECTGroupListNew_type0.Factory.parse(reader);
        }

        if ("http://www.dhcc.com.cn/epr/metaservice".equals(namespaceURI) &&
                "Time".equals(typeName)) {
            return cn.com.dhcc.www.epr.metaservice.Time.Factory.parse(reader);
        }

        if ("http://www.dhcc.com.cn/epr/metaservice".equals(namespaceURI) &&
                "EInstanceLog".equals(typeName)) {
            return cn.com.dhcc.www.epr.metaservice.EInstanceLog.Factory.parse(reader);
        }

        if ("http://www.dhcc.com.cn/epr/metaservice".equals(namespaceURI) &&
                "EInstanceData".equals(typeName)) {
            return cn.com.dhcc.www.epr.metaservice.EInstanceData.Factory.parse(reader);
        }

        if ("http://www.dhcc.com.cn/epr/metaservice".equals(namespaceURI) &&
                "ReStreamData".equals(typeName)) {
            return cn.com.dhcc.www.epr.metaservice.ReStreamData.Factory.parse(reader);
        }

        if ("http://www.dhcc.com.cn/epr/metaservice".equals(namespaceURI) &&
                "EInsGroupNewDataSet".equals(typeName)) {
            return cn.com.dhcc.www.epr.metaservice.EInsGroupNewDataSet.Factory.parse(reader);
        }

        throw new org.apache.axis2.databinding.ADBException("Unsupported type " +
            namespaceURI + " " + typeName);
    }
}
