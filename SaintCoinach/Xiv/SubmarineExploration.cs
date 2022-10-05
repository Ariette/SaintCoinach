using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintCoinach.Xiv {
    public class SubmarineExploration  : XivRow {
        #region Properties

        public Text.XivString Name { get { return AsString("Destination"); } }

        public int RequiredLevel { get { return AsInt32("RankReq"); } }

        public int RequiredFuel { get { return AsInt32("CeruleumTankReq"); } }

        public TimeSpan Duration { get { return TimeSpan.FromMinutes(AsInt32("SurveyDuration<min>")); } }

        public int ExpReward { get { return AsInt32("ExpReward"); } }

        #endregion

        #region Constructors

        public SubmarineExploration(IXivSheet sheet, SaintCoinach.Ex.Relational.IRelationalRow sourceRow) : base(sheet, sourceRow) { }

        #endregion
    }
}
