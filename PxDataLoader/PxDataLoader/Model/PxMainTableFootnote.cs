using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxMainTableFootnote : PxFootnote
    {

        public PxMainTable MainTable { get; set; }

        public PxMainTableFootnote()
        {
            FootnoteType = "7";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteMainTable footnoteMainTable = new PxMetaModel.FootnoteMainTable();

                footnoteMainTable.MainTable = MainTable.TableId;

                footnoteMainTable.FootnoteNo = FootnoteNo;

                footnoteMainTable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnoteMainTable.LogDate = DateTime.Now;

                context.AddToFootnoteMainTables(footnoteMainTable);
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from c in context.FootnoteMainTables 
                        where c.FootnoteNo == FootnoteNo && c.MainTable == MainTable.TableId 
                        select c).First();

            context.DeleteObject(f);

        }

    }
}
