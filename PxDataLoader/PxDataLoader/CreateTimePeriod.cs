using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PxDataLoader.Model;
using System.Windows.Forms;

namespace PxDataLoader
{
    public partial class CreateTimePeriod : Form
    {
        public PxDataLoader.Model.PxMainTable MainTable { get; set; }

        public string ImportFile { get; set; }

        public int FootnoteNo { get; set; }

        public CreateTimePeriod()
        {
            InitializeComponent();
        }

        private void CreateTimePeriod_Load(object sender, EventArgs e)
        {
            lbTimePeriods.DataSource = MainTable.Contents[0].TimePeriods;
            FootnoteNo = VariableFacade.GetFootnoteNextId();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AddPeriod(txbTimePeriod.Text))
            {
                txbTimePeriod.Text = GetNextTime(txbTimePeriod.Text);
            }
        }

        private bool AddPeriod(string period)
        {
            if (CheckTimePeriod(period) && !TimePeriodExistst(period))
            {

                foreach (var content in MainTable.Contents)
                {
                    PxDataLoader.Model.PxTime timePeriod = new Model.PxTime();
                    timePeriod.TimePeriod = period;
                    timePeriod.IsNew = true;
                    timePeriod.Content = content;
                    content.TimePeriods.Add(timePeriod);
                }
                return true;
            }
            return false;
        }

        private string GetNextTime(string timePeriod)
        {
            //check aginst times scale of maintable
            if (MainTable.TimeScaleId == "Year")
            {
                int year;
                int.TryParse(timePeriod, out year);
                year++;
                return year.ToString();

            }

            else if (MainTable.TimeScaleId == "Month")
            {


                int year;
                int month;
                int.TryParse(timePeriod.Substring(0, 4), out year);
                int.TryParse(timePeriod.Substring(5), out month);
                if (month == 12)
                {
                    month = 1;
                    year++;

                }
                else
                {
                    month++;
                }
               return year.ToString() + "-" + month.ToString();
            }

            else if (MainTable.TimeScaleId == "Quarter")
            {

                int quorter;
                int year;
                int.TryParse(timePeriod.Substring(0, 4), out year);
                int.TryParse(timePeriod.Substring(5), out quorter);
                if (quorter == 4) 
                {
                    quorter = 1;
                    year++;
                }
                else 
                {
                    quorter++;
                }
                return year.ToString() + "-" + quorter.ToString();
            }
            return "";
        }

        private bool CheckTimePeriod(string timePeriod)
        {
            //check aginst times scale of maintable
            if (MainTable.TimeScaleId == "Year")
            {
                if (timePeriod.Length != 4) return false;
                int year;
                if (!int.TryParse(timePeriod, out year)) return false;
                if (year < 1500) return false;
                
            }

            else if (MainTable.TimeScaleId == "Month")
            {
                if (timePeriod.Length != 7) return false;
                if (timePeriod[4] != '-') return false;
                int a;
                if (!int.TryParse(timePeriod.Substring(0, 4), out a)) return false;
                if (a < 1500) return false;
                if (!int.TryParse(timePeriod.Substring(5), out a)) return false;
                if (a < 1 || a > 12) return false;
            }

            else if (MainTable.TimeScaleId == "Quarter")
            {
                if (timePeriod.Length != 6) return false;
                if (timePeriod[4] != '-') return false;
                int a;
                if (!int.TryParse(timePeriod.Substring(0, 4), out a)) return false;
                if (a < 1500) return false;
                if (!int.TryParse(timePeriod.Substring(5), out a)) return false;
                if (a < 1 || a > 4) return false;
            }
            return true;
        }

        private bool TimePeriodExistst(string timePeriod)
        {
            foreach (var item in MainTable.Contents[0].TimePeriods)
            {
                if (String.Compare(timePeriod, item.TimePeriod, true) == 0)
                {
                    return true;
                }

            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (VariableFacade.AddContentsTime(MainTable))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ImportFile))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImportFromExcel(ofd.FileName);
                }
            }
            else
            {
                ImportFromExcel(ImportFile);
            }
        }

        private void ImportFromExcel(string excelPath)
        {
            List<string> periods = VariableFacade.GetTimeValuesFormExcel(excelPath);

            foreach (var period in periods)
            {
                if (!AddPeriod(period))
                {
                    MessageBox.Show("Could not add period " + period);
                }
            }

        }

        private void llCreateFootonoteForSelectedTimePeriod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PxTime pxTime = (PxTime)lbTimePeriods.SelectedItem;

            if (pxTime != null)
            {
                var timeFootnoteArray = (from tf in pxTime.TimeFootnotes
                                             select tf).ToArray();
                FootnoteDialog frmFootnote = new FootnoteDialog();

                frmFootnote.Context = pxTime;
                pxTime.Content.FootnoteTime = "B";

                if (timeFootnoteArray.Count() == 0)
                {
                    PxTimeFootnote timeFootnote = (PxTimeFootnote)CreateTimeFootnote(pxTime);
                    timeFootnoteArray = (from tf in pxTime.TimeFootnotes
                                             select tf).ToArray();
                }
                frmFootnote.SetDataSource((PxFootnote[])timeFootnoteArray);

                frmFootnote.AddFotnoteHandler = CreateTimeFootnote;
                frmFootnote.RemoveFootnoteHandler = RemoveTimeFootnote;
                frmFootnote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select a time period first!");

            }
        }

        public PxTimeFootnote CreateTimeFootnote(PxObject context)
        {
            PxTimeFootnote tf = new PxTimeFootnote();
            tf.FootnoteNo = FootnoteNo;
            FootnoteNo++;
            tf.FootnoteText = "Shenim i ri";
            tf.FootnoteTextEnglish = "New Footnote";
            tf.MandOption = "O";
            tf.ShowFootnote = "B";
            tf.IsNew = true;
            ((PxTime)lbTimePeriods.SelectedItem).TimeFootnotes.Add(tf);
            return tf;

        }


        public void RemoveTimeFootnote(PxObject context, PxFootnote footnote)
        {

            ((PxTime)lbTimePeriods.SelectedItem).TimeFootnotes.Remove((PxTimeFootnote)footnote);
            if (!footnote.IsNew)
            {
                ((PxTime)lbTimePeriods.SelectedItem).RemovedTimeFootnotes.Add((PxTimeFootnote)footnote);
            }

        }
    }
}
