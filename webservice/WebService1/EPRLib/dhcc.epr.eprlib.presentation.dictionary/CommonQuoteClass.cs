using dhcc.epr.eprlib.dataaccess;
using HISData;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace dhcc.epr.eprlib.presentation.dictionary
{
	public class CommonQuoteClass
	{
		[DebuggerNonUserCode]
		public CommonQuoteClass()
		{
		}

		public void QueryEpsoideList(DataGridView dgEpsoideList, string patientID)
		{
			dgEpsoideList.Rows.Clear();
			EEpisodeListByPIdDataset eEpisodeListByPIdDataset = new EEpisodeListByPIdDataset();
			eEpisodeListByPIdDataset = WebServiceLayer.HISDataAccess.GetEpisodeListByPID(patientID);
			dgEpsoideList.DataSource = eEpisodeListByPIdDataset.Tables["GetEpisodeListByPID"];
			dgEpsoideList.Sort(dgEpsoideList.Columns["EpisodeDate"], ListSortDirection.Descending);
			CommonFuncs.DataGridStyle(ref dgEpsoideList);
			dgEpsoideList.Columns["EpisodeDate"].HeaderText = "就诊日期";
			dgEpsoideList.Columns["EpisodeDate"].Width = 120;
			dgEpsoideList.Columns["DeptDesc"].HeaderText = "就诊科室";
			dgEpsoideList.Columns["DeptDesc"].Width = 100;
			dgEpsoideList.Columns["MainDocName"].HeaderText = "就诊医生";
			dgEpsoideList.Columns["MainDocName"].Width = 60;
			dgEpsoideList.Columns["EpisodeType"].HeaderText = "就诊类型";
			dgEpsoideList.Columns["EpisodeType"].Width = 60;
			dgEpsoideList.Columns["EpisodeReason"].HeaderText = "病人类型";
			dgEpsoideList.Columns["EpisodeReason"].Width = 60;
			dgEpsoideList.Columns["DischargeDate"].HeaderText = "出院日期";
			dgEpsoideList.Columns["DischargeDate"].Width = 120;
			dgEpsoideList.Columns["Diagnosis"].HeaderText = "诊断";
			dgEpsoideList.Columns["Diagnosis"].Width = 190;
			dgEpsoideList.Columns["EpisodeID"].Visible = false;
		}
	}
}
