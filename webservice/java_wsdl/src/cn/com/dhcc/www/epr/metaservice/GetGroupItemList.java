/**
 * GetGroupItemList.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.7.6  Built on : Jul 30, 2017 (09:08:58 BST)
 */
package cn.com.dhcc.www.epr.metaservice;


/**
 *  GetGroupItemList bean class
 */
@SuppressWarnings({"unchecked",
    "unused"
})
public class GetGroupItemList implements org.apache.axis2.databinding.ADBBean {
    public static final javax.xml.namespace.QName MY_QNAME = new javax.xml.namespace.QName("http://www.dhcc.com.cn/epr/metaservice",
            "GetGroupItemList", "ns1");

    /**
     * field for APatientID
     */
    protected java.lang.String localAPatientID;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localAPatientIDTracker = false;

    /**
     * field for AEpisodeID
     */
    protected java.lang.String localAEpisodeID;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localAEpisodeIDTracker = false;

    /**
     * field for AEpisodeType
     */
    protected java.lang.String localAEpisodeType;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localAEpisodeTypeTracker = false;

    /**
     * field for AChartItemID
     */
    protected java.lang.String localAChartItemID;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localAChartItemIDTracker = false;

    /**
     * field for AChartItemType
     */
    protected java.lang.String localAChartItemType;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localAChartItemTypeTracker = false;

    /**
     * field for ACategoryType
     */
    protected java.lang.String localACategoryType;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localACategoryTypeTracker = false;

    /**
     * field for ACategoryID
     */
    protected java.lang.String localACategoryID;

    /*  This tracker boolean wil be used to detect whether the user called the set method
     *   for this attribute. It will be used to determine whether to include this field
     *   in the serialized XML
     */
    protected boolean localACategoryIDTracker = false;

    public boolean isAPatientIDSpecified() {
        return localAPatientIDTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getAPatientID() {
        return localAPatientID;
    }

    /**
     * Auto generated setter method
     * @param param APatientID
     */
    public void setAPatientID(java.lang.String param) {
        localAPatientIDTracker = param != null;

        this.localAPatientID = param;
    }

    public boolean isAEpisodeIDSpecified() {
        return localAEpisodeIDTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getAEpisodeID() {
        return localAEpisodeID;
    }

    /**
     * Auto generated setter method
     * @param param AEpisodeID
     */
    public void setAEpisodeID(java.lang.String param) {
        localAEpisodeIDTracker = param != null;

        this.localAEpisodeID = param;
    }

    public boolean isAEpisodeTypeSpecified() {
        return localAEpisodeTypeTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getAEpisodeType() {
        return localAEpisodeType;
    }

    /**
     * Auto generated setter method
     * @param param AEpisodeType
     */
    public void setAEpisodeType(java.lang.String param) {
        localAEpisodeTypeTracker = param != null;

        this.localAEpisodeType = param;
    }

    public boolean isAChartItemIDSpecified() {
        return localAChartItemIDTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getAChartItemID() {
        return localAChartItemID;
    }

    /**
     * Auto generated setter method
     * @param param AChartItemID
     */
    public void setAChartItemID(java.lang.String param) {
        localAChartItemIDTracker = param != null;

        this.localAChartItemID = param;
    }

    public boolean isAChartItemTypeSpecified() {
        return localAChartItemTypeTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getAChartItemType() {
        return localAChartItemType;
    }

    /**
     * Auto generated setter method
     * @param param AChartItemType
     */
    public void setAChartItemType(java.lang.String param) {
        localAChartItemTypeTracker = param != null;

        this.localAChartItemType = param;
    }

    public boolean isACategoryTypeSpecified() {
        return localACategoryTypeTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getACategoryType() {
        return localACategoryType;
    }

    /**
     * Auto generated setter method
     * @param param ACategoryType
     */
    public void setACategoryType(java.lang.String param) {
        localACategoryTypeTracker = param != null;

        this.localACategoryType = param;
    }

    public boolean isACategoryIDSpecified() {
        return localACategoryIDTracker;
    }

    /**
     * Auto generated getter method
     * @return java.lang.String
     */
    public java.lang.String getACategoryID() {
        return localACategoryID;
    }

    /**
     * Auto generated setter method
     * @param param ACategoryID
     */
    public void setACategoryID(java.lang.String param) {
        localACategoryIDTracker = param != null;

        this.localACategoryID = param;
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
                this, MY_QNAME));
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
                    namespacePrefix + ":GetGroupItemList", xmlWriter);
            } else {
                writeAttribute("xsi",
                    "http://www.w3.org/2001/XMLSchema-instance", "type",
                    "GetGroupItemList", xmlWriter);
            }
        }

        if (localAPatientIDTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "APatientID", xmlWriter);

            if (localAPatientID == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "APatientID cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localAPatientID);
            }

            xmlWriter.writeEndElement();
        }

        if (localAEpisodeIDTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "AEpisodeID", xmlWriter);

            if (localAEpisodeID == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "AEpisodeID cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localAEpisodeID);
            }

            xmlWriter.writeEndElement();
        }

        if (localAEpisodeTypeTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "AEpisodeType", xmlWriter);

            if (localAEpisodeType == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "AEpisodeType cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localAEpisodeType);
            }

            xmlWriter.writeEndElement();
        }

        if (localAChartItemIDTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "AChartItemID", xmlWriter);

            if (localAChartItemID == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "AChartItemID cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localAChartItemID);
            }

            xmlWriter.writeEndElement();
        }

        if (localAChartItemTypeTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "AChartItemType", xmlWriter);

            if (localAChartItemType == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "AChartItemType cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localAChartItemType);
            }

            xmlWriter.writeEndElement();
        }

        if (localACategoryTypeTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "ACategoryType", xmlWriter);

            if (localACategoryType == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "ACategoryType cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localACategoryType);
            }

            xmlWriter.writeEndElement();
        }

        if (localACategoryIDTracker) {
            namespace = "http://www.dhcc.com.cn/epr/metaservice";
            writeStartElement(null, namespace, "ACategoryID", xmlWriter);

            if (localACategoryID == null) {
                // write the nil attribute
                throw new org.apache.axis2.databinding.ADBException(
                    "ACategoryID cannot be null!!");
            } else {
                xmlWriter.writeCharacters(localACategoryID);
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
        public static GetGroupItemList parse(
            javax.xml.stream.XMLStreamReader reader) throws java.lang.Exception {
            GetGroupItemList object = new GetGroupItemList();

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

                        if (!"GetGroupItemList".equals(type)) {
                            //find namespace for the prefix
                            java.lang.String nsUri = reader.getNamespaceContext()
                                                           .getNamespaceURI(nsPrefix);

                            return (GetGroupItemList) cn.com.dhcc.www.epr.metaservice.ExtensionMapper.getTypeObject(nsUri,
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
                            "http://www.dhcc.com.cn/epr/metaservice",
                            "APatientID").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "APatientID").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "APatientID" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setAPatientID(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
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
                            "AEpisodeID").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "AEpisodeID").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "AEpisodeID" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setAEpisodeID(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
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
                            "AEpisodeType").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "AEpisodeType").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "AEpisodeType" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setAEpisodeType(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
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
                            "AChartItemID").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "AChartItemID").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "AChartItemID" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setAChartItemID(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
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
                            "AChartItemType").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "AChartItemType").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "AChartItemType" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setAChartItemType(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
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
                            "ACategoryType").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "ACategoryType").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "ACategoryType" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setACategoryType(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
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
                            "ACategoryID").equals(reader.getName())) ||
                        new javax.xml.namespace.QName("", "ACategoryID").equals(
                            reader.getName())) {
                    nillableValue = reader.getAttributeValue("http://www.w3.org/2001/XMLSchema-instance",
                            "nil");

                    if ("true".equals(nillableValue) ||
                            "1".equals(nillableValue)) {
                        throw new org.apache.axis2.databinding.ADBException(
                            "The element: " + "ACategoryID" +
                            "  cannot be null");
                    }

                    java.lang.String content = reader.getElementText();

                    object.setACategoryID(org.apache.axis2.databinding.utils.ConverterUtil.convertToString(
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
