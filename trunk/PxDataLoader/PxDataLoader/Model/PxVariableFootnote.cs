using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PxDataLoader.Model
{
    public class PxVariableFootnote : PxFootnote
    {

        public PxVariable Variable { get; set; }

        public PxVariableFootnote()
        {
            FootnoteType = "5";
        }

        public override void CreateEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            if (IsNew)
            {
                base.CreateEntities(context);

                PxMetaModel.FootnoteVariable footnoteVariable = new PxMetaModel.FootnoteVariable();

                footnoteVariable.Variable = Variable.Variable;

                footnoteVariable.FootnoteNo = FootnoteNo;

                footnoteVariable.UserId = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                footnoteVariable.LogDate = DateTime.Now;

                context.AddToFootnoteVariables(footnoteVariable);
            }

            else
            {
                base.UpdateEntities(context);
            }

        }

        public override void DeleteEntities(PxMetaModel.PcAxisMetabaseEntities context)
        {
            base.DeleteEntities(context);

            var f = (from fvariable in context.FootnoteVariables
                     where fvariable.FootnoteNo == FootnoteNo && fvariable.Variable == Variable.Variable
                     select fvariable).First();

            context.DeleteObject(f);

        }

    }
}
