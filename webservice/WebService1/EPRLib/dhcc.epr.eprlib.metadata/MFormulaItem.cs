using dhcc.epr.eprlib.formula;
using dhcc.epr.eprlib.instancedata;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Xml;

namespace dhcc.epr.eprlib.metadata
{
	public class MFormulaItem
	{
		private string _StrFormula;

		private string _Description;

		private CFormula _Formula;

		private NInstanceData _NInstanceData;

		public NInstanceData NInstanceData
		{
			get
			{
				return this._NInstanceData;
			}
			set
			{
				this._NInstanceData = value;
			}
		}

		public string StrFormula
		{
			get
			{
				return this._StrFormula;
			}
			set
			{
				this._StrFormula = value;
			}
		}

		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				this._Description = value;
			}
		}

		public CFormula Formula
		{
			get
			{
				if (this._Formula == null)
				{
					this._Formula = new CFormula(this._StrFormula, this._NInstanceData);
				}
				else if (Operators.CompareString(this._Formula.StrFormula, this._StrFormula, false) != 0)
				{
					this._Formula.StrFormula = this._StrFormula;
				}
				return this._Formula;
			}
		}

		[DebuggerNonUserCode]
		public MFormulaItem()
		{
		}

		public void XMLSerialize(XmlWriter writer)
		{
			writer.WriteStartElement("MFormulaItem");
			writer.WriteElementString("StrFormula", this.StrFormula);
			writer.WriteElementString("Description", this.Description);
			writer.WriteEndElement();
		}

		public void XMLDeserialize(XmlReader reader)
		{
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.StrFormula = reader.Value;
				reader.Read();
			}
			reader.Read();
			if (!reader.IsEmptyElement)
			{
				reader.Read();
				this.Description = reader.Value;
				reader.Read();
			}
		}
	}
}
