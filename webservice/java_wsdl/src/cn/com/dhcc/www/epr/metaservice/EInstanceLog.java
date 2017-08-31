/**
 * EInstanceLog.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.7.6  Built on : Jul 30, 2017 (09:08:58 BST)
 */
package cn.com.dhcc.www.epr.metaservice;


/**
 *  EInstanceLog bean class
 */
@SuppressWarnings({"unchecked",
    "unused"
})
public class EInstanceLog implements org.apache.axis2.databinding.ADBBean {
    /* This type was generated from the piece of schema that had
       name = EInstanceLog
       Namespace URI = http://www.dhcc.com.cn/epr/metaservice
       Namespace Prefix = ns1
     */

    /**
     * field for Action
     */
    protected java.lang.String localAction;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localActionTracker = false;

    /**
     * field for OperateDate
     */
    protected java.lang.String localOperateDate;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localOperateDateTracker = false;

    /**
     * field for FinalStatus
     */
    protected java.lang.String localFinalStatus;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localFinalStatusTracker = false;

    /**
     * field for InitStatus
     */
    protected java.lang.String localInitStatus;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localInitStatusTracker = false;

    /**
     * field for OperateTime
     */
    protected java.lang.String localOperateTime;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localOperateTimeTracker = false;

    /**
     * field for OperateUserID
     */
    protected java.lang.String localOperateUserID;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localOperateUserIDTracker = false;

    /**
     * field for OperateMachineIP
     */
    protected java.lang.String localOperateMachineIP;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localOperateMachineIPTracker = false;

    /**
     * field for RealOperateUserID
     */
    protected java.lang.String localRealOperateUserID;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localRealOperateUserIDTracker = false;

    /**
     * field for OperateUserName
     */
    protected java.lang.String localOperateUserName;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localOperateUserNameTracker = false;

    public boolean isActionSpecified() {
        return localActionTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getAction() {
        return localAction;
    }

    /**
     * Auto generated setter method
     * @param param Action
     */
    public void setAction(java.lang.String param) {
        localActionTracker = param != null;

        this.localAction = param;
    }

    public boolean isOperateDateSpecified() {
        return localOperateDateTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getOperateDate() {
        return localOperateDate;
    }

    /**
     * Auto generated setter method
     * @param param OperateDate
     */
    public void setOperateDate(java.lang.String param) {
        localOperateDateTracker = param != null;

        this.localOperateDate = param;
    }

    public boolean isFinalStatusSpecified() {
        return localFinalStatusTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getFinalStatus() {
        return localFinalStatus;
    }

    /**
     * Auto generated setter method
     * @param param FinalStatus
     */
    public void setFinalStatus(java.lang.String param) {
        localFinalStatusTracker = param != null;

        this.localFinalStatus = param;
    }

    public boolean isInitStatusSpecified() {
        return localInitStatusTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getInitStatus() {
        return localInitStatus;
    }

    /**
     * Auto generated setter method
     * @param param InitStatus
     */
    public void setInitStatus(java.lang.String param) {
        localInitStatusTracker = param != null;

        this.localInitStatus = param;
    }

    public boolean isOperateTimeSpecified() {
        return localOperateTimeTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getOperateTime() {
        return localOperateTime;
    }

    /**
     * Auto generated setter method
     * @param param OperateTime
     */
    public void setOperateTime(java.lang.String param) {
        localOperateTimeTracker = param != null;

        this.localOperateTime = param;
    }

    public boolean isOperateUserIDSpecified() {
        return localOperateUserIDTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getOperateUserID() {
        return localOperateUserID;
    }

    /**
     * Auto generated setter method
     * @param param OperateUserID
     */
    public void setOperateUserID(java.lang.String param) {
        localOperateUserIDTracker = param != null;

        this.localOperateUserID = param;
    }

    public boolean isOperateMachineIPSpecified() {
        return localOperateMachineIPTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getOperateMachineIP() {
        return localOperateMachineIP;
    }

    /**
     * Auto generated setter method
     * @param param OperateMachineIP
     */
    public void setOperateMachineIP(java.lang.String param) {
        localOperateMachineIPTracker = param != null;

        this.localOperateMachineIP = param;
    }

    public boolean isRealOperateUserIDSpecified() {
        return localRealOperateUserIDTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getRealOperateUserID() {
        return localRealOperateUserID;
    }

    /**
     * Auto generated setter method
     * @param param RealOperateUserID
     */
    public void setRealOperateUserID(java.lang.String param) {
        localRealOperateUserIDTracker = param != null;

        this.localRealOperateUserID = param;
    }

    public boolean isOperateUserNameSpecified() {
        return localOperateUserNameTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getOperateUserName() {
        return localOperateUserName;
    }

    /**
     * Auto generated setter method
     * @param param OperateUserName
     */
    public void setOperateUserName(java.lang.String param) {
        localOperateUserNameTracker = param != null;

        this.localOperateUserName = param;
    }

    /**
     *
     * @param parentQName
     * @param factory
     * @return org.apache.axiom.om.OMElement
     */
    public org.apache.axiom.om.OMElement getOMElement(
        final javax.xml.namespace.QName parentQName,
        final org.apache.axiom.om.OMFactory factory)
        throws org.apache.axis2.databinding.ADBException {
        return factory.createOMElement(new org.apache.axis2.databinding.ADBDataSource(
                this, parentQName));
    }

    public void serialize(final javax.xml.namespace.QName parentQName,
        javax.xml.stream.XMLStreamWriter xmlWriter)
        throws javax.xml.stream.XMLStreamException,
            org.apache.axis2.databinding.ADBException {
        serialize(parentQName, xmlWriter, false);
    }

    public void serialize(final javax.xml.namespace.QName parentQName,
        javax.xml.stream.XMLStreamWriter xmlWriter, boolean serializeType)
        throws javax.xml.stream.XMLStreamException,
            org.apache.axis2.databinding.ADBException {
        java.lang.String prefix = null;
        java.lang.String namespace = null;

        prefix = parentQName.getPrefix();
        namespace = parentQName.getNamespaceURI();
        writeStartElement(prefix, namespace, parentQName.getLocalPart(),
            xmlWriter);

        if (serializeType) {
            java.lang.String namespacePrefix = registerPrefix(xmlWriter,
                    "http://www.dhcc.com.cn/epr/metaservice");

            if ((namespacePrefix != null) &&
                    (namespacePrefix.trim().length() > 0)) {
                writeAttribute("xsi",
                    "http://www.w3.org/2001/XMLSchema-instance", "type",
                    namespacePrefix + ":EInstanceLog", xmlWriter);
            } else {
                writeAttribute("xsi",
                    "http://www.w3.org/2001/XMLSchema-instance", "type",
                    "EInstanceLog", xmlWriter);
            }
        }

        if (localActionTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "Action", xmlWriter);

            if (localAction == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "Action cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localAction);
            }

            xmlWriter.writeEndElement();
        }

        if (localOperateDateTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "OperateDate", xmlWriter);

            if (localOperateDate == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "OperateDate cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localOperateDate);
            }

            xmlWriter.writeEndElement();
        }

        if (localFinalStatusTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "FinalStatus", xmlWriter);

            if (localFinalStatus == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "FinalStatus cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localFinalStatus);
            }

            xmlWriter.writeEndElement();
        }

        if (localInitStatusTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "InitStatus", xmlWriter);

            if (localInitStatus == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "InitStatus cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localInitStatus);
            }

            xmlWriter.writeEndElement();
        }

        if (localOperateTimeTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "OperateTime", xmlWriter);

            if (localOperateTime == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "OperateTime cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localOperateTime);
            }

            xmlWriter.writeEndElement();
        }

        if (localOperateUserIDTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "OperateUserID", xmlWriter);

            if (localOperateUserID == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "OperateUserID cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localOperateUserID);
            }

            xmlWriter.writeEndElement();
        }

        if (localOperateMachineIPTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "OperateMachineIP", xmlWriter);

            if (localOperateMachineIP == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "OperateMachineIP cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localOperateMachineIP);
            }

            xmlWriter.writeEndElement();
        }

        if (localRealOperateUserIDTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "RealOperateUserID", xmlWriter);

            if (localRealOperateUserID == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "RealOperateUserID cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localRealOperateUserID);
            }

            xmlWriter.writeEndElement();
        }

        if (localOperateUserNameTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "OperateUserName", xmlWriter);

            if (localOperateUserName == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "OperateUserName cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localOperateUserName);
            }

            xmlWriter.writeEndElement();
        }

        xmlWriter.writeEndElement();
    }

    private static java.lang.String generatePrefix(java.lang.String namespace) {
        if (namespace.equals("http://www.dhcc.com.cn/epr/metaservice")) {
            return "ns1";
        }

        return org.apache.axis2.databinding.utils.BeanUtil.getUniquePrefix();
    }

    /**
     * Utility method to write an element start tag.
     */
    private void writeStartElement(java.lang.String prefix,
        java.lang.String namespace, java.lang.String localPart,
        javax.xml.stream.XMLStreamWriter xmlWriter)
        throws javax.xml.stream.XMLStreamException {
        java.lang.String writerPrefix = xmlWriter.getPrefix(namespace);

        if (writerPrefix != null) {
            xmlWriter.writeStartElement(writerPrefix, localPart, namespace);
        } else {
            if (namespace.length() == 0) {
                prefix = "";
            } else if (prefix == null) {
                prefix = generatePrefix(namespace);
            }

            xmlWriter.writeStartElement(prefix, localPart, namespace);
            xmlWriter.writeNamespace(prefix, namespace);
            xmlWriter.setPrefix(prefix, namespace);
        }
    }

    /**
     * Util method to write an attribute with the ns prefix
     */
    private void writeAttribute(java.lang.String prefix,
        java.lang.String namespace, java.lang.String attName,
        java.lang.String attValue, javax.xml.stream.XMLStreamWriter xmlWriter)
        throws javax.xml.stream.XMLStreamException {
        java.lang.String writerPrefix = xmlWriter.getPrefix(namespace);

        if (writerPrefix != null) {
            xmlWriter.writeAttribute(writerPrefix, namespace, attName, attValue);
        } else {
            xmlWriter.writeNamespace(prefix, namespace);
            xmlWriter.setPrefix(prefix, namespace);
            xmlWriter.writeAttribute(prefix, namespace, attName, attValue);
        }
    }

    /**
     * Util method to write an attribute without the ns prefix
     */
    private void writeAttribute(java.lang.String namespace,
        java.lang.String attName, java.lang.String attValue,
        javax.xml.stream.XMLStreamWriter xmlWriter)
        throws javax.xml.stream.XMLStreamException {
        if (namespace.equals("")) {
            xmlWriter.writeAttribute(attName, attValue);
        } else {
            xmlWriter.writeAttribute(registerPrefix(xmlWriter, namespace),
                namespace, attName, attValue);
        }
    }

    /**
     * Util method to write an attribute without the ns prefix
     */
    private void writeQNameAttribute(java.lang.String namespace,
        java.lang.String attName, javax.xml.namespace.QName qname,
        javax.xml.stream.XMLStreamWriter xmlWriter)
        throws javax.xml.stream.XMLStreamException {
        java.lang.String attributeNamespace = qname.getNamespaceURI();
        java.lang.String attributePrefix = xmlWriter.getPrefix(attributeNamespace);

        if (attributePrefix == null) {
            attributePrefix = registerPrefix(xmlWriter, attributeNamespace);
        }

        java.lang.String attributeValue;

        if (attributePrefix.trim().length() > 0) {
            attributeValue = attributePrefix + ":" + qname.getLocalPart();
        } else {
            attributeValue = qname.getLocalPart();
        }

        if (namespace.equals("")) {
            xmlWriter.writeAttribute(attName, attributeValue);
        } else {
            registerPrefix(xmlWriter, namespace);
            xmlWriter.writeAttribute(attributePrefix, namespace, attName,
                attributeValue);
        }
    }

    /**
     *  method to handle Qnames
     */
    private void writeQName(javax.xml.namespace.QName qname,
        javax.xml.stream.XMLStreamWriter xmlWriter)
        throws javax.xml.stream.XMLStreamException {
        java.lang.String namespaceURI = qname.getNamespaceURI();

        if (namespaceURI != null) {
            java.lang.String prefix = xmlWriter.getPrefix(namespaceURI);

            if (prefix == null) {
                prefix = generatePrefix(namespaceURI);
                xmlWriter.writeNamespace(prefix, namespaceURI);
                xmlWriter.setPrefix(prefix, namespaceURI);
            }

            if (prefix.trim().length() > 0) {
                xmlWriter.writeCharacters(prefix + ":" +
                    org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                        qname));
            } else {
                // i.e this is the default namespace
                xmlWriter.writeCharacters(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                        qname));
            }
        } else {
            xmlWriter.writeCharacters(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                    qname));
        }
    }

    private void writeQNames(javax.xml.namespace.QName[] qnames,
        javax.xml.stream.XMLStreamWriter xmlWriter)
        throws javax.xml.stream.XMLStreamException {
        if (qnames != null) {
            // we have to store this data until last moment since it is not possible to write any
            // namespace data after writing the charactor data
            java.lang.StringBuffer stringToWrite = new java.lang.StringBuffer();
            java.lang.String namespaceURI = null;
            java.lang.String prefix = null;

            for (int i = 0; i < qnames.length; i++) {
                if (i > 0) {
                    stringToWrite.append(" ");
                }

                namespaceURI = qnames[i].getNamespaceURI();

                if (namespaceURI != null) {
                    prefix = xmlWriter.getPrefix(namespaceURI);

                    if ((prefix == null) || (prefix.length() == 0)) {
                        prefix = generatePrefix(namespaceURI);
                        xmlWriter.writeNamespace(prefix, namespaceURI);
                        xmlWriter.setPrefix(prefix, namespaceURI);
                    }

                    if (prefix.trim().length() > 0) {
                        stringToWrite.append(prefix).append(":")
                                     .append(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                                qnames[i]));
                    } else {
                        stringToWrite.append(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                                qnames[i]));
                    }
                } else {
                    stringToWrite.append(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            qnames[i]));
                }
            }

            xmlWriter.writeCharacters(stringToWrite.toString());
        }
    }

    /**
     * Register a namespace prefix
     */
    private java.lang.String registerPrefix(
        javax.xml.stream.XMLStreamWriter xmlWriter, java.lang.String namespace)
        throws javax.xml.stream.XMLStreamException {
        java.lang.String prefix = xmlWriter.getPrefix(namespace);

        if (prefix == null) {
            prefix = generatePrefix(namespace);

            javax.xml.namespace.NamespaceContext nsContext = xmlWriter.getNamespaceContext();

            while (true) {
                java.lang.String uri = nsContext.getNamespaceURI(prefix);

                if ((uri == null) || (uri.length() == 0)) {
                    break;
                }

                prefix = org.apache.axis2.databinding.utils.BeanUtil.getUniquePrefix();
            }

            xmlWriter.writeNamespace(prefix, namespace);
            xmlWriter.setPrefix(prefix, namespace);
        }

        return prefix;
    }

    /**
     *  Factory class that keeps the parse method
     */
    public static class Factory {
        private static org.apache.commons.logging.Log log = org.apache.commons.logging.LogFactory.getLog(Factory.class);

        /**
         * static method to create the object
         * Precondition:  If this object is an element, the current or next start element starts this object and any intervening reader events are ignorable
         *                If this object is not an element, it is a complex type and the reader is at the event just after the outer start element
         * Postcondition: If this object is an element, the reader is positioned at its end element
         *                If this object is a complex type, the reader is positioned at the end element of its outer element
         */
        public static EInstanceLog parse(
            javax.xml.stream.XMLStreamReader reader) throws java.lang.Exception {
            EInstanceLog object = new EInstanceLog();

            int event;
            javax.xml.namespace.QName currentQName = null;
            java.lang.String nillableValue = null;
            java.lang.String prefix = "";
            java.lang.String namespaceuri = "";

            try {
                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                currentQName = reader.getName();

                if (reader.getAttributeValue(
                            "http://www.w3.org/2001/XMLSchema-instance", "type") != null) {
                    java.lang.String fullTypeName = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "type");

                    if (fullTypeName != null) {
                        java.lang.String nsPrefix = null;

                        if (fullTypeName.indexOf(":") > -1) {
                            nsPrefix = fullTypeName.substring(0,
                                    fullTypeName.indexOf(":"));
                        }

                        nsPrefix = (nsPrefix == null) ? "" : nsPrefix;

                        java.lang.String type = fullTypeName.substring(fullTypeName.indexOf(
                                    ":") + 1);

                        if (!"EInstanceLog".equals(type)) {
                            //find namespace for the prefix
                            java.lang.String nsUri = reader.getNamespaceContext()
                                                           .getNamespaceURI(nsPrefix);

                            return (EInstanceLog) cn.com.dhcc.www.epr.metaservice.ExtensionMapper.getTypeObject(nsUri,
                                type, reader);
                        }
                    }
                }

                // Note all attributes that were handled. Used to differ normal attributes
                // from anyAttributes.
                java.util.Vector handledAttributes = new java.util.Vector();

                reader.next();

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice", "Action").equals(
                            reader.getName())) ||
                        new javax.xml.namespace.QName("", "Action").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "Action" + "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setAction(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "OperateDate").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "OperateDate").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "OperateDate" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setOperateDate(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "FinalStatus").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "FinalStatus").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "FinalStatus" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setFinalStatus(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "InitStatus").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "InitStatus").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "InitStatus" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setInitStatus(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "OperateTime").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "OperateTime").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "OperateTime" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setOperateTime(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "OperateUserID").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "OperateUserID").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "OperateUserID" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setOperateUserID(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "OperateMachineIP").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "OperateMachineIP").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "OperateMachineIP" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setOperateMachineIP(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "RealOperateUserID").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "RealOperateUserID").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "RealOperateUserID" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setRealOperateUserID(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if ((reader.isStartElement() &&
                        new javax.xml.namespace.QName(
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "OperateUserName").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "OperateUserName").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "OperateUserName" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setOperateUserName(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
                            content));

                    reader.next();
                } // End of if for expected property start element

                else {
                }

                while (!reader.isStartElement() && !reader.isEndElement())
                    reader.next();

                if (reader.isStartElement()) {
                    // 2 - A start element we are not expecting indicates a trailing invalid property
                    throw new org.apache.axis2.databinding.ADBException(
                        "Unexpected subelement " + reader.getName());
                }
            } catch (javax.xml.stream.XMLStreamException e) {
                throw new java.lang.Exception(e);
            }

            return object;
        }
    } //end of factory class
}
