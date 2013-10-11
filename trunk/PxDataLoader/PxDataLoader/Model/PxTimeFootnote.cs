using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxTimeFootnote : PxFootnote
    {

        public PxTime ContentTime { get; set; }

        public PxTimeFootnote()
        {
            FootnoteType = "4";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteContTime footnoteContentTime = new PxMetaModel.FootnoteContTime();

                footnoteContentTime.MainTable = ContentTime.Content.MainTable.TableId;

                footnoteContentTime.Contents = ContentTime.Content.Content;

                footnoteContentTime.TimePeriod = ContentTime.TimePeriod;

                footnoteContentTime.FootnoteNo = FootnoteNo;

                footnoteContentTime.Cellnote = "N";

                footnoteContentTime.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                footnoteContentTime.LogDate = DateTime.Now;

                context.AddToFootnoteContTimes(footnoteContentTime);
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from fcontTime in context.FootnoteContTimes
                     where fcontTime.FootnoteNo == FootnoteNo && fcontTime.MainTable == ContentTime.Content.MainTable.TableId && fcontTime.Contents == ContentTime.Content.Content && fcontTime.TimePeriod == ContentTime.TimePeriod
                     select fcontTime).FirstOrDefault();
            if (f != null)
            {
                context.DeleteObject(f);
            }

        }

    }
}
