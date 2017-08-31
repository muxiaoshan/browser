using System;
using System.Text;
using System.Xml;

namespace dhcc.epr.systemframework
{
	public class XmlCompressor
	{
		private static string TAG_EPR_STYLE_COLLECTION = "EPRStyleCollection";

		private static string TAG_EPR_STYLE = "EPRStyle";

		private static string TAG_EPR_STYLE_ID = "EPRStyleID";

		private static string ATTRIBUTE_EPR_STYLE_ID = "ID";

		private static string XPATH_EPR_STYLE = "/EPRStyleCollection/EPRStyle";

		private static string XPATH_FP = "//Spread";

		private static string XPATH_FP_EPR_STYLE_COLLECTION = "//Spread/EPRStyleCollection";

		private static string XPATH_FP_CELLTYLE = "//Spread/Presentation/Sheets/Sheet/StyleModels/DataArea/CellStyles/CellStyle";

		public static string CompressXml(string xmlData)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xmlData);
			XmlCompressor.CompressXml(ref xmlDocument);
			return xmlDocument.OuterXml;
		}

		public static void CompressXml(ref XmlDocument doc)
		{
			if (XmlCompressor.IsXmlCompressed(doc))
			{
				return;
			}
			XmlNodeList xmlNodeList = doc.SelectNodes(XmlCompressor.XPATH_FP_CELLTYLE);
			if (xmlNodeList.Count < 1)
			{
				return;
			}
			XmlDocument styleDoc = XmlCompressor.CreateEPRStyleDoc();
			int num = 0;
			string style = string.Empty;
			string text = string.Empty;
			foreach (XmlNode xmlNode in xmlNodeList)
			{
				style = xmlNode.InnerXml;
				text = XmlCompressor.GetEPRStyleID(styleDoc, style);
				if (text.Equals(string.Empty))
				{
					num++;
					text = num.ToString();
					XmlCompressor.AddEPRStyle(ref styleDoc, style, num);
				}
				xmlNode.InnerXml = XmlCompressor.GetCompressedStyle(text);
			}
			XmlCompressor.AppendEPRStyleXml(ref doc, styleDoc);
		}

		private static bool IsXmlCompressed(XmlDocument doc)
		{
			return doc.SelectSingleNode(XmlCompressor.XPATH_FP_EPR_STYLE_COLLECTION) != null;
		}

		private static XmlDocument CreateEPRStyleDoc()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<");
			stringBuilder.Append(XmlCompressor.TAG_EPR_STYLE_COLLECTION);
			stringBuilder.Append("></");
			stringBuilder.Append(XmlCompressor.TAG_EPR_STYLE_COLLECTION);
			stringBuilder.Append(">");
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(stringBuilder.ToString());
			return xmlDocument;
		}

		private static void AddEPRStyle(ref XmlDocument styleDoc, string style, int count)
		{
			XmlAttribute xmlAttribute = styleDoc.CreateAttribute(XmlCompressor.ATTRIBUTE_EPR_STYLE_ID);
			xmlAttribute.Value = count.ToString();
			XmlElement xmlElement = styleDoc.CreateElement(XmlCompressor.TAG_EPR_STYLE);
			xmlElement.Attributes.Append(xmlAttribute);
			xmlElement.InnerXml = style;
			styleDoc.DocumentElement.AppendChild(xmlElement);
		}

		private static string GetEPRStyleID(XmlDocument styleDoc, string style)
		{
			string result = string.Empty;
			XmlNodeList xmlNodeList = styleDoc.SelectNodes(XmlCompressor.XPATH_EPR_STYLE);
			foreach (XmlNode xmlNode in xmlNodeList)
			{
				if (xmlNode.InnerXml == style)
				{
					result = xmlNode.Attributes[XmlCompressor.ATTRIBUTE_EPR_STYLE_ID].InnerText;
					break;
				}
			}
			return result;
		}

		private static string GetCompressedStyle(string styleID)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<");
			stringBuilder.Append(XmlCompressor.TAG_EPR_STYLE_ID);
			stringBuilder.Append(">");
			stringBuilder.Append(styleID);
			stringBuilder.Append("</");
			stringBuilder.Append(XmlCompressor.TAG_EPR_STYLE_ID);
			stringBuilder.Append(">");
			return stringBuilder.ToString();
		}

		private static void AppendEPRStyleXml(ref XmlDocument doc, XmlDocument styleDoc)
		{
			XmlElement xmlElement = doc.CreateElement(XmlCompressor.TAG_EPR_STYLE_COLLECTION);
			xmlElement.InnerXml = styleDoc.DocumentElement.InnerXml;
			XmlNode xmlNode = doc.SelectSingleNode(XmlCompressor.XPATH_FP);
			xmlNode.AppendChild(xmlElement);
		}

		public static string DecompressXml(string xmlData)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xmlData);
			XmlCompressor.DecompressXml(ref xmlDocument);
			return xmlDocument.OuterXml;
		}

		public static void DecompressXml(ref XmlDocument doc)
		{
			XmlNode xmlNode = doc.SelectSingleNode(XmlCompressor.XPATH_FP_EPR_STYLE_COLLECTION);
			if (xmlNode == null)
			{
				return;
			}
			XmlNodeList childNodes = xmlNode.ChildNodes;
			if (childNodes.Count < 1)
			{
				XmlCompressor.RemoveEPRStyleXml(ref doc, xmlNode);
				return;
			}
			XmlNodeList xmlNodeList = doc.SelectNodes(XmlCompressor.XPATH_FP_CELLTYLE + "/" + XmlCompressor.TAG_EPR_STYLE_ID);
			foreach (XmlNode xmlNode2 in xmlNodeList)
			{
				xmlNode2.ParentNode.InnerXml = XmlCompressor.GetDecompressedStyle(childNodes, xmlNode2.InnerText);
			}
			XmlCompressor.RemoveEPRStyleXml(ref doc, xmlNode);
		}

		private static string GetDecompressedStyle(XmlNodeList styleNodeList, string styleID)
		{
			string result = "";
			try
			{
				result = styleNodeList[Convert.ToInt32(styleID) - 1].InnerXml;
			}
			catch (Exception ex)
			{
				MessageManager.ShowErrorMessage("解压缩Xml文件错误！\r\n 错误信息: \r\n" + ex.Message + "\r\n" + ex.StackTrace);
			}
			return result;
		}

		private static void RemoveEPRStyleXml(ref XmlDocument doc, XmlNode styleCollectionNode)
		{
			styleCollectionNode.ParentNode.RemoveChild(styleCollectionNode);
		}
	}
}
