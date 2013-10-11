using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxValueFootnote : PxFootnote
    {

        public PxValue Value { get; set; }

        public PxValueFootnote()
        {
            FootnoteType = "9";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteValue footnoteValue = new PxMetaModel.FootnoteValue();

                footnoteValue.ValuePool = Value.ValuePool;

                footnoteValue.ValueCode = Value.ValueCode;

                footnoteValue.FootnoteNo = FootnoteNo;

                footnoteValue.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                footnoteValue.LogDate = DateTime.Now;

                context.AddToFootnoteValues(footnoteValue
                    );
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from fvalue in context.FootnoteValues
                     where fvalue.FootnoteNo == FootnoteNo  && fvalue.ValuePool == Value.ValuePool && fvalue.ValueCode == Value.ValueCode 
                     select fvalue).First();

            context.DeleteObject(f);

        }

    }
}
