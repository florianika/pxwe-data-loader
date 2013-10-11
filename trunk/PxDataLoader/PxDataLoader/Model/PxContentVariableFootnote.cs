using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxContentVariableFootnote : PxFootnote
    {

        public PxMainTable MainTable { get; set; }

        public PxContent Content { get; set; }

        public PxVariable Variable { get; set; }

        public PxContentVariableFootnote()
        {
            FootnoteType = "3";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteContVbl footnoteContentVariable = new PxMetaModel.FootnoteContVbl();

                footnoteContentVariable.MainTable = MainTable.TableId;

                footnoteContentVariable.Contents = Content.Content;

                footnoteContentVariable.Variable = Variable.Variable;

                footnoteContentVariable.FootnoteNo = FootnoteNo;

                footnoteContentVariable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                footnoteContentVariable.LogDate = DateTime.Now;

                context.AddToFootnoteContVbls(footnoteContentVariable);
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from cv in context.FootnoteContVbls
                     where cv.FootnoteNo == FootnoteNo && cv.MainTable == MainTable.TableId && cv.Contents == Content.Content && cv.Variable == Variable.Variable
                     select cv).First();

            context.DeleteObject(f);

        }

    }
}
