using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxMainTableValueFootnote : PxFootnote
    {

        public PxMainTable MainTable { get; set; }

        public PxVariable Variable { get; set; }

        public PxValue Value { get; set; }

        public PxMainTableValueFootnote()
        {
            FootnoteType = "9";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteMaintValue footnoteMainTableValue = new PxMetaModel.FootnoteMaintValue();

                footnoteMainTableValue.MainTable = MainTable.TableId;

                footnoteMainTableValue.Variable = Variable.Variable;

                footnoteMainTableValue.ValuePool = Value.ValuePool;

                footnoteMainTableValue.ValueCode = Value.ValueCode;

                footnoteMainTableValue.FootnoteNo = FootnoteNo;

                footnoteMainTableValue.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnoteMainTableValue.LogDate = DateTime.Now;

                context.AddToFootnoteMaintValues(footnoteMainTableValue);
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from mfvalue in context.FootnoteMaintValues
                     where mfvalue.FootnoteNo == FootnoteNo && mfvalue.MainTable == MainTable.TableId && mfvalue.Variable == Variable.Variable && mfvalue.ValuePool == Value.ValuePool && mfvalue.ValueCode == Value.ValueCode 
                     select mfvalue).First();

            context.DeleteObject(f);

        }

    }
}
