using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastReport.Data;
using FastReport.BG.Data;

namespace FastReportBGObjects
{
    public class HierarchicalReportSource : HierarchicalDataSourceBase
    {
        private HierarchicalRootRecord root = new HierarchicalRootRecord();
        private DataSourceBase dataSource;
        private string valueMember = "";
        private List<string> levelTextMembers = new List<string>();

        public DataSourceBase DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }

        public string[] LevelTextMembers
        {
            get { return levelTextMembers.ToArray(); }
            set { levelTextMembers.Clear(); levelTextMembers.AddRange(value); }
        }

        private HierarchicalRecords GetLevelRecord(HierarchicalRecords level, string text)
        {
            HierarchicalRecord rec = level.Find(text);
            if (rec == null)
            {
                rec = new HierarchicalRecord(text);
                level.Add(rec);
            }
            return rec.Children;
        }

        public void Load()
        {
            int levelCount = levelTextMembers.Count;
            if (levelCount == 0) return;

            DataSource.Init();
            DataSource.First();

            HierarchicalRecords records = new HierarchicalRecords(null);

            while (DataSource.HasMoreRows)
            {
                HierarchicalRecords level = records;

                try
                {
                    for (int i = 0; i < levelCount - 1; i++)
                    {
                        level = GetLevelRecord(level, Convert.ToString(DataSource.Report.Calc(LevelTextMembers[i])));
                    }
                    level.Add(new HierarchicalRecord(Convert.ToString(DataSource.Report.Calc(LevelTextMembers[levelCount - 1])), Convert.ToDouble(DataSource.Report.Calc(ValueMember))));
                }
                catch (Exception)
                {
                }

                DataSource.Next();
            }

            root.SetChildren(records);
            DoChange();
        }

        public override string ValueMember
        {
            get { return valueMember; }
            set { valueMember = value; }
        }

        public override HierarchicalRecords Records => root.Children;

        public override HierarchicalRootRecord Root => root;
    }
}
