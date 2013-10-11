using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxContentValueFootnote : PxFootnote
    {

        public PxMainTable MainTable { get; set; }

        public PxContent Content { get; set; }

        public PxVariable Variable { get; set; }

        public PxValue Value { get; set; }

        public PxContentValueFootnote()
        {
            FootnoteType = "4";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteContValue footnoteContentValue = new PxMetaModel.FootnoteContValue();

                footnoteContentValue.MainTable = MainTable.TableId;

                footnoteContentValue.Contents = Content.Content;

                footnoteContentValue.Variable = Variable.Variable;

                footnoteContentValue.ValuePool = Value.ValuePool;

                footnoteContentValue.ValueCode = Value.ValueCode;

                footnoteContentValue.FootnoteNo = FootnoteNo;
                footnoteContentValue.Cellnote = "N";

                footnoteContentValue.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnoteContentValue.LogDate = DateTime.Now;

                context.AddToFootnoteContValues(footnoteContentValue);
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from cfvalue in context.FootnoteContValues
                     where cfvalue.FootnoteNo == FootnoteNo && cfvalue.MainTable == MainTable.TableId && cfvalue.Contents == Content.Content && cfvalue.Variable == Variable.Variable && cfvalue.ValuePool == Value.ValuePool && cfvalue.ValueCode == Value.ValueCode
                     select cfvalue).First();

            context.DeleteObject(f);

        }

    }
}
